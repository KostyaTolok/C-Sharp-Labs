using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Programmer : Student, IScholarship, IMilitaryDepartment
    {
        public Programmer() : base()
        {
        }
        public Programmer(string name, int age, string sex, int height, int weight, int course, int group)
            : base(name, age, sex, height, weight, course, group)
        {
        }
        public bool DetermineSuitability()
        {
            if (BodyMassIndex > 13.5 && BodyMassIndex < 34.5 && Sex == "Male")
            {
                return true;
            }
            else return false;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public double GetScholarship()
        {
            if (Course <= 2)
            {
                return 100.67;
            }
            else if (Course <= 4)
            {
                return 110.26;
            }
            else
            {
                return 120.69;
            }
        }
        public override string GetSubjects(DaysOfWeek day)
        {
            switch (day)
            {
                case DaysOfWeek.Monday:
                    return "Mathematical Logic\n" + "Physical Education\n";
                case DaysOfWeek.Tuesday:
                    return "Geometry and Algebra\n" + "Mathematical Analysis\n";
                case DaysOfWeek.Wednesday:
                    return "Physical Education\n" + "Programming\n" + "Geometry and Algebra\n";
                case DaysOfWeek.Thursday:
                    return "Logic\n" + "Programming\n" + "English\n";
                case DaysOfWeek.Friday:
                    return "Programming\n" + "Mathematical Logic\n" + "Mathematical Analysis\n";
                case DaysOfWeek.Suturday:
                    return "Belarusian Language\n" + "Programming\n";
                case DaysOfWeek.Sunday:
                default:
                    return "";
            }
        }
    }
}
