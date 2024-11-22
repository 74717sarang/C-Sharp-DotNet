
using System.Diagnostics;

namespace catlog
{
    public class product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double price { get; set; }

        public double quantity { get; set; }

        public double priceRate = 11; 

        public product() { }


        public product(int id, string name, string desc, double price, double qty)
        {
            Id = id;
            Name = name;
            Description = desc;
            this.price = price;
            quantity = qty;
        }

        public static void displayPriduct()
        {
            Console.WriteLine("hii from product");
            Console.WriteLine("Product Details:");
           
        }






    }
}
