using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign04oop
{
    internal class Rectangle
    {
        #region Attributes
        public int width { get; set; }
        public int height { get; set; }
        #endregion

        #region constructor

        public Rectangle() { }

        public Rectangle(int Width, int Height)
        {
            width = Width;
            height = Height;
        }

        public Rectangle(int num)
        {
            width = num;
            height = num;
        }
        #endregion
    }
}
