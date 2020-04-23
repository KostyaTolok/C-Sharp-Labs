using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Linguist : Student, IMilitaryDepartment
    {
        public Linguist() : base()
        {
        }
        public Linguist(string name, int age, string sex, int height, int weight, int course, int group)
            : base(name, age, sex, height, weight, course, group)
        {
        }
        public bool DetermineSuitability()
        {
            if (BodyMassIndex > 16 && BodyMassIndex < 30 && Sex == "Male")
            {
                return true;
            }
            else return false;
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public override string GetSubjects(DaysOfWeek day)
        {
            switch (day)
            {
                case DaysOfWeek.Monday:
                    return "English\n" + "History\n";
                case DaysOfWeek.Tuesday:
                    return "Philosophy\n" + "Spanish\n";
                case DaysOfWeek.Wednesday:
                    return "Political Science\n" + "English\n" + "German\n";
                case DaysOfWeek.Thursday:
                    return "Spanish\n" + "Belarusian Language\n" + "History\n";
                case DaysOfWeek.Friday:
                    return "Psychology\n" + "Logic\n";
                case DaysOfWeek.Suturday:
                    return "Philosophy\n";
                case DaysOfWeek.Sunday:
                default:
                    return "";
            }
        }
    }
}
