namespace StudentLibrary
{
    public class Student
    {
        public string Name { get; set; } // Выполнил Ватаву
        public double Ocenka { get; set; }
        public Student(String name, double ocenka) {
            this.Name = name; //ВЫполнил Ватаву
            this.Ocenka = ocenka;
        }
        public void Show()
        {
            Console.WriteLine("Имя: " + Name + " Оценка: " + Ocenka);
        }
    }
    public class Group{
        public string Name { get; set; }
        public string College { get; set;}
        public List<Student> Students { get; set; } = new List<Student>();
        public Group(String name, String college) { 
            this.Name=name;
            this.College=college;
        }
        public void addStudent(Student student)
        {
            Students.Add(student);
        }
        public void ShowAll() {
            Console.WriteLine($"Группа: {Name}, Колледжа: {College}");
            foreach(Student student in Students)
            {
                student.Show();
            }
        }
    }
}
