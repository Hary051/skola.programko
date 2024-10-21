class Kalkulacka
{
    static void Main(string[] args)
    {
        // Příklad: (2 + 3) * 4
        IExpression vyraz = new Multiplication(new Number(4),
                                new Addition(
                                    new Number(2),
                                    new Number(3)
                                )
                                
                            );

        Console.WriteLine("Výsledek: " + vyraz.Evaluate());

        // Další příklad: 5 * (6 + 7)
        IExpression vyraz2 = new Multiplication(
                                new Number(5),
                                new Addition(
                                    new Number(6),
                                    new Number(7)
                                )
                            );

        Console.WriteLine("Výsledek: " + vyraz2.Evaluate());
    }
}
