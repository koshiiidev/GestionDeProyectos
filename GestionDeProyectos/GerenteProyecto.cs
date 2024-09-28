using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeProyectos
{
    internal class GerenteProyecto : Empleado
    {
        public int CantidadProyectos {  get; set; }
        public GerenteProyecto(string nombre, string posicion, int horasTrabajadas, int cantidadProyectos) : base(nombre, posicion, horasTrabajadas)
        {
            CantidadProyectos = cantidadProyectos;
        }

        public override int GetHorasTrabajadas()
        {
            return base.GetHorasTrabajadas() + (base.GetHorasTrabajadas() / 10);
        }
    }
}
