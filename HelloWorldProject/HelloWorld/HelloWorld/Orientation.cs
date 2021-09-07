using System;
namespace CSharpLearning
{
    class Orientation
    {
        public void Main()
        {
            var inp = new inputClass();

            int width = inp.inputInt();
            int height = inp.inputInt();

            if(width > height)
                Console.WriteLine("Landscape");
            else if(height > width)
                Console.WriteLine("Portrait");
            else
                Console.WriteLine("Invalid size or Squre");
        }
    }
}
