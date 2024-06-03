namespace EspacioEmpleado;
public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador,
    }
public class Empleado{
    

    private string nombre;
    private string apellido;
    private DateTime fechaNacimiento;
    private char estadoCivil;
    private DateTime fechaIngreso;
    private double sueldo;
    private Cargos cargo;

    

    public string Nombre{
        get => nombre;
        set => nombre = value;
    }

    public string Apellido{
        get => apellido;
        set => apellido = value;
    }

    public DateTime FechaNacimiento{
        get => fechaNacimiento;
        set => fechaNacimiento = value;
    }
    public char EstadoCivil{
        get => estadoCivil;
        set => estadoCivil = value;
    }
    public DateTime FechaIngreso{
        get => fechaIngreso;
        set => fechaIngreso = value;
    }
    public double Sueldo{
        get => sueldo;
        set => sueldo = value;
    }
    public Cargos Cargo{
        get => cargo;
        set => cargo = value;
    }

    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, char estadoCivil, DateTime fechaIngreso, double sueldo, Cargos cargo){
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = fechaNacimiento;
        this.estadoCivil = estadoCivil;
        this.fechaIngreso = fechaIngreso;
        this.sueldo = sueldo;
        this.cargo = cargo;
    }

    public int Antiguedad(){
        DateTime fechaActual = DateTime.Now;
        int antiguedad = fechaActual.Year - fechaIngreso.Year;

        if (fechaActual.Month < fechaIngreso.Month)
        {
            antiguedad--;
        }
        return antiguedad;
    }

    public int Edad(){
        DateTime fechaActual = DateTime.Now;
        int edad = fechaActual.Year - fechaNacimiento.Year;
        if(fechaActual.Month < fechaNacimiento.Month){
            edad--;
        }
        return edad;
    }

    public int AniosParaJubilo(){
        int edad = Edad();
        int jubilo = 65 -  edad;
        return jubilo;
    }

    public double CalcularSalario(){
        double adicional = 0;
        if(Antiguedad() >= 20){
            adicional = sueldo * 0.25;
        }
        else
        {
            adicional = sueldo * Antiguedad() * 0.01;
        }
        if (cargo == Cargos.Ingeniero || cargo == Cargos.Especialista)
        {
            adicional *= 1.50;
        }
        if(estadoCivil == 'C'){
            adicional += 15000;
        }

        return sueldo + adicional;
    }
}