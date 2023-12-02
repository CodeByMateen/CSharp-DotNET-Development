using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Electonics : Item
    {
        string _warranty; // specialized attribute


        public Electonics() { }
        public Electonics(int id, string name, string color, string brandName, float price , string warranty) : base(id, name, color, brandName, price)
        {
            this._warranty = warranty;
        }

        public string Warranty { get => _warranty; set => _warranty = value; }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n<----------Electronic Info---------->");
            base.DisplayInfo();
            Console.WriteLine("Item Warranty: " + _warranty);
        }

    }
}
