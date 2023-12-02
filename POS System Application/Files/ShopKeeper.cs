using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class ShopKeeper
    {
        int _itemCount;
        bool _check;

        private List<Item> _inventory;

        public ShopKeeper()
        {
            _inventory = new List<Item>();
            _itemCount = 0;
        }

        public int ItemCount { get => _itemCount; set => _itemCount = value; }

        public void AddItem(Item item)
        {
            _inventory.Add(item);
            _itemCount += 1;
        }

        public void RemoveItem(int id)
        {
            _check = false;
            foreach(Item item in _inventory)
            {
                if (item.Id == id)
                {
                    _check = true;
                    _inventory.Remove(item);
                    _itemCount -= 1;

                    Console.WriteLine("\nData Removed Successfully...");
                    return;
                }
            }

            if(_check == false)
            {
                Console.WriteLine("\nData Not Found...");
            }
        }

        public void UpdateItem(int id, float price)
        {
            _check = false;
            foreach (Item item in _inventory)
            {
                if (item.Id == id)
                {
                    item.Price = price; //just updating price for now
                    Console.WriteLine("\nPrice Updated Successfully...");
                    return;
                }
            }

            if (_check == false)
            {
                Console.WriteLine("\nData Not Found...");
            }
        }

        public void DisplayItems()
        {
            Console.WriteLine("Total Items in Inventory: " + _itemCount);
            foreach(Item item in _inventory)
            {
                item.DisplayInfo();
            }
        }

        public List<Item> GetInventory()
        {
            return _inventory;
        }
    }
}