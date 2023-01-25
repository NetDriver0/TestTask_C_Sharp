using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TestTask1
{
    class Circle : IFigure
    {
        private double radius;
        public double Radius {
            get { return radius; }
            set { if (value>0)
                radius = value;
            else Console.WriteLine("Ошибка, сторона не может быть меньше нуля");
            }
        }

        public double Area() {
            return Math.PI * radius * radius;
        }
    }
    class Triangle : IFigure
    {
        double A, B, C;
        public void SetSides(double A, double B, double C) {
            if ((A < 0 || B < 0 || C < 0)               //проверяем что треугольник возможен сначала тем что у нас нет нулевой стороны
                || (A > B + C || B>A+C || C>A+B))       // а затем проверяем треугольник на свойство треугольника по длинее сторон
                Console.WriteLine("Ошибка, сторона не может быть меньше нуля");
            else {
                this.A = A;
                this.B = B;
                this.C = C;
            }
        }
        public double Area() {
            double p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public bool IsSquare() {
            if (A > B && A > C) {
                return (A * A == B * B + C * C);
            }
            else if (B > A && B > C) {
                return (B * B == A * A + C * C);
            }
            else if (C > A && C > B) {
                return (C * C == B * B + A * A);
            }
            else return false;
        }
    }
}

