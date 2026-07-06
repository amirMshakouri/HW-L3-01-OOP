using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.task2
{
    public class Student : Person
    {
        public string StudentId { get; set; }

        public string Major { get; set; }

        public Student(string name, int age, string studentId, string major)
            : base(name, age)
        {
            StudentId = studentId;
            Major = major;
        }

        public override string GetDetails()
        {
            return $"Role : Strudent\n" +
                   $"Name: {Name}\n" +
                   $"Age: {Age}\n" +
                   $"Student Number: {StudentId}\n" +
                   $"Major: {Major}";
        }
    }
}
