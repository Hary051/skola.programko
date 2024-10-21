class Addition : IExpression
{
    private IExpression left;
    private IExpression right;

    public Addition(IExpression left, IExpression right)
    {
        this.left = left;
        this.right = right;
    }

    public double Evaluate()
    {
        return left.Evaluate() + right.Evaluate();
    }
}
