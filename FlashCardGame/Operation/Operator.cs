using System;
using System.Collections.Generic;
using System.Linq;

namespace FlashCardGame.Operation
{
    abstract class Operator
    {
        public static int minNumber = 0;
        public static int maxNumber = 13;
        public readonly List<Tuple<int, int>> _quizCombo;

        public Operator()
        {
            _quizCombo = InitializeList();

        }
        public abstract double PerformCalculation(int digitOne, int digitTwo);
        public virtual Tuple<int, int> GenerateQuiz()
        {
            if (_quizCombo.Count == 0) { throw new AllCombinationTestedException("All 169 Combinations\nTested"); }
            Random rnd = new Random();
            int index = rnd.Next(0, _quizCombo.Count - 1);
            return _quizCombo.ElementAt(index);
        }
        public List<Tuple<int, int>> InitializeList()
        {
            List<Tuple<int, int>> quizCombo = new List<Tuple<int, int>>();
            for (int i = 0; i < 13; i++)
            {                
                for (int j = 0; j < 13; j++)
                {
                    quizCombo.Add(Tuple.Create(i, j));
                }
            }
            return quizCombo;
        }
    }
}
