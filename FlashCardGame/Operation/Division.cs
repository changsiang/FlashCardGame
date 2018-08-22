using System;
using System.Linq;

namespace FlashCardGame.Operation
{
    class Division : Operator
    {
        public override Tuple<int, int> GenerateQuiz()
        {
            // Division has lesser number of quiz as divide by 0 is an invalid operation.
            _quizCombo.RemoveAll(x => x.Item2 == 0);
            if (_quizCombo.Count == 0) { throw new AllCombinationTestedException("All 155 Combinations\nTested"); }            
            Random rnd = new Random();            
            int index = rnd.Next(0, _quizCombo.Count - 1);
            return _quizCombo.ElementAt(index);
        }        
        public override double PerformCalculation(int digitOne, int digitTwo)
        {
            _quizCombo.Remove(Tuple.Create(digitOne, digitTwo));
            double result = Math.Round(Convert.ToDouble(digitOne) / Convert.ToDouble(digitTwo), 2);            
            return result;
        }
    }
}
