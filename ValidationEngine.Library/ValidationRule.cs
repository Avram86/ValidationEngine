using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Library
{
    public abstract class ValidationRule
    {
        public ValidationRule(Person[] p)
        {
            person = p;
        }
        public Person[] person { get; }
        public abstract List<Person> EvaluateList();
    }
}
