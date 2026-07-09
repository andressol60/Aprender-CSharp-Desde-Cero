using _07.POO_Herencia;
namespace Cliente_08.POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicios:
            //Ejercicio 1 — Lista polimórfica de empleados
            //Toma las clases del Tema 07(Persona, Empleado, EmpleadoFijo, EmpleadoPorHoras).
            //Crea una List<Empleado> con al menos 4 empleados de ambos tipos mezclados.
            //Recorre la lista con un foreach y para cada empleado imprime su nombre,
            //cargo y sueldo calculado.El polimorfismo hace que cada uno calcule su sueldo de forma
            //diferente sin que necesites verificar el tipo.
            List<Empleado> listaEmpleados = new List<Empleado>();
            EmpleadoFijo emp1 = new EmpleadoFijo("Juan", "Perez", 19, "Seguridad", 500, 10);
            EmpleadoFijo emp2 = new EmpleadoFijo("Carlos", "Acosta", 22, "Jefe carga", 800, 20);
            EmpleadoPorHoras emp3 = new EmpleadoPorHoras("Pedro", "Sanchez", 30, "Produccion", 480, 120, 5);
            EmpleadoPorHoras emp4 = new EmpleadoPorHoras("Pablo", "Noriega", 30, "Produccion", 480, 120, 5);
            listaEmpleados.Add(emp1);
            listaEmpleados.Add(emp2);
            listaEmpleados.Add(emp3);
            listaEmpleados.Add(emp4);

            foreach (Empleado emp in listaEmpleados)
            {
                Console.WriteLine(emp.Nombre);
                Console.WriteLine(emp.Cargo);
                Console.WriteLine($"Sueldo: {emp.CalcularSalario():F2}");
                Console.WriteLine("---------");
            }

            //Ejercicio 2 — Sistema de formas geométricas
            //Crea una clase base Forma con un método virtual decimal CalcularArea().
            //Crea tres clases que hereden: Cuadrado con propiedad Lado, Rectangulo con Ancho y Alto,
            //y Circulo con Radio.
            //Cada una implementa CalcularArea() con su fórmula.Crea una List<Forma> con varias formas de cada tipo.
            //Recorre la lista y calcula el área total de todas las formas. Usa polimorfismo para que cada
            //forma calcule su área sin necesidad de casting.

            Console.Read();
        }
    }
}
