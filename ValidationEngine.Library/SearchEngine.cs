using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidationEngine.Library
{
    public class SearchEngine
    {
        public SearchEngine(ValidationRule[] rules=null)
        {
            this.Rules = rules ;
        }
        public ValidationRule[] Rules { get; set; }

        List<Person> result = new List<Person>();
        public Person[] AfterValidation() 
        {
            List<Person> result = new List<Person>();

            foreach(ValidationRule rule in Rules)
            {
                result=rule.EvaluateList();
            }

            return result.ToArray();
        }

    }
}
