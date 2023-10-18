// See https://aka.ms/new-console-template for more information

double pocitac1;
double pocitac2;
bool success;
bool success1;
string operace;
bool x;
Console.WriteLine("+ součet");
Console.WriteLine("- rozdíl");
Console.WriteLine("* součin");
Console.WriteLine("/ podíl");
Console.WriteLine("m mocnina  1. číslo se umocní 2. ");
Console.WriteLine("o odmocnina  1. číslo se odmocní 2. \n");
do
{


    do
    {


        Console.WriteLine("Číslo 1");
        string cislo1 = Console.ReadLine();
        success = double.TryParse(cislo1, out pocitac1);



        Console.WriteLine("Číslo 2");
        string cislo2 = Console.ReadLine();
        success1 = double.TryParse(cislo2, out pocitac2);
        if (success1 == false || success == false)
        {
            Console.WriteLine("špatné číslo");

        }

    }
    while (!success || !success1);



do
{
Console.WriteLine("Zvol Operaci");

 operace = Console.ReadLine();
if(!(operace == "+" || operace == "/" || operace == "*" || operace == "-" || operace == "m" || operace == "o"))
    {
        Console.WriteLine("Neplatné znaménko");
    }
    x = (operace == "o" || operace == "/")&&pocitac2 == 0;
    if (x==true)
    {
        Console.WriteLine("Nulou nelze dělit");

    }
}
while (!(operace == "+" || operace == "/" || operace == "*" || operace == "-" || operace == "m" || operace == "o"));
}
while (x==true) ;


if (operace == "+")
    {
        Console.WriteLine(pocitac1 + pocitac2);
    }
else if (operace == "-")
    {
        Console.WriteLine(pocitac1 - pocitac2);
    }
else if (operace == "*")
    {
        Console.WriteLine(pocitac1 * pocitac2);
    }
else if (operace == "/")
    {
        Console.WriteLine(pocitac1 / pocitac2);
    }
else if (operace == "m")
    {
    Console.WriteLine(Math.Pow(pocitac1, pocitac2));
    }
else if(operace == "o")
    {
    Console.WriteLine(Math.Pow(pocitac1,1/pocitac2));

    }
