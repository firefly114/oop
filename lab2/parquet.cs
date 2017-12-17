using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{    public class Parquet : Plank, Burning<Parquet>, Dyeing<Parquet>
    {
        private string color;

        public Parquet(Colors color, double length, double width, double thickness) : base(length,width,thickness) {
            this.Color = color.ToString("g");
        }

        public string Color { get => color; set => color = value; }

        public override double Burning() {
            return this.Volume() * 2400 * 900;
        }

        public Boolean Dyeing(Colors color) {
            if (this.Color != color.ToString("g")) {
                this.Color = color.ToString("g");
                return true;
            } else {
                return false;
            }
        }
    }
}
