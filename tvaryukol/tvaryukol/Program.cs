
Console.WriteLine("výpočty geometrických obrazců");
Console.WriteLine("pro dvojrozměrné obsah a obvod");
Console.WriteLine("pro trojrozměrné objem a povrch");
Console.WriteLine("všechny hodnoty jsou zadávány v cm");
Console.WriteLine();

string[] tvary = new string[] { "trojúhelník ", "čtverec ", "kruh ", "obdelník ", "pravidelný n-úhelník", "krychle ", "kvádr ", "koule","kužel"};
string znovu;
do
{
    vyber();
    Console.WriteLine("Přejete si skončit?");
    Console.WriteLine("n=konec, pro pokračování jen zmáčkni enter");
    znovu = Console.ReadLine();
}
while (!(znovu=="n"));
void vyber()
{
    Console.WriteLine("vyber tvar, který chceš spočítat");
    Console.WriteLine();

    for (int i = 0; i < tvary.Length; i++)
    {
        Console.WriteLine(i+1 + " = "+ tvary[i]);
    }
    int cislo1;
    do {
        string kterej = Console.ReadLine();
        int.TryParse(kterej, out cislo1);
        if (!(cislo1 < 10 && cislo1 > 0))
        {
            Console.WriteLine("neplatná volba");
        
        }
    } while (!(cislo1 < 10 && cislo1 > 0));
    Console.WriteLine(tvary[cislo1-1]);
    
   
    switch (cislo1)
    {
        case 1:
           trojuhelnik();
        break;
        case 2:
            ctverec();
            break;
        case 3:
            kruh();
            break;
        case 4:
            obdelnik();
            break;
        case 5:
            nuhelnik();
            break;
        case 6:
            krychle();
            break;
        case 7:
            kvadr();
            break;
        case 8:
            koule();
            break;
        case 9:
            kuzel();
            break;
    }

}





double strany(string pismeno)
{
    double delka1;
    string delka;
    bool x;
    bool z;
    do
    {       
        Console.WriteLine("zadej "+pismeno);      
            
        delka = Console.ReadLine();
        x= double.TryParse(delka, out delka1);
        z=delka1 > 0;
        if (!x)
        {
            Console.WriteLine("to není číslo");
        }
        else if (!z)
        {
            Console.WriteLine("neplatná délka strany");
        }
    }
    while (!x||!z);


    return delka1;
}

void vypis2d(double x,double y)
{
    Console.WriteLine("obvod je: " + x+" cm");
    Console.WriteLine("obsah je: " + y+" cm2");

}
void vypis3d(double x, double y)
{
    Console.WriteLine("povrch je: " + x + " cm2");
    Console.WriteLine("objem je: " + y + " cm3");

}

double o;
double s;
//u 2d o=obvod, s=obsah
//u 3d o=povrch, s=objem
void trojuhelnik()
{
    double a;
    double b;
    double c;
    
    bool nerovnost;
    do
    {
        a = strany("a");
        b = strany("b");
        c = strany("c");
        nerovnost = (a + b <= c || a + c <= b || b + c <= a);
        if (nerovnost)
        {
            Console.WriteLine("Neplatí trojúhelníková nerovnost, zadej strany znovu");
        }
    }
    while (nerovnost);

    o = a + b + c;
    
    //heronuv vzorec pro obsah
    double ss = (o) / 2;
    double s = Math.Sqrt(ss * (ss - a) * (ss - b) * (ss - c));
    vypis2d(o, s);

}
void ctverec() 
{
    double a = strany("a");
    o = 4 * a;
    s = a * a;
    vypis2d(o, s);
}

void kruh() 
{
    double polomer = strany("r");
    o = Math.PI * 2 * polomer;
    s = Math.PI * polomer * polomer;

    vypis2d(o, s);
}
void obdelnik()
{
    double a = strany("a");
    double b = strany("b");
    o = 2 * (b + a);
    s = b * a;
    vypis2d(o, s);


}
void nuhelnik() 
{ 
    double a = strany("a");
    double stran = strany("počet stran");
    o = a * stran;

    //c# nenabízí cotangens, tak jsem dal tangens na -1
    double tang=Math.Tan(Math.PI/stran);
    s = a * a * stran / 4 * Math.Pow(tang, -1);
    vypis2d(o, s);
}
void krychle()
{
    double a = strany("a");
    o = 6 * a * a;
    s = a * a * a;
    vypis3d(o, s);
}
void kvadr()
{
   double a = strany("a");
   double b = strany("b");
   double c = strany("c");
    o = 2 * (a * b) + 2 * (a * c) + 2 * (b * c);
    s = a * b * c;
    vypis3d(o, s);
}
void koule() 
{
   double a = strany("r");
    o = 4 * a * a * Math.PI;
    s = Math.PI * a * a * a * 4 / 3;
    vypis3d(o, s);

}
void kuzel() 
{
    double a = strany("výšku");
    double r = strany("r podstavy");
    //plast=od kraje podstavy k vrcholu
    double plast = Math.Sqrt(a * a + r * r);
    o = Math.PI * r * (r + plast);
    s = Math.PI * r * r * a / 3;
    vypis3d(o, s);
}






