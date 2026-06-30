namespace _06.POO_ClasesYObjetos;

public class Estudiante
{
    public string Nombre { get; set; }
    public string Apellido { get; set; }
    public int Edad { get; set; }
    public decimal Nota { get; set; }

    public Estudiante()
    {

    }

    public Estudiante(string nombre, string apellido, int edad,
        decimal nota)
    {
        Nombre = nombre;
        Apellido = apellido;
        Edad = edad;
        Nota = nota;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Nombre: {Apellido}");
        Console.WriteLine($"Edad: {Edad}");
        Console.WriteLine($"Nota: {Nota}");
    }

    public string ObtenerNombreCompleto()
    {
        return Nombre + " " + Apellido;
    }

    public string ObtenerCalificacion()
    {
        if (Nota < 0 || Nota > 10)
        {
            return "Nota inválida";
        }
        else if (Nota < 5)
        {
            return "Reprobado";
        }
        else if (Nota < 7)
        {
            return "Aprobado";
        }
        else if (Nota < 8)
        {
            return "Bueno";
        }
        else if (Nota < 9)
        {
            return "Muy Bueno";
        }
        else // entre 9 y 10
        {
            return "Excelente";
        }
    }

}
