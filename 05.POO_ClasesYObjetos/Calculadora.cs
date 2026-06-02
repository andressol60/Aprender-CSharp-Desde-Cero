namespace _06.POO_ClasesYObjetos;

public class Calculadora
{
    public List<string> Historial { get; set; }

    public Calculadora()
    {
        Historial = new List<string>();
    }

    // Crea los métodos Sumar, Restar, Multiplicar y Dividir
    public void Sumar(decimal num1, decimal num2)
    {
        decimal suma = num1 + num2;
        Historial.Add($"{num1} + {num2} = {suma:F2}");
    }

    public void Restar(decimal num1, decimal num2)
    {
        decimal resta = num1 - num2;
        Historial.Add($"{num1} - {num2} = {resta:F2}");
    }

    public void Multiplicar(decimal num1, decimal num2)
    {
        decimal multiplicacion = num1 * num2;
        Historial.Add($"{num1} x {num2} = {multiplicacion:F2}");
    }

    public void Dividir(decimal num1, decimal num2)
    {
        if (num2 == 0)
        {
            Console.WriteLine("No se pude dividir por cero");
            Historial.Add("No se pude dividir por cero");
        }
        else
        {
            decimal division = num1 / num2;
            Historial.Add($"{num1} / {num2} = {division:F2}");
        }
    }
}
