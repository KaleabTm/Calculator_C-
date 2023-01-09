using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator0
{
    internal class Calc
    {
        public double t;
        public double Op(string opr, double r, double y)
        {
            switch (opr)
            {
                case "+":
                    t = r + y;
                    break;

                case "-":
                    t = r - y;
                    break;

                case "*":
                    t = r * y;
                    break;

                case "/":
                    t = r / y;
                    break;

                case "%":

                    t = r % y;

                    break;
            }
            return t;
        }


        public double Un(double f, string uort)
        {
            switch (uort)
            {
                case "x2":
                    t = f * f;
                    break;

                case "1/x":
                    t = 1 / f;
                    break;

            }
            return t;
        }
    }

}
