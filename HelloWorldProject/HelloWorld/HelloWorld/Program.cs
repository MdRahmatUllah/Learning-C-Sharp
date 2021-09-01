using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var inp = new inputClass();
            var outp = new outputClass();

            outp.printString("Enter the first Number: ");
            
            int number1;
            number1 = inp.inputInt();
            outp.printString("Enter the second Number: ");

            int number2;
            number2 = inp.inputInt();

            int fl = 0;

            outp.printString("For Add press 1\nFor Substractions 2\nFor Division 3\n" +
                "For Multiplications 4");

            fl = inp.inputInt();

            var myCalc = new Calculator();

            myCalc.number1 = number1;
            myCalc.number2 = number2;

            switch (fl)
            {
                case 1:
                    myCalc.Add();
                    break;
                case 2:
                    myCalc.Substraction();
                    break;
                case 3:
                    myCalc.Multiplications();
                    break;
                case 4:
                    myCalc.Division();
                    break;
                default:
                    outp.printString("Invalid Input");
                    break;
            }
            outp.printOutputString();
        }
    }

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

    public class inputClass
    {
        public int inputInt()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }

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
