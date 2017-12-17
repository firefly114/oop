using System;

namespace lab2
{    public class Log : Tree, Burning<Log>
    {
        private double length;
        private int bough;

        public double Length { get => length; set {
            if(value <= Limits.Log_Max_Length)
                length = value;
            else {
                length = Limits.Log_Max_Length;
                Console.WriteLine("too long log");
            }
        } }
        public int Bough { get => bough; set => bough = value; }

        public Log(double length) {
            this.Length = length;
            this.Bough = 1;  
        }

        public Log() {
            this.Length = 1;
            this.Bough = 1;  
        }

        public virtual double Burning() {
            return this.crossSectionSquare() * this.length * 2400 * 900;
        }

        public Log(double length, int Bough ,string genus, int diameter, int age, int heightTree) 
        : base(genus,diameter,age,heightTree) {
            this.Length = length;
            this.Bough = Bough;
        }

        public override void Print() {
            Console.WriteLine("{0}\n{1} cm\n{2} m\n{3} m\n{4} mm\n",this.Genus,this.Diameter,this.HeightTree, this.Length,this.Bough);
        }
    }
}
