using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expression
{
    internal class Subtraction : BinaryExpression
    {
        public Subtraction(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override double Evaluate()
        {
            return left.Evaluate() - right.Evaluate();
        }

        public override string ToString()
        {
            return $"({left.ToString()} - {right.ToString()})";
        }
    }
}