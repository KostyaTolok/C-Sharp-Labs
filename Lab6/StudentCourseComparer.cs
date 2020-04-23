using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class StudentCourseComparer : IComparer<Student>
    {
        public int Compare(Student student1, Student student2)
        {
            if (student1.Course > student2.Course)
            {
                return 1;
            }
            else if (student1.Course < student2.Course)
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
