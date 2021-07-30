using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Library
{
    public class CNPAStringContainingOnlyNumbers : ValidationRule
    {
        public CNPAStringContainingOnlyNumbers(Person[] person):base(person)
        {
        }

        public  bool IsValid(Person p)
        {
            bool isValid = true;


            foreach (char digit in p.CNP)
            {
                if (char.IsDigit(digit))
                {
                    isValid=true;
                }
                else
                {
                    isValid = false;
                    break;
                }
            }
            return isValid;
        }

        public override List<Person> EvaluateList()
        {
            List<Person> result = new List<Person>();
            foreach(Person p in person)
            {
                if(IsValid(p))
                {
                    result.Add(p);
                }
            }
            return result;
        }
    }
}
