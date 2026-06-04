using _07.POO_Herencia;

namespace Cliente_07.POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Perro("Botas", 6, "pitbull");

            perro.HacerSonido();
            perro.Dormir();

            //Ejercicio 1 — Jerarquía de vehículos
            //Crea una clase base Vehiculo con las propiedades Marca, Modelo, Año y Velocidad.
            //Agrega un método virtual llamado MostrarInfo() que imprima todos los datos, y un método
            //Acelerar(int km) que sume a la velocidad.Luego crea tres clases que hereden de Vehiculo:
            //Auto con la propiedad NumeroPuertas, Moto con la propiedad TipoManubrio,
            //y Camion con la propiedad CapacidadToneladas.Cada una hace override de MostrarInfo()
            //para mostrar también su propiedad extra.Crea un objeto de cada tipo y prueba todos los métodos.
            Console.WriteLine("--------------------------------");
            Vehiculo auto1 = new Auto("Chevrolet", "Camaro", 2012, 90.5m, 2);
            Vehiculo moto1 = new Moto("Suzuki", "abc456", 2020, 60.5m, "recto");
            Vehiculo camion1 = new Camion("Hino", "gh", 2021, 40.5m, 5);

            auto1.MostrarInfo();
            Console.WriteLine("=========");
            moto1.MostrarInfo();
            Console.WriteLine("=========");
            camion1.MostrarInfo();

            //Ejercicio 2 — Sistema de empleados
            //Crea una clase base Persona con Nombre, Apellido y Edad.
            //Crea una clase Empleado que herede de Persona y agregue Cargo, SalarioBase
            //y un método virtual CalcularSalario() que devuelva el salario base.
            //Luego crea dos clases que hereden de Empleado: EmpleadoFijo que agregue
            //Bonificacion y sobreescriba CalcularSalario() sumando la bonificación al salario base,
            //y EmpleadoPorHoras que agregue HorasTrabajadas y ValorHora y sobreescriba CalcularSalario()
            //multiplicando horas por valor hora.Crea objetos de ambos tipos y muestra el salario calculado de cada uno.
            Console.WriteLine("--------------------------------");
            Empleado empleado1 = new EmpleadoFijo("Carlos", "Saenz", 25, "supervisor", 1000, 15m);
            EmpleadoPorHoras empleado2 = new EmpleadoPorHoras("Pedro", "Herrera", 29, "Empleado producción", 900, 120, 5);

            Console.WriteLine($"Empleado Fijo: {empleado1.Nombre} {empleado1.Apellido}");
            Console.WriteLine($"Sueldo mensual: {empleado1.CalcularSalario()}");

            Console.WriteLine("===================");
            Console.WriteLine($"Empleado por horas: {empleado2.Nombre} {empleado2.Apellido}");
            Console.WriteLine($"Costo de hora: {empleado2.ValorHora}");
            Console.WriteLine($"Sueldo por {empleado2.HorasTrabajadas}: {empleado2.CalcularSalario()}");

            //Ejercicio 3 — Extensión de CuentaBancaria
            //Toma la clase CuentaBancaria que ya hiciste en el Tema 05 y crea dos clases que hereden de ella:
            //CuentaAhorros que agregue una propiedad TasaInteres y un método AplicarInteres()
            //que calcule y sume los intereses al saldo, y CuentaCorriente que agregue LimiteDescubierto
            //y sobreescriba el método Retirar() para permitir retirar hasta el límite de descubierto sin
            //que el saldo baje de cero.Prueba ambas cuentas con depósitos, retiros y sus métodos especiales.
            Console.WriteLine("--------------------------------");



            Console.Read();
        }
    }
}
