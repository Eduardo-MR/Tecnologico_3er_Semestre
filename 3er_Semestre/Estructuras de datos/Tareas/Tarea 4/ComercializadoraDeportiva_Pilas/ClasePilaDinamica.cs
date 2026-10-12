using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComercializadoraDeportiva_Pilas
{
    internal class ClasePilaDinamica<Tipo> where Tipo : IEquatable<Tipo>
    {
        private ClaseNodo<Tipo> _top;

        public ClaseNodo<Tipo> Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public ClasePilaDinamica()
        {
            _top = null;
        }

        public bool Vacia
        {
            get
            {
                if (Top == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public void Push(Tipo objeto)
        {
            ClaseNodo<Tipo> nodoNuevo = new ClaseNodo<Tipo>();

            if (Vacia)
            {
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = null;
                _top = nodoNuevo;
                return;
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            nodoActual = Top;
            
            while (nodoActual != null)
            {
                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    throw new Exception("El objeto ya existe en la Pila.");

                }
                nodoActual = nodoActual.Siguiente;
            }
            nodoNuevo.ObjetoConDatos = objeto;
            nodoNuevo.Siguiente = Top;
            Top = nodoNuevo;
            return;
        }

        public Tipo Pop()
        {
            if (Vacia)
            {
                throw new Exception("La pila esta vacia");
            }

            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            Tipo nodoEliminado = nodoActual.ObjetoConDatos;
            nodoActual = Top;
            Top = nodoActual.Siguiente;
            nodoActual = null;
            return nodoEliminado;
        }

        public Tipo Pop(Tipo objeto)
        {
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            ClaseNodo<Tipo> nodoAnterior = new ClaseNodo<Tipo>();
            if (Vacia)
            {
                throw new Exception("La pila está vacía.");
            }

            nodoActual = Top;

            while (nodoActual != null)
            {
                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    if (Top == nodoActual)
                    {
                        Tipo objetoElinminado = nodoActual.ObjetoConDatos;
                        Top = nodoActual.Siguiente;
                        nodoActual = null;
                        return objetoElinminado;
                    }
                    else if (nodoActual.Siguiente == null)
                    {
                        Tipo objetoElinminado = nodoActual.ObjetoConDatos;
                        nodoAnterior.Siguiente = null;
                        nodoActual = null;
                        return objetoElinminado;
                    }
                    else
                    {
                        Tipo objetoElinminado = nodoActual.ObjetoConDatos;
                        nodoAnterior = nodoActual.Siguiente;
                        nodoActual = null;
                        return objetoElinminado;
                    }
                }
            }
            throw new Exception("El objeto no existe en la pila.");
        }

        public Tipo BuscarNodo(Tipo objeto)
        {
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            if (Vacia)
            {
                throw new Exception("La pila está vacía.");
            }
            nodoActual = Top;

            while (nodoActual != null)
            {
                if (objeto.Equals(nodoActual.ObjetoConDatos))
                {
                    return nodoActual.ObjetoConDatos;
                }
                nodoActual = nodoActual.Siguiente;
            }
            throw new Exception("El objeto no existe en la pila.");
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
                nodoActual = Top;
                nodoPrevio = null;

                while(nodoActual != null)
                {
                    nodoPrevio = nodoActual;
                    nodoActual = nodoActual.Siguiente;
                    nodoPrevio = null;
                }
                Top = null;
            }
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            ClaseNodo<Tipo> nodoActual = new ClaseNodo<Tipo>();
            if (Vacia)
            {
                yield break;
            }
            else
            {
                nodoActual = Top;
                while (nodoActual != null)
                {
                    yield return nodoActual.ObjetoConDatos;
                    nodoActual = nodoActual.Siguiente;
                }
            }
        }

        ~ClasePilaDinamica()
        {
            Vaciar();
        }
    }
}
