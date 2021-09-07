using System;

namespace CSharpLearning
{
    public class Calculator
    {


        public int number1;
        public int number2;
        public int res;
        public char sign;

        public void Add()
        {
            res = number1 + number2;
            sign = '+';
        }
        public void Substraction()
        {
            res = number1 - number2;
            sign = '-';
        }
        public void Multiplications()
        {
            res = number1 * number2;
            sign = '*';
        }
        public void Division()
        {
            try
            {
                res = number1 / number2;
                sign = '/';
            }
            catch (Exception ex)
            {
                var outp = new outputClass();
                outp.printString("Exception occur" + ex.Message);
            }
        }
    }
}
