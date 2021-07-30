using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Library
{
    public class SearchEngine
    {
        public SearchEngine(Person[] people, ValidationRule[] rules=null )
        {
            this.Rules = rules ;
            this.People = people;
        }
        public ValidationRule[] Rules { get; set; }
        public Person[] People { get; set; }

        List<Person> result = new List<Person>();
        public Person[] AfterValidation() 
        {
            List<Person> result = People.ToList();

            foreach(ValidationRule rule in Rules)
            {
                result=rule.EvaluateList(result.ToArray());
            }

            return result.ToArray();
        }

    }
}
