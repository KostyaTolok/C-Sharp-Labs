using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    abstract class Student : Person
    {
        public int Course { get; set; }
        public int Group { get; set; }
        public Student() : base()
        {
        }
        public Student(string name, int age, string sex, int height, int weight)
            : this(name, age, sex, height, weight, 0)
        {
        }
        public Student(string name, int age, string sex, int height, int weight, int course)
            : this(name, age, sex, height, weight, course, 0)
        {
        }
        public Student(string name, int age, string sex, int height, int weight, int course, int group)
            : base(name, age, sex, height, weight)
        {
            Course = course;
            Group = group;
        }
        public override string ToString()
        {
            return base.ToString() + "\nCourse: " + Course + "\nGroup: " + Group;
        }
        public abstract string GetSubjects(DaysOfWeek day);
    }
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Suturday,
        Sunday
    }
}
