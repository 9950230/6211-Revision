using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Teacher[] teachers = new Teacher[5];
            Student[] students = new Student[5];


            teachers[0] = new Teacher("Addison", 35, "Addison_Username");
            teachers[1] = new Teacher("Davey", 30, "Davey_Username");
            teachers[2] = new Teacher("Celine", 39, "Celine_Username");
            teachers[3] = new Teacher("Ted", 42, "Ted_Username");
            teachers[4] = new Teacher("Rosie", 55, "Rosie_Username");

            students[0] = new Student("Willy", 22, 1);
            students[1] = new Student("Elisa", 27, 2);
            students[2] = new Student("Evelin", 20, 3);
            students[3] = new Student("Vinny", 34, 4);
            students[4] = new Student("Nancee", 19, 5);

            Console.WriteLine("[---- Teachers -------------------------------]\n");

            for (int i = 0; i < teachers.Length; i++)
            {
                Console.WriteLine("Name: {0}", teachers[i].Name);
                Console.WriteLine("Age: {0}", teachers[i].Age);
                Console.WriteLine("Username: {0}", teachers[i].Username);
                Console.WriteLine();

            }

            Console.WriteLine("\n[---- Students -------------------------------]\n");

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Name: {0}", students[i].Name);
                Console.WriteLine("Age: {0}", students[i].Age);
                Console.WriteLine("Id: {0}", students[i].Id);
                Console.WriteLine();

            }

            Console.ReadLine();

                
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Teacher : Person
    {
       
        public string Username { get; set; }

        public Teacher(string name, int age, string username)
        {
            Name = name;
            Age = age;
            Username = username;
        }

    }

    class Student : Person
    {
        public int Id { get; set; }

        public Student(string name, int age, int id)
        {
            Name = name;
            Age = age;
            Id = id;
        }
    }
}
