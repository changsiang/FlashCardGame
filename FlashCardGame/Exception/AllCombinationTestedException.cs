using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashCardGame
{
    class AllCombinationTestedException : Exception
    {
        public AllCombinationTestedException()
        {
        }
        public AllCombinationTestedException(string message): base(message)
        {
        }
        public AllCombinationTestedException(string message, Exception inner): base(message, inner)
        {
        }

    }
}
