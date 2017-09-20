using System.Diagnostics;

namespace Concepts.ConceptImplementation
{
    internal class RefConcept : ConceptBase
    {
        public RefConcept(string description, bool run) :
            base(description, run)
        {
        }

        protected override void TestConcept()
        {
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
}
