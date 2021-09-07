using System;

namespace CSharpLearning
{
    class DivisibleBy3
    {
        public void Main()
        {
            var cu = 0;

            for (var i = 3; i <= 100; i+=3)
            {
                if (0 == i % 3) cu++;
            }
            Console.WriteLine("Divisible numbers from 1 to 100 is {0}", cu);
        }
    }
}
