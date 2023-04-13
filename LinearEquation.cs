using System;

namespace Equation
{ // private data field
    class LinearEquation
    {   private double a;
        private double b;
        private double c;
        private double d;
        private double e;
        private double f;
     // constructor
        public LinearEquation(double A, double B, double C, double D, double E, double F)
        {
            this.a = A;
            this.b = B;
            this.c = C;
            this.d = D;
            this.e = E;
            this.f = F;
        }
        // method isSolvable
        public bool isSolvable()
        {
            if(a*d-b*c == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

            
        }
         public double getY()
            {
                double y;
                y = (a*f - e*c)/(a*d - b*c);
                return y;
            }
            public double getX()
            {
                double x;
                x = (e*d - b*f)/(a*d -b*c);
                return x;
            }
        
    }
}
