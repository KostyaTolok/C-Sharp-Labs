using System;
using System.Collections.Generic;
using System.Threading;
namespace Task1
{
    class Program
    {
        static void DefineAge(int age)
        {
            Console.Write("Age: ");
            if (age >= 0 && age < 18)
            {
                Console.WriteLine("Teen");
            }
            else if (age >= 18 && age <= 50)
            {
                Console.WriteLine("Adult");
            }
            else if (age > 50 && age <= 100)
            {
                Console.WriteLine("Aged");
            }
            else
            {
                Console.WriteLine("Incorrect Age");
            }
        }
        static void DefineBodyMasIndex(double index)
        {
            Console.Write("Body Mass Index: ");
            if (index > 0 && index <= 15)
            {
                Console.WriteLine("Very severely underweight");
            }
            else if (index > 15 && index <= 16)
            {
                Console.WriteLine("Severely underweight");
            }
            else if (index > 16 && index <= 18.5)
            {
                Console.WriteLine("Underweight");
            }
            else if (index > 18.5 && index <= 25)
            {
                Console.WriteLine("Normal");
            }
            else if (index > 25 && index <= 30)
            {
                Console.WriteLine("Overweight");
            }
            else if (index > 30 && index <= 35)
            {
                Console.WriteLine("Moderately obese");
            }
            else if (index > 35 && index <= 40)
            {
                Console.WriteLine("Severely obese");
            }
            else if (index > 40 && index <= 204)
            {
                Console.WriteLine("Very severely obese");
            }
            else
            {
                Console.WriteLine("Incorrect body mass index");
            }
        }
        static void InputObject(List<Student> list)
        {
            int amount;
            string input;
            ConsoleKey choice;
            Student student;
            while (true)
            {
                Console.WriteLine("Enter amount of students:");
                input = Console.ReadLine();
                if (int.TryParse(input, out amount) && amount > 0)
                {
                    Console.Clear();
                    break;
                }
                Console.WriteLine("Wrong amount");
                Thread.Sleep(500);
                Console.Clear();
            }
            Console.Clear();
            for (int i = 0; i<amount; i++)
            {
                Console.WriteLine("Choose student:\n1.Programmer\n2.Medic\n3.Linguist");
                choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        student = new Programmer();
                        break;
                    case ConsoleKey.D2:
                        student = new Medic();
                        break;
                    case ConsoleKey.D3:
                        student = new Linguist();
                        break;
                    default:
                        Console.Clear();
                        continue;
                }
                Console.Clear();
                Console.WriteLine("Enter name: ");
                student.Name = Console.ReadLine();
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Enter age: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int temp) && temp > 0 && temp < 100)
                    {
                        student.Age = temp;
                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("Wrong age");
                    Thread.Sleep(500);
                    Console.Clear();
                }
                while (true)
                {
                    Console.WriteLine("Choose sex:\n1.Male\n2.Female");
                    choice = Console.ReadKey(true).Key;
                    switch (choice)
                    {
                        case ConsoleKey.D1:
                            student.Sex = "Male";
                            break;
                        case ConsoleKey.D2:
                            student.Sex = "Female";
                            break;
                        default:
                            Console.Clear();
                            continue;
                    }
                    Console.Clear();
                    break;
                }
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Enter height: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int temp) && temp > 0 && temp < 270)
                    {
                        student.Height = temp;
                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("Wrong height");
                    Thread.Sleep(500);
                    Console.Clear();
                }
                while (true)
                {
                    Console.WriteLine("Enter weight: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int temp) && temp > 0 && temp < 419)
                    {
                        student.Weight = temp;
                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("Wrong weight");
                    Thread.Sleep(500);
                    Console.Clear();
                }
                while (true)
                {
                    Console.WriteLine("Enter course: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int temp) && temp > 0 && temp < 6)
                    {
                        student.Course = temp;
                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("Wrong course");
                    Thread.Sleep(500);
                    Console.Clear();
                }
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Enter group: ");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int temp) && temp > 0 && temp < 10)
                    {
                        student.Group = temp;
                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("Wrong group");
                    Thread.Sleep(500);
                    Console.Clear();
                }
                Console.Clear();
                list.Add(student);
            }
        }
        static void Main(string[] args)
        {
            ConsoleKey choice;
            List<Student> students;
            while (true)
            {
                Console.WriteLine("Do you want to use preset?(Y/N)");
                choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.Y:
                        Student Kostya = new Programmer("Kostya", 18, "male", 175, 70, 1, 5);
                        Student Lena = new Medic("Lena", 19, "female", 160, 50, 4, 3);
                        Student Katya = new Linguist("Katya", 20, "female", 165, 65, 5, 1);
                        students = new List<Student> { Kostya, Lena, Katya };
                        break;
                    case ConsoleKey.N:
                        students = new List<Student>();
                        InputObject(people);
                        break;
                    default:
                        Console.Clear();
                        continue;
                }
                Console.Clear();
                break;
            }
            Console.WriteLine("Order by:\n1.Names\n2.Courses\n3.Groups\n4.Body Mass Indices");
            while (true)
            {
                choice = Console.ReadKey(true).Key;
                switch (choice)
                {
                    case ConsoleKey.D1:
                        students.Sort();
                        break;
                    case ConsoleKey.D2:
                        students.Sort(new StudentCourseComparer());
                        break;
                    case ConsoleKey.D3:
                        students.Sort(new StudentGroupComparer());
                        break;
                    case ConsoleKey.D4:
                        students.Sort(new StudentBodyMassIndexComparer());
                        break;
                    default:
                        Console.Clear();
                        continue;
                }
                Console.Clear();
                break;
            }
            Console.WriteLine("\nAmount of students " + people.Count);
            foreach (Student student in students)
            {
                if (student is Programmer)
                {
                    Console.WriteLine("\nProgrammer:");
                }
                else if (student is Medic)
                {
                    Console.WriteLine("\nMedic:");
                }
                else
                {
                    Console.WriteLine("\nLinguist:");
                }
                Console.WriteLine(student);
                DefineAge(student.Age);
                DefineBodyMasIndex(student.BodyMassIndex);
                if (student is IScholarship scholarship)
                {
                    Console.WriteLine(student.Name + "'s scholarship is " + scholarship.GetScholarship());
                }
                if (student is IMilitaryDepartment department)
                {
                    if (department.DetermineSuitability())
                    {
                        Console.WriteLine("Suitable for military department");
                    }
                    else
                    {
                        Console.WriteLine("Not suitable for military department");
                    }
                }
                Console.WriteLine("\nScedule: \n");
                for (DaysOfWeek day = 0; day != DaysOfWeek.Sunday; day++)
                {
                    Console.WriteLine(Convert.ToString(day) + ":\n" + student.GetSubjects(day));
                }
            }
        }
    }
}
