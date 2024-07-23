using System;

namespace ConsoleApp25
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            Persona persona = new Persona("Jostin Wilmer", 20, "Calle Manuel Maria De Corso", "jostinwilmer@hotmail.com");

            
            CorreoService correoService = new CorreoService();
            ImprimirService imprimirService = new ImprimirService();

           
            imprimirService.ImprimirDatos(persona);
            correoService.EnviarCorreoElectronico("Hola, este es un mensaje de prueba.", persona);
        }
    }
}