using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Fraction
    {
        protected long Numer;
        protected long Denom;

        public double ToDouble()
        {
            var s = Numer + "," + Denom;

            return Convert.ToDouble(s);
        }

        public override string ToString()
        {
            return this.ToDouble().ToString("n2");
        }

        public static Fraction ToFraction(double value)
        {
            var arr = value.ToString().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

            return new Fraction()
            {
                Numer = Convert.ToInt32(arr[0]),
                Denom = arr.Length == 2 ? Convert.ToUInt32(arr[1]) : 0
            };
        }

        public static Fraction operator +(Fraction a, Fraction b)
        {
            return ToFraction(a.ToDouble() + b.ToDouble());
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            return ToFraction(a.ToDouble() - b.ToDouble());
        }
        public static Fraction operator *(Fraction a, Fraction b)
        {
            return ToFraction(a.ToDouble() * b.ToDouble());
        }
        public static bool operator ==(Fraction a, Fraction b)
        {
            return a.Denom == b.Denom && a.Numer == b.Numer;
        }
        public static bool operator !=(Fraction a, Fraction b)
        {
            return a.Denom != b.Denom || a.Numer != b.Numer;
        }
        

        }
    }

