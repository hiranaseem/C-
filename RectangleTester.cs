using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baseClassExample
{
    /*Sample program to see how a base class works*/
  
    class Shape
    {
        public void setWidth(int w)//whatever value is taken in for w, set it as width
        {
            width = w;
        }

        public void setHeight(int h)//whatever value is taken in for l, set it ot length
        {
            height = h;
        }

        protected int width;//initialised width
        protected int height;//initialised height
    }

    //Derived class 

    class Rectangle : Shape//class Shape is derived from Rectangle
    {
        public int getArea()//method to get area of shape
        {
            return (width * height);//returns an int of width*height
        }
    }
    
    class RectangleTester//Main Method
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();//Create a new object of type Rectangle
            rect.setWidth(4);//set width to 4
            rect.setHeight(5);//set height to 5

            Console.WriteLine("Total area is: {0}", rect.getArea());//total are of rect is
            Console.ReadKey();
        }
    }
}
