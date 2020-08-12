using System;
using Ordenamientos.Entidad;
using Ordenamientos.Modelo;

namespace JonathanSanchezOrdenamiento.Implementacion
{
    public class JonathanSanchezOrdenamientoPigeonholeSort : Ordenamiento, IOrdenamiento
    {

        public void MostrarArreglo(int[] array)
        {
            foreach (int i in array)
                Console.Write(" " + i.ToString());
        }

        public void Ordenar(int[] array)
        {
            MostrarArreglo(array);
            PigeonholeSort1(array);
            Console.ReadLine();
            MostrarArreglo(array);
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
