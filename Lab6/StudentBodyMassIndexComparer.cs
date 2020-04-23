using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class StudentBodyMassIndexComparer : IComparer<Student>
    {
        public int Compare(Student student1, Student student2)
        {
            if (student1.BodyMassIndex > student2.BodyMassIndex)
            {
                return 1;
            }
            else if (student1.BodyMassIndex < student2.BodyMassIndex)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
