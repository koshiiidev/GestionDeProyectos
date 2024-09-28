using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeProyectos
{
    public class Empleado
    {

        protected string Nombre { get; set; }
        protected string Posicion { get; set; }
        protected int HorasTrabajadas { get; set; }

        

        public Empleado(string nombre, string posicion, int horasTrabajadas)
        {
            Nombre = nombre;
            Posicion = posicion;
            SetHorasTrabajadas(horasTrabajadas);
        }

        //Getters & Setters

        public string GetNombre()
        {
            return Nombre;
        }

        public void SetNombre(string value)
        {
            Nombre = value;
        }

        public string GetPosicion()
        {
            return Posicion;
        }

        public void SetPosicion(string value)
        {
            Posicion = value;
        }

        public virtual int GetHorasTrabajadas()
        {
            return HorasTrabajadas;
        }

        public void SetHorasTrabajadas(int Horas)
        {
            try
            {
                if (Horas < 0)
                {
                    throw new ArgumentException("Las horas trabajadas no pueden ser negativas");
                }
                HorasTrabajadas = Horas;

            }
            catch (ArgumentException e)
            {

                Console.WriteLine($"A ocurrido un error, Error {e.Message}");
            }
        }


    }
}
