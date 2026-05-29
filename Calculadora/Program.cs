//-----PUNTO 1-----
    using EspacioCalculadora;
    string respuesta,operacion;
    double num=0;
    Calculadora miCalc=new Calculadora();
    do
    {
        //Ingreso de la operacion
        do
        {
            Console.WriteLine("Que operacion desea hacer?");
            Console.WriteLine("1:Suma");
            Console.WriteLine("2:Resta");
            Console.WriteLine("3:Multiplicacion");
            Console.WriteLine("4:Division");
            Console.WriteLine("5:Limpiar");
            operacion=Console.ReadLine();
        }while(!operacion.Equals("1") && !operacion.Equals("2") && !operacion.Equals("3") && !operacion.Equals("4") && !operacion.Equals("5"));
    //Ingreso del numero
        if (!operacion.Equals("5"))
        {
            do
            {
                Console.WriteLine("Ingrese el numero a operar");
                respuesta=Console.ReadLine();
            }while(!double.TryParse(respuesta,out num));
        }
        switch(operacion)
        {
            case "1":
                miCalc.sumar(num);
            break;
            case "2":
                miCalc.restar(num);
            break;
            case "3":
                miCalc.multiplicar(num);
            break;
            case "4":
                miCalc.dividir(num);
            break;
            case "5":
                miCalc.limpiar();
            break;
        }
        Console.WriteLine($"Resultado:{miCalc.Resultado}");
        Console.WriteLine("Desea seguir operando?  1:Si");
        respuesta=Console.ReadLine();

    }while(respuesta.Equals("1"));
    
//-----PUNTO 2-----