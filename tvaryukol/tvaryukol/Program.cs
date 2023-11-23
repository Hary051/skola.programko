
string[] tvary = new string[] { "trojúhelník ", "čtverec ", "kruh ", "obdelník ", "pětiúhelník ", "krychle ", "kvádr ", "koule" };


int vyber()
{
    
    for (int i = 0; i < tvary.Length; i++)
    {
        Console.WriteLine(i + " = "+ tvary[i]);
    }
    string kterej = Console.ReadLine();
    int.TryParse(kterej, out int cislo1);
    return cislo1;
}
int a=vyber();
Console.WriteLine(a);