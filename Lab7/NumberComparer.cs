using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class NumberComparer : IComparer<RationalNumber>
    {
        public int Compare(RationalNumber number1, RationalNumber number2)
        {
            if (number1.Value > number2.Value)
            {
                return 1;
            }
            else if (number1.Value < number2.Value)
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
