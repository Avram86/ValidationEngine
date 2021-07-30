using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Library
{
    public class NameAndSurnameCannotBenullRule : ValidationRule
    {
        public NameAndSurnameCannotBenullRule()
        {
        }
        public override List<Person> EvaluateList(Person[] person)
        {
            List<Person> people = new List<Person>();

            foreach(Person p in person)
            {
                if(p.Name!=null || p.SurName!=null)
                {
                    people.Add(p);
                }
            }

            return people;
        }

        
    }
}
