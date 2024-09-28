//Codigo por Isaac López Valverde
//GitHub: KoshiiiDev

using GestionDeProyectos;

//Creacion de un objeto de la clase Proyecto
Proyecto proyecto = new Proyecto()
{
    NombreProyecto = "Sistema de Gestion",
    FechaInicio = DateTime.Now,
    FechaFin = DateTime.Now.AddMonths(6),
    EstadoProyecto = "En Proceso"
};

//Creacion de los empleados
Empleado empleado1 = new Empleado { Nombre = "Isaac Lopez", Posicion = "Desarrollador"};
Empleado empleado2 = new Empleado { Nombre = "Juanito", Posicion = "Tester"};
GerenteProyecto gerente = new GerenteProyecto { Nombre = "Pancho", Posicion = "Gerente", CantidadProyectos = 3 };

//Asignacion de las horas trabajadas
empleado1.SetHorasTrabajadas(160);
empleado2.SetHorasTrabajadas(140);
gerente.SetHorasTrabajadas(180);

//Intento de agragar un numero negativo en horas
empleado1.SetHorasTrabajadas(-10);

//Agregacion de los empleados al proyecto
proyecto.AgregarEmpleado(empleado1);
proyecto.AgregarEmpleado(empleado2);
proyecto.AgregarEmpleado(gerente);

//Simulacion de generacion y envio de reporte

proyecto.EnviarReporte();

Console.WriteLine($"Total de horas trabajadas en el proyecto: {proyecto.CalcularTotalHorasTrabajadas}");