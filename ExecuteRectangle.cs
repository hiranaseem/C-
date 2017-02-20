using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseClassExample2
{
    class Rectangle
    {
        //member variables
        protected double length;//initialised length
        protected double width;//initialised width
        public Rectangle(double l, double w)//constructor that takes in l, w
        {
            length = l;//set length to l
            width = w;//set width to w
        }

        public double GetArea()//method to get GetArea
        {
            return length * width;//returns length*width
        }

        public void Display()//method to display
        {
            Console.WriteLine("Length: {0}", length);//display length
            Console.WriteLine("Width: {0}", width);//display width
            Console.WriteLine("Area: {0}", GetArea());//display area
        }
    }//end class Rectangle  

    class Tabletop : Rectangle//Class Tabletop is derived from Rectangle
    {
        private double cost;//initialised a variable cost

        /*the "base" keyword allows access to any of the public 
        and protected members of the base class*/
        public Tabletop(double l, double w):base(l, w)//constructor
        { }
        public double GetCost()//method to find cost of tabletop
        {
            double cost;
            cost = GetArea() * 70;//cost = area * 70;
            return cost;//return cost
        }
        public void Display()//method to display cost
        {
            base.Display();
            Console.WriteLine("Cost: {0}", GetCost());
        }
    }
    class ExecuteRectangle//Main class
    {
        static void Main(string[] args)
        {
            Tabletop t = new Tabletop(4.5, 7.5);//initialise t of type Tabletop
            t.Display();//display cost of t
            //t.GetCost();
            Console.ReadLine();
        }
    }
}