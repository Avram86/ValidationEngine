using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Library
{
    public abstract class ValidationRule
    {
        public ValidationRule()
        {
        }
        public Person[] person { get; set; }
        public abstract List<Person> EvaluateList(Person[] person);
    }
}
