using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercializadoraDeportiva
{
    internal class ComercializadoraDeportiva: IComparable<ComercializadoraDeportiva>, IEquatable<ComercializadoraDeportiva>
    {
		private int _intNumeroDeComercializadora;

		public int NumeroDeComercializadora
		{
			get { return _intNumeroDeComercializadora; }
			set { _intNumeroDeComercializadora = value; }
		}


		private int _intNumeroDeSucursales;

		public int NumeroDeSucursales
		{
			get { return _intNumeroDeSucursales; }
			set { _intNumeroDeSucursales = value; }
		}

		private double _dblVentasAnuales;

		public double VentasAnuales
		{
			get { return _dblVentasAnuales; }
			set { _dblVentasAnuales = value; }
		}

		private string _strRazonSocial;

		public string RazonSocial
		{
			get { return _strRazonSocial; }
			set { _strRazonSocial = value; }
		}

		private char _chrCategoriaTamano;

		public char CategoriaTamano
		{
			get { return _chrCategoriaTamano; }
			set { _chrCategoriaTamano = value; }
		}

		private DateTime _dtmFechaDeFundacion;

		public DateTime FechaDeFundacion
		{
			get { return _dtmFechaDeFundacion; }
			set { _dtmFechaDeFundacion = value; }
		}

		private bool _blnEsMayorista;

		public bool EsMayorista
		{
			get { return _blnEsMayorista; }
			set { _blnEsMayorista = value; }
		}

		private string _strRutaLogotipo;

		public string RutaLogotipo
		{
			get { return _strRutaLogotipo; }
			set { _strRutaLogotipo = value; }
		}

		public int CompareTo(ComercializadoraDeportiva otra)
        {
            if (otra == null) return 1;
            return this.NumeroDeComercializadora.CompareTo(otra.NumeroDeComercializadora);
        }

        public bool Equals(ComercializadoraDeportiva otra)
        {
            if (otra == null) return false;
            return this.NumeroDeComercializadora.Equals(otra.NumeroDeComercializadora);
        }

    }
}
