using System;

namespace FlashCardGame.Operation
{
    class Multiplication : Operator
    {
        public override double PerformCalculation(int digitOne, int digitTwo)
        {
            _quizCombo.Remove(Tuple.Create(digitOne, digitTwo));
            double result = digitOne * digitTwo;
            return result;
        }
    }
}
