using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign04oop
{
    internal class Complex
    {
        public int Real {  get; set; }
        public int Img { get; set; }

        public static Complex operator +(Complex a, Complex b)
        {
            return new Complex
            {
                Real = (a?.Real?? 0) +(b?.Real?? 0),
                Img = (a?.Img?? 0) + (b?.Img?? 0)
            };
        }
        public static Complex operator -(Complex a, Complex b)
        {
            return new Complex 
            {
                Real = (a?.Real?? 0) - (b?.Real??0),
                Img = (a?.Img?? 0) - (b?.Img?? 0)
            };
        }
        public override string ToString()
        {
            return $"{Real} + {Img}i";
        }
    }
}
