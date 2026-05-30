using Personal;
//Cargado de empleados
Empleado[] empleados = new Empleado[3];
empleados[0]=new Empleado("Juan Cruz","Gomez Corbalan",new DateTime(2003,07,31),'s',new DateTime(2015,02,20),450000.65,Empleado.Cargo.Ingeniero);
empleados[1]=new Empleado("Pedro","Suarez",new DateTime(2000,03,25),'c',new DateTime(2010,09,04),750000.56,Empleado.Cargo.Administrativo);
empleados[2]=new Empleado("Rosa","Ruiz",new DateTime(1995,05,20),'c',new DateTime(2005,10,23),1000000.189,Empleado.Cargo.Investigador);

Empleado aux;
aux=empleados[0];
// Console.WriteLine(DateTime.Compare(aux.ParaJubilarse(),DateTime.Now));

double total=0;

foreach (Empleado empleado in empleados)
{
    if(DateTime.Compare(aux.ParaJubilarse(),empleado.ParaJubilarse())==1)  aux=empleado;

    total=total+empleado.Salario();
}
Console.WriteLine($"MONTO TOTAL EN SALARIOS: ${total}");
Console.WriteLine($"-----EMPLEADO MAS PROXIMO A JUBILARSE CON {aux.ParaJubilarse().Year} ANIOS Y {aux.ParaJubilarse().Month} MESES-----");
Console.WriteLine($"Antiguedad: {aux.Antiguedad().Year} anios , {aux.Antiguedad().Month} meses.");
Console.WriteLine($"Edad: {aux.Edad()}");

