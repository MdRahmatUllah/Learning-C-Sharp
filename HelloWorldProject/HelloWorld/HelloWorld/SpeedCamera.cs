using System;

namespace CSharpLearning
{
    class SpeedCamera
    {

        

        public void Main()
        {

            var inp = new inputClass();

            while (true)
            {
                Console.WriteLine("What is the speed limit? ");
                var lim = inp.inputInt();
                var speed = inp.inputInt();

                if (lim >= speed)
                    Console.WriteLine("Ok");
                else
                {
                    var dem = (speed - lim) / 5;

                    if (dem > 12)
                        Console.WriteLine("Suspended");
                    else
                        Console.WriteLine("Speed limit crossed {0}", dem);
                }
            }
        }
    }
}
