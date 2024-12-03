using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace expression
{
    internal class Number : IExpression
    {
        private double value { get; set; }

        public Number(double value)
        {
            this.value = value;
        }

        public double Evaluate()
        {
            return value;
        }

        public string ToString()
        {
            return value.ToString();
        }
    }
}