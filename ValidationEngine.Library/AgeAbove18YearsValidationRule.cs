using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Library
{
    public class AgeAbove18YearsValidationRule : ValidationRule
    {
        public AgeAbove18YearsValidationRule(Person[] person):base(person)
        {

        }
        public override List<Person> EvaluateList()
        {
            List<Person> result = new List<Person>();
            foreach(Person p in person)
            {
                if (p.Age>=18)
                {
                    result.Add(p);
                }
            }
            return result;
        }
    }
}
