using System;
namespace CSharpLearning
{
    class Factorials
    {
        public int Fact(int num)
        {
            var ans = 1;

            while(Convert.ToBoolean(num))
            {
                ans *= num;
                num -= 1;
            }
            return ans;
        }

        public void Main()
        {
            var num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Factorial of {0} is {1}", num, Fact(num));
        }
    }
}
