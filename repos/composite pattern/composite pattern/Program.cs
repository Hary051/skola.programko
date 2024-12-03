using expression;
using System.Linq.Expressions;


IExpression resultExpression = new ExpressionBuilder(7).Add(14).Divide(new ExpressionBuilder(5).Subtract(1).Subtract(1).Build()).Build();

Console.WriteLine(resultExpression.ToString() + " = " + resultExpression.Evaluate());