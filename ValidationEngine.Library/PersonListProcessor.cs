using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Library
{
    public class PersonListProcessor: SearchEngine
    {
        public PersonListProcessor(Person[] people, ValidationRule[] rules):base(people, rules)
        {
        }
        public void PrintOutcomeForValidatiopnRules()
        {
            SearchEngine engine = new SearchEngine(People ,Rules);

            Person[] result = engine.AfterValidation();

            foreach(Person p in result)
            {
                Console.WriteLine($"Name: {p.Name} {p.SurName} {p.CNP} {p.Age}");
            }
        }
    }
}
