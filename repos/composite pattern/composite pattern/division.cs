using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace expression
{
    internal class Division : BinaryExpression
    {
        public Division(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override double Evaluate()
        {
            return left.Evaluate() / right.Evaluate();
        }

        public override string ToString()
        {
            return $"({left.ToString()} / {right.ToString()})";
        }
    }
}