using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class ShoppingReportGeneration : Cashier
    {
        int _items;
        float _price;

        float _finalPrice;
        int _invoiceID;
        float _discount;
        float _tax;
        float _coupon;
        float _bundleOffer;

        Random rnd = new Random();

        public ShoppingReportGeneration(int items, float price) 
        {
            this.Items = items;
            this.Price = price;
        }
        public float FinalPrice { get => _finalPrice; set => _finalPrice = value; }
        public int InvoiceID { get => _invoiceID; set => _invoiceID = value; }
        public float Discount { get => _discount; set => _discount = value; }
        public float Tax { get => _tax; set => _tax = value; }
        public float Coupon { get => _coupon; set => _coupon = value; }
        public float BundleOffer { get => _bundleOffer; set => _bundleOffer = value; }
        public int Items { get => _items; set => _items = value; }
        public float Price { get => _price; set => _price = value; }

        public void CalculateReceipt()
        {
            if(Items > 1 && Items < 4)
            {
                BundleOffer = (Price * 10) / 100;
            }

            if(Items > 3)
            {
                BundleOffer = (Price * 20) / 100;
            }

            Tax = (Price * 3) / 100;

            InvoiceID = rnd.Next(100000, 199999);
            Coupon = rnd.Next(100000, 300000);
        }

        public override void DisplayReceipt()
        {
            Console.WriteLine("Invoice ID: " + InvoiceID);
            Console.WriteLine("Invoice Coupon: " + Coupon);
            Console.WriteLine("Total Items Purchased: " + Items);
            Console.WriteLine("Total Price: $" + Price);

            if (Items > 1 && Items < 4)
            {
                Console.WriteLine("Bundle Discount Given: $" + BundleOffer);
            }
            if (Items > 3)
            {
                Console.WriteLine("Bundle Discount Given: $" + BundleOffer);
            }

            Console.WriteLine("Item Tax: $" + Tax);
            Console.WriteLine("Final Price: $" + ((Price + Tax) - BundleOffer));

        }

    }
}
