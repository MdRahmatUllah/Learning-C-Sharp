using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*byte b = 1;
            int i = b;
            Console.WriteLine(i);*/

            /*int i = 1;
            byte b = (byte)i;
            Console.WriteLine(b);*/

            /*int i = 1000;
            byte b = (byte)i;
            Console.WriteLine(b);*/

            string number = "1234";
            try
            {
                int i = Convert.ToInt32(number);
                Console.WriteLine(i);
                byte b = Convert.ToByte(number);
                Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted");
            }
        }
    }
}
