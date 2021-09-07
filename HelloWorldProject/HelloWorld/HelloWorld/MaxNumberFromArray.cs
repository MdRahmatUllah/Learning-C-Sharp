using System;

namespace CSharpLearning
{
    class MaxNumberFromArray
    {
        public void Main()
        {
            var inp = Console.ReadLine();
            int mx = 0;

            foreach(var num in inp.Split(','))
            {
                if(Convert.ToInt32(num) > mx)
                {
                    mx = Convert.ToInt32(num);
                }
            }

            Console.WriteLine("Max number is {0}", mx);
        }

    }
}
