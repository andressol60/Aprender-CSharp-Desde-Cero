namespace _05.Constructores;

public class Persona
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }

    public Persona()
    {

    }
    public Persona(string nombre, string apellido, int edad)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
    }

}
