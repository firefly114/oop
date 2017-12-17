using System;

namespace lab2
{    public class Laminat : Plank, Burning<Parquet>, Dyeing<Parquet>
    {
        private string color;
        
        public Laminat(Colors color) {
            this.Color = color.ToString("g");
        }

        public Laminat() {
            this.color = "";
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

        public void CopyColor<T>(T par) where T : Parquet {
            this.color = par.Color;
        }

    }
}
