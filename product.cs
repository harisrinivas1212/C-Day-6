using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    public class Product
    {
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public Dictionary<string,int> data { get; set; }
        public void InputDeatils()
        {
            Dictionary<string, int> data = new Dictionary<string, int>();
            Console.WriteLine("Enter the no.of Products to be entered to the collection : ");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter the Product Name : ");
                ProductName = Console.ReadLine();
                Console.Write("Enter the Quantity of the Product : ");
                Quantity = Convert.ToInt32(Console.ReadLine());

                data.Add(ProductName, Quantity); //adding each product to the dictionary
            }
            Console.WriteLine("INVOICE");
            Console.WriteLine("\n S.No \t\t Product Name \t\t Quantity");
            int index = 1;
            foreach (var item in data)
            {
                Console.Write(index);
                Console.Write("\t\t");
                Console.Write(item.Key);
                Console.Write("\t\t\t\t");
                Console.Write(item.Value);
                Console.WriteLine();
                index = index + 1;
            }
        }
        public static void Main()
        {
            Product obj1 = new Product();
            obj1.InputDeatils();
        }
    }
}