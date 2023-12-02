using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Item
    {
        int _id;
        string _name;
        string _color;
        string _brandName;
        float _price;

        // For Discounts or other Promotional things

        //float _itemDiscount;
        //float _itemTax;
        //float _itemPromotion;
        //float _itemBundleDiscount;

        public Item() { }

        public Item(int id, string name, string color, string brandName, float price)
        {
            this._id = id;
            this._name = name;
            this._color = color;
            this._brandName = brandName;
            this._price = price;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Color { get => _color; set => _color = value; }
        public string BrandName { get => _brandName; set => _brandName = value; }
        public float Price { get => _price; set => _price = value; }
        //public float ItemDiscount { get => _itemDiscount; set => _itemDiscount = value; }
        //public float ItemTax { get => _itemTax; set => _itemTax = value; }
        //public float ItemPromotion { get => _itemPromotion; set => _itemPromotion = value; }
        //public float ItemBundleDiscount { get => _itemBundleDiscount; set => _itemBundleDiscount = value; }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Item Name: {this._name}");
            Console.WriteLine($"Item ID:  {this._id}");
            Console.WriteLine($"Item Brand: {this._brandName}");
            Console.WriteLine($"Item Color: {this._color}");
            Console.WriteLine($"Item Price: ${this._price}");
        }

    }
}
