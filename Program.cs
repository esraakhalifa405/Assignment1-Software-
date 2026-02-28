
using System;

namespace Hospital_System
{
    class Patient
    {
        public int ID;
        public string name;
        public int age;
        public string phone;
        public string history;
    }

    class Doctor
    {
        public int ID;
        public string name;
        public string specialization;
    }

    class Appointment
    {
        public int patientID;
        public int doctorID;
        public string date;
        public string time;
    }

    class Program
    {
        // ========= Add Patient =========
        static void addPatient(Patient p)
        {
            Console.Write("Enter Patient ID: ");
            p.ID = int.Parse(Console.ReadLine());

            Console.Write("Enter Patient Name: ");
            p.name = Console.ReadLine();

            Console.Write("Enter Age: ");
            p.age = int.Parse(Console.ReadLine());

            Console.Write("Enter Phone: ");
            p.phone = Console.ReadLine();

            Console.Write("Enter Medical History: ");
            p.history = Console.ReadLine();
        }

        // ========= Show Patient =========
        static void showPatient(Patient p)
        {
            Console.WriteLine($"\nID: {p.ID}");
            Console.WriteLine($"Name: {p.name}");
            Console.WriteLine($"Age: {p.age}");
            Console.WriteLine($"Phone: {p.phone}");
            Console.WriteLine($"History: {p.history}");
            Console.WriteLine("--------------------");
        }

        // ========= Search Patient =========
        static bool searchPatient(int id, string name, Patient p)
        {
            if (p.ID == id && p.name == name)
                return true;
            return false;
        }

        // ========= Add Doctor =========
        static void addDoctor(Doctor d)
        {
            Console.Write("Enter Doctor ID: ");
            d.ID = int.Parse(Console.ReadLine());

            Console.Write("Enter Doctor Name: ");
            d.name = Console.ReadLine();

            Console.Write("Enter Specialization: ");
            d.specialization = Console.ReadLine();
        }

        // ========= Show Doctor =========
        static void showDoctor(Doctor d)
        {
            Console.WriteLine($"\nDoctor ID: {d.ID}");
            Console.WriteLine($"Name: {d.name}");
            Console.WriteLine($"Specialization: {d.specialization}");
            Console.WriteLine("--------------------");
        }

        // ========= Book Appointment =========
        static void bookAppointment(Appointment a)
        {
            Console.Write("Enter Patient ID: ");
            a.patientID = int.Parse(Console.ReadLine());

            Console.Write("Enter Doctor ID: ");
            a.doctorID = int.Parse(Console.ReadLine());

            Console.Write("Enter Date: ");
            a.date = Console.ReadLine();

            Console.Write("Enter Time: ");
            a.time = Console.ReadLine();
        }

        // ========= Show Appointment =========
        static void showAppointment(Appointment a)
        {
            Console.WriteLine($"\nPatient ID: {a.patientID}");
            Console.WriteLine($"Doctor ID: {a.doctorID}");
            Console.WriteLine($"Date: {a.date}");
            Console.WriteLine($"Time: {a.time}");
            Console.WriteLine("--------------------");
        }

        // ========= Bill =========
        static void calculateBill()
        {
            Console.Write("Enter Consultation Fee: ");
            double c = double.Parse(Console.ReadLine());

            Console.Write("Enter Medicine Cost: ");
            double m = double.Parse(Console.ReadLine());

            Console.WriteLine($"Total Bill = {c + m}");
        }

        static void Main(string[] args)
        {
            Patient[] patients = new Patient[100];
            Doctor[] doctors = new Doctor[50];
            Appointment[] appointments = new Appointment[200];

            int pCount = 0, dCount = 0, aCount = 0;
            int choice;
            do
            {
                Console.WriteLine("\n==== Hospital System ====");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. View Patients");
                Console.WriteLine("3. Search Patient");
                Console.WriteLine("4. Add Doctor");
                Console.WriteLine("5. View Doctors");
                Console.WriteLine("6. Book Appointment");
                Console.WriteLine("7. View Appointments");
                Console.WriteLine("8. Calculate Bill");
                Console.WriteLine("9. Exit");

                Console.Write("Enter choice: ");
                choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    patients[pCount] = new Patient();
                    addPatient(patients[pCount]);
                    pCount++;
                }
                else if (choice == 2)
                {
                    for (int i = 0; i < pCount; i++)
                        showPatient(patients[i]);
                }
                else if (choice == 3)
                {
                    Console.Write("Enter ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine();

                    bool found = false;
                    for (int i = 0; i < pCount; i++)
                    {
                        if (searchPatient(id, name, patients[i]))
                        {
                            showPatient(patients[i]);
                            found = true;
                        }
                    }

                    if (!found)
                        Console.WriteLine("Patient not found.");
                }
                else if (choice == 4)
                {
                    doctors[dCount] = new Doctor();
                    addDoctor(doctors[dCount]);
                    dCount++;
                }
                else if (choice == 5)
                {
                    for (int i = 0; i < dCount; i++)
                        showDoctor(doctors[i]);
                }
                else if (choice == 6)
                {
                    appointments[aCount] = new Appointment();
                    bookAppointment(appointments[aCount]);
                    aCount++;
                }
                else if (choice == 7)
                {
                    for (int i = 0; i < aCount; i++)
                        showAppointment(appointments[i]);
                }
                else if (choice == 8)
                {
                    calculateBill();
                }

            } while (choice != 9);
        }
    }
}