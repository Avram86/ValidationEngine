using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Library
{
    public class AgeBelow18YearsValidationRule : ValidationRule
    {
        public AgeBelow18YearsValidationRule()
        {

        }
        public override List<Person> EvaluateList(Person[] person)
        {
            List<Person> result = new List<Person>();
            foreach(Person p in person)
            {
                if (p.Age>=0 && p.Age<18)
                {
                    result.Add(p);
                }
            }
            return result;
        }
    }
}
