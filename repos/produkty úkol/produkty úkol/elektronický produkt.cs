
    public class eprodukt : produkt
    {
    public string Manufacturer;

    public void Zobrazinfo()
    {
        Console.WriteLine("název: " + Name);
        Console.WriteLine("cena: " + Price);
        Console.WriteLine("výrobce: " + Manufacturer);
        //z nějakýho důvodu to nevypisuje výrobce, nerozumim tomu, je to komplet stejný jako autor u knihy
    }
}
