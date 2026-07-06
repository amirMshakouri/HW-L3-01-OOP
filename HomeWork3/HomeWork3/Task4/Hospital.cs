using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork3.Task4
{
    public class Hospital
    {
        public List<Doctor> Doctors { get; set; }

        public List<Room> Rooms { get; set; }

        public Hospital()
        {
            Doctors = new List<Doctor>();
            Rooms = new List<Room>();
        }

        public void AdmitPatient(Patient patient)
        {
            foreach (Room room in Rooms)
            {
                try
                {
                    room.AssignPatient(patient);

                    Console.WriteLine($"{patient.Name} Hospitalized {room.RoomNumber}.");
                    
                    return;
                }
                catch (RoomFullException)
                {

                }
            }

            Console.WriteLine("there is no empty room.");
        }

        public void DischargePatient(string patientId)
        {
            foreach (Room room in Rooms)
            {
                Patient patient = room.Patients.Find(p => p.PatientId == patientId);

                if (patient != null)
                {
                    room.Patients.Remove(patient);

                    Console.WriteLine($"{patient.Name} Discharged");

                    return;
                }
            }

            Console.WriteLine(" patient not found ");
        }
    }
}
