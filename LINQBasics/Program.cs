namespace LINQBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student> { new Student("John", true),
                                                new Student("Andrew", false),
                                                new Student("Cindy", false),
                                                new Student("Bob", true) };

            // Method Syntax

            IEnumerable<string> studentsPayingAttention = students
                .Where(s => s.IsPayingAttention)
                .Select(s => s.Name);

            foreach (var item in studentsPayingAttention)
            {
                Console.WriteLine(item);
            }

            //Query Syntax

            IEnumerable<string> studentsPayingAttention2 = 
                from student in students
                where student.IsPayingAttention
                select student.Name;

            foreach (var item in studentsPayingAttention2)
            {
                Console.WriteLine(item);
            }
        }

    }

    class Student
    {
        string _Name;
        bool _IsPayingAttention;

        public string Name { get => _Name; set => _Name = value; }
        public bool IsPayingAttention { get => _IsPayingAttention; set => _IsPayingAttention = value; }

        public Student(string Name, bool IsPayingAttention)
        {
            _Name = Name;
            _IsPayingAttention = IsPayingAttention;
        }
    }
}