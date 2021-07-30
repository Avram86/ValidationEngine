using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using ValidationEngine.Library;

namespace ValidationEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfPeople = new Person[]
            {
                    new Person { Name="Doe", SurName="John", CNP="1234567896325", Age=15},
                    new Person { Name="Doe", SurName="Jane", CNP="2541369856321", Age=18},
                    new Person { Name="Popescu", SurName="Ion", CNP="3256321456321", Age=25},
                    new Person { Name="Ionescu", SurName="Maria", CNP="8523698523698", Age=16},
                    new Person { Name="Petrescu", SurName="Gigel", CNP="7531264896523", Age=14},
                    new Person { Name="Mateescu", SurName="Viorica", CNP="4215632589652", Age=21},
                    new Person { Name="Radulescu", SurName="Vasile", CNP="3124569852369", Age=50},
                    new Person { Name="Goergescu", SurName="Gratiela", CNP="6523652365236", Age=45}
            };

            //var ruleType = typeof(ValidationRule);

            ////https://stackoverflow.com/questions/5411694/get-all-inherited-classes-of-an-abstract-class/6944605
            //IEnumerable<ValidationRule> rules = (IEnumerable<ValidationRule>)Assembly.GetAssembly(typeof(ValidationRule)).GetTypes()
            //    .Where(p=>p.IsClass && !p.IsAbstract && p.IsSubclassOf(typeof(ValidationRule)));

            //Console.WriteLine($"Please choose a number from 1 to {rules.Count()} accordingly to the rule you want to filter the dataBse with:");
            //int i = 1;
            //foreach(var rule in rules)
            //{
            //    Console.WriteLine($"{i}) {nameof(rule)}");
            //    i++;
            //}

            //string input = Console.ReadLine();


            PersonListProcessor personListProcessor = new PersonListProcessor(null, listOfPeople);
            personListProcessor.Rules = new ValidationRule[]
            {
                new NameAndSurnameCannotBenullRule(listOfPeople),
                new CNPAStringContainingOnlyNumbers(listOfPeople),
                new AgeAbove18YearsValidationRule(listOfPeople)
            };

            personListProcessor.PrintOutcomeForValidatiopnRules();
            Console.WriteLine($"----------------------------------------------------------------------------------------------------------------");


            personListProcessor.Rules = new ValidationRule[]
           {
                new NameAndSurnameCannotBenullRule(listOfPeople),
                new CNPAStringContainingOnlyNumbers(listOfPeople),
                new MaleCNPValidationRule(listOfPeople),
                new AgeBelow18YearsValidationRule(listOfPeople)
           };

            personListProcessor.PrintOutcomeForValidatiopnRules();
        }
    }
}
