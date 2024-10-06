using System;
using System.Collections.Generic;

namespace Universidad
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();

            Console.WriteLine("¿Cuántos estudiantes desea ingresar?");
            int cantidadEstudiantes;
            while (!int.TryParse(Console.ReadLine(), out cantidadEstudiantes) || cantidadEstudiantes <= 0)
            {
                Console.WriteLine("Ingrese un numero valido de estudiantes.");
            }

            // Ingresar datos de los estudiantes
            for (int i = 0; i < cantidadEstudiantes; i++)
            {
                Console.WriteLine($"Estudiante {i + 1}:");

                Console.WriteLine("Nombre: ");
                string nombre = Console.ReadLine();

                int sesionesTotales;
                do
                {
                    Console.WriteLine("Numero total de sesiones: ");
                } while (!int.TryParse(Console.ReadLine(), out sesionesTotales) || sesionesTotales <= 0);

                int sesionesAsistidas;
                do
                {
                    Console.WriteLine("Numero de sesiones asistidas: ");
                } while (!int.TryParse(Console.ReadLine(), out sesionesAsistidas) || sesionesAsistidas < 0 || sesionesAsistidas > sesionesTotales);

                // Crear el estudiante y agregarlo a la lista
                estudiantes.Add(new Estudiante(nombre, sesionesTotales, sesionesAsistidas));
            }

            // Mostrar información de cada estudiante
            Console.WriteLine("Resumen de asistencia de los estudiantes: ");
            foreach (var estudiante in estudiantes)
            {
                estudiante.MostrarInformacion();
            }
        }
    }
}
