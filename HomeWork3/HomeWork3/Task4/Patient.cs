using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task4
{
    using HomeWork3.task2;
    using System.Collections.Generic;

    public class Patient : HPerson
    {
        public string PatientId { get; set; }

        public List<string> MedicalHistory { get; set; }

        public Patient(string name, int age, string nationalId, string patientId)
            : base(name, age, nationalId)
        {
            PatientId = patientId;
            MedicalHistory = new List<string>();
        }

        public void AddToMedicalHistory(string disease)
        {
            MedicalHistory.Add(disease);
        }

        public override string GetDetails()
        {
            return base.GetDetails() +
                   $"\nPatientId: {PatientId}";
        }
    }
}
