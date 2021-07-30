using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Library
{
    public class FemaleCNPValidationRule : ValidationRule
    {
        public FemaleCNPValidationRule()
        {

        }
        public override List<Person> EvaluateList(Person[] person)
        {
            List<Person> result = new List<Person>();

            foreach(Person p in person)
            {
                int startsWith = p.CNP[0];
                switch (startsWith)
                {
                    case 2:
                    case 4:
                    case 6:
                    case 8:
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
