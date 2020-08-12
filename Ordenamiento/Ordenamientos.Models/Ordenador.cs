namespace Ordenamientos.Modelo
{
    public class Ordenador
    {
        public IOrdenamiento Ordenamiento { get; set; }

        public void Ordenar(int[] arreglo) 
        {
            Ordenamiento.Ordenar(arreglo);
        }
    }
}
