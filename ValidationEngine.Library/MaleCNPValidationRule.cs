using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Library
{
    public class MaleCNPValidationRule : ValidationRule
    {
        public MaleCNPValidationRule(Person[] person):base(person)
        {

        }

        public override List<Person> EvaluateList()
        {
            List<Person> result = new List<Person>();

            foreach(Person p in person)
            {
                char startsWith = p.CNP[0];
                switch (startsWith)
                {
                    case '1':
                    case '3':
                    case '5':
                    case '7':
                        result.Add(p);
                        break;

                    default:
                        break;
                }
            }
            return result;
        }

    }
}
