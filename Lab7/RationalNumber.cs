using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class RationalNumber : IComparable<RationalNumber>
    {
        public int Natural { get; set; }
        public int Whole { get; set; }
        public double Value
        {
            get
            {
                return (double)Whole / Natural;
            }
        }
        public RationalNumber() : this(1, 1)
        {
        }
        public RationalNumber(int whole, int natural)
        {
            Whole = whole / GCD(whole, natural);
            Natural = natural / GCD(whole, natural);
        }
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int tmp = b;
                b = a % b;
                a = tmp;
            }
            return Math.Abs(a);
        }
        public override string ToString()
        {
            if (Natural == 1 || Whole == 0)
            {
                return Convert.ToString(Whole);
            }
            else
            {
                return Whole + "/" + Natural;
            }
        }
        public string GetValue()
        {
            return string.Format("{0:f20}", Value);
        }
        public int CompareTo(RationalNumber number)
        {
            return Value.CompareTo(number.Value);
        }
        public static RationalNumber operator +(RationalNumber number1, RationalNumber number2)
        {
            RationalNumber result = new RationalNumber
            {
                Natural = number1.Natural * number2.Natural,
                Whole = number1.Whole * number2.Natural + number2.Whole * number1.Natural
            };
            return result;
        }
        public static RationalNumber operator -(RationalNumber number1, RationalNumber number2)
        {
            RationalNumber result = new RationalNumber()
            {
                Natural = number1.Natural * number2.Natural,
                Whole = number1.Whole * number2.Natural - number2.Whole * number1.Natural
            };
            return result;
        }
        public static RationalNumber operator *(RationalNumber number1, RationalNumber number2)
        {
            RationalNumber result = new RationalNumber()
            {
                Natural = number1.Natural * number2.Natural,
                Whole = number1.Whole * number2.Whole
            };
            return result;
        }
        public static RationalNumber operator /(RationalNumber number1, RationalNumber number2)
        {
            RationalNumber result = new RationalNumber();
            result.Natural = number1.Natural * number2.Whole;
            result.Whole = number1.Whole * number2.Natural;
            if (result.Natural==0)
            {
                throw new Exception("Can't divide by zero");
            }
            return result;
        }
        public static bool operator ==(RationalNumber number1, RationalNumber number2)
        {
            if (number1.Value == number2.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(RationalNumber number1, RationalNumber number2)
        {
            if (number1.Value != number2.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >(RationalNumber number1, RationalNumber number2)
        {
            if (number1.Value > number2.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <(RationalNumber number1, RationalNumber number2)
        {
            if (number1.Value < number2.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator >=(RationalNumber number1, RationalNumber number2)
        {
            if (number1.Value >= number2.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator <=(RationalNumber number1, RationalNumber number2)
        {
            if (number1.Value != number2.Value)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public void ConvertFromFraction(string str)
        {
            Regex regex = new Regex(@"\d+");
            MatchCollection matches = regex.Matches(str);
            if (matches.Count == 2)
            {
                Whole = Convert.ToInt32(matches[0].Value);
                Natural = Convert.ToInt32(matches[1].Value);
            }
            else
            {
                Whole = Convert.ToInt32(matches[0].Value);
            }
        }
        public RationalNumber ConvertFromValue(string str)
        {
            RationalNumber number = new RationalNumber();
            Regex regex = new Regex(@"\d+,\d+");
            MatchCollection matches = regex.Matches(str);
            number.Natural = Natural;
            if (matches.Count == 1)
            {
                number.Whole = (int)(Convert.ToDouble(matches[0].Value) * Natural);
            }
            else
            {
                Regex regex1 = new Regex(@"\d+");
                MatchCollection matches1 = regex1.Matches(str);
                number.Whole = (int)(Convert.ToDouble(matches1[0].Value) * Natural);
            }
            return number;
        }
        public static explicit operator int(RationalNumber number)
        {
            return (int)number.Value;
        }
        public static explicit operator double(RationalNumber number)
        {
            return number.Value;
        }
    }
}
/*public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            RationalNumber number = obj as RationalNumber;
            if (number as RationalNumber == null)
            {
                return false;
            }
            return number.Whole == Whole && number.Natural == Natural && number.Value == Value;
        }
        public bool Equals(RationalNumber number)
        {
            if (number==null)
            {
                return false;
            }
            return number.Whole == Whole && number.Natural == Natural && number.Value == Value;
        }*/
