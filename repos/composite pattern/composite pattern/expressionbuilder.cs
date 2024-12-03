using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace expression
{
    public class ExpressionBuilder
    {
        private IExpression expression;

        public ExpressionBuilder(double num)
        {
            expression = new Number(num);
        }


        public ExpressionBuilder Add(double num)
        {
            var exp = new Number(num);
            return Add(exp);
        }

        public ExpressionBuilder Add(IExpression exp)
        {
            var newResult = new Addition(expression, exp);
            expression = newResult;

            return this;
        }

        public ExpressionBuilder Subtract(double num)
        {
            var exp = new Number(num);
            return Subtract(exp);
        }

        public ExpressionBuilder Subtract(IExpression exp)
        {
            expression = new Subtraction(expression, exp);
            return this;
        }

        public ExpressionBuilder Multiply(double num)
        {
            var exp = new Number(num);
            return Multiply(exp);
        }

        public ExpressionBuilder Multiply(IExpression exp)
        {
            expression = new Multiplication(expression, exp);
            return this;
        }

        public ExpressionBuilder Divide(double num)
        {
            var exp = new Number(num);
            return Divide(exp);
        }

        public ExpressionBuilder Divide(IExpression exp)
        {
            expression = new Division(expression, exp);
            return this;
        }

        public IExpression Build()
        {
            return expression;
        }
    }
}