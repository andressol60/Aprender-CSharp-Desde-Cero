namespace _07.POO_Herencia
{
    public class Animal
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public Animal(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void Respirar()
        {
            Console.WriteLine($"{Nombre} está respirando");
        }

        public void Dormir()
        {
            Console.WriteLine($"{Nombre} está durmiendo");
        }

        public virtual void HacerSonido()
        {
            Console.WriteLine("El animal hace un sonido");
        }
    }
}
