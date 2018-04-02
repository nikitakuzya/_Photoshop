using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class Pixel
    {
        double r;
        double g;
        double b;

        public double Check(double value)
        {
            if (value < 0 || value > 1) throw new ArgumentException();
            return value;
        }

        public double R
        {
            get { return r; }
            set
            {
                r = Check(value);
            }
        }
        public double G
        {
            get { return g; }
            set
            {
                r = Check(value);
            }
        }
        public double B
        {
            get { return b; }
            set
            {
                r = Check(value);
            }
        }
    }
}