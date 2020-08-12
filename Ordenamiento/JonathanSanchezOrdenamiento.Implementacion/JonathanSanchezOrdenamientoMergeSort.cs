using System;
using Ordenamientos.Entidad;
using Ordenamientos.Modelo;

namespace JonathanSanchezOrdenamiento.Implementacion
{
    public class JonathanSanchezOrdenamientoMergeSort : Ordenamiento, IOrdenamiento
    {
        public void MostrarArreglo(int[] array)
        {
            foreach (int i in array)
                Console.Write(" " + i.ToString());
        }

        public void Ordenar(int[] array)
        {
            MostrarArreglo(array);
            MergeSort(array, 0, array.Length - 1);
            Console.ReadLine();
            MostrarArreglo(array);
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
    }
}
