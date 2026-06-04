namespace _07.POO_Herencia
{
    public class EmpleadoPorHoras : Empleado
    {
        // agregue HorasTrabajadas y ValorHora y sobreescriba CalcularSalario()
        //multiplicando horas por valor hora
        public int HorasTrabajadas { get; set; }
        public decimal ValorHora { get; set; }
        public EmpleadoPorHoras(string nombre, string apellido, int edad,
            string cargo, decimal salariobase, int horastrabajadas, decimal valorhora)
            : base(nombre, apellido, edad, cargo, salariobase)
        {
            HorasTrabajadas = horastrabajadas;
            ValorHora = valorhora;
        }

        public override decimal CalcularSalario()
        {
            decimal total = HorasTrabajadas * ValorHora;
            return total;
        }
    }
}
