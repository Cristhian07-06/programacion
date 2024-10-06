using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    public class Estudiante
    {
        public string Nombre { get; set; }
        public int SesionesTotales { get; set; }
        public int SesionesAsistidas { get; set; }

        // Constructor del estudiante
        public Estudiante(string nombre, int sesionesTotales, int sesionesAsistidas)
        {
            Nombre = nombre;
            SesionesTotales = sesionesTotales;
            SesionesAsistidas = sesionesAsistidas;
        }

        // Método para calcular porcentaje de asistencia
        public static double CalcularPorcentajeAsistencia(int sesionesTotales, int sesionesAsistidas)
        {
            if (sesionesTotales == 0) return 0;
            return (double)sesionesAsistidas / sesionesTotales * 100;
        }

        // Método para verificar si se cumple con el mínimo
        public static bool CumpleConAsistenciaMinima(double porcentajeAsistencia)
        {
            return porcentajeAsistencia >= 75; // Mínimo de asistencia requerido es 75%
        }

        // Método para mostrar la información del estudiante
        public void MostrarInformacion()
        {
            double porcentajeAsistencia = CalcularPorcentajeAsistencia(SesionesTotales, SesionesAsistidas);
            bool cumpleRequisito = CumpleConAsistenciaMinima(porcentajeAsistencia);

            Console.WriteLine($"Estudiante: {Nombre}, Porcentaje de asistencia: {porcentajeAsistencia:F2}%, Estado: {(cumpleRequisito ? "Aprobado" : "No aprobado")}");
        }
    }
}
