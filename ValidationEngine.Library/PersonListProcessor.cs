using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Library
{
    public class PersonListProcessor: SearchEngine
    {
        public PersonListProcessor(ValidationRule[] rules, Person[] people):base(rules)
        {
            People = people ?? new Person[0];
        }
        public Person[] People { get; set; }

        public void PrintOutcomeForValidatiopnRules()
        {
            SearchEngine engine = new SearchEngine(Rules);

            Person[] result = engine.AfterValidation();

            foreach(Person p in result)
            {
                Console.WriteLine($"Name: {p.Name} {p.SurName} {p.CNP} {p.Age}");
            }
        }
    }
}
