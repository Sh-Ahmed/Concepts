using Concepts.ConceptImplementation;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Concepts
{    
    class Program
    {
        static void Main(string[] args)
        {
            List<IConcept> concepts = new List<IConcept>
            {
                new FuncConcept("Func<T...>", true),
                new RefConcept("ref", true)
            };

            concepts.ForEach(c => c.Run());
        }
    }
}
