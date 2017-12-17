using System;
using System.Collections;
using System.Collections.Generic;

namespace lab2
{
    public class Oak : Tree
    {
        public const int density = 900;

        public Oak(int diameter, int age, int height, Lumberjack lumberjack) {
            this.Genus = "oak";
            this.Diameter = diameter;
            this.Age = age;
            this.HeightTree = height;
            lumberjack.LumberjackCuttingDownEvent += new CuttingHandle(this.Cut);
        }

        public Oak() {
            this.Diameter = 0;
            this.Age = 0;
            this.HeightTree = 0;
        }

        public void Cut(Lumberjack l, CuttingDownEventArgs cdargs) {
            if(this.HeightTree > 0) {
                if(cdargs.length > this.HeightTree) {
                        Console.WriteLine("{0} height is lower than inputed log length | {1}",this.Genus,cdargs.length);
                        return;
                }
                for(int i = 0; i < cdargs.number;i++) {
                    if(this.HeightTree - cdargs.length < 0) {
                        Console.WriteLine("{0} can't be cut down anymore, {1} meters left",this.Genus,this.HeightTree);
                        break;
                    }
                    this.HeightTree -= cdargs.length;
                    Console.WriteLine("Lumberjack {0} is cutting down a {1}, {2} meters left",l.name,this.Genus,this.HeightTree);
                }
            } else 
                Console.WriteLine("{0} height <= 0, so it cant be cutted down",l.name,this.Genus);
        }
    }
}

