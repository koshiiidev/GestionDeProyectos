using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeProyectos
{
    public class Proyecto : IReporteable
    {
        public string NombreProyecto;
        public DateTime FechaInicio;
        public DateTime FechaFin;
        public string EstadoProyecto;
        private List<Empleado> empleados = new List<Empleado>();

        public Proyecto(string nombreProyecto, DateTime fechaInicio, DateTime fechaFin, string estadoProyecto)
        {
            NombreProyecto = nombreProyecto;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            EstadoProyecto = estadoProyecto;
            
            
        }

        //Getters & Setters
        public string GetNombreProyecto()
        {
            return NombreProyecto;
        }

        public void SetNombreProyecto(string value)
        {
            NombreProyecto = value;
        }

        public DateTime GetFechaInicio()
        {
            return FechaInicio;
        }

        public void SetFechaInicio(DateTime value)
        {
            FechaInicio = value;
        }

        public DateTime GetFechaFin()
        {
            return FechaFin;
        }

        public void SetFechaFin(DateTime value)
        {
            FechaFin = value;
        }

        public string GetEstadoProyecto()
        {
            return EstadoProyecto;
        }

        public void SetEstadoProyecto(string value)
        {
            EstadoProyecto = value;
        }


        //Metodos

        public void AgregarEmpleado(Empleado empleado)
        {
            
            empleados.Add(empleado);
            Console.WriteLine($"{empleado.GetNombre()} agregado exitosamente al proyecto: {GetNombreProyecto()}");
        }

        public int CalcularTotalHorasTrabajadas()
        {
            return empleados.Sum(e => e.GetHorasTrabajadas());
        }

        public string MostrarEstadoActual()
        {
            return $"El proyecto{NombreProyecto} esta actualmente {EstadoProyecto}";
        }

        public List<Empleado> ObtenerEmpleados()
        {
            return empleados;
        }

        public string GenerarReporte()
        {
            string reporte = $"Reporte del Proyecto: {NombreProyecto}\n";
            reporte += $"Estado: {EstadoProyecto}\n";
            reporte += "Empleados y horas trabajdas: \n";

            foreach (var empleado in empleados)
            {
                reporte += $"- {empleado.GetNombre()}: {empleado.GetHorasTrabajadas()} horas\n";
            }

            return reporte;
            
        }

        public void EnviarReporte()
        {
            Console.WriteLine("****Enviando reporte al gerente****");
            Console.WriteLine(GenerarReporte());
            Console.WriteLine("****Reporte enviado exitosamente****");
        }
    }
}
