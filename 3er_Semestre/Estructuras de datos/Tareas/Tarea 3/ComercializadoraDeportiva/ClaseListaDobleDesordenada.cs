using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercializadoraDeportiva
{
	internal class ClaseListaDobleDesordenada<Tipo> where Tipo : IEquatable<Tipo>
	{
		private ClaseNodo<Tipo> _nodoInicial;

		public ClaseNodo<Tipo> NodoInicial
		{
			get { return _nodoInicial; }
			set { _nodoInicial = value; }
		}

		private ClaseNodo<Tipo> _nodoFinal;

		public ClaseNodo<Tipo> NodoFinal
		{
			get { return _nodoFinal; }
			set { _nodoFinal = value; }
		}

		public ClaseListaDobleDesordenada()
		{
			_nodoInicial = null;
			_nodoFinal = null;
		}

		public bool Vacia
		{
			get
			{
				if (NodoInicial == null && NodoFinal == null)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}

		public void Insertar(Tipo objeto)
		{
			ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();

			if (Vacia)
			{
				nodoNuevo.ObjetoConDatos = objeto;
				nodoNuevo.Siguiente = null;
				nodoNuevo.Anterior = null;
				NodoInicial = nodoNuevo;
				NodoFinal = nodoNuevo;
				return;
			}

			ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
			nodoActual = NodoInicial;
			ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
            while (nodoActual != null)
			{
				if (objeto.Equals(nodoActual.ObjetoConDatos))
				{
					throw new Exception("El objeto ya existe en la lista.");

				}
				nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;
			}
			nodoNuevo.ObjetoConDatos = objeto;
			nodoNuevo.Siguiente = null;
			nodoNuevo.Anterior = nodoPrevio;
			nodoPrevio.Siguiente = nodoNuevo;
			NodoFinal = nodoNuevo;
			return;
		}

		public Tipo Eliminar(Tipo objeto)
		{
			ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
			if (Vacia)
			{
				throw new Exception("La lista está vacía.");
			}

			nodoActual = NodoInicial;

			while (nodoActual != null)
			{
				if (objeto.Equals(nodoActual.ObjetoConDatos))
				{
					if (NodoInicial == nodoActual && NodoFinal == nodoActual)
					{
						Tipo objetoElinminado = nodoActual.ObjetoConDatos;
						NodoInicial = null;
						NodoFinal = null;
						nodoActual = null;
						return objetoElinminado;
					}
					else if (NodoInicial == nodoActual)
					{
						Tipo objetoEliminado = nodoActual.ObjetoConDatos;
						NodoInicial = nodoActual.Siguiente;
						nodoActual.Siguiente.Anterior = null;
						nodoActual = null;
						return objetoEliminado;
					}
					else if (nodoActual.Siguiente == null && NodoFinal == nodoActual)
					{
						Tipo objetoEliminado = nodoActual.ObjetoConDatos;
						nodoActual.Anterior.Siguiente = null;
						NodoFinal = nodoActual.Anterior;
						nodoActual = null;
						return objetoEliminado;
					}
					else
					{
						Tipo objetoEliminado = nodoActual.ObjetoConDatos;
						nodoActual.Anterior.Siguiente = nodoActual.Siguiente;
						nodoActual.Siguiente.Anterior = nodoActual.Anterior;
						nodoActual = null;
						return objetoEliminado;
					}
				}
				nodoActual = nodoActual.Siguiente;
			}
			throw new Exception("El objeto no existe en la lista.");
		}

		public Tipo Buscar(Tipo objeto)
		{
			ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
			if (Vacia)
			{
				throw new Exception("La lista está vacía.");
			}
			nodoActual = NodoInicial;
			while (nodoActual != null)
			{
				if (objeto.Equals(nodoActual.ObjetoConDatos))
				{
					return nodoActual.ObjetoConDatos;
				}
				nodoActual = nodoActual.Siguiente;
			}
			throw new Exception("El objeto no existe en la lista.");
		}

		public void Vaciar()
		{
			ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
			ClaseNodo<Tipo> nodoPrevio = new ClaseNodo<Tipo>();
			if (Vacia)
			{
				return;
			}
			else
			{
				nodoActual = NodoInicial;

				do
				{
					nodoPrevio = nodoActual;
					nodoActual = nodoActual.Siguiente;
					nodoPrevio = null;
				} while (nodoActual != null);
                    NodoInicial = null;
				NodoFinal = null;
			}
		}

		public IEnumerable<Tipo> HaciaAdelante
		{
			get
			{
				ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
				if (Vacia)
				{
					yield break;
				}
				nodoActual = NodoInicial;
				while (nodoActual != null)
				{
					yield return nodoActual.ObjetoConDatos;
					nodoActual = nodoActual.Siguiente;
				}
				yield break;
			}
		}

		public IEnumerable<Tipo> HaciaAtras
		{
			get
			{
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                if (Vacia)
				{
					yield break;
				}
				nodoActual = NodoFinal;
				while (nodoActual != null)
				{
					yield return nodoActual.ObjetoConDatos;
					nodoActual = nodoActual.Anterior;
				}
				yield break;
			}
		}

		~ClaseListaDobleDesordenada()
		{
			Vaciar();
		}
	}
}
