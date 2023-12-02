using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Clothes : Item
    {
        string _clothStyle; // specialized attribute
        // it defines if shirt -> tshirt, fullshirt, casual shirt || pant-> Jeans, Plain || Shoe -> Fleet, Sneakers

        public Clothes() { }
        public Clothes(int id, string name, string color, string brandName, float price, string clothStyle) : base(id, name, color, brandName, price)
        {
            this._clothStyle = clothStyle;
        }

        public string ClothStyle { get => _clothStyle; set => _clothStyle = value; }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n<----------Cloth Info---------->");
            base.DisplayInfo();
            Console.WriteLine("Cloth Style: " + _clothStyle);
        }

    }
}
