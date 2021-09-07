using System;
namespace CSharpLearning
{
    class GuessTheNumber
    {

        public void Main()
        {
            var rand = new Random();
            var theNumber = rand.Next(1, 10);
            bool flag = false;
            for(var i = 0; i < 4; i++)
            {
                int guessedNumber = Convert.ToInt32(Console.ReadLine());

                if(10 < guessedNumber || 1 > guessedNumber)
                {
                    Console.WriteLine("{0} Invalid Guess, please guess between 1 to 10", guessedNumber);
                    i -= 1;
                }

                if(guessedNumber == theNumber)
                {
                    Console.WriteLine("You Won in {0}th try the number is {1}", i + 1, theNumber);
                    flag = true;
                    break;
                }
            }

            if(!flag)
                Console.WriteLine("You lost in every try, the number is {0}", theNumber);
        }

    }
}
