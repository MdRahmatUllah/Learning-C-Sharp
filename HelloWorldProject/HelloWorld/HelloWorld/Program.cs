namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var inp = new inputClass();
            var outp = new outputClass();

            outp.printString("Enter the first Number: ");
            
            int number1;
            number1 = inp.inputInt();
            outp.printString("Enter the second Number: ");

            int number2;
            number2 = inp.inputInt();

            int fl = 0;

            outp.printString("For Add press 1\nFor Substractions 2\nFor Division 3\n" +
                "For Multiplications 4");

            fl = inp.inputInt();

            var myCalc = new Calculator();

            myCalc.number1 = number1;
            myCalc.number2 = number2;

            switch (fl)
            {
                case 1:
                    myCalc.Add();
                    break;
                case 2:
                    myCalc.Substraction();
                    break;
                case 3:
                    myCalc.Multiplications();
                    break;
                case 4:
                    myCalc.Division();
                    break;
                default:
                    outp.printString("Invalid Input");
                    break;
            }
            outp.printOutputString();
        }
    }
}
