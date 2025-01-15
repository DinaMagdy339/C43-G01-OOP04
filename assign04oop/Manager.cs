using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign04oop
{
    internal class Manager : Employee
    {
       new  public void Work()
        {
            Console.WriteLine("Manager is managing");       
        }
    }
}
