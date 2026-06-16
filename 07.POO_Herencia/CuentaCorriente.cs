using _06.POO_ClasesYObjetos;

namespace _07.POO_Herencia
{
    public class CuentaCorriente : CuentaBancaria
    {
        public decimal TasaInteres { get; set; }
        public CuentaCorriente(string numeroCuenta, string titular, decimal saldo, decimal tasaInteres)
            : base(numeroCuenta, titular, saldo)
        {
            TasaInteres = tasaInteres;
        }

        public decimal AplicarInteres()
        {
            decimal interes = Saldo * (TasaInteres / 100);
            return interes;
        }
    }
}
