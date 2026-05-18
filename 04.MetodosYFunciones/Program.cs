namespace _04.MetodosYFunciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saludar();

            Console.WriteLine("Métodos y funciones");
            Console.WriteLine("Ingrese el primer numero: ");
            decimal num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero: ");
            decimal num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------------------------------------------------");
            //Ejercicio 1 — Calculadora con métodos
            //Crea cuatro métodos: Sumar, Restar, Multiplicar y Dividir.Cada uno recibe dos 
            //números decimal y devuelve el resultado.Para Dividir agrega una validación
            //dentro del método que evite la división entre cero y muestre un mensaje si eso ocurre.
            //Llama a los cuatro métodos desde el programa principal y muestra cada resultado.
            Console.WriteLine("Ejercicio 1");

            decimal suma = Sumar(num1, num2);
            Console.WriteLine($"Suma: {suma}");

            decimal resta = Restar(num1, num2);
            Console.WriteLine($"Resta: {resta}");

            decimal multiplicacion = Multiplicacion(num1, num2);
            Console.WriteLine($"Multiplicacion: {multiplicacion}");

            string division = Division(num1, num2);
            Console.WriteLine($"Division: {division}");

            Console.WriteLine("----------------------------------------------------");


            //Metodos son bloques de codigo que pueden ser reutilizables cuantas veces sea necesario
            //estructura
            //modificador de acceso: permite utilizar o no el método o si se define
            //en una variable se aplica a ella en poo se define de mejor forma

            //Método sin variable de retorno solo imprime el mensage
            static void Saludar()
            {
                Console.WriteLine("Hola, Bienvenido");
            }

            static decimal Sumar(decimal num1, decimal num2)
            {
                decimal sum = num1 + num2;
                return sum;
            }

            static decimal Restar(decimal num1, decimal num2)
            {
                decimal res = num1 - num2;
                return res;
            }

            static decimal Multiplicacion(decimal num1, decimal num2)
            {
                decimal mul = num1 * num2;
                return mul;
            }

            static string Division(decimal num1, decimal num2)
            {
                if (num2 == 0)
                {
                    return "no se puede dividir entre 0";
                }
                decimal divi = num1 / num2;
                return Convert.ToString(divi);
            }
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Ejercicio 2");
            bool respuesta;
            do
            {
                Console.WriteLine("Ingrese su edad: ");
                int edad = Convert.ToInt32(Console.ReadLine());
                respuesta = EsMayorDeEdad(edad);
                if (respuesta == false)
                {
                    Console.WriteLine("Su edad es menor a 18");
                }
            } while (respuesta == false);

            bool contrase;
            do
            {
                Console.WriteLine("Ingrese su contraseña: ");
                string contrasenia = Console.ReadLine();
                contrase = EsContrasenaValida(contrasenia);
                if (contrase == false)
                {
                    Console.WriteLine("Menos de 8 caracteres, respuesta incorrecta");
                }
            }
            while (contrase == false);

            bool valorNota;
            do
            {
                Console.WriteLine("Ingrese su Nota: ");
                int Nota = Convert.ToInt32(Console.ReadLine());
                valorNota = EsNotaValida(Nota);
                if (valorNota == false)
                {
                    Console.WriteLine("Invalido, notas entre 0 y 100");
                }
            }
            while (valorNota == false);


            //---------------------------------------------------------
            //Ejercicio 2 — Validador de datos
            //Crea tres métodos de validación que devuelvan bool:
            //EsMayorDeEdad(int edad) → verdadero si edad es mayor o igual a 18
            //EsContrasenaValida(string contrasena) → verdadero si tiene 8 o más caracteres
            //EsNotaValida(int nota) → verdadero si está entre 0 y 100
            //Luego en el programa principal pide esos tres datos al usuario,
            //llama a cada método de validación y muestra un mensaje diciendo si cada dato es válido o no.
            static bool EsMayorDeEdad(int edad)
            {
                if (edad < 18)
                {
                    return false;
                }
                return true;
            }

            static bool EsContrasenaValida(string contrasena)
            {
                if (contrasena.Length < 8)
                {
                    return false;
                }
                return true;
            }

            static bool EsNotaValida(int nota)
            {
                if (nota >= 0 && nota <= 100)
                {
                    return true;
                }
                return false;
            }

            //-------------------------------------------
            //Ejercicio 3 — Calculadora de descuentos
            //Crea un método CalcularPrecioFinal que reciba el precio original como decimal y el porcentaje
            //de descuento como double, y devuelva el precio final ya con el descuento aplicado.
            //Luego crea un segundo método MostrarResumen que reciba los mismos datos más el precio final
            //y muestre en consola un resumen formateado
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Ejercicio 3");
            Console.WriteLine("Ingrese el precio Original del producto: ");
            decimal precioOriginal = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el porcentaje de descuento: ");
            double descuento = double.Parse(Console.ReadLine());

            MostrarResumen(precioOriginal, descuento, CalcularPrecioFinal(precioOriginal, descuento));

            static decimal CalcularPrecioFinal(decimal precioOriginal, double descuento)
            {
                decimal precioFinal;
                descuento = descuento / 100;
                precioFinal = precioOriginal - (precioOriginal * Convert.ToDecimal(descuento));
                return precioFinal;
            }

            static void MostrarResumen(decimal precioOriginal, double descuento, decimal precioFinal)
            {
                Console.WriteLine("***************************");
                decimal ahorro = precioOriginal * Convert.ToDecimal(descuento / 100);
                Console.WriteLine($"Precio Original: {precioOriginal:F2}");
                Console.WriteLine($"Descuento: {descuento:F2}%");
                Console.WriteLine($"Ahorro: {ahorro}");
                Console.WriteLine($"Precio Final: {precioFinal}");
                Console.WriteLine("***************************");
            }

            Console.Read();
        }
    }
}
