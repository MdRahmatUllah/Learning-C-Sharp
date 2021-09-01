using System;

namespace HelloWorld
{
    public class outputClass
    {
        public int num1;
        public int num2;
        public char sign;
        public int res;

        public void setValue()
        {
            var clc = new Calculator();
            num1 = clc.number1;
            num2 = clc.number2;
            sign = clc.sign;
            res = clc.res;
        }

        public void printOutputString()
        {
            setValue();
            Console.WriteLine(num1 + " " + sign + " " + num2 + " = " + res);
        }

        public void printString(string st)
        {
            Console.WriteLine(st);
        }
    }
}
