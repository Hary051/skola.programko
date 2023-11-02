


//double maximum(double x, double y)
//{
//    if (x > y)
//    {
//        return x;
//    }
//    else
//    {
//        return y;
//    }
//}
//double x = 10;
//double y = 10;
//Console.WriteLine(maximum(x, y));

//bool aresame(double x, double y)
//{
//    if (x == y)
//    {
//        return true;
//    }
//    else
//    {
//        return false;
//    }
//}
//Console.WriteLine(aresame(x, y));

int cislooduzivatele()
{
   string cislo= Console.ReadLine();
    int.TryParse(cislo, out int cislo1);
    return cislo1;
}

Console.WriteLine(cislooduzivatele());