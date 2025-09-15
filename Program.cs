namespace JuniorDevChallenge1
{
    internal class Program
    {
        class Student
        {
            public string Name { get; set; } = string.Empty;
            public int Grade { get; set; }
        }
        static void Main()
        {
            List<Student> students = new List<Student>();

            while (true)
            {
                string name;
                while (true)
                {
                    Console.Write("請輸入學生姓名: ");
                    name = Console.ReadLine()?.Trim() ?? "";

                    if (string.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("姓名不能為空，請重新輸入。");
                    }
                    else
                    {
                        break;
                    }
                }

                Console.Write("請輸入學生成績: ");
                if (!int.TryParse(Console.ReadLine(), out int grade))
                {
                    Console.WriteLine("成績輸入錯誤，請輸入有效的整數。");
                    continue;
                }

                students.Add(new Student { Name = name, Grade = grade });

                Console.Write("是否要輸入另一位學生？(Y/N): ");
                string again = Console.ReadLine()?.Trim().ToUpper() ?? "";
                if (again != "Y") break;
            }

            foreach (var student in students)
            {
                string level = GetGradeLevel(student.Grade);
                Console.WriteLine($"{student.Name} 的成績是 {level}");
            }
        }

        static string GetGradeLevel(int grade)
        {
            return grade switch
            {
                >= 90 => "A",
                >= 80 => "B",
                >= 70 => "C",
                >= 60 => "D",
                _ => "F"
            };
        }

    }

}
