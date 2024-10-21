using System;

interface IExpression
{
    double Evaluate();
}

class Number : IExpression
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
