namespace _07.POO_Herencia
{
    public class Empleado : Persona
    {
        public string Cargo { get; set; }
        public decimal SalarioBase { get; set; }
        public Empleado(string nombre, string apellido, int edad, string cargo, decimal salariobase)
            : base(nombre, apellido, edad)
        {
            Cargo = cargo;
            SalarioBase = salariobase;
        }

        public virtual decimal CalcularSalario()
        {
            return SalarioBase;
        }
    }
}
