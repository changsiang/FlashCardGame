using System;

namespace FlashCardGame.Operation
{
    class OperatorFactory
    {
        public static Operator GetOperator(string arg)
        {
            switch (arg)
            {
                case "+":
                    return new Addition();
                case "-":
                    return new Subtraction();
                case "x":
                    return new Multiplication();
                case "÷":
                    return new Division();
                default:
                    throw new InvalidOperationException("Invalid Mathematical\nOperation");
            }
        }
    }
}
