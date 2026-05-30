using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Tracing;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace Personal;
public class Empleado
{
    //-----CAMPOS-----
    private string nombre;
    private string apellido;
    private DateTime fechaNac;
    private char estadoCivil;
    private DateTime ingreso;
    private double sueldoB;
    public enum Cargo
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }
    private Cargo cargo;
    //-----CONSTRUCTOR-----
    public Empleado(string nom,string ape,DateTime fechaNac,char estadoCivil,DateTime ingreso,double sueldoB,Cargo cargo)
    {
        nombre=nom;
        apellido=ape;
        this.fechaNac=fechaNac;
        this.estadoCivil=estadoCivil;
        this.ingreso=ingreso;
        this.sueldoB=sueldoB;
        this.cargo=cargo;
    }
    //-----METODOS-----
    public DateTime Antiguedad()
    {
        DateTime resultado,fechaHoy=DateTime.Now;
        int anio,mes,dia;
        anio=fechaHoy.Year-ingreso.Year;
        if(ingreso.Month>fechaHoy.Month)    
        {
            mes=ingreso.Month;
            anio--;
        }else   mes=fechaHoy.Month-ingreso.Month;
  
        if(ingreso.Day>fechaHoy.Day)    mes--;
        dia=fechaHoy.Day-ingreso.Day;
        resultado=new DateTime(anio,mes,dia);

        return resultado;
    }
    public int Edad()
    {
        DateTime fechaHoy=DateTime.Now;
        int edad;
        edad=fechaHoy.Year-fechaNac.Year;
        if(fechaNac.Month>fechaHoy.Month)   edad--;

        return edad;
    }
    public DateTime ParaJubilarse()
    {
        int edad=this.Edad();
        if (65 - edad > 0)
        {
            int anio,mes;
            anio=64-edad;
            mes=ingreso.Month;
            if (mes==0) anio++;

            return (new DateTime(anio,mes,1));
        }else   return (new DateTime(1,1,1));
    }
    public double Salario()
    {
        double adicional;
        //Adicional con respecto a la antiguedad
        DateTime antiguedad=Antiguedad();
        if(antiguedad.Year<20)  adicional = sueldoB * ((double)antiguedad.Year/100);
        else    adicional = sueldoB * 0.25;
        //Adicional con respecto al cargo que ocupa
        Cargo cargo=this.cargo;
        if(cargo==Cargo.Ingeniero || cargo==Cargo.Especialista) adicional=adicional*1.50;    
        //Adicional con respecto a su estado civil
        if(estadoCivil=='c')    adicional=adicional+150000;
        return (sueldoB+adicional);
    }
}

