namespace Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales
            //son estructuras que permiten al programa tomas una descición deacuerdo
            //al manejo de las variables
            //El if evalua las condiciones dentro del parentesis si es si va por el if
            //si es no va por el else
            //se ejecuta la primera condoción que sea verdadera
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Estructura if/else");
            int n = 6;
            if (n > 5)
            {
                Console.WriteLine("El numero es mayor a 5");
            }
            Console.WriteLine("---------------------------------");
            int edad = 16;
            if (edad > 18)
            {
                Console.WriteLine("mayor a 18 años de edad");
            }
            else if (edad == 18)
            {
                Console.WriteLine("Tiene 18 años");
            }
            else
            {
                Console.WriteLine("menor a 18 años");
            }
            Console.WriteLine("---------------------------------");
            //switch se usa cuando se tiene demasiados casos entonces estos se dividen
            //y se ejecuta la selección correcta o el default si en ese caso no
            //coincide con lo pedido
            int dia = 5;
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miercoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sabado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("No corresponde a un dia o es no existe ese nuemro de dia");
                    break;
            }
            // =   asignar a...
            //==   igual a
            //!=   diferente de
            //>    mayor que
            //<    menor que
            //>=   mayor o igual
            //<=   menor o igual
            //&&   Y — ambas condiciones deben ser verdaderas
            //||   O — basta con que una sea verdadera
            //!    NO — invierte el resultado

            //Ejercicio 1 — Calificaciones
            //Crea un programa que pida al usuario una nota entre 0 y 100 usando Console.ReadLine()
            //y muestre en consola el resultado según esta tabla:
            //Menos de 60 → "Reprobado"
            //60 a 69 → "Aprobado"
            //70 a 79 → "Bueno"
            //80 a 89 → "Muy bueno"
            //90 a 100 → "Excelente"
            //Menor a 0 o mayor a 100 → "Nota inválida"

            Console.Write("Ingrese una nota entre 0 y 100: ");
            string entrada = Console.ReadLine();

            if (int.TryParse(entrada, out int nota))
            {
                if (nota < 0 || nota > 100)
                {
                    Console.WriteLine("Nota inválida");
                }
                else if (nota < 60)
                {
                    Console.WriteLine("Reprobado");
                }
                else if (nota <= 69)
                {
                    Console.WriteLine("Aprobado");
                }
                else if (nota <= 79)
                {
                    Console.WriteLine("Bueno");
                }
                else if (nota <= 89)
                {
                    Console.WriteLine("Muy bueno");
                }
                else // entre 90 y 100
                {
                    Console.WriteLine("Excelente");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida, debe ser un número.");
            }
            Console.WriteLine("-----------------------------------------------------");
            //Ejercicio 2 — Sistema de acceso
            //Crea un programa que simule el login de un sistema.Declara un usuario y contraseña correctos
            //directamente en el código como variables.
            //Pide al usuario que ingrese su usuario ycontraseña por consola y muestra
            //uno de estos tres mensajes:
            //Si ambos son correctos → "Acceso concedido. Bienvenido."
            //Si el usuario es correcto pero la contraseña no → "Contraseña incorrecta."
            //Si el usuario no existe → "Usuario no encontrado."
            string usuario = "andresito";
            string contrasenia = "andres123";
            Console.WriteLine("Ingrese su usuario: ");
            string usuarioIngresado = Console.ReadLine();
            Console.WriteLine("Ingrese una contraseña: ");
            string contraseniaIngresada = Console.ReadLine();

            if (usuario == usuarioIngresado && contrasenia == contraseniaIngresada)
            {
                Console.WriteLine("Acceso concedido. Bienvenido");
            }
            else if (usuario == usuarioIngresado && contrasenia != contraseniaIngresada)
            {
                Console.WriteLine("Contraseña incorrecta");
            }
            else if (usuario != usuarioIngresado)
            {
                Console.WriteLine("Usuario no encontrado");
            }
            Console.WriteLine("-----------------------------------------------------");
            //Ejercicio 3 — Calculadora de tarifas
            //Crea un programa para una empresa de transporte que cobra según el tipo de pasajero.
            //El usuario ingresa el tipo con un número:
            //1 → Adulto normal → $1.50
            //2 → Estudiante → $0.75
            //3 → Adulto mayor → $0.50
            //4 → Persona con discapacidad → $0.25
            //Cualquier otro número → "Tipo de pasajero no válido"
            Console.WriteLine("Ingrese su Tipo de pasajero");
            int numeroPasajero = Convert.ToInt32(Console.ReadLine());
            switch (numeroPasajero)
            {
                case 1:
                    Console.WriteLine("Valor tarifa transporte Adulto: ");
                    Console.WriteLine("$1.50");
                    break;
                case 2:
                    Console.WriteLine("Valor tarifa transporte Estudiante: ");
                    Console.WriteLine("$0.75");
                    break;
                case 3:
                    Console.WriteLine("Valor tarifa transporte Adulto mayor: ");
                    Console.WriteLine("$0.50");
                    break;
                case 4:
                    Console.WriteLine("Valor tarifa transporte persona con discapacidad: ");
                    Console.WriteLine("$0.25");
                    break;
                default:
                    Console.WriteLine("Tipo de pasajero no valido");
                    break;
            }
        }
    }
}
