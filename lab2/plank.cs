using System;

namespace lab2
{    public class Plank : Log
    {
        private double thickness;
        private double width;

        public double Width { get => width; set => width = value; }
        public double Thickness { get => thickness; set => thickness = value; }

        public Plank(double length, double width, double thickness) : base(length) {
            this.Thickness = thickness;
            this.Width = width;
        }

        public double Volume() {
            return Thickness*width*Length;
        }
        public Plank() {
            
        }
    }
}
