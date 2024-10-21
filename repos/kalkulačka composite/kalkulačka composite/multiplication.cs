class Multiplication : IExpression
{
    private IExpression left;
    private IExpression right;

    public Multiplication(IExpression left, IExpression right)
    {
        this.left = left;
        this.right = right;
    }

    public double Evaluate()
    {
        return left.Evaluate() * right.Evaluate();
    }
}
