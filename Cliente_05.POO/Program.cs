using _06.POO_ClasesYObjetos;

namespace Cliente_05.POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //referencio con el otro proyecto
            //Clieck en el proyecto con program luego en agregar referencia

            //Creo una instancia de persona
            //Es decir creo un molde del objeto persona y lleno sus caracteristicas con información
            //Deacuerdo al tipo de variable
            Persona persona = new Persona();
            persona.Nombre = "Juan";
            persona.Edad = 25;

            //llamo al metodo de la clase persona 
            persona.Saludar();
            Console.WriteLine("-----------------------------------------");
            Persona persona1 = new Persona();
            persona1.Nombre = "Maria";
            persona1.Edad = 24;
            persona1.Saludar();
            Console.WriteLine($"Nombre persona 1: {persona.Nombre}");

            Console.WriteLine("-----------------------------------------");
            Operaciones_matematicas ope = new Operaciones_matematicas(8, 5);
            Console.WriteLine($"Numero 1: {ope.Numero1}");
            Console.WriteLine($"Numero 2: {ope.Numero2}");
            Console.WriteLine($"Suma: {ope.suma()}");
            Console.WriteLine($"Resta: {ope.resta()}");
            Console.WriteLine($"Multiplicación: {ope.multiplicacion()}");
            Console.WriteLine($"División: {ope.division()}");
            Console.WriteLine("------------------------------------------------");
            //Ejercicios:
            //Ejercicio 1 — Clase Estudiante
            //Crea una clase Estudiante con las propiedades Nombre, Apellido, Edad y Nota.
            //Agrega un constructor que reciba todos los datos. Crea tres métodos: MostrarInfo()
            //que imprima todos los datos del estudiante, ObtenerNombreCompleto() que devuelva nombre y apellido juntos,
            //y ObtenerCalificacion() que devuelva un string con la calificación según la nota(Reprobado, Aprobado,
            //Bueno, Muy bueno, Excelente).Crea al menos tres objetos Estudiante distintos y llama a todos los métodos.
            Estudiante estudiante1 = new Estudiante("Andres", "Solis", 19, 7.5m);
            Estudiante estudiante2 = new Estudiante("Alfredo", "Acosta", 19, 3.5m);
            Estudiante estudiante3 = new Estudiante("Carlos", "Armendariz", 19, 10m);
            Estudiante estudiante4 = new Estudiante("Pedro", "Valle", 19, 9m);

            //estudiante1
            estudiante1.MostrarInfo();
            Console.WriteLine("-------------------");
            Console.WriteLine(estudiante2.ObtenerNombreCompleto());
            Console.WriteLine("-------------------");
            Console.WriteLine(estudiante3.ObtenerCalificacion());
            Console.WriteLine(estudiante2.ObtenerCalificacion());
            Console.WriteLine("=========================================");




            //Ejercicio 2 — Clase CuentaBancaria
            //Crea una clase CuentaBancaria con las propiedades NumeroCuenta, Titular y Saldo.
            //El saldo debe ser de solo lectura desde afuera, solo la propia clase puede modificarlo.
            //Crea tres métodos: Depositar(decimal monto) que sume al saldo validando que el monto sea mayor a cero,
            //Retirar(decimal monto) que reste del saldo validando que haya suficiente dinero y que el monto sea mayor a cero,
            //y MostrarEstado() que imprima el número de cuenta, titular y saldo actual.Crea dos cuentas distintas
            //y prueba depositar, retirar y mostrar el estado.





            //Ejercicio 3 — Clase Calculadora
            //Crea una clase Calculadora que tenga una propiedad Historial que sea una lista de strings donde
            //se guarden todas las operaciones realizadas. Crea los métodos Sumar, Restar, Multiplicar y Dividir,
            //cada uno recibe dos decimales, realiza la operación, guarda en el historial un string con el formato "5 + 3 = 8"
            //y devuelve el resultado. Agrega un método MostrarHistorial() que imprima todas las operaciones realizadas.
            //Realiza al menos seis operaciones distintas y muestra el historial al final.



            Console.Read();
        }
    }
}
