using _07.POO_Herencia;

namespace Cliente_07.POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Perro("Botas", 6, "pitbull");

            perro.HacerSonido();
            perro.Dormir();
        }
    }
}
