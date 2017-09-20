using System;
using System.Diagnostics;

namespace Concepts
{
    delegate int TheSquarer(int x);
    class Program
    {
        //Changed in remote repository
        static void Main(string[] args)
        {
            TheSquarer ts = x => x * x;
            int result = ts(5);
            Debug.WriteLine("Result:" + result);

            Func<int> func0 = F0;
            Debug.WriteLine("F0:" + func0());

            Func<int, string> func1 = F1;
            Debug.WriteLine("F1:" + func1(12));

            Func<int, long, string> func2 = F2;
            Debug.WriteLine("F2:" + func2(12, 38));

            // Declare an instance of Product and display its initial values.
            Product item = new Product("Fasteners", 54321);
            Debug.WriteLine("Original values in Main.  Name: {0}, ID: {1}\n", item.ItemName, item.ItemID);

            // Pass the product instance to ChangeByReference.
            ChangeByReference(ref item);
            Debug.WriteLine("Back in Main after ChangeByReference, pointing to new object.  Name: {0}, ID: {1}\n", item.ItemName, item.ItemID);

            // Pass the product instance to Change.
            Change(item);
            Debug.WriteLine("Back in Main after Change, Not pointing to new object.  Name: {0}, ID: {1}\n", item.ItemName, item.ItemID);
        }

        private static int F0()
        {
            return int.MaxValue;
        }

        private static string F1(int v)
        {
            return "Value passed to F1 is: " + v;
        }

        private static string F2(int v1, long v2)
        {
            return string.Format("Sum of {0} and {1} is {2}", v1, v2, v1+v2);
        }
        static void ChangeByReference(ref Product itemRef)
        {
            // Change the address that is stored in the itemRef parameter.   
            itemRef = new Product("Stapler", 99999);

            // You can change the value of one of the properties of
            // itemRef. The change happens to item in Main as well.
            itemRef.ItemID = 12345;
        }

        static void Change(Product item)
        {
            // Create new object and point it to item.   
            // item is a local variable that was pointing to item in main but now its pointing to new object 
            item = new Product("GlueStick", 88888);

            // change value.
            item.ItemID = 12345;
            Debug.WriteLine("In Change, showing local new object.  Name: {0}, ID: {1}\n", item.ItemName, item.ItemID);
        }
    }

    class Product
    {
        public Product(string name, int newID)
        {
            ItemName = name;
            ItemID = newID;
        }

        public string ItemName { get; set; }
        public int ItemID { get; set; }
    }
}
