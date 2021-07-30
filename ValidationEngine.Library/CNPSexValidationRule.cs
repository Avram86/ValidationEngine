using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Library
{
    public class CNPSexValidationRule : ValidationRule
    {
        public CNPSexValidationRule(Person[] person):base(person)
        {

        }

        public override List<Person> EvaluateList()
        {
            List<Person> result = new List<Person>();
            foreach(Person p in person)
            {
                if (p.CNP is null)
                {
                    result=null;
                }

                int startsWith = p.CNP[0];
                switch (startsWith)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                        result.Add(p);
                        break;


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
