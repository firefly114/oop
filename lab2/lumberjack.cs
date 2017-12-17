using System;
using System.Collections.Generic;
using System.Text;

namespace lab2
{    public class CuttingDownEventArgs : EventArgs
    {
        public int length;

        public int number;

        public CuttingDownEventArgs(int length, int number)
        {
            this.length = length;
            this.number = number;
        }

        public CuttingDownEventArgs() : this(1,1) { }
    }
    public delegate void CuttingHandle(Lumberjack l, CuttingDownEventArgs cdargs);

    public class Lumberjack {
        public string name;
        public event CuttingHandle LumberjackCuttingDownEvent;

        public Lumberjack(string name)
        {
            this.name = name;
        }

        public void CuttingDown() {
            int length;
            int num;
            CuttingDownEventArgs cdargs;
            try {
                Console.Write("Enter length of log: ");
                length = Int32.Parse(Console.ReadLine());
                Console.Write("Enter number of logs: ");
                num = Int32.Parse(Console.ReadLine());
                cdargs = new CuttingDownEventArgs(length,num);
            }catch {
                cdargs = new CuttingDownEventArgs();
            }
            if(LumberjackCuttingDownEvent != null)
                LumberjackCuttingDownEvent((Lumberjack)this,cdargs);
        }

    }
}