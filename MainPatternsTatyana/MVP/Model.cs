using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVP
{
    class Model
    {
        double op1 = 1;
        double op2 = 1;
        string sign = "+";
        double result = 1;
        int error = 0;
        public void PresenterToModel(double a, double b, string op)
        {
            op1 = a;
            op2 = b;
            sign = op;
        }
        public void CalculationInModel() 
        {
            if ( (!object.Equals(sign,"/") || op2 != 0))
            {
                switch (sign)
                {
                    case "+":
                        result = op1 + op2;
                        break;
                    case "-":
                        result = op1 - op2;
                        break;
                    case "*":
                        result = op1 * op2;
                        break;
                    case "/":
                        result = op1 / op2;
                        break;
                    default:
                        result = 1;
                        break;
                }
                
            }
            else
            {
                error=1;
                result=1;
            }
        }
        public void ModelToPresenter(ref double result1, ref int error1)
        {
            CalculationInModel();
            result1 = result;
            error1 = error;
        }
    }
}
