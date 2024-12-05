using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.FINAL // Define el espacio de nombres para la clase estática Ordenacion.
{
    public static class Ordenacion // Define una clase estática para contener métodos de ordenación.
    {
        // Método de ordenación Burbuja.
        public static void Burbuja(int[] numeros)
        {
            // Recorre el arreglo varias veces.
            for (int i = 0; i < numeros.Length - 1; i++)
            {
                for (int j = 0; j < numeros.Length - i - 1; j++)
                {
                    // Intercambia si el elemento actual es mayor que el siguiente.
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }
        }

        // Método de ordenación QuickSort.
        public static void QuickSort(int[] numeros, int inicio, int fin)
        {
            if (inicio < fin) // Condición base para recursión.
            {
                int indicePivote = Particionar(numeros, inicio, fin); // Encuentra el índice del pivote.
                QuickSort(numeros, inicio, indicePivote - 1); // Ordena la mitad izquierda.
                QuickSort(numeros, indicePivote + 1, fin); // Ordena la mitad derecha.
            }
        }

        // Método auxiliar para particionar el arreglo.
        private static int Particionar(int[] numeros, int inicio, int fin)
        {
            int pivote = numeros[fin]; // Elige el último elemento como pivote.
            int i = inicio - 1;

            for (int j = inicio; j < fin; j++)
            {
                if (numeros[j] <= pivote) // Si el elemento es menor o igual al pivote.
                {
                    i++;
                    // Intercambia elementos.
                    int temp = numeros[i];
                    numeros[i] = numeros[j];
                    numeros[j] = temp;
                }
            }

            // Coloca el pivote en su posición correcta.
            int tempFinal = numeros[i + 1];
            numeros[i + 1] = numeros[fin];
            numeros[fin] = tempFinal;

            return i + 1; // Devuelve el índice del pivote.
        }

        // Método de ordenación ShellSort.
        public static void ShellSort(int[] numeros)
        {
            int n = numeros.Length;

            // Reduce el tamaño del intervalo en cada iteración.
            for (int gap = n / 2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                {
                    int temp = numeros[i];
                    int j;
                    // Inserción directa dentro del intervalo.
                    for (j = i; j >= gap && numeros[j - gap] > temp; j -= gap)
                    {
                        numeros[j] = numeros[j - gap];
                    }
                    numeros[j] = temp;
                }
            }
        }

        // Método de ordenación RadixSort.
        public static void RadixSort(int[] numeros)
        {
            int max = ObtenerMaximo(numeros); // Encuentra el valor máximo en el arreglo.
            for (int exp = 1; max / exp > 0; exp *= 10) // Itera por cada dígito.
            {
                ContarOrdenar(numeros, exp); // Ordena por el dígito actual.
            }
        }

        // Encuentra el valor máximo en el arreglo.
        private static int ObtenerMaximo(int[] numeros)
        {
            int max = numeros[0];
            foreach (var num in numeros)
            {
                if (num > max)
                    max = num;
            }
            return max;
        }

        // Ordena los números según el dígito especificado por `exp`.
        private static void ContarOrdenar(int[] numeros, int exp)
        {
            int n = numeros.Length;
            int[] salida = new int[n]; // Arreglo temporal para almacenar el resultado.
            int[] conteo = new int[10]; // Conteo de dígitos (0-9).

            // Contar ocurrencias de cada dígito.
            for (int i = 0; i < n; i++)
            {
                int indice = (numeros[i] / exp) % 10;
                conteo[indice]++;
            }

            // Calcular posiciones acumuladas.
            for (int i = 1; i < 10; i++)
            {
                conteo[i] += conteo[i - 1];
            }

            // Construir el arreglo de salida.
            for (int i = n - 1; i >= 0; i--)
            {
                int indice = (numeros[i] / exp) % 10;
                salida[conteo[indice] - 1] = numeros[i];
                conteo[indice]--;
            }

            // Copiar el arreglo ordenado al original.
            for (int i = 0; i < n; i++)
            {
                numeros[i] = salida[i];
            }
        }

        // Método para intercalar dos arreglos ordenados.
        public static int[] Intercalar(int[] arr1, int[] arr2)
        {
            int n1 = arr1.Length, n2 = arr2.Length;
            int[] resultado = new int[n1 + n2];
            int i = 0, j = 0, k = 0;

            // Combina los dos arreglos en uno.
            while (i < n1 && j < n2)
            {
                if (arr1[i] <= arr2[j])
                {
                    resultado[k++] = arr1[i++];
                }
                else
                {
                    resultado[k++] = arr2[j++];
                }
            }

            // Copia los elementos restantes del primer arreglo.
            while (i < n1)
            {
                resultado[k++] = arr1[i++];
            }

            // Copia los elementos restantes del segundo arreglo.
            while (j < n2)
            {
                resultado[k++] = arr2[j++];
            }

            return resultado; // Devuelve el arreglo intercalado.
        }

        // Método de ordenación por mezcla directa (MergeSort).
        public static void MezclaDirecta(int[] numeros)
        {
            if (numeros.Length <= 1) // Caso base: el arreglo ya está ordenado.
                return;

            int medio = numeros.Length / 2;

            // Divide el arreglo en dos partes.
            int[] izquierda = new int[medio];
            int[] derecha = new int[numeros.Length - medio];

            Array.Copy(numeros, 0, izquierda, 0, medio);
            Array.Copy(numeros, medio, derecha, 0, numeros.Length - medio);

            // Ordena recursivamente cada mitad.
            MezclaDirecta(izquierda);
            MezclaDirecta(derecha);

            // Combina las mitades ordenadas.
            Combinar(numeros, izquierda, derecha);
        }

        // Combina dos arreglos ordenados.
        private static void Combinar(int[] numeros, int[] izquierda, int[] derecha)
        {
            int i = 0, j = 0, k = 0;

            // Fusiona elementos de los subarreglos.
            while (i < izquierda.Length && j < derecha.Length)
            {
                if (izquierda[i] <= derecha[j])
                {
                    numeros[k++] = izquierda[i++];
                }
                else
                {
                    numeros[k++] = derecha[j++];
                }
            }

            // Copia los elementos restantes de la izquierda.
            while (i < izquierda.Length)
            {
                numeros[k++] = izquierda[i++];
            }

            // Copia los elementos restantes de la derecha.
            while (j < derecha.Length)
            {
                numeros[k++] = derecha[j++];
            }
        }

        // Método de MergeSort Natural.
        public static void MergeSortNatural(int[] numeros)
        {
            int n = numeros.Length;
            int[] resultado = new int[n];

            int longitudSubsecuencia = 1;
            while (longitudSubsecuencia < n)
            {
                for (int i = 0; i < n; i += 2 * longitudSubsecuencia)
                {
                    int inicio = i;
                    int mitad = Math.Min(i + longitudSubsecuencia, n);
                    int fin = Math.Min(i + 2 * longitudSubsecuencia, n);

                    Merge(numeros, resultado, inicio, mitad, fin);
                }

                longitudSubsecuencia *= 2;
                Array.Copy(resultado, 0, numeros, 0, n);
            }
        }

        // Fusión en MergeSort Natural.
        private static void Merge(int[] numeros, int[] resultado, int inicio, int mitad, int fin)
        {
            int i = inicio, j = mitad, k = inicio;

            while (i < mitad && j < fin)
            {
                if (numeros[i] <= numeros[j])
                {
                    resultado[k++] = numeros[i++];
                }
                else
                {
                    resultado[k++] = numeros[j++];
                }
            }

            while (i < mitad)
            {
                resultado[k++] = numeros[i++];
            }

            while (j < fin)
            {
                resultado[k++] = numeros[j++];
            }
        }
    }
}

