// See https://aka.ms/new-console-template for more information

int pocitac1;
int pocitac2;
bool success;
bool success1;
string operace;
do
{


    Console.WriteLine("Číslo 1");
    string cislo1 = Console.ReadLine();
    success = int.TryParse(cislo1, out pocitac1);



    Console.WriteLine("Číslo 2");
    string cislo2 = Console.ReadLine();
    success1 = int.TryParse(cislo2, out pocitac2);
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
if(!(operace == "+" || operace == "/" || operace == "*" || operace == "-"))
    {
        Console.WriteLine("Neplatné znaménko");
    }
}
while (!(operace == "+" || operace == "/" || operace == "*" || operace == "-"));



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

