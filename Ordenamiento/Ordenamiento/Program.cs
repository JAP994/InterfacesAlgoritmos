using JonathanSanchezOrdenamiento.Implementacion;
using Ordenamientos.Modelo;
using System;
namespace Ordenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mergeSort = { 12, 13, 15, 2, 3, 4, 5, 7, 44, 32 };
            int[] pigeonholeSort = { 4, 6, 7, 8, 1, 2, 3, 9, 34, 56, 12, 11, 14, 15,15,15 };

            Console.WriteLine("Métodos de Ordenamiento ");
            Ordenador ordenador = new Ordenador();

            ordenador.Ordenamiento = new JonathanSanchezOrdenamientoMergeSort {Nombre= "MergeSort" };
            Console.WriteLine($"Ordenamiento por { ordenador.Ordenamiento.Nombre}");
            ordenador.Ordenar(mergeSort);

            ordenador.Ordenamiento = new JonathanSanchezOrdenamientoPigeonholeSort { Nombre = "PigeonholeSort" };
            Console.WriteLine($"Ordenamiento por { ordenador.Ordenamiento.Nombre}");
            ordenador.Ordenar(pigeonholeSort);
        }
    }
}
