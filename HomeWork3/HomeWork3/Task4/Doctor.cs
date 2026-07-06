using HomeWork3.task2;
using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task4
{
    public class Doctor : HPerson
    {
        public string DoctorId { get; set; }

        public string Specialization { get; set; }

        public Doctor(string name, int age, string nationalId,
                      string doctorId, string specialization)
            : base(name, age, nationalId)
        {
            DoctorId = doctorId;
            Specialization = specialization;
        }

        public void Diagnose(Patient patient, string disease)
        {
            patient.AddToMedicalHistory(disease);

            Console.WriteLine($"{patient.Name} diagnosed  with {disease} .");
        }

        public override string GetDetails()
        {
            return base.GetDetails() +
                   $"\n DoctorID: {DoctorId}" +
                   $"\n Specialization: {Specialization}";
        }
    }
}
