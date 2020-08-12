using System;
using System.Collections.Generic;
using System.Text;

namespace JonathanSanchez.Ordenamiento
{
   public class Algoritmo
    {

        public void Bubblesort(int[] desordenado)
        {
            Mostrar(desordenado);
            Console.ReadLine();
            var ordenado = Burbuja(desordenado);
            Mostrar(ordenado);
            Console.ReadLine();
        }
       
        static private int[] Burbuja(int[] desordenado) 
        {
            int mayor;
            int[] ordenado;
            for (int inicio = 1; inicio < desordenado.Length; inicio++)
            {
                for (int final = desordenado.Length - 1; final >= inicio; final--)
                {
                    if (desordenado[final - 1] > desordenado[final])
                    {
                        mayor = desordenado[final - 1];
                        desordenado[final - 1] = desordenado[final];
                        desordenado[final] = mayor;
                    }
                }
            }
            ordenado = desordenado;
            return ordenado;
        }

        static private void Mostrar(int[] array)
        {
            foreach (int i in array)
                Console.Write(" " + i.ToString());
        }

        public void MergeSort(int[] array)
        {
            Mostrar(array);
            MergeSort(array, 0, array.Length - 1);
            Console.ReadLine();
            Mostrar(array);
            Console.ReadLine();
        }
        static private void MergeSort(int[] array, int inicio, int fin)
        {
            if (inicio == fin)
            {
                return;
            }
            int mitad = (inicio + fin) / 2;

            MergeSort(array, inicio, mitad);
            MergeSort(array, mitad + 1, fin);
            int[] aux = juntarArrays(array, inicio, mitad, mitad + 1, fin);
            Array.Copy(aux, 0, array, inicio, aux.Length);
        }

        static private int[] juntarArrays(int[] x, int inicio, int fin, int inicio2, int fin2)
        {
            int aux1 = inicio;
            int aux2 = inicio2;
            int[] resultado = new int[fin - inicio + fin2 - inicio2 + 2];
            for (int i = 0; i < resultado.Length; i++)
            {
                if (aux2 != x.Length)
                {
                    if (aux1 > fin && aux2 <= fin2)
                    {
                        resultado[i] = x[aux2];
                        aux2++;
                    }
                    if (aux2 > fin2 && aux1 <= fin)
                    {
                        resultado[i] = x[aux1];
                        aux1++;
                    }
                    if (aux1 <= fin && aux2 <= fin2)
                    {
                        if (x[aux2] <= x[aux1])
                        {
                            resultado[i] = x[aux2];
                            aux2++;
                        }
                        else
                        {
                            resultado[i] = x[aux1];
                            aux1++;
                        }
                    }

                }
                else
                {
                    if (aux1 <= fin)
                    {
                        resultado[i] = x[aux1];
                        aux1++;
                    }
                }
            }
            return resultado;
        }
        public void PigeonholeSort(int[] array)
        {
            Mostrar(array);
            PigeonholeSort1(array);
            Console.ReadLine();
            Mostrar(array);
            Console.ReadLine();
        }
        private static void PigeonholeSort1(int[] arr)
        {
            int min = arr[0];
            int max = arr[0];
            int range, i, j, index;

            for (int a = 0; a < arr.Length; a++)
            {
                if (arr[a] > max)
                    max = arr[a];
                if (arr[a] < min)
                    min = arr[a];
            }

            range = max - min + 1;
            int[] phole = new int[range];

            for (i = 0; i < arr.Length; i++)
                phole[i] = 0;

            for (i = 0; i < arr.Length; i++)
                phole[arr[i] - min]++;


            index = 0;

            for (j = 0; j < range; j++)
                while (phole[j]-- > 0)
                    arr[index++] = j + min;

        }
    }
}
