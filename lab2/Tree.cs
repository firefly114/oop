using System;
using System.Collections;
using System.Collections.Generic;

namespace lab2
{
    public abstract class Tree
    {
        private string genus;
        private int diameter;
        private int age;
        private int heightTree; 
        
        protected string Genus { get => genus; set => genus = value; }
        protected int Diameter { get => diameter; set => diameter = value; }
        protected int Age { get => age; set => age = value; }
        public int HeightTree { get => heightTree; set => heightTree = value; }

        public Tree(string genus, int diameter, int age, int height) {
            this.Genus = genus;
            this.Diameter = diameter;
            this.Age = age;
            this.HeightTree = height;
        }

        
        public Tree() {
            this.Genus = "undefined";
            this.Diameter = 0;
            this.Age = 0;
            this.HeightTree = 0;
        }

        public double crossSectionSquare() {
            return Math.PI*Math.Pow(Diameter/2,2);
        }

        public virtual List<Log> CutDown(int lengthLog) {
            if(2*lengthLog >= this.heightTree) {
                   throw new HeightLogException("Log is too long, it have to be 2 times lower than hieght of tree",lengthLog);
            } else {
                var logs = new List<Log>();
                for(int i = 0; i < this.HeightTree/lengthLog;i++) 
                    logs.Add(new Log(lengthLog,60,this.genus,this.diameter, this.age,this.HeightTree));
                return logs;
            }
        }

        public virtual List<Log> CutDown<T>(T log)where T:Log {
            if(2*log.Length >= this.heightTree) {
                   throw new HeightLogException("Log is too long, it have to be 2 times lower than hieght of tree",(int)log.Length);
            } else {
                var logs = new List<Log>();
                for(int i = 0; i < this.HeightTree/log.Length;i++) 
                    logs.Add(new Log(log.Length,60,this.genus,this.diameter, this.age,this.HeightTree));
                return logs;
            }
        }
        public virtual void Print() {
            Console.WriteLine("{0}\n{1} years\n{2} cm\n{3} m\n",this.Genus,this.Age,this.Diameter,this.HeightTree);
        }
    }
}

