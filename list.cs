using System;
using System.Collections.Generic;
using System.Text;

namespace Day6
{
    class Program
    {
        static void Main()
        {
            List<int> myList = new List<int>();
            Console.WriteLine("Enter the elements of the list : ");
            for (int i=0; i<5; i++)
            {
                myList.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Elements of the list");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
            int odd_count = 0;
            int even_count = 0;
            foreach (var item in myList)
            {
                if(item%2==0)
                {
                    Console.WriteLine(item+" is even");
                    even_count++;
                }
                else
                {
                    Console.WriteLine(item + " is odd");
                    odd_count++;
                }
            }
            Console.WriteLine("Total Even Numbers : " + even_count);
            Console.WriteLine("Total Even Numbers : " + odd_count);
        }
    }
}