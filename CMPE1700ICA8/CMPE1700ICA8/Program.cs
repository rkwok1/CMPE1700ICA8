using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace CMPE1700ICA8
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> intlink = new LinkedList<int>();
            int value = 0;
        
            AddItem(intlink, value);
            PopulateList(intlink, value);
            PrintList(intlink);

            if (Debugger.IsAttached)
            {
                Console.ReadKey();
            }
        }
        ////////////////////////////////Methods\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        /*********************************************************************************************
         * Method: AddItem
         * Effect: will accept a LinkedList<int> and a int and add the integer to the end of the List
         * *******************************************************************************************/
         public static LinkedList<int> AddItem(LinkedList<int> list, int value)
        {
            
            list.AddLast(value);
            return list;
        }


        /*********************************************************************************************
         * Method: PopulateList
         * Effect: Accepts a linked list<int> and performs the following
         * a.) Use addItem to add 100 random integers in range 0 to 99
         * b.) Add 5 copies of the value -1 to the head of the list
         * c.) Add 5 copies the value 100 to the end of the list
         *********************************************************************************************/
        public static LinkedList<int> PopulateList(LinkedList<int> list, int value)
        {
            Random rnd = new Random();
            
            for (int i = 0; i < 101; i++)
            {
                value = rnd.Next(0, 100);
                list.AddLast(value); //Uses AddItem 100 random integers in range 0 to 99
            }
            for (int i = 0; i < 5; i++)
            {
                list.AddFirst(-1); // Add 5 copies of the value -1 to end of list
                list.AddLast(100); // Add 5 copies of the value 100 to end of list
            }
            return list;
        }

        /*********************************************************************************************
         * Method: PrintList
         * Effect: accepts a LinkedList<int> and print the values of it's contents, in order, space
         * delimited, to the console.
         * ********************************************************************************************/
         public static void PrintList(LinkedList<int> list)
        {
            foreach(int i in list)
            {
                Console.Write(i + " ");
            }
        }
    }
}
