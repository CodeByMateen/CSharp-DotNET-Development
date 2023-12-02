using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Groceries : Item
    {
        string _dateOfExpiry; /// <summary>
        /// grocery expiry date
        /// </summary>

        public Groceries() { }
        public Groceries(int id, string name, string color, string brandName, float price, string dateOfExpiry) : base(id, name, color, brandName, price)
        {
            this._dateOfExpiry = dateOfExpiry;
        }

        public string DateOfExpiry { get => _dateOfExpiry; set => _dateOfExpiry = value; }

        public override void DisplayInfo()
        {
            Console.WriteLine("\n<----------Grocery Info---------->");
            base.DisplayInfo();
            Console.WriteLine("Item Date of Expiry: " + _dateOfExpiry);
        }

    }
}
