using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task4
{
    public class HPerson
    {
        
            public string Name { get; set; }
            public int Age { get; set; }
            public string NationalId { get; set; }

            public HPerson(string name, int age, string nationalId)
            {
                Name = name;
                Age = age;
                NationalId = nationalId;
            }

            public virtual string GetDetails()
            {
                return $"Name: {Name}\n Age: {Age}\n National Code: {NationalId}";
            }
        }
    }

