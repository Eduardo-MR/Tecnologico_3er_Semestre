using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComercializadoraDeportiva
{
    public partial class Form1 : Form
    {
        private ClaseListaSimpleOrdenada<ComercializadoraDeportiva> listaComercializadoras = new ClaseListaSimpleOrdenada<ComercializadoraDeportiva>();
        private string rutaFotoActual = string.Empty;

        public Form1()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        private void ConfigurarGrid()
        {
            dgvDatos.Columns.Clear();
            dgvDatos.Columns.Add("Numero", "Número");
            dgvDatos.Columns.Add("RazonSocial", "Razón Social");
            dgvDatos.Columns.Add("Sucursales", "Sucursales");
            dgvDatos.Columns.Add("Ventas", "Ventas Anuales");
            dgvDatos.Columns.Add("Fecha", "Fundación");
            dgvDatos.Columns.Add("Mayorista", "Mayorista");
            dgvDatos.Columns.Add("Categoria", "Tamaño");
            dgvDatos.Columns.Add("Ruta", "Ruta Foto");
            dgvDatos.Columns["Ruta"].Visible = false;
        }

        private void ActualizarGrid()
        {
            dgvDatos.Rows.Clear();

            foreach (ComercializadoraDeportiva empresa in listaComercializadoras)
            {
                dgvDatos.Rows.Add(
                    empresa.NumeroDeComercializadora,
                    empresa.RazonSocial,
                    empresa.NumeroDeSucursales,
                    empresa.VentasAnuales.ToString("C2"),
                    empresa.FechaDeFundacion.ToShortDateString(),
                    empresa.EsMayorista ? "Sí" : "No",
                    empresa.CategoriaTamano,
                    empresa.RutaLogotipo
                );
            }
        }

        private void LimpiarControles()
        {
            txtNumero.Clear();
            txtRazonSocial.Clear();
            txtNumero.Clear();
            txtVentas.Clear();
            dtpFechaFundacion.Value = DateTime.Now;
            chkMayorista.Checked = false;
            radPequena.Checked = true;
            picLogotipo.Image = null;
            rutaFotoActual = string.Empty;
            txtNumero.Focus();
        }

        private ComercializadoraDeportiva ObtenerDatosDeControles()
        {
            if (!int.TryParse(txtNumero.Text, out int numero))
                throw new Exception("El número debe ser un valor entero válido.");

            if (string.IsNullOrWhiteSpace(txtRazonSocial.Text))
                throw new Exception("La razón social no puede estar vacía.");

            if (!double.TryParse(txtVentas.Text, out double ventas))
                throw new Exception("Las ventas anuales deben tener un formato numérico válido.");

            char categoria = 'P';
            if (radMediana.Checked) categoria = 'M';
            else if (radGrande.Checked) categoria = 'G';

            return new ComercializadoraDeportiva
            {
                NumeroDeComercializadora = int.Parse(txtNumero.Text),
                RazonSocial = txtRazonSocial.Text,
                NumeroDeSucursales = int.Parse(txtNumSucursales.Text),
                VentasAnuales = ventas,
                FechaDeFundacion = dtpFechaFundacion.Value,
                EsMayorista = chkMayorista.Checked,
                CategoriaTamano = categoria,
                RutaLogotipo = rutaFotoActual
            };
        }


        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int numeroSeleccionado = Convert.ToInt32(dgvDatos.Rows[e.RowIndex].Cells["Numero"].Value);

                    ComercializadoraDeportiva busqueda = new ComercializadoraDeportiva { NumeroDeComercializadora = numeroSeleccionado };
                    ComercializadoraDeportiva encontrada = listaComercializadoras.BuscarNodo(busqueda);

                    MostrarDatosEnControles(encontrada);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos del registro seleccionado: " + ex.Message);
                }
            }
        }

        private void MostrarDatosEnControles(ComercializadoraDeportiva empresa)
        {
            txtNumero.Text = empresa.NumeroDeComercializadora.ToString();
            txtRazonSocial.Text = empresa.RazonSocial;
            txtNumSucursales.Text = empresa.NumeroDeSucursales.ToString();
            txtVentas.Text = empresa.VentasAnuales.ToString();
            dtpFechaFundacion.Value = empresa.FechaDeFundacion;
            chkMayorista.Checked = empresa.EsMayorista;

            if (empresa.CategoriaTamano == 'P') radPequena.Checked = true;
            else if (empresa.CategoriaTamano == 'M') radMediana.Checked = true;
            else if (empresa.CategoriaTamano == 'G') radGrande.Checked = true;

            rutaFotoActual = empresa.RutaLogotipo;

            if (!string.IsNullOrEmpty(rutaFotoActual) && File.Exists(rutaFotoActual))
            {
                using (FileStream fs = new FileStream(rutaFotoActual, FileMode.Open, FileAccess.Read))
                {
                    picLogotipo.Image = Image.FromStream(fs);
                }
            }
            else
            {
                picLogotipo.Image = null;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ComercializadoraDeportiva nuevaEmpresa = ObtenerDatosDeControles();
                listaComercializadoras.InsertarNodo(nuevaEmpresa);
                ActualizarGrid();
                LimpiarControles();
                MessageBox.Show("Registro agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de captura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerarAleatorios_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            Dictionary<string, string> marcasDeportivas = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                { "1.png", "Jordan Brand" },
                { "2.png", "Roger Federer (RF)" },
                { "3.png", "Tiger Woods (TW)" },
                { "4.png", "Messi Store" },
                { "5.png", "Rafa Nadal Academy" },
                { "6.png", "Andy Murray (AM)" },
                { "7.png", "Novak Djokovic (ND)" },
                { "8.png", "Athletics O-Brand" },
                { "9.png", "Neymar Jr (NJR)" },
                { "10.png", "CR7 Cristiano Ronaldo" }
            };

            string rutaCarpetaImg = Path.Combine(Application.StartupPath, "Imagenes");
            string[] archivosImg = null;

            if (Directory.Exists(rutaCarpetaImg))
            {
                archivosImg = Directory.GetFiles(rutaCarpetaImg, "*.png");
            }

            char[] categorias = { 'P', 'M', 'G' };

            for (int i = 0; i < 10; i++)
            {
                int nuevoNumero = rnd.Next(1, 1000);
                string rutaImgAleatoria = string.Empty;
                string razonSocialAleatoria = "Comercializadora " + nuevoNumero;

                if (archivosImg != null && archivosImg.Length > 0)
                {
                    rutaImgAleatoria = archivosImg[rnd.Next(archivosImg.Length)];
                    string nombreArchivo = Path.GetFileName(rutaImgAleatoria);

                    if (marcasDeportivas.ContainsKey(nombreArchivo))
                    {
                        razonSocialAleatoria = marcasDeportivas[nombreArchivo];
                    }
                }

                ComercializadoraDeportiva aleatoria = new ComercializadoraDeportiva
                {
                    NumeroDeComercializadora = nuevoNumero,
                    RazonSocial = razonSocialAleatoria,
                    NumeroDeSucursales = rnd.Next(1, 50),
                    VentasAnuales = rnd.NextDouble() * 1000000,
                    FechaDeFundacion = DateTime.Now.AddDays(-rnd.Next(100, 5000)),
                    EsMayorista = rnd.Next(2) == 0,
                    CategoriaTamano = categorias[rnd.Next(categorias.Length)],
                    RutaLogotipo = rutaImgAleatoria
                };

                try
                {
                    listaComercializadoras.InsertarNodo(aleatoria);
                }
                catch (Exception)
                {
                }
            }

            ActualizarGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtNumero.Text, out int numeroBuscar))
                {
                    MessageBox.Show("Ingrese un número válido en la casilla 'Número' para buscar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ComercializadoraDeportiva objBusqueda = new ComercializadoraDeportiva { NumeroDeComercializadora = numeroBuscar };
                ComercializadoraDeportiva encontrada = listaComercializadoras.BuscarNodo(objBusqueda);

                MostrarDatosEnControles(encontrada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(txtNumero.Text, out int numeroEliminar))
                {
                    MessageBox.Show("Ingrese el número del registro que desea eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult respuesta = MessageBox.Show($"¿Está seguro que desea eliminar el registro {numeroEliminar}?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    ComercializadoraDeportiva objEliminar = new ComercializadoraDeportiva { NumeroDeComercializadora = numeroEliminar };
                    listaComercializadoras.EliminarNodo(objEliminar);
                    ActualizarGrid();
                    LimpiarControles();
                    MessageBox.Show("Registro eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listaComercializadoras.Vacia) return;

                DialogResult respuesta = MessageBox.Show("¿Está COMPLETAMENTE SEGURO que desea eliminar todos los registros?", "Confirmar Vaciado", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    listaComercializadoras.Vaciar();
                    ActualizarGrid();
                    LimpiarControles();
                    MessageBox.Show("La lista ha sido vaciada.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                rutaFotoActual = ofd.FileName;
                picLogotipo.Image = Image.FromFile(rutaFotoActual);
            }
        }
    }
}
