// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//detekce prvočísel

string a = Console.ReadLine();
int b=int.Parse(a);
int d = 2;

do
{

    d++;
   

} while (b%d>0);
 if (d == b){
        Console.WriteLine("prvočíslo");
    }
else
{
    Console.WriteLine("není prvočíslo");
}