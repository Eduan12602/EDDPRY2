using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EDDemo.Estructuras_No_Lineales // Define el espacio de nombres.
{
    public class ArbolBusqueda // Clase que representa un árbol binario de búsqueda.
    {
        private NodoBinario Raiz; // Nodo raíz del árbol.
        public string strArbol; // Representación textual del árbol.
        public string strRecorrido; // Representación textual de los recorridos.

        // Constructor para inicializar el árbol.
        public ArbolBusqueda()
        {
            Raiz = null; // Inicializa la raíz como nula.
            strArbol = ""; // Inicializa la cadena de representación del árbol como vacía.
            strRecorrido = ""; // Inicializa la cadena de recorridos como vacía.
        }

        // Verifica si el árbol está vacío.
        public bool EstaVacio()
        {
            return Raiz == null; // Devuelve true si la raíz es nula, false en caso contrario.
        }

        // Devuelve la raíz del árbol.
        public NodoBinario RegresaRaiz()
        {
            return Raiz; // Retorna la raíz del árbol.
        }

        // Inserta un nuevo nodo en el árbol.
        public void InsertaNodo(int Dato, ref NodoBinario Nodo)
        {
            if (Nodo == null) // Si el nodo actual es nulo.
            {
                Nodo = new NodoBinario(Dato); // Crea un nuevo nodo con el dato proporcionado.

                if (Raiz == null) // Si la raíz aún no ha sido inicializada.
                    Raiz = Nodo; // Asigna el nodo actual como raíz.
            }
            else if (Dato < Nodo.Dato) // Si el dato es menor al valor del nodo actual.
                InsertaNodo(Dato, ref Nodo.Izq); // Inserta en el subárbol izquierdo.
            else if (Dato > Nodo.Dato) // Si el dato es mayor al valor del nodo actual.
                InsertaNodo(Dato, ref Nodo.Der); // Inserta en el subárbol derecho.
        }

        // Genera una representación textual del árbol "acostado".
        public void MuestraArbolAcostado(int nivel, NodoBinario nodo)
        {
            if (nodo == null) // Si el nodo actual es nulo, retorna.
                return;

            MuestraArbolAcostado(nivel + 1, nodo.Der); // Llama recursivamente para el subárbol derecho.
            for (int i = 0; i < nivel; i++) // Indenta según el nivel actual.
                strArbol += "      "; // Agrega espacios para la representación.

            strArbol += nodo.Dato.ToString() + "\r\n"; // Agrega el dato del nodo y un salto de línea.
            MuestraArbolAcostado(nivel + 1, nodo.Izq); // Llama recursivamente para el subárbol izquierdo.
        }

        // Genera la representación en formato DOT para visualización.
        public string ToDot(NodoBinario nodo)
        {
            StringBuilder b = new StringBuilder(); // Utiliza un StringBuilder para crear la representación.

            if (nodo.Izq != null) // Si el nodo tiene un hijo izquierdo.
            {
                b.AppendFormat("{0}->{1} [side=L]{2}", nodo.Dato, nodo.Izq.Dato, Environment.NewLine); // Representa la conexión izquierda.
                b.Append(ToDot(nodo.Izq)); // Llama recursivamente al hijo izquierdo.
            }
            if (nodo.Der != null) // Si el nodo tiene un hijo derecho.
            {
                b.AppendFormat("{0}->{1} [side=R]{2}", nodo.Dato, nodo.Der.Dato, Environment.NewLine); // Representa la conexión derecha.
                b.Append(ToDot(nodo.Der)); // Llama recursivamente al hijo derecho.
            }
            return b.ToString(); // Retorna la representación completa.
        }

        // Realiza un recorrido en preorden (Nodo - Izquierda - Derecha).
        public void PreOrden(NodoBinario nodo)
        {
            if (nodo == null) return; // Si el nodo es nulo, detiene la recursión.

            strRecorrido += nodo.Dato + ", "; // Agrega el dato actual al recorrido.
            PreOrden(nodo.Izq); // Llama recursivamente al subárbol izquierdo.
            PreOrden(nodo.Der); // Llama recursivamente al subárbol derecho.
        }

        // Realiza un recorrido en inorden (Izquierda - Nodo - Derecha).
        public void InOrden(NodoBinario nodo)
        {
            if (nodo == null) return; // Si el nodo es nulo, detiene la recursión.

            InOrden(nodo.Izq); // Llama recursivamente al subárbol izquierdo.
            strRecorrido += nodo.Dato + ", "; // Agrega el dato actual al recorrido.
            InOrden(nodo.Der); // Llama recursivamente al subárbol derecho.
        }

        // Realiza un recorrido en postorden (Izquierda - Derecha - Nodo).
        public void PostOrden(NodoBinario nodo)
        {
            if (nodo == null) return; // Si el nodo es nulo, detiene la recursión.

            PostOrden(nodo.Izq); // Llama recursivamente al subárbol izquierdo.
            PostOrden(nodo.Der); // Llama recursivamente al subárbol derecho.
            strRecorrido += nodo.Dato + ", "; // Agrega el dato actual al recorrido.
        }

        // Busca un valor en el árbol.
        public bool Busqueda(int Valor, NodoBinario nodo)
        {
            if (nodo == null) // Si el nodo es nulo, el valor no se encuentra en el árbol.
                return false;

            if (nodo.Dato == Valor) // Si el dato del nodo coincide con el valor buscado.
                return true;

            // Busca recursivamente en el subárbol correspondiente.
            if (Valor < nodo.Dato)
                return Busqueda(Valor, nodo.Izq);
            else
                return Busqueda(Valor, nodo.Der);
        }

        // Elimina todos los nodos del árbol.
        public void PodarArbol()
        {
            PodarNodo(ref Raiz); // Llama al método recursivo para eliminar los nodos.
            Raiz = null; // Reinicia la raíz.
            strArbol = ""; // Limpia la representación del árbol.
            strRecorrido = ""; // Limpia la representación de los recorridos.
        }

        // Método recursivo para eliminar todos los nodos desde las hojas hasta la raíz.
        private void PodarNodo(ref NodoBinario nodo)
        {
            if (nodo == null) return; // Si el nodo es nulo, detiene la recursión.

            PodarNodo(ref nodo.Izq); // Llama recursivamente para el subárbol izquierdo.
            PodarNodo(ref nodo.Der); // Llama recursivamente para el subárbol derecho.
            nodo = null; // Elimina el nodo actual.
        }

        // Método para eliminar un nodo específico del árbol.
        public bool EliminarNodo(int dato)
        {
            NodoBinario padre = null, actual = Raiz; // Variables para rastrear el nodo actual y su padre.
            bool esHijoIzquierdo = false; // Indica si el nodo actual es un hijo izquierdo.

            // Busca el nodo a eliminar.
            while (actual != null && actual.Dato != dato)
            {
                padre = actual; // Actualiza el padre.
                if (dato < actual.Dato) // Si el dato buscado es menor.
                {
                    actual = actual.Izq; // Mueve al subárbol izquierdo.
                    esHijoIzquierdo = true; // Marca como hijo izquierdo.
                }
                else // Si el dato buscado es mayor.
                {
                    actual = actual.Der; // Mueve al subárbol derecho.
                    esHijoIzquierdo = false; // Marca como hijo derecho.
                }
            }

            if (actual == null) return false; // Si no se encuentra el nodo, retorna false.

            // Elimina el nodo según los tres casos posibles.
            // Caso 1: Nodo hoja.
            if (actual.Izq == null && actual.Der == null)
            {
                if (actual == Raiz) Raiz = null; // Si es la raíz, se elimina.
                else if (esHijoIzquierdo) padre.Izq = null; // Si es hijo izquierdo, se desconecta.
                else padre.Der = null; // Si es hijo derecho, se desconecta.
            }
            // Caso 2: Nodo con un solo hijo.
            else if (actual.Der == null) // Si solo tiene un hijo izquierdo.
            {
                if (actual == Raiz) Raiz = actual.Izq; // Conecta el hijo izquierdo como raíz.
                else if (esHijoIzquierdo) padre.Izq = actual.Izq; // Conecta el hijo izquierdo.
                else padre.Der = actual.Izq; // Conecta el hijo izquierdo.
            }
            else if (actual.Izq == null) // Si solo tiene un hijo derecho.
            {
                if (actual == Raiz) Raiz = actual.Der; // Conecta el hijo derecho como raíz.
                else if (esHijoIzquierdo) padre.Izq = actual.Der; // Conecta el hijo derecho.
                else padre.Der = actual.Der; // Conecta el hijo derecho.
            }
            // Caso 3: Nodo con dos hijos.
            else
            {
                NodoBinario sucesor = ObtenerSucesor(actual); // Encuentra el sucesor.
                if (actual == Raiz) Raiz = sucesor; // Reemplaza la raíz.
                else if (esHijoIzquierdo) padre.Izq = sucesor; // Conecta el sucesor como hijo izquierdo.
                else padre.Der = sucesor; // Conecta el sucesor como hijo derecho.
                sucesor.Izq = actual.Izq; // Conecta el subárbol izquierdo del nodo eliminado al sucesor.
            }

            return true; // Indica que el nodo fue eliminado con éxito.
        }

        // Encuentra el sucesor de un nodo (el nodo más pequeño del subárbol derecho).
        private NodoBinario ObtenerSucesor(NodoBinario nodoEliminar)
        {
            NodoBinario sucesor = nodoEliminar, actual = nodoEliminar.Der;

            while (actual != null) // Busca el nodo más pequeño del subárbol derecho.
            {
                sucesor = actual;
                actual = actual.Izq;
            }

            return sucesor; // Retorna el sucesor.
        }

        // Realiza un recorrido por niveles.
        public void RecorridoPorNiveles(NodoBinario nodo)
        {
            if (nodo == null) return;

            Queue<NodoBinario> cola = new Queue<NodoBinario>(); // Cola para el recorrido.
            cola.Enqueue(nodo);

            while (cola.Count > 0)
            {
                NodoBinario actual = cola.Dequeue();
                strRecorrido += actual.Dato + ", "; // Agrega el dato al recorrido.

                if (actual.Izq != null) cola.Enqueue(actual.Izq); // Agrega el hijo izquierdo a la cola.
                if (actual.Der != null) cola.Enqueue(actual.Der); // Agrega el hijo derecho a la cola.
            }
        }

        // Calcula la altura del árbol.
        public int ObtenerAltura()
        {
            return CalcularAltura(Raiz); // Llama al método recursivo.
        }

        private int CalcularAltura(NodoBinario nodo)
        {
            if (nodo == null) return 0; // Si el nodo es nulo, la altura es 0.
            return 1 + Math.Max(CalcularAltura(nodo.Izq), CalcularAltura(nodo.Der)); // Calcula la altura recursivamente.
        }

        // Cuenta las hojas del árbol.
        public int ContarHojas()
        {
            return ContarHojasRecursivo(Raiz); // Llama al método recursivo.
        }

        private int ContarHojasRecursivo(NodoBinario nodo)
        {
            if (nodo == null) return 0; // Si el nodo es nulo, no hay hojas.
            if (nodo.Izq == null && nodo.Der == null) return 1; // Si el nodo no tiene hijos, es una hoja.
            return ContarHojasRecursivo(nodo.Izq) + ContarHojasRecursivo(nodo.Der); // Suma las hojas de ambos subárboles.
        }

        // Cuenta los nodos del árbol.
        public int ContarNodos()
        {
            return ContarNodosRecursivo(Raiz); // Llama al método recursivo.
        }

        private int ContarNodosRecursivo(NodoBinario nodo)
        {
            if (nodo == null) return 0; // Si el nodo es nulo, no hay nodos.
            return 1 + ContarNodosRecursivo(nodo.Izq) + ContarNodosRecursivo(nodo.Der); // Suma los nodos de ambos subárboles.
        }

        // Verifica si el árbol es completo.
        public bool EsArbolCompleto()
        {
            return EsArbolCompletoRecursivo(Raiz, 0, ContarNodos());
        }

        private bool EsArbolCompletoRecursivo(NodoBinario nodo, int index, int numeroNodos)
        {
            if (nodo == null) return true; // Si el nodo es nulo, se considera completo.
            if (index >= numeroNodos) return false; // Si un índice supera el número de nodos, no es completo.
            return EsArbolCompletoRecursivo(nodo.Izq, 2 * index + 1, numeroNodos) &&
                   EsArbolCompletoRecursivo(nodo.Der, 2 * index + 2, numeroNodos);
        }

        // Verifica si el árbol es lleno.
        public bool EsArbolLleno()
        {
            return EsArbolLlenoRecursivo(Raiz); // Llama al método recursivo.
        }

        private bool EsArbolLlenoRecursivo(NodoBinario nodo)
        {
            if (nodo == null) return true; // Si el nodo es nulo, se considera lleno.
            if (nodo.Izq == null && nodo.Der == null) return true; // Si no tiene hijos, es una hoja.
            if (nodo.Izq != null && nodo.Der != null) // Si tiene ambos hijos, verifica recursivamente.
                return EsArbolLlenoRecursivo(nodo.Izq) && EsArbolLlenoRecursivo(nodo.Der);
            return false; // Si tiene un solo hijo, no es lleno.
        }
    }
}

