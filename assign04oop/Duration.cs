using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign04oop
{
    internal class Duration
    {
        #region Attributes
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }
        #endregion

        #region Override

        public override string ToString()
        {
            if (Hours > 0)
                return $"Hours: {Hours} , Minutes: {Minutes} , Seconds: {Seconds}";
            else
                return $"Minutes: {Minutes} , Seconds: {Seconds}";
        }
        public override bool Equals(object? obj)
        {

            if (obj is Duration D)
            {
                return Hours == D.Hours && Minutes == D.Minutes && Seconds == D.Seconds;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        #endregion

        #region Constructor
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public Duration(int TotalSeconds)
        {
            Hours = TotalSeconds / 3600;
            TotalSeconds %= 3600;
            Minutes = TotalSeconds / 60;
            Seconds = TotalSeconds % 60;
        }
        #endregion

        #region Overloding

        public static Duration operator +(Duration d1, Duration d2)
        {
            int seconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) + (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);

            return new Duration(seconds);
        }
        public static Duration operator +(Duration d1, int num)
        {
            int seconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) + num;

            return new Duration(seconds);
        }
        public static Duration operator +(int num, Duration d1)
        {
            int seconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) + num;

            return new Duration(seconds);
        }
        public static Duration operator -(Duration d1, Duration d2)
        {
            int seconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) - (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds);

            return new Duration(seconds);
        }

        public static Duration operator ++(Duration d1)
        {
            int seconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) + 60;
            return new Duration(seconds);
        }

        public static Duration operator --(Duration d1)
        {
            int seconds = (d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) - 60;
            return new Duration(seconds);
        }

        public static bool operator >(Duration d1, Duration d2)
        { 
            if ((d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) > (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds))
                return d1 > d2;
            else
                return d2 > d1;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            if ((d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) < (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds))
                return d1 < d2;
            else
                return d2 < d1;
        }

        public static bool operator <=(Duration d1, Duration d2)
        { 
            if ((d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) <= (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds))
                return d1 <= d2;
            else 
                return d2 <= d1;
        }
        public static bool operator >=(Duration d1, Duration d2)
        {
            if ((d1.Hours * 3600 + d1.Minutes * 60 + d1.Seconds) >= (d2.Hours * 3600 + d2.Minutes * 60 + d2.Seconds))
                return d1 >= d2;
            else
                return d2 >= d1;
        }
        public static explicit operator DateTime (Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }
        public static implicit operator int(Duration d)
        {
            return (d.Hours * 3600 + d.Minutes * 60 + d.Seconds);
        }

        #endregion

    }
}
    

