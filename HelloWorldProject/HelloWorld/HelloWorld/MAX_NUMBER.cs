using System;
namespace CSharpLearning
{
    public class MAX_NUMBER 
    {
        public void Max()
        {
            var inp = new inputClass();

            while (true)
            {
                int num1 = inp.inputInt();
                int num2 = inp.inputInt();

                if (num1 > num2)
                    Console.WriteLine("Number 1 is Max {0}", num1);
                else if (num1 < num2)
                    Console.WriteLine("Number 2 is Max {0}", num2);
                else
                    Console.WriteLine("Numbers are equal");
            }
        }
    }
}
