using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercializadoraDeportiva
{
    internal class ClaseListaSimpleOrdenada<Tipo> where Tipo : IEquatable<Tipo>, IComparable<Tipo>
    {
        public ClaseListaSimpleOrdenada()
        {
            _nodoInicial = null;
        }


        private ClaseNodo<Tipo> _nodoInicial;

        private ClaseNodo<Tipo> NodoInicial
        {
            get { return _nodoInicial; }
            set { _nodoInicial = value; }
        }

        public bool Vacia
        {
            get
            {
                if (NodoInicial == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void InsertarNodo(Tipo objeto)
        {

            if (Vacia)
            {
                ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = null;
                NodoInicial = nodoNuevo;
                return;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoAnterior = new ClaseNodo<Tipo>();
                nodoActual = NodoInicial;
                nodoAnterior = null;

                while (nodoActual != null)
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        throw new Exception("No se permiten duplicados");
                    }
                    else if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
                    {
                        if (NodoInicial == nodoActual)
                        {
                            ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                            nodoNuevo.ObjetoConDatos = objeto;
                            nodoNuevo.Siguiente = nodoActual;
                            NodoInicial = nodoNuevo;
                        }
                        else
                        {
                            ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();
                            nodoNuevo.ObjetoConDatos = objeto;
                            nodoNuevo.Siguiente = nodoActual;
                            nodoAnterior.Siguiente = nodoNuevo;
                        }
                        return;
                    }
                    nodoAnterior = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                }

                //Alta al final de la lista
                ClaseNodo<Tipo> nodoFinal = new ClaseNodo<Tipo>();
                nodoFinal.ObjetoConDatos = objeto;
                nodoFinal.Siguiente = null;
                nodoAnterior.Siguiente = nodoFinal;
                return;
            }
        }

        public Tipo EliminarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("Lista vacía");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoAnterior = new ClaseNodo<Tipo>();
                nodoAnterior = null;
                nodoActual = NodoInicial;
                while (nodoActual != null)
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        if (nodoActual == NodoInicial)
                        {
                            NodoInicial = nodoActual.Siguiente;
                        }
                        else
                        {
                            nodoAnterior.Siguiente = nodoActual.Siguiente;
                        }
                        return nodoActual.ObjetoConDatos;
                    }
                    nodoAnterior = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                }
                throw new Exception("No se encontró el objeto a eliminar");
            }
        }

        public Tipo BuscarNodo(Tipo objeto)
        {
            if (Vacia)
            {
                throw new Exception("Lista vacía");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = NodoInicial;
                while (nodoActual != null)
                {
                    if (objeto.Equals(nodoActual.ObjetoConDatos))
                    {
                        return nodoActual.ObjetoConDatos;
                    }
                    else if (objeto.CompareTo(nodoActual.ObjetoConDatos) == -1)
                    {
                        throw new Exception("No se encontró el objeto");
                    }
                    nodoActual = nodoActual.Siguiente;
                }
                throw new Exception("No se encontró el objeto");
            }
        }

        public void Vaciar()
        {
            if (Vacia)
            {
                throw new Exception("Lista vacía");
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                ClaseNodo<Tipo> nodoAnterior = new ClaseNodo<Tipo>();
                nodoActual = NodoInicial;
                nodoAnterior = null;
                while (nodoActual != null)
                {
                    nodoAnterior = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoAnterior = null;
                }

                NodoInicial = null;
            }
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if(Vacia)
            {
                yield break;
            }
            else
            {
                ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
                nodoActual = NodoInicial;
                while (nodoActual != null)
                {
                    yield return nodoActual.ObjetoConDatos;
                    nodoActual = nodoActual.Siguiente;
                }
                yield break;
            }
        }

        ~ClaseListaSimpleOrdenada()
        {
            Vaciar();
        }
    }
}
