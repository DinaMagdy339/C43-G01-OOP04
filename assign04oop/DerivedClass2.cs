using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign04oop
{
    internal class DerivedClass2 : BaseClass
    {
        new public void DisplayMessage() 
        {
            Console.WriteLine("Message from DerivedClass2");
        }
    }
}
