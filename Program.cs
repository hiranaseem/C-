using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseString2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string to reverse");//entered string
            String str = Console.ReadLine();//read in string


            char[] array=str.ToCharArray();
            char[] result = new char[array.Length];

            for (int i = 0, j = str.Length - 1; i < str.Length; i++, j--)
            {

                result[i] = array[j];

            }
            foreach(char item in result)
            {
                Console.WriteLine(item);
            }


            /*int num = str.Length;//stored length of string

            String[] array = new String[num];//created array of string length
            array = str.Split(',');//inserted string into array

           

            foreach(string item in array)
            {
                Array.Reverse(array);
                Console.WriteLine(item);
            }
            */
            

        }
    }
}
