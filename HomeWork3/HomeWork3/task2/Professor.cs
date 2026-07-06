using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.task2
{
    public class Professor : Person
    {
        public string ProfessorID { get; set; }

        public string Subject { get; set; }

        public Professor(string name, int age, string professorID, string subject)
            : base(name, age)
        {
            ProfessorID = professorID;
            Subject = subject;
        }

        public override string GetDetails()
        {
            return $"Role : Professor \n" +
                   $"Name: {Name}\n" +
                   $"Age: {Age}\n" +
                   $"ProfessorID: {ProfessorID}\n" +
                   $"Subject: {Subject}";
        }
    }
}
