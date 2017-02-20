using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructorExample
{
    /*A constructor is a special member function that is executed whenever
     create new objects of that class
     Constrcutor has the same name as class and does not have a return type*/

    class Program
    {
        private double length;//length of a line
        public Program()//created constructor of the class
        {
            Console.WriteLine("Object is being created");
        }

        public void setLength(double len)
        {
            length = len;
        }

        public double getLength()
        {
            return length;
        }

        static void Main(string[] args)//main method
        {
            Program Line = new Program();

            //set line length
            Line.setLength(6.0);
            Console.WriteLine("Length of line is: {0}", Line.getLength());
            Console.ReadKey();
        }
    }
}
