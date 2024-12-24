using System;
using StudentLibrary;

namespace StudentConsoleApp
{
    class Programm { 
    static void Main(string[] args)
        {
            Group group = new Group("36ИС", "1-МОК");
            group.addStudent(new Student("Козырев Максим", 3.5)); 
            group.addStudent(new Student("Ватаву Степан", 4.9)); //Выполнил Ватаву Степан
            group.addStudent(new Student("Боровых Виван", 4.7));
            group.addStudent(new Student("Иван Иванов", 3.0)); 
            group.addStudent(new Student("Сабуро Арасака", 4.3));
            group.ShowAll();
        }
    }
       
    
}