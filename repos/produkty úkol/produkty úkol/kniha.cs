
public class kniha : produkt
{
    public string Author;

    public void Zobrazinfo()
    {
        Console.WriteLine("název: " + Name);
        Console.WriteLine("cena: " + Price);
        Console.WriteLine("autor: " + Author);
    }
}
