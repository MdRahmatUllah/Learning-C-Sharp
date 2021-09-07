using System;

namespace CSharpLearning
{
    class NumberValidation
    {
        public void numberValidation()
        {
            var obj = new inputClass();
            int num = obj.inputInt();

            if (num >= 0 && num <= 10)
                Console.WriteLine("Number is valid\n");
            else
                Console.WriteLine("Number in not valid\n");
        }
    }
}
