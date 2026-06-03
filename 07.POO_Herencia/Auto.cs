namespace _07.POO_Herencia
{
    public class Auto : Vehiculo
    {
        public int NumeroPuertas { get; set; }
        public Auto(string marca, string modelo, int anio,
            decimal velocidad, int numeroPuertas) : base(marca, modelo, anio, velocidad)
        {
            NumeroPuertas = numeroPuertas;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();   //NO HAY NECESIDAD DE COPIAR TODO EL CODIGO DEL METODO POR ALGO ESTA HEREDANDO
            Console.WriteLine($"Número Puertas: {NumeroPuertas}");
        }
    }
}
