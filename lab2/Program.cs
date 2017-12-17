using System;

using System.Collections;
using System.Collections.Generic;
public enum Colors{
    Brown = 0, White = 1, Beige = 2, IntensityBrown = 3, Sand = 4, LightBrown = 5 
}

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Lumberjack la = new Lumberjack("zdarovaa");
            Oak T = new Oak(10,300,50,la);
            la.CuttingDown();
            T.Print();
            Console.WriteLine("{0} площа поперечного перерізу\n",T.crossSectionSquare());
            
            Log l = new Log(4,100,"oak",80,300,40);
            try{
                List<Log> logs = T.CutDown<Log>(l);
                for (int i = 0; i < logs.Count;i++)
                    logs[i].Print();
            } catch(HeightLogException e) {
                Console.WriteLine("{0}", e);
                int height = 2*e.LogLength;
                Console.WriteLine("Height of tree must be {0} meters high or more",height);
            }

            Plank p = new Plank(l.Length,20,10);
            Parquet par = new Parquet(Colors.Brown,p.Length,p.Width,p.Thickness);
            Console.WriteLine("{0}",par.Color);
            par.Dyeing(Colors.Beige);
            Console.WriteLine("{0}",par.Color);
            Console.WriteLine("{0}",par.Burning());
        }
    }
}
