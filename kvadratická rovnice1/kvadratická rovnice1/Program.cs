using System.ComponentModel.Design.Serialization;

Console.WriteLine("Ovládání:");
Console.WriteLine("vypisuješ čísla, která po tobě program požaduje");
Console.WriteLine("Pokud místo koeicientu zadáš stop, dostaneš se na konec programu");
Console.WriteLine("Když dojedeš na konec, program se zeptá, jestli chceš skončit, zadáním písmena a skončíš, cokoliv jiného je pokračování");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();


while (true)
{


Console.WriteLine("řešení kvadratické rovnice");
double koeficienty(string koef)
{
    while (true)
    {
        Console.WriteLine("Zadej koeficient " + koef);
        string cislo = Console.ReadLine();
        double.TryParse(cislo, out double cislo1);
        if (cislo == "stop")
        {
            return 198765498;
            //tohle tady je kvuli tomu, že jsem to chtěl dělat ve funkcich a tady ta mi
            //vyhazuje double, takze nejde, aby byl vystup string. Neprisel jsem na to,
            //jak bych to jinak udělal s tim, že tady necham funkci double. Tohle funguje,
            //jen nikdo nesmí zadat to dlouhý číslo, což by u náhodnýho uživatele bylo de
            //facto vyloučený. Vim, že by to určitě šlo bez funkcí, ale chtěl jsem to zkusit
            //přes ně, taky kvůli tomu, že v nich mam dost mezery. Roli taky hraje to, že mě
            //trochu tlačí čas.
        }
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
    while (true) { 
double a = koeficienty("a");
    if (a == 198765498)
    {
        break;
    }

    double b = koeficienty("b");
    if (b == 198765498)
    {
        break;
    }

    double c = koeficienty("c");
    if (c == 198765498)
    {
        break;
    }


reseni();

void reseni()
{
    Console.WriteLine(a + "x2+" + b + "x+" + c+"=0");
    double diskriminant = b * b - 4 * a * c;
    if (diskriminant > 0)
    {
        double root1 = (-b + Math.Sqrt(diskriminant)) / (2 * a);
        double root2 = (-b - Math.Sqrt(diskriminant)) / (2 * a);
        Console.WriteLine("kvadratická rovnice má 2 kořeny " + root1 + " a " + root2);
        ;
    }
    else if (diskriminant == 0)
    {
        double root3 = -b / (2 * a);
        Console.WriteLine("kvadratická rovnice má 1 kořen " + root3);

    }
    else
    {
        Console.WriteLine("kvadratická rovnice nemá řešeni");


    }
}

    Console.WriteLine("zadej koeficient pro dopočítání rovnice");
    
    double x = koeficienty("x");
    if (x == 198765498)
        {
            break;
        }
    Console.Write(a +"*"+x + "*"+x+"+"+b + "*" +x +"+"+ c + "=");
    double vypocetx = a * x * x + b * x + c;
    Console.WriteLine(vypocetx);
        break;
       
    
    } 
    Console.WriteLine("přejete si skončit? a=ano");
    string konec = Console.ReadLine();
        if (konec == "a")
        {
          Console.WriteLine("konec programu"); 
          break;
        

    }
}

