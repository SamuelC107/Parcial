// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Personas Persona = new Personas();
Persona.Id = 1;
Persona.Nombre = "Samuel";
Persona.Estatura = 1.73m;
Persona.Vive = true;
Persona.Fecha = DateTime.Now;
Persona.Estado = new Estados() { Id = 1, Nombre = "Soltero" };
Persona.VideoJuegos = new List<VideoJuegos>();
Persona.VideoJuegos.Add(new VideoJuegos() { Id = 1, Nombre = "GTA" });

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