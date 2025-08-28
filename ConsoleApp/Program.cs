// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Estados
{
    public int Id;
    public string? Nombre;
    public List<Personas>? Personas;
}

public class VideoJuegos
{
    public int Id;
    public string? Nombre;
}

public class Personas
{
    public int Id;
    public string? Nombre;
    public decimal Estatura;
    public bool Vive;
    public DateTime Fecha;
    public Estados? Estado;
    public List<VideoJuegos>? VideoJuegos;
}