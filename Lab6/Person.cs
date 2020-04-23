using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    abstract class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public double Height { get; set; }
        public int Weight { get; set; }
        public int CompareTo(Person person)
        {
            return Name.CompareTo(person.Name);
        }
        public double BodyMassIndex
        {
            get
            {
                double m_height = Height / 100;
                return Weight / (m_height * m_height);
            }
        }
        public static int count = 0;
        public virtual string this[string field]
        {
            get
            {
                switch (field)
                {
                    case "name": return Name;
                    case "sex": return Sex;
                    case "age": return Age.ToString();
                    case "height": return Height.ToString();
                    case "weight": return Weight.ToString();
                    default: return null;
                }
            }
            set
            {
                switch (field)
                {
                    case "name":
                        Name = value;
                        break;
                    case "sex":
                        Sex = value;
                        break;
                    case "age":
                        Age = Convert.ToInt32(value);
                        break;
                    case "height":
                        Height = Convert.ToInt32(value);
                        break;
                    case "weight":
                        Weight = Convert.ToInt32(value);
                        break;
                }
            }
        }
        public override string ToString()
        {
            return "\nName: " + Name + "\nAge: " + Age + "\nSex: "
                + Sex + "\nHeight: " + Height + "\nWeight: " + Weight;
        }
        public Person() : this("Unknown")
        {
        }
        public Person(string name) : this(name, 0)
        {
        }
        public Person(string name, int age) : this(name, age, "Unknown")
        {
        }
        public Person(string name, int age, string sex) : this(name, age, sex, 0)
        {
        }
        public Person(string name, int age, string sex, int height) : this(name, age, sex, height, 0)
        {
        }
        public Person(string name, int age, string sex, int height, int weight)
        {
            Name = name;
            Age = age;
            Sex = sex;
            Height = height;
            Weight = weight;
            count++;
        }
    }
}
