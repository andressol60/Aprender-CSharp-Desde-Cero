//Variable: es un espacio de memoria en la cual
//se guarda un dato para usarlo despues
int n1 = 15;
string dato2 = "Hola";
Console.WriteLine(dato2 + " " + n1);
Console.WriteLine("-------------------------------------");
//  Tipos de variables:
//En C# cada variables tiene un tipo de datos que la define
//no es lo mismo guardar un numero entero que uno con decimales

//string: cadenas,palabras o texto
string texto1 = "Hola, estoy aprendiendo C#";
Console.WriteLine(texto1);
Console.WriteLine("Tipo: " + texto1.GetType());  //El método GetType() nos devuelve el typo de datos de la variable
Console.WriteLine("-------------------------------------");

//int: es un valor entero sin decimales
int n2 = 10;
Console.WriteLine(n2);
Console.WriteLine("Tipo: " + n2.GetType());
Console.WriteLine("-------------------------------------");

//double y decimal: se usa para valores de punto flotante o con decimales
double valor1 = 10.5;
decimal valor2 = 10.55m; //la m nos dice que es decimal
Console.WriteLine(valor1);
Console.WriteLine(valor1.GetType());
Console.WriteLine(valor2);
Console.WriteLine(valor2.GetType());
Console.WriteLine("-------------------------------------");

//bool: Se usa para variable de valor booleano es decir verdadero o falso(true or false) o 0-1
bool booleano1 = true;
Console.WriteLine(booleano1);
booleano1 = false;
Console.WriteLine(booleano1);
Console.WriteLine(booleano1.GetType());
Console.WriteLine("-------------------------------------");

//char: Se utiliza cuando queremos escribir un solo caracter
char c1 = 'a';
Console.WriteLine(c1);
Console.WriteLine(c1.GetType());

Console.WriteLine("-------------------------------------");
Console.WriteLine("Ejercicios");
Console.WriteLine("Ejercicio 1:");
//Crea un programa que declare variables con tu información personal: nombre, edad, ciudad,
//estatura y si estás trabajando actualmente. Luego imprime todo en consola en una sola oración
//por dato, por ejemplo: "Mi nombre es Carlos y tengo 22 años".
string nombre = "Wellington";
string apellido = "Solis";
int edad = 29;
string ciudad = "Ambato";
double estatura = 1.70;
bool trabajas = true;
Console.WriteLine($"Mi nombre es: {nombre} y tengo {edad} años");

Console.WriteLine("-------------------------------------");
Console.WriteLine("Ejercicio 2:");
//Declara dos variables numéricas enteras, realiza las cuatro operaciones básicas entre ellas
//(suma, resta, multiplicación, división) y muestra cada resultado en consola con una etiqueta
//que diga qué operación es.
int n3 = 5;
int n4 = 8;
int suma = n3 + n4;
int resta = n4 - n3;
int multiplicacion = n4 * n3;
double division = n4 / n3;
Console.WriteLine($"Número 1: {n3} | Número 2: {n4}");
Console.WriteLine($"Suma: {suma}");
Console.WriteLine($"Resta: {resta}");
Console.WriteLine($"Multiplicación: {multiplicacion}");
Console.WriteLine($"División: {division}");

Console.WriteLine("-------------------------------------");
Console.WriteLine("Ejercicio 3:");
//Crea un programa que calcule el precio final de un producto aplicando un descuento.
//Declara el precio original como decimal, el porcentaje de descuento como double,
//calcula el precio con descuento y muestra ambos precios en consola.
//Presta atención a cómo conviertes entre tipos distintos.
decimal precioProducto = 5.60m;
double descuentoPorcentaje = 15.6;
Console.WriteLine($"Precio del producto: {precioProducto}");

decimal valorDescuento = (precioProducto * Convert.ToDecimal(descuentoPorcentaje)) / 100;
decimal precioTotal = precioProducto - valorDescuento;
Console.WriteLine(precioTotal.ToString());