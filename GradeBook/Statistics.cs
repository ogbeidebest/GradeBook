using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return sum / count;
            }
        }

        public char Letter
        {
            get
            {
                if (Average >= 90)
                {
                    return 'A';
                }
                else if (Average >= 80)
                {
                    return 'B';
                }
                else if (Average >= 70)
                {
                   return 'C';
                }
                else if (Average >= 80)
                {
                    return 'D';
                }
                else
                {
                    return 'F';
                }

            }
        }
        public double High;
        public double Low;
     
        public double sum;
        public int count;

        public void Add(double number)
        {
            sum += number;
            count++;
            High = Math.Max(number, High);
            Low = Math.Min(number, Low);
        }
        public Statistics()
        {
            count = 0;
            sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;

        }
    }
}
