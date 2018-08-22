using System;

namespace FlashCardGame.Operation
{
    class Subtraction : Operator
    {
        public override double PerformCalculation(int digitOne, int digitTwo)
        {
            _quizCombo.Remove(Tuple.Create(digitOne, digitTwo));
            double result = digitOne - digitTwo;
            return result;
        }
    }
}
