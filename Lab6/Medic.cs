using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Medic : Student, IScholarship
    {
        public Medic() : base()
        {
        }
        public Medic(string name, int age, string sex, int height, int weight, int course, int group)
            : base(name, age, sex, height, weight, course, group)
        {
        }
        public override string ToString()
        {
            return base.ToString();
        }
        public double GetScholarship()
        {
            if (Course <= 2)
            {
                return 95.35;
            }
            else if (Course <= 4)
            {
                return 105.46;
            }
            else
            {
                return 120.20;
            }
        }
        public override string GetSubjects(DaysOfWeek day)
        {
            switch (day)
            {
                case DaysOfWeek.Monday:
                    return "Biology\n" + "Chemistry\n";
                case DaysOfWeek.Tuesday:
                    return "English\n" + "History\n";
                case DaysOfWeek.Wednesday:
                    return "Pharmacology\n" + "Chemistry\n" + "Anatomy\n";
                case DaysOfWeek.Thursday:
                    return "Biology\n" + "Surgery\n" + "English\n";
                case DaysOfWeek.Friday:
                    return "Pediatrics\n" + "Logic\n" + "Belarusian Language\n";
                case DaysOfWeek.Suturday:
                    return "Anatomy\n";
                case DaysOfWeek.Sunday:
                default:
                    return "";
            }
        }
    }
}
