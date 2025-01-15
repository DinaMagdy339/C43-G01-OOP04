using System.ComponentModel;
using System.Numerics;

namespace assign04oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            //Console.WriteLine($"Sum 3 int num = {Calculator.Add(3, 4, 6)}");
            //Console.WriteLine($"Sum 2 int num = {Calculator.Add(3, 4)}");
            //Console.WriteLine($"Sum 2 double num = {Calculator.Add(3.77, 6)}");

            #endregion

            #region Q2

            //Rectangle Rect = new Rectangle() ;
            //Console.WriteLine($"Width = {Rect.width} , Height = {Rect.height}");
            //Rectangle Rect01 = new Rectangle(12,4);
            //Console.WriteLine($"Width01 = {Rect01.width} , Height01 = {Rect01.height}");
            //Rectangle Rect02 = new Rectangle(5);
            //Console.WriteLine($"Width02 = {Rect02.width} , Height02 = {Rect02.height}");

            #endregion

            #region Q3

            //Complex c1 = new Complex() { Real=7 , Img=3};
            //Complex c2 = new Complex() { Real=5 , Img=2};
            //Complex? c3 = default;
            //    c3 = c1 + c2;
            //Complex? c4 = default;
            //    c4 = c1 - c2;
            //Console.WriteLine($"c1 = {c1}");
            //Console.WriteLine($"c2 = {c2}");
            //Console.WriteLine($"c3 = {c3}");
            //Console.WriteLine($"c4 = {c4}");
            #endregion

            #region Q4

            //Employee employee = new Employee();
            //employee.Work();
            //Manager manager = new Manager();
            //manager.Work();
            #endregion

            #region Q5

            //BaseClass Base = new BaseClass();
            //Base.DisplayMessage();
            //DerivedClass1 Derived = new DerivedClass1();
            //Derived.DisplayMessage();
            //DerivedClass2 Derived2 = new DerivedClass2();
            //Derived2.DisplayMessage();

            ////override: Maintains polymorphism and uses runtime binding.
            ////new: Breaks polymorphism and uses compile - time binding, making the method in the derived class independent of the base class's method.

            #endregion

            #region part02

            //Duration D = new Duration(1, 10, 15);
            //Console.WriteLine(D.ToString());
            //Duration D1 = new Duration(3600);
            //Console.WriteLine(D1.ToString());
            //Duration D2 = new Duration(7800);
            //Console.WriteLine(D2.ToString());
            //Duration D3 = new Duration(666);
            //Console.WriteLine(D3.ToString());
            //D3 = D1 + D2;
            //Console.WriteLine(D3.ToString());
            //D3 = D1 + 7800;
            //Console.WriteLine(D3.ToString());
            //D3 = 666 + D3;
            //Console.WriteLine(D3.ToString());
            //D3 = ++D1;
            //Console.WriteLine(D3.ToString());
            //D3 = --D2;
            //Console.WriteLine(D3.ToString());
            //D1 = D1 - D2;
            //Console.WriteLine(D3.ToString());
            //if (D1>D2)
            //Console.WriteLine("D1>D2");
            //if (D1<=D2)
            //Console.WriteLine("D1<=D2");
            //DateTime Obj = (DateTime)D1;
            //Console.WriteLine(Obj);

            #endregion

        }
    }
}