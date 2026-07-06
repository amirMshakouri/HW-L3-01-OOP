using HomeWork3.Task1;
using HomeWork3.task2;
using HomeWork3.Task3;
using HomeWork3.Task4;

namespace HomeWork3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Task1---------------");

            Library library = new Library();

            library.AddBook(new Book("ghomarbaz", "Dastayofski", "01", true));
            library.AddBook(new Book("soghut", "AlberKamo", "02", true));
            library.AddBook(new Book("delma", "Herman Hesse", "03", false));

            library.ShowBooks();
            library.BarrowBook("ghomarbaz");
            library.ShowBooks();
            library.ReturnBook("delma");
            library.ShowBooks();

            Console.WriteLine("-----------------Task2----------------");

            List<Person> people = new List<Person>();

            people.Add(new Student("amir", 22, "40111541054056", "Computer engineer"));
            people.Add(new Student("nima", 32, "404712010", "psychology"));

            people.Add(new Professor("Amir Noori", 45, "1", "Data Base"));
            people.Add(new Professor("Asma Farokhi", 32, "2", "General psychology"));

            foreach (Person person in people)
            {
                Console.WriteLine("------");
                Console.WriteLine(person.GetDetails());

            }

            Console.WriteLine("-----------------Task3----------------");

            List<Product> products = new List<Product>();

            Electronic laptop = new Electronic("Laptop-lenovo ideapad gaming y-7", 120000000, 24);
            Electronic phone = new Electronic("IPhone 14 promax", 60000000, 18);

            Clothing Tshirt = new Clothing("T-Shirt", 800, "XL", "thread");
            Clothing jeans = new Clothing("Jeans", 1500, "36", "Jean");

            laptop.ApplyDiscount(15);
            phone.ApplyDiscount(25);

            products.Add(laptop);
            products.Add(phone);
            products.Add(Tshirt);
            products.Add(jeans);

            foreach (Product product in products)
            {
                Console.WriteLine("------");
                Console.WriteLine(product.GetProductDetails());

            }

            Console.WriteLine("-----------------Task4----------------");

            Hospital hospital = new Hospital();

            hospital.Rooms.Add(new Room(101, 2));
            hospital.Rooms.Add(new Room(102, 1));

            Doctor doctor = new Doctor(
                "DR.Taghikhani ",
                45,
                "1234567890",
                "100",
                "Heart");

            hospital.Doctors.Add(doctor);

            Patient p1 = new Patient("Ali", 31, "000", "001");
            Patient p2 = new Patient("Darya", 29, "111", "002");
            Patient p3 = new Patient("Sina", 19, "222", "003");
            Patient p4 = new Patient("Anahit", 25, "333", "004");

            hospital.AdmitPatient(p1);
            hospital.AdmitPatient(p2);
            hospital.AdmitPatient(p3);
            hospital.AdmitPatient(p4);

            doctor.Diagnose(p1, "Flu");
            doctor.Diagnose(p2, "Diabete");

            hospital.DischargePatient("002");

            Console.WriteLine();

            Console.WriteLine(p1.GetDetails());

            Console.WriteLine();

            Console.WriteLine("patient Medical History :");

            foreach (string disease in p1.MedicalHistory)
            {
                Console.WriteLine(disease);
            }
        }
    }
}
