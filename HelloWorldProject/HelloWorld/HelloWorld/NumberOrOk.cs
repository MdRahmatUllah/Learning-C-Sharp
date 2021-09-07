using System;
namespace CSharpLearning
{
    class NumberOrOk
    {
        public void Main()
        {
            var sum = 0;
            while(true)
            {
                var inp = Console.ReadLine();

                if ("ok" == inp) break;

                sum += Convert.ToInt32(inp);
            }

            Console.WriteLine("The Sum is {0}", sum);
        }
    }
}
