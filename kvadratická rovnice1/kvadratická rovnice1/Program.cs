
using System.ComponentModel.Design.Serialization;

Console.WriteLine("řešení kvadratické rovnice");
double koeficienty(string koef)
{
    while (true)
    {
    Console.WriteLine("Zadej koeficient "+koef);
    string cislo =Console.ReadLine();
    double.TryParse(cislo, out double cislo1);
        if (double.TryParse(cislo, out cislo1))
        {
        return cislo1;
        }
        else
        {
        Console.WriteLine("toto není číslo");
        }
        

    }
    
}

double a = koeficienty("a");
double b = koeficienty("b");
double c = koeficienty("c");


reseni();

void reseni()
{
    Console.WriteLine(a+"x2+" + b+"x+" + c); 
    double diskriminant= b * b - 4 * a * c;
    if (diskriminant > 0)
    {
     double root1 = (-b + Math.Sqrt(diskriminant)) / (2 * a);
     double root2 = (-b - Math.Sqrt(diskriminant)) / (2 * a);
    Console.WriteLine("kvadratická rovnice má 2 kořeny " + root1 + " a "+root2);
            ;
        }
    else if(diskriminant==0)
        {
        double root3 = -b / (2 * a);
        Console.WriteLine("kvadratická rovnice má 1 kořen " + root3);

        }
        else
        {
         Console.WriteLine("kvadratická rovnice nemá řešeni");

        
    }
}

pokracovat();
void pokracovat()
{
    while (true) { 
    Console.WriteLine("Chcete dosadit něco za x? a=ano, n=ne");
    string pokr = Console.ReadLine();
    

    if (pokr == "a")
    {
        pocitanix();
            
    }
    else if (pokr == "n")
    {
            break;
        }
    }
}

void pocitanix()
{
    double x = koeficienty("x");
    Console.Write(a+"x2+"+b+"x+"+c+"=");
    double vypocetx =a*x*x+b*x+c;
    Console.WriteLine(vypocetx + "=");
}

    
