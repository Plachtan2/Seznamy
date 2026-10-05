namespace Seznamy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Jak Tě oslovují:");

            //string? jmeno;
            //jmeno = Console.ReadLine();

            //Console.WriteLine("Ahoj " + jmeno);

            var list = new List<string>() { "Pepa", "Karel", "Mirek", "Kryštof" };

            // vypiš spojení ...
            Console.WriteLine (String.Join(",", list));

            list.Add("Ivan");

            Console.WriteLine(String.Join(",", list));

            list.Remove("Pepa");

            Console.WriteLine(String.Join(",", list));


            Console.ReadKey();

            var s1 = new Student(); s1.Jmeno = "Dušan"; s1.Body = 14;
            
            var s2 = new Student() { Jmeno="Pepe Lopez", Body = 15 };

            var s3 = new Student("Karel", 75);

            var liststud = new List<Student>() { s1, s2, s3 };

            foreach (var student in liststud)
            {
                Console.WriteLine(student.Jmeno + " --- " + student.Body);
            }

        }
    }

    public class Student
    {
        public Student() { }

        public Student(string jmeno, int body) 
        { 
           Jmeno = jmeno;
            Body = body;
        }


        public string? Jmeno { get; set; }
        public int Body { get; set; }
    }

}
