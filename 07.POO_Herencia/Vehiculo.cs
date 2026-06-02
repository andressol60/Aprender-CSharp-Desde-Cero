namespace _07.POO_Herencia
{
    public class Vehiculo
    {
        ////Crea una clase base Vehiculo con las propiedades Marca, Modelo, Año y Velocidad.
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Anio { get; set; }
        public decimal Velocidad { get; set; }

        public Vehiculo(string marca, string modelo, int anio, decimal velocidad)
        {
            Marca = marca;
            Modelo = modelo;
            Anio = anio;
            Velocidad = velocidad;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Año: {Anio}");
            Console.WriteLine($"Velocidad: {Velocidad}");
        }

        public decimal Acelerar(int km)
        {
            decimal velocidadFinal = Velocidad + km;
            return velocidadFinal;
        }



    }
}
