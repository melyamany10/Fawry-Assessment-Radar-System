using System;
using System.Collections.Generic;
using System.Text;

namespace Fawry_Assessment.Classes
{
    public class Violations
    {
        public string Violations_Description { get; set; }
        public int Fine_Value { get; set; }

        public Violations(string description, int amount) 
        {
            Violations_Description = description;
            Fine_Value = amount;
        }
    }
}
