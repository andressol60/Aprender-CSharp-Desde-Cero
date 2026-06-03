namespace _07.POO_Herencia
{
    public class Moto : Vehiculo
    {
        public string TipoManubrio { get; set; }
        public Moto(string marca, string modelo,
        int anio, decimal velocidad, string tipomanubrio)
            : base(marca, modelo, anio, velocidad)
        {
            TipoManubrio = tipomanubrio;
        }

        public override void MostrarInfo()
        {
            base.MostrarInfo();    //NO HAY NECESIDAD DE COPIAR TODO EL CODIGO DEL METODO POR ALGO ESTA HEREDANDO
            Console.WriteLine($"Tipo Manubrio: {TipoManubrio}");
        }
    }
}
