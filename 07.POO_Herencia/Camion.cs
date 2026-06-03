namespace _07.POO_Herencia
{
    public class Camion : Vehiculo
    {
        public decimal CapacidadToneladas { get; set; }
        public Camion(string marca, string modelo,
            int anio, decimal velocidad, decimal capacidadtoneladas)
            : base(marca, modelo, anio, velocidad)
        {
            CapacidadToneladas = capacidadtoneladas;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();    //NO HAY NECESIDAD DE COPIAR TODO EL CODIGO DEL METODO POR ALGO ESTA HEREDANDO
            Console.WriteLine($"Capacidad Toneladas: {CapacidadToneladas}");
        }
    }
}
