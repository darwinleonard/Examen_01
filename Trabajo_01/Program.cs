// See https://aka.ms/new-console-template for more information

string Caso1(int numerovalidar)
{
    string numerovalidado = string.Empty;
    
    if (numerovalidar == 0)
        numerovalidado = "el número ingresado es Cero";
    if (numerovalidar > 0)
        numerovalidado = "el numero ingresado es positivo";
    if (numerovalidar < 0)
        numerovalidado = "el numero ingresado es negativo";

        return numerovalidado;

}

void Caso2()
{
    Console.WriteLine("Ingrese un dia de la semana:");
    string semana1 = Console.ReadLine();
   string semana = semana1.ToLower();
    
    if (semana == "lunes")
        Console.WriteLine("Usted ingreso el dia LUNES");
    else if (semana == "martes")
        Console.WriteLine("Usted ingreso el dia MARTES");
    else if (semana == "miercoles")
        Console.WriteLine("Usted ingreso el dia MIERCOLES");
    else if (semana == "jueves")
        Console.WriteLine("Usted ingreso el dia JUEVES");
    else if (semana == "viernes")
        Console.WriteLine("Usted ingreso el dia VIERNES");
    else if (semana == "sabado")
        Console.WriteLine("Usted ingreso el dia SABADO");
    else if (semana == "domingo")
        Console.WriteLine("Usted ingreso el dia DOMINGO");
    else
        Console.WriteLine("Usted ingreso un dia erroneo: " + semana1);
}

int Caso3()
    {
        System.Console.WriteLine("Suma de números naturales");

        int Suma_numeros = 0;//acumulador
        //int k = 0;

        for (int i = 0; i <= 100; i++)
        {

                Suma_numeros = Suma_numeros + i;
      
        }
        
   
    return Suma_numeros;
   
    }

void Caso4()
{
    System.Console.WriteLine("Suma de números ingresado por el usuario");
    System.Console.WriteLine("Ingrese un número:");
    string numerox = Console.ReadLine();

    //var stringNumber = "123";
    int numeroz;
    bool esnumero = int.TryParse(numerox, out numeroz);

    if (esnumero == true)
    {
        int Suma_numeros = 0;//acumulador
                             //int k = 0;

        for (int i = 0; i <= numeroz; i++)
        {

            Suma_numeros = Suma_numeros + i;

        }
        System.Console.WriteLine("Has ingresados el número: " + numeroz + " , la suma de todos sus números es: " + Suma_numeros);
    }

    else
        System.Console.WriteLine("Has ingresado un valor no numérico...bye");


}

double Caso5(double radiodelcirculo)
{
      
    double area = Math.PI * Math.Pow(radiodelcirculo, 2);
    
    return area;
}


void Caso6()
{

    int Tamañouni = 0;
    Console.WriteLine("INGRESE EL TAMAÑO DEL ARREGO DIMENSIONAL:");
    Tamañouni = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(" ");

    string[] ArregloUni = new string[Tamañouni];

    for (int i = 0; i < Tamañouni; i++)
    {
        
        Console.WriteLine("INGRESE DATO [" + (i+1) + "]: ");
        ArregloUni[i] = Console.ReadLine();

    }
    Console.WriteLine(" ");
    Console.WriteLine("LOS DATOS INGRESADOS SON:");

    for (int i = 0; i < Tamañouni; i++)
    {

        Console.WriteLine("El dato [" + (i + 1) + "] es: ");
        Console.WriteLine(ArregloUni[i]);

    }



}


void Caso7()
{


    List<string> Listax = new List<string>();
    string nombre = string.Empty;

    int Tamañolista = 0;
    Console.WriteLine("INGRESE EL TAMAÑO DEL LA LISTA:");
    Tamañolista = Convert.ToInt32(Console.ReadLine());

 
    for (int i = 0; i < Tamañolista; i++)
    {

        Console.WriteLine("INGRESE DATO [" + (i + 1) + "]: ");
        nombre = Console.ReadLine();
        Listax.Add(nombre);

    }

    Console.WriteLine(" ");
    Console.WriteLine("LOS DATOS INGRESADOS EN LA LISTA SON:");
    Console.WriteLine(" ");

    foreach (var name in Listax)
    {
        Console.WriteLine(name);
    }

}


// MENU DE OPCIONES  SELECCIONAR

bool salir = false;

while (!salir)
{

  
    Console.WriteLine("---------------");
    Console.WriteLine("1. Opción 1");
    Console.WriteLine("2. Opción 2");
    Console.WriteLine("3. Opción 3");
    Console.WriteLine("4. Opción 4");
    Console.WriteLine("5. Opción 5");
    Console.WriteLine("6. Opción 6");
    Console.WriteLine("7. Opción 7");
    Console.WriteLine("8. Salir");
    Console.WriteLine("---------------");
    Console.WriteLine("Ingrese un número según la lista de opciones:");
    int opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("Has elegido la opción 1");
            Console.WriteLine("Ingrese un número para validar:");
            int numerovalidar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Caso1(numerovalidar));
            Console.WriteLine("---------------");
            break;

        case 2:
            Console.WriteLine("Has elegido la opción 2");
            Caso2();
            Console.WriteLine("---------------");
            break;

        case 3:
            Console.WriteLine("Has elegido la opción 3");
            System.Console.WriteLine("El resultado de la suma de los 100 primeros numeros naturales es: " + Caso3());
            Console.WriteLine("---------------");
            break;

        case 4:
            Console.WriteLine("Has elegido la opción 4");
            Caso4();
            Console.WriteLine("---------------");
            break;
        case 5:
            Console.WriteLine("Has elegido la opción 5");
            Console.WriteLine("Cálculo del área de un círculo");
            Console.WriteLine("Ingrese el radio del círculo:");
            double radiodelcirculo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("El área del círculo es: " + Caso5(radiodelcirculo));
            Console.WriteLine("---------------");
            break;
        case 6:
            Console.WriteLine("Has elegido la opción 6");
            Caso6();
            break;
        case 7:
            Caso7();
            break;
        case 8:
            Console.WriteLine("Has elegido salir de la aplicación...bye");
            salir = true;
            break;
        default:
            Console.WriteLine("Por favor, Seleccione una opción entre 1 y 8");
            break;
    }



}



