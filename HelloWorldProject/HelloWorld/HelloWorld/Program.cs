using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first Number: ");
            int number1;
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second Number: ");
            int number2;
            number2 = Convert.ToInt32(Console.ReadLine());

            int fl = 0;

            Console.WriteLine("For Add press 1\nFor Substractions 2\nFor Division 3\n" +
                "For Multiplications 4");

            fl = Convert.ToInt32(Console.ReadLine());

            Calculator myCalc = new Calculator();

            if(fl == 1)
            {
                Console.WriteLine(number1 + " + " + number2 + " = " 
                    + myCalc.Add(number1, number2));
            }

            if (fl == 2)
            {
                Console.WriteLine(number1 + " - " + number2 + " = "
                    + myCalc.Substraction(number1, number2));
            }

            if (fl == 3)
            {
                Console.WriteLine(number1 + " / " + number2 + " = "
                    + myCalc.Division(number1, number2));
            }

            if (fl == 4)
            {
                Console.WriteLine(number1 + " * " + number2 + " = "
                    + myCalc.Multiplications(number1, number2));
            }

        }
    }

    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Substraction(int a, int b)
        {
            return a - b;
        }
        public int Multiplications(int a, int b)
        {
            return a * b;
        }
        public int Division(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occur" + ex.Message);
            }

            return 0;
        }
    }
}
