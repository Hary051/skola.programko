using System;

internal interface IExpression
{
    double Evaluate();
}

internal class Number : IExpression
{
    private double value;

    public Number(double value)
    {
        this.value = value;
    }

    public double Evaluate()
    {
        return value;
    }
}
