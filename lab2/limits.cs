using System;

namespace lab2
{    public class Limits
    {
        public static double Par_Min_Width;
        public static double Par_Max_Width;
        public static double Par_Max_Thickness;
        public static double Par_Max_Length;
        public static int Par_Standart_Bough;
        public static double Log_Max_Length;
        public static int House_Max_Floors;

        static Limits() {
            Par_Max_Width = 1.2;
            Par_Max_Length = 5.0;
            Par_Max_Thickness = 0.08;
            Par_Min_Width = 0.1;
            Par_Standart_Bough = 1;
            Log_Max_Length = 7;
            House_Max_Floors = 7;
        }
    }
}
