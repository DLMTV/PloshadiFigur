using System;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Messaging;
using ConsoleApplication2;

namespace ConsoleApplication2
{
    public abstract class Figure
    {
        public abstract double Ploshad();
        

        public class Triangle : Figure
        {
            double a;
            double b;
            double c;

            public Triangle(double a, double b, double c)
            {
                this.a = a;
                this.b = b;
                this.c = c;
            }
            public override double Ploshad()
            {
                double p = ((a + b + c) / 2);
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
        
        public class Square : Figure
        {
            double d;

            public Square(double d)
            {
                this.d = d;
            }

            public override double Ploshad()
            {
                return d * d;
            }
            /*S =a* a */

        }

        public class Circle : Figure
        {
            double r;

            public Circle(double r)
            {
                this.r = r;
            }

            public override double Ploshad()
            {
                return 3.14 * (r * r);

                /*  s = pi*(r*r)*/
            }
        }
    }
}