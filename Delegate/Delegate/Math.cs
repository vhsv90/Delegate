namespace Delegate
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Math
    {

        public delegate void PointToMathsOperation(int numberOne, int numberTwo);

        PointToMathsOperation pointToMathsOperation = null;

        public PointToMathsOperation Operation(string operationName)
        {
            switch (operationName.ToLower())
            {
                case "add":
                    pointToMathsOperation = Add;
                    return pointToMathsOperation;
                case "sub":
                    pointToMathsOperation = Sub;
                    return pointToMathsOperation;
                case "div":
                    pointToMathsOperation = Mul;
                    return pointToMathsOperation;
                case "mul":
                    pointToMathsOperation = Div;
                    return pointToMathsOperation;
            }
            return pointToMathsOperation;
        }

        private void Add(int numberOne, int numberTwo)
        {
            Console.WriteLine((numberOne + numberTwo).ToString());
        }
        private void Sub(int numberOne, int numberTwo)
        {
            Console.WriteLine((numberOne - numberTwo).ToString());
        }
        private void Div(int numberOne, int numberTwo)
        {
            Console.WriteLine((numberOne / numberTwo).ToString());
        }
        private void Mul(int numberOne, int numberTwo)
        {
            Console.WriteLine((numberOne * numberTwo).ToString());
        }

    }

}
