using System;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter two number:");
            var numberOneString = Console.ReadLine();
            var numberTwoString = Console.ReadLine();
            Console.WriteLine("Please enter operation to perform like add,mul,sub and div :-");
            var choice = Console.ReadLine();
            int numberOne, numberTwo;
            Math math = new Math();
            int.TryParse(numberOneString, out numberOne);
            int.TryParse(numberTwoString, out numberTwo);
            math.Operation(choice).Invoke(numberOne, numberTwo);
            Console.ReadLine();

        }
    }
}
