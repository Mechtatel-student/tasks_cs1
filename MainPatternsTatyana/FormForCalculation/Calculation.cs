using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormForCalculation
{
    class Calculation
    {
        public string ImplementOperation(string a, string b, string op)
        {
            double op1 = 1, op2 = 1;
            double r = 1;
            bool isCorrect = true;
            string result = "";
            isCorrect = double.TryParse(a, out op1) &&
                 double.TryParse(b, out op2);

            if (isCorrect && (!object.Equals(op, "/") || op2 != 0))
            {
                switch (op)
                {
                    case "+":
                        r = op1 + op2;
                        break;
                    case "-":
                        r = op1 - op2;
                        break;
                    case "*":
                        r = op1 * op2;
                        break;
                    case "/":
                        r = op1 / op2;
                        break;
                    default:
                        r = 1;  
                        break;
                }
                result = r.ToString();
            }
            else
            {
                if (!isCorrect)
                {
                    result += "некорректные аргументы";
                }
                if (object.Equals(op, "/") && op2 == 0)
                {
                    result += "деление на 0";
                }
            }

            return result;
        }
    }
}
