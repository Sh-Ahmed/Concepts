using System;
using System.Diagnostics;

namespace Concepts.ConceptImplementation
{
    internal class FuncConcept : ConceptBase
    {
        public FuncConcept(string description, bool run) :
            base(description, run)
        {
        }

        delegate int TheSquarer(int x);

        protected override void TestConcept()
        {
            TheSquarer ts = x => x * x;
            int result = ts(5);
            Debug.WriteLine("Result:" + result);

            Func<int> func0 = F0;
            Debug.WriteLine("F0:" + func0());

            Func<int, string> func1 = F1;
            Debug.WriteLine("F1:" + func1(12));

            Func<int, long, string> func2 = F2;
            Debug.WriteLine("F2:" + func2(12, 38));
        }

        private int F0()
        {
            return int.MaxValue;
        }

        private string F1(int v)
        {
            return "Value passed to F1 is: " + v;
        }

        private string F2(int v1, long v2)
        {
            return string.Format("Sum of {0} and {1} is {2}", v1, v2, v1 + v2);
        }
    }
}
