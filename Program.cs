using EspacioEmpleado;
using System;

Empleado[] empleados = new Empleado[3];

empleados[0] = new Empleado(
    nombre: "Rodrigo",
    apellido: "Mendoza",
    fechaNacimiento: new DateTime(2000, 10, 10),
    estadoCivil: 'C',
    fechaIngreso: new DateTime(2018, 8, 26),
    sueldo: 160000,
    cargo: Cargos.Ingeniero
);
empleados[1] = new Empleado(
    nombre: "Ana",
    apellido: "García",
    fechaNacimiento: new DateTime(1990, 7, 22),
    estadoCivil: 'C',
    fechaIngreso: new DateTime(2015, 4, 10),
    sueldo: 140000,
    cargo: Cargos.Administrativo
);

empleados[2] = new Empleado(
    nombre: "Luis",
    apellido: "Martínez",
    fechaNacimiento: new DateTime(1995, 10, 30),
    estadoCivil: 'D',
    fechaIngreso: new DateTime(2005, 9, 23),
    sueldo: 160000,
    cargo: Cargos.Especialista
);

Empleado masProximoJubilo = empleados[0];
double totalPagar = 0;

foreach (Empleado empleado in empleados)
{
    totalPagar += empleado.CalcularSalario();

    if (empleado.AniosParaJubilo() < masProximoJubilo.AniosParaJubilo())
    {
        masProximoJubilo = empleado;
    }
}
Console.WriteLine($"Monto Total de Salarios: {totalPagar}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("El empleado mas proximo a jubilarse: ");
Console.WriteLine($"Nombre: {masProximoJubilo.Nombre}");
Console.WriteLine($"Apellido: {masProximoJubilo.Apellido}");
Console.WriteLine($"Fecha de nacimiento: {masProximoJubilo.FechaNacimiento}");
Console.WriteLine($"Fecha de ingreso: {masProximoJubilo.FechaIngreso}");
Console.WriteLine($"Sueldo basico: {masProximoJubilo.Sueldo}");
Console.WriteLine($"Cargo: {masProximoJubilo.Cargo}");
Console.WriteLine($"Antiguedad: {masProximoJubilo.Antiguedad()}");
Console.WriteLine($"Anios para Jubilarse: {masProximoJubilo.AniosParaJubilo()}");
Console.WriteLine($"Salario final: {masProximoJubilo.CalcularSalario()}");