using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Circle
    {
        private double radius = 0.0;
        private double area = 0.0;
        private double circumference = 0.0;
        private const double pi = Math.PI;
        
        public double getRadius()
        {
            return radius;
        }

        public void setRadius(double input)

        {
            this.radius = input;
        }        
        public Circle(double radius)
        {
            this.radius = radius;
        }

        //circ is D * pi  - d is r*2

        public double calculateCircumference()
        {
            double circ= 0.00;
            circ = (this.radius * 2) * (pi);
            this.circumference = circ;
            return circ;
        }

        public string calculateFormattedCircumference()
        {
            string cfc = "";
            cfc = ("Circumference: " + Decimal.Round((decimal)this.circumference, 2));
            return cfc;
        }

        //area is pi * R^2
        public double calculateArea()
        {
            double area= 0.0;
            area = this.radius * this.radius * pi;
            this.area = area;
            return area;
        }

        public string calculateFormattedArea()
        {
            string cfa = "";
            
            cfa = ("Area: " + Decimal.Round((decimal)this.area, 2));
            // Console.WriteLine(("{0:D2} circ"), this.circumference);
            return cfa;
        }

        private string formatNumber(double x)
        {
            string fn = "";

            return fn;
        }

    }
}
