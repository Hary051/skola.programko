Console.WriteLine("vydělávej peníze!");
Console.WriteLine("na začátek máš 10 volných toček");
Console.WriteLine("pro zatočení jen stiskni enter");
Console.WriteLine("vklad=1");
Console.WriteLine("výběr=2");
Console.WriteLine("výše sázky=3, automaticky je výše 1");


int konto = 10;
int vysesazk = 1;
while (konto > 0)
{
    string akce = Console.ReadLine();
    
    switch (akce)
    {
        case "1":
            vklad();
            break;
        case "2":
            vyber();
            break;
        case "3":
            vysesazky();
            break;
        default:
            roztoc();
            break;
    }

    void vklad()
    {
        Console.WriteLine("kolik chceš vložit?");
        int vlozeno;
        bool x;
        do
        {
            string kolik = Console.ReadLine();
            x = int.TryParse(kolik, out vlozeno);
            if (!x)
            {
                Console.WriteLine("neplatná volba");

            }
        } while (!x);
        konto = konto + vlozeno;
        Console.WriteLine("aktuální stav konta je: " + konto);
    }
    void vyber()
    {
        Console.WriteLine("kolik chceš vybrat?");
        int vybrano;
        bool x;
        do
        {
            string kolik = Console.ReadLine();
            x = int.TryParse(kolik, out vybrano);
            if (!x)
            {
                Console.WriteLine("neplatná volba");

            }
        } while (!x);
        konto = konto - vybrano;
        Console.WriteLine("aktuální stav konta je: " + konto);

    }
    void vysesazky()
    {
        Console.WriteLine("nastav výši sázky?");
        int vyse;
        bool x;
        do
        {
            string kolik = Console.ReadLine();
            x = int.TryParse(kolik, out vyse);
            if (!x)
            {
                Console.WriteLine("neplatná volba");

            }
        } while (!x);
        vysesazk = vyse;
        Console.WriteLine("výše sázky je: " + vyse);


    }
    void roztoc()
    {
        konto = konto - vysesazk;
        Console.WriteLine("stav konta:" + konto);
        Console.WriteLine("sázka:" + vysesazk);
        Console.WriteLine();

        Random rnd = new Random();
        int ovoce1 = rnd.Next(1, 9);
        int ovoce2 = rnd.Next(1, 9);
        int ovoce3 = rnd.Next(1, 9);
        Console.WriteLine(ovoce1 + " " + ovoce2 + " " + ovoce3);
        if (ovoce1 == ovoce2 && ovoce2 == ovoce3)
        {
            Console.WriteLine("Jackpot!!!!!");
            Console.WriteLine("výhra: " + 50 * vysesazk);
            konto = konto + 50 * vysesazk;
        }
        else if (ovoce1 == ovoce2 || ovoce1 == ovoce3 || ovoce3 == ovoce2)
        {
            Console.WriteLine("výhra: " + 5 * vysesazk);
            konto = konto + 5 * vysesazk;
        }
    }
}
