using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssigmentOOP05.Third
{
    internal class Duration
    {
        private int hours;
        public int Hours { get { return hours; } set { hours = value; } }
        private int minutes;
        public int Minutes { get 
            { 
                return minutes; 
            } 
            set{ minutes = value ; } }
        private int second;
        public int Second
        {
            get { return second; }
            set { second = value ; }
        }
        public Duration()
        {
            
        }
        public Duration(int second)
        {

            Hours = second / 3600;

            Second = second - (Hours * 3600);
            Minutes = Second / 60;
            Second = Second - (Minutes * 60);



        }

        public Duration(int hours, int minutes, int second)
        {
            Hours = hours;
            Minutes = minutes;
            Second = second;
        }
        /* Second = (second/3600) */
        //Minutes =( second - (Hours * 3600))/60 ;
        //public Duration(int second )
        //{
          
        //    Hours = second/3600;
            
        //    Second = second - (Hours * 3600);
        //    Minutes = Second / 60;
        //    Second = second - (Minutes * 60);
            
           
                 
        //}
       

        public override string ToString()
        {
            return $"Hours = {Hours} , Minutes = {Minutes} , Second = {Second}";
        }
        public static Duration operator +(Duration X , Duration Y )
        {
            return new Duration()
            {
                Hours =X?.Hours??0 + Y?.Hours??0 ,
                Minutes = X?.Minutes??0 + Y?.Minutes ??0,
                second = X?.second??0 + Y?.Second??0
            };
        }
        
        public static Duration operator -(Duration X , Duration Y )
        {
            return new Duration()
            {
                Hours = X?.Hours ?? 0 - Y?.Hours ?? 0,
                Minutes = X?.Minutes ?? 0 - Y?.Minutes ?? 0,
                second = X?.second ?? 0 - Y?.Second ?? 0
            };
        }
        public static Duration operator ++(Duration D)
        {
            return new Duration()
            {
                Hours = D?.Hours +  1 ??0,
                Minutes = D?.Minutes+1??0,
                Second = D?.Second +1 ??0
            };
        }
        public static Duration operator --(Duration D)
        {
            return new Duration()
            {
                Hours = D?.Hours - 1 ?? 0,
                Minutes = D?.Minutes - 1 ?? 0,
                Second = D?.Second - 1 ?? 0
            };
        }
        public static bool operator >(Duration X, Duration Y)
        {
            if (X.Hours == Y.Hours)
                return X.Minutes > Y.Minutes;
            else if (X.Minutes == Y.Minutes)
                return X.second > Y.Second;
            else
                return X.Hours > Y.Hours;
        }
        public static bool operator <(Duration X, Duration Y)
        {
            if (X.Hours == Y.Hours)
                return X.Minutes < Y.Minutes;
            else if (X.Minutes == Y.Minutes)
                return X.second < Y.Second;
            else
                return X.Hours < Y.Hours;
        }
        public static bool operator <=(Duration X, Duration Y)
        {
            if (X.Hours == Y.Hours)
                return X.Minutes <= Y.Minutes;
            else if (X.Minutes == Y.Minutes)
                return X.second <= Y.Second;
            else
                return X.Hours <= Y.Hours;
        }
        public static bool operator >=(Duration X, Duration Y)
        {
            if (X.Hours == Y.Hours)
                return X.Minutes >= Y.Minutes;
            else if (X.Minutes == Y.Minutes)
                return X.second >= Y.Second;
            else
                return X.Hours >= Y.Hours;
        }
        public static  explicit operator DateTime (Duration X)
        {
            return new DateTime(X.Hours);
        }
    }
}
