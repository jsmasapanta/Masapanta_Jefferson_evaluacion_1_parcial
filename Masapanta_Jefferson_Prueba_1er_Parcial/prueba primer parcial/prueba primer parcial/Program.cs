using System;

public class Estudiante
{
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public double Calificacion { get; set; }

    
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad: {Edad} años");
        Console.WriteLine($"Calificación: {Calificacion}");
    }
}


public class EstudianteGraduado : Estudiante
{
    
    public string Titulo { get; set; }

    
    public new void MostrarInformacion()
    {
        base.MostrarInformacion();
        Console.WriteLine($"Título obtenido: {Titulo}");
    }
}

namespace prueba_primer_parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 50;
            int numero2 = 30;

            int resultado = numero1 + numero2;
            Console.WriteLine("EJERCICIO 1");
            Console.WriteLine("La suma de {0} y {1} es: {2}", numero1, numero2, resultado);

            int edad = 30;

            Console.WriteLine("EJERCICIO 2");
            if (edad >= 18)
            {
                Console.WriteLine("La persona es mayor de edad.");
            }
            else
            {
                Console.WriteLine("La persona no es mayor de edad.");
            }

            Estudiante estudianteespe = new Estudiante
            {
                Nombre = "Jefferson Masapanta",
                Edad = 30,
                Calificacion = 19.25
            };

            Console.WriteLine("EJERCICIO 3");
            Console.WriteLine("Información del Estudiante:");
            estudianteespe.MostrarInformacion();

           
            Console.WriteLine("EJERCICIO 4");
            estudianteespe.MostrarInformacion();

            
            EstudianteGraduado graduadoespe = new EstudianteGraduado
            {
                Nombre = "Estefania Vargas",
                Edad = 22,
                Calificacion = 19.35,
                Titulo = "Ingeniera en Sistemas"
            };

            
            Console.WriteLine("EJERCICIO 5");
            Console.WriteLine("Información del Estudiante Graduado:");
            graduadoespe.MostrarInformacion();

            Console.ReadKey();
        }
    }
}
