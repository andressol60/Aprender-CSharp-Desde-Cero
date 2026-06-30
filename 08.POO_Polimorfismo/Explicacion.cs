namespace _08.POO_Polimorfismo
{
    public class Explicacion
    {
        //Polimorfismo significa "muchas formas".
        //Es la capacidad de un objeto de tomar múltiples formas según su tipo real,
        //aunque se declare con un tipo más general.

        //Imagina que tienes una lista de pagos.
        //Cada pago puede ser de un tipo distinto:
        //con tarjeta de crédito,
        //en efectivo,
        //por transferencia.
        //Cada uno calcula los intereses de forma diferente, pero todos son "pagos".
        //is y as — operadores para polimorfismo
        //Para verificar el tipo real de un objeto:
        //if(vehiculo is Auto)
        //{
        //Auto auto = (Auto)vehiculo;
        //Console.WriteLine(auto.NumeroPuertas);
        //}

        // o más limpio con pattern matching (C# 7+)
        //if (vehiculo is Auto auto)
        //{
        //Console.WriteLine(auto.NumeroPuertas);
        //}
    }
}
