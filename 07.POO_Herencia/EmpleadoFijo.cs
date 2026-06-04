namespace _07.POO_Herencia
{
    public class EmpleadoFijo : Empleado
    {
        //Agregue Bonificacion y sobreescriba CalcularSalario() sumando la bonificación al salario base
        public decimal Bonificacion { get; set; }

        public EmpleadoFijo(string nombre, string apellido,
            int edad, string cargo, decimal salariobase, decimal bonificacion)
            : base(nombre, apellido, edad, cargo, salariobase)
        {
            Bonificacion = bonificacion;
        }

        public override decimal CalcularSalario()
        {
            decimal totalfinal = base.CalcularSalario() + Bonificacion;
            return totalfinal;
        }
    }
}
