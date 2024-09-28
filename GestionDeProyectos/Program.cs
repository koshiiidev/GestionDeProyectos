//Codigo por Isaac López Valverde
//GitHub: KoshiiiDev

using GestionDeProyectos;

internal class Program
{
    private static void Main(string[] args)
    {
        //Creacion de un objeto de la clase Proyecto
        List<Empleado> empleados = new List<Empleado>();
        Proyecto proyecto = new Proyecto("Sistema de Gestion de Proyectos", DateTime.Now, DateTime.Now.AddMonths(6), "En Proceso", empleados);
        
        //Creacion de los empleados
        Empleado empleado1 = new Empleado("Isaac Lopez", "Desarrollador", 160);
        Empleado empleado2 = new Empleado("Juanito", "Tester", 140);

        //Creacion de un gerente para el Proyecto
        GerenteProyecto gerente = new GerenteProyecto("Pancho", "Gerente", 180, 3);

        //Agregacion de los empleados al proyecto
        proyecto.AgregarEmpleado(empleado1);
        proyecto.AgregarEmpleado(empleado2);
        proyecto.AgregarEmpleado(gerente);


        //Intento de agragar un numero negativo en horas
        empleado1.SetHorasTrabajadas(-10);


        //Simulacion de generacion y envio de reporte

        proyecto.EnviarReporte();

        Console.WriteLine($"Total de horas trabajadas en el proyecto: {proyecto.CalcularTotalHorasTrabajadas}");
    }
}