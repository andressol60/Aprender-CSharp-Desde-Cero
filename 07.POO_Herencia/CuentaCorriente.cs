using _06.POO_ClasesYObjetos;

namespace _07.POO_Herencia
{
    public class CuentaCorriente : CuentaBancaria
    {
        public decimal LimiteDescubierto { get; set; }
        public CuentaCorriente(string numeroCuenta, string titular, decimal saldo, decimal limiteDescubierto)
            : base(numeroCuenta, titular, saldo)
        {
            LimiteDescubierto = limiteDescubierto;
        }

        public override void Retirar(decimal montoRetiro)
        {
            if (montoRetiro <= Saldo + LimiteDescubierto && montoRetiro > 0)
            {
                Saldo -= montoRetiro;
                Console.WriteLine($"Retiro: {montoRetiro}, Saldo actual: {Saldo}");
            }
            else
            {
                Console.WriteLine("Supera el límite de descubierto.");
            }
        }
    }
}
