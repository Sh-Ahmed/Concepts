using System.Diagnostics;

namespace Concepts
{
    internal abstract class ConceptBase : IConcept
    {
        private readonly bool _run;
        public ConceptBase(string description) :
            this(description, true)
        {                        
        }

        public ConceptBase(string description, bool run)
        {
            Description = description;
            _run = run;
        }


        public string Description
        {
            get;
            private set;
        }

        public void Run()
        {
            if (_run)
            {
                Debug.WriteLine(string.Format("Running '{0}' ...", Description));
                TestConcept();
                Debug.WriteLine(string.Format("-|- {0} -|-", Description));
            }
        }

        protected abstract void TestConcept();
    }
}
