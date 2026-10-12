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

namespace _1erExamenPractico
{
    public partial class Form1 : Form
    {
        private ClaseListaDobleDesordenada<ComercializadoraDeportiva> listaComercializadoras = new ClaseListaDobleDesordenada<ComercializadoraDeportiva>();

        public Form1()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        public void ConfigurarGrid()
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

            foreach (ComercializadoraDeportiva empresa in listaComercializadoras.HaciaAdelante)
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

        private void btnGenerarAleatorios_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int intCantidadNodosAGenerar = int.Parse(txtCantidadDeAleatorios.Text);

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

            for (int i = 0; i < intCantidadNodosAGenerar; i++)
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
                    listaComercializadoras.Insertar(aleatoria);
                }
                catch (Exception)
                {
                }
            }

            ActualizarGrid();
        }

        private void btnCantidadNodos_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Cantidad de nodos en la lista: {listaComercializadoras.ContarNodos()}");
        }
    }
}
