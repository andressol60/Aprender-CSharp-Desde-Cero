using _06.POO_ClasesYObjetos;

namespace _07.POO_Herencia
{
    public class CuentasAhorros : CuentaBancaria
    {
        public decimal LimiteDescubierto { get; set; }
        public CuentasAhorros(string numeroCuenta, string titular, decimal saldo, decimal limiteDescubierto)
            : base(numeroCuenta, titular, saldo)
        {
            LimiteDescubierto = limiteDescubierto;
        }

        public virtual bool Retirar(decimal montoRetiro)   // metodo virtual para calcular el retiro
        {
            if (montoRetiro <= Saldo + LimiteDescubierto)
            {
                Saldo -= montoRetiro;
                Console.WriteLine($"Retiro con descubierto: {montoRetiro}, Saldo actual: {Saldo}");
                return true;
            }
            Console.WriteLine("Supera el límite de descubierto.");
            return false;
        }

    }
}
