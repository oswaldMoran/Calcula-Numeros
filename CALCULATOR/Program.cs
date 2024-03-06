// See https://aka.ms/new-console-template for more information
string respuesta;
do
{
    Console.WriteLine("--------------Calculadora-------------");
    Console.WriteLine("Elije una opcion del menú:");
    Console.WriteLine("1.- -----Suma");
    Console.WriteLine("2.- -----Resta");
    Console.WriteLine("3.- -----Multiplicacion");
    Console.WriteLine("4.- -----Division\n");
    bool respUser = false;
    int menuUsuario = 0;
    while (!respUser)
    {
        string menu = Console.ReadLine();
        respUser = int.TryParse(menu, out menuUsuario);
        if (!respUser)
        {
            Console.WriteLine("Elige una opcion valida en el menú\n");
        }
    }


    switch (menuUsuario)
    {
        case 1:
            MethodSuma();
            break;

        case 2:
            MethodResta();
            break;

        case 3:
            MethodMulti();
            break;

        case 4:
            MethodDiv();
            break;


        default:
            Console.WriteLine("La opcion no se encuntra en el menú");
            break;
    }
    Console.WriteLine("deseas intentarlo de nuevo?");
    respuesta = Console.ReadLine();
} while (respuesta != "no".ToLower());


















void MethodSuma()
{
    Console.WriteLine("---------- SUMA ----------");
    int n1 = 0;
    bool result1 = false;
    while (!result1)
    {
        Console.WriteLine("Escribe el 1er numero");
        string num1 = Console.ReadLine();
        result1 = int.TryParse(num1, out n1);
        if (!result1)
        {
            Console.WriteLine("El caracter no es valido");
        }
    }

    int n2 = 0;
    bool result2 = false;
    while (!result2)
    {
        Console.WriteLine("Escribe el 2do numero");
        string num2 = Console.ReadLine();
        result2 = int.TryParse(num2, out n2);
        if (!result2)
        {
            Console.WriteLine("El caracter no es valido");
        }
    }

    int suma = n1 + n2;
    Console.WriteLine($"El resultado de tu suma es:{suma}\n");
}

void MethodResta()
{
    Console.WriteLine("--------- RESTA ---------\n");
    int rest1 = 0;
    bool resta1 = false;
    while (!resta1)
    {
        Console.WriteLine("Teclea el 1er numero");
        string rest = Console.ReadLine();
        resta1 = int.TryParse(rest, out rest1);
        if (!resta1)
        {
            Console.WriteLine("El caracter no es valido");
        }
    }

    int rest2 = 0;
    bool resta2 = false;
    while (!resta2)
    {
        Console.WriteLine("Teclea el 2do numero");
        string res2 = Console.ReadLine();
        resta2 = int.TryParse(res2, out rest2);
        if (!resta2)
        {
            Console.WriteLine("El caracter no es valido, intenta de nuevo");
        }
    }

    int resultRest = rest1 - rest2;
    Console.WriteLine($"El resultado de tu resta es:{resultRest}\n");


}

void MethodMulti()
{
    Console.WriteLine("---------- Multiplicacion ---------- \n");
    int numb = 0;
    bool restMulti = false;
    while (!restMulti)
    {
        Console.WriteLine("Agrega el 1er numero:");
        string numbr1 = Console.ReadLine();
        restMulti = int.TryParse(numbr1, out numb);
        if (!restMulti)
        {
            Console.WriteLine("El caracter no es valido, intenta de nuevo");
        }
    }

    int numb2 = 0;
    bool restMulti2 = false;
    while (!restMulti2)
    {
        Console.WriteLine("Agrega el 2do numero:");
        string numbr2 = Console.ReadLine();
        restMulti2 = int.TryParse(numbr2, out numb2);
        if (!restMulti2)
        {
            Console.WriteLine("El caracter no es valido, intenta otra vez");
        }

    }

    int resultMulti = numb * numb2;
    Console.WriteLine($"El resultado de tu Multiplicacion es:{resultMulti}");

}

void MethodDiv()
{
    Console.WriteLine("---------- DIVISION ---------- \n");
    int nro1 = 0;
    bool numero1 = false;
    while (!numero1)
    {
        Console.WriteLine("Ingresa el numero a dividir:");
        string nmro = Console.ReadLine();
        numero1 = int.TryParse(nmro, out nro1);
        if (!numero1)
        {
            Console.WriteLine("El caracter no es valido, intenta otra vez");
        }
    }
    bool numero2 = false;
    int nro2 = 0;
    while (!numero2)
    {
        Console.WriteLine("Entre que numero quieres dividirlo?");
        string nmro2 = Console.ReadLine();
        numero2 = int.TryParse(nmro2, out nro2);
        if (!numero2)
        {
            Console.WriteLine("El caracter no es valido, intenta otra vez");
        }

        int resultMulti = nro1 / nro2;
        Console.WriteLine($"El resultado de tu Division es:{resultMulti}");
    }
}