public class Persona
{
    private string nombre;
    private int edad;
    private string direccion;
    private string correoElectronico;

    public Persona(string nombre, int edad, string direccion, string correoElectronico)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.direccion = direccion;
        this.correoElectronico = correoElectronico;
    }

    public string Nombre => nombre;
    public int Edad => edad;
    public string Direccion => direccion;
    public string CorreoElectronico => correoElectronico;
}

public class CorreoService
{
    public void EnviarCorreoElectronico(string mensaje, Persona persona)
    {
        // Lógica para enviar correo electrónico
    }
}

public class ImprimirService
{
    public void ImprimirDatos(Persona persona)
    {
        Console.WriteLine($"Nombre: {persona.Nombre}");
        Console.WriteLine($"Edad: {persona.Edad}");
        Console.WriteLine($"Dirección: {persona.Direccion}");
        Console.WriteLine($"Correo electrónico: {persona.CorreoElectronico}");
    }
}