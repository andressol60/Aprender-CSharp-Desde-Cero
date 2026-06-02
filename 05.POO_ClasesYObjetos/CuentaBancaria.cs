namespace _06.POO_ClasesYObjetos;

public class CuentaBancaria
{
    public string NumeroCuenta { get; set; }
    public string Titular { get; set; }
    public decimal Saldo { get; private set; }

    public CuentaBancaria(string numeroCuenta, string titular, decimal saldo)
    {
        NumeroCuenta = numeroCuenta;
        Titular = titular;
        Saldo = saldo;
    }

    //public decimal ConsultarSaldo()
    //{
    //    return Saldo;
    //}

    //Sume al saldo validando que el monto sea mayor a cero
    public void Depositar(decimal monto)
    {
        if (monto > 0)
        {
            Saldo = Saldo + monto;
        }
        else
        {
            Console.WriteLine("El monto a Depositar debe ser mayor a 0");
        }
    }

    //Que reste del saldo validando que haya suficiente dinero y que el monto sea mayor a cero
    public void Retirar(decimal montoRetiro)
    {

        if (montoRetiro <= Saldo && montoRetiro > 0)
        {
            Saldo = Saldo - montoRetiro;
        }
        else
        {
            Console.WriteLine("Saldo Insuficiente o monto menor e igual a cero");
        }
    }

    public void MostrarEstado()
    {
        Console.WriteLine($"Número de Cuenta: {NumeroCuenta}");
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Saldo: {Saldo}");
    }
}
