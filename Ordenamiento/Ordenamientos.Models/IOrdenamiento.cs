namespace Ordenamientos.Modelo
{
    public interface IOrdenamiento
    {
        public string Nombre { get; set; }

        void MostrarArreglo(int[] array);

        void Ordenar(int[] array);
    }
}
