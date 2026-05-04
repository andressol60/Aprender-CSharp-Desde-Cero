namespace _03.Bucles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //un bucle es una estructura que ejecuta un bloque de codigo repetidas veces hasta o mientras
            //se cumpla una condición
            //FOR:
            //Es una estructura que se divide en 3 partes esta estructura se utiliza cuando se tiene
            //idea de la veces que se va repetir el bloque de código
            //for(i=0;i>10:i++)
            //(i=0;**;**) aqui se inicializa la variable
            //(**;i>10;**) ahora se evalua si la condicion llego a su fin o seguira repitiendose
            //(**;**;i++) este es el incremento es decir si es una suma de 1 en 1 o de 2 en 2 en este caso es i+1
            int i;
            for (i = 0; i < 10; i++) //empieza en 0 si quieres que empieze el 1 inicializa la variable en 1
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------------------------------------------------");
            //while
            //Esta estructura se utiliza cuando no se sabe el numero exacto de repeticiones
            //que va hacer el bloque de código
            //El while evalúa la condición antes de cada vuelta.
            //Si desde el inicio es falsa, no entra nunca.
            int n = 0;
            while (n != 6)
            {
                Console.WriteLine("Ingrese el valor 6: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------------------------------");
            //do while igual que while pero al menos hay una ejecución
            string respuesta;
            do
            {
                Console.WriteLine("Escriba algo (o 'salir' para terminar):");
                respuesta = Console.ReadLine();
            } while (respuesta != "salir");

            Console.WriteLine("-----------------------------------------------------");
            //foreach para recorrer colecciones elemento por elemento
            string[] frutas = { "manzana", "pera", "uva" };

            foreach (string fruta in frutas)
            {
                Console.WriteLine(fruta);
            }

            Console.WriteLine("-----------------------------------------------------");
            //break y continue — control dentro del bucle

            for (int k = 0; k < 10; k++)
            {
                if (k == 5) break;     // sale del bucle cuando i llega a 5
                Console.WriteLine(k);
            }

            for (int k = 0; k < 5; k++)
            {
                if (k == 2) continue;  // salta la vuelta cuando i es 2
                Console.WriteLine(k);
            }

            //Ejercicio 1 — Tabla de multiplicar
            //Crea un programa que pida al usuario un número y muestre su tabla de multiplicar
            //completa del 1 al 12 con este formato exacto:
            Console.WriteLine("Ingrese un número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < 13; j++)
            {
                int v = num * j;
                Console.WriteLine($"{num} x {j} = {v}");
            }
            Console.WriteLine("------------------------------------------------------");
            //Ejercicio 2 — Suma acumulada
            //Crea un programa que pida números al usuario uno por uno en un bucle.
            //El programa debe ir sumando cada número ingresado. Cuando el usuario escriba
            //0 el programa se detiene y muestra en consola la suma total y cuántos
            //números ingresó sin contar el cero.
            int val = 1;
            int suma = 0;
            int contador = 0;
            while (val != 0)
            {
                Console.WriteLine("Ingrese un numero, 0 para terminar");
                val = Convert.ToInt32(Console.ReadLine());
                suma += val;
                contador = contador + 1;
            }
            Console.WriteLine($"Suma: {suma}");
            Console.WriteLine($"Cantidad numeros ingresados: {contador - 1}");
            Console.WriteLine("-------------------------------------------------");
            //Ejercicio 3 — Triángulo de asteriscos
            //Crea un programa que pida al usuario un número N y dibuje un triángulo de
            //asteriscos de N filas.La primera fila tiene 1 asterisco, la segunda 2,
            //y así hasta N.Luego sin pedir nada más, dibuja el triángulo al revés desde N hasta 1.
            Console.WriteLine("Ingrese la cantidad de filas para el triangulo: ");
            int va = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j <= va; j++)
            {
                string asteriscos = new string('*', j);
                Console.WriteLine(asteriscos);
            }
            for (int j = va - 1; j >= 1; j--)
            {
                string asteriscos = new string('*', j);
                Console.WriteLine(asteriscos);
            }

        }
    }
}
