using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Customer
    {
        string name;
        string phone;
        int _itemCount;
        bool _check;

        private List<Item> _shoppingCart;

        public Customer() 
        {
            _shoppingCart = new List<Item>();
            _itemCount = 0;
        }

        public string Name { get => name; set => name = value; }
        public string Phone { get => phone; set => phone = value; }
        public int ItemCount { get => _itemCount; set => _itemCount = value; }

        // Methods

        public void AddItem(int id, List<Item> _inventory)
        {
            foreach(Item item in _inventory)
            {
                if (item.Id == id)
                {
                    _shoppingCart.Add(item);
                    _inventory.Remove(item);
                    ItemCount += 1;
                    break;
                }
            }
        }

        public void DropItem(int id, List<Item> _inventory)
        {
            _check = false;
            foreach(Item item in _shoppingCart)
            {
                if (item.Id == id)
                {
                    _inventory.Add(item);
                    _shoppingCart.Remove(item);
                    ItemCount -= 1;

                    Console.WriteLine("\nData Removed Successfully...");
                    return;
                }
            }

            if (_check == false)
            {
                Console.WriteLine("\nData Not Found...");
            }
        }

        public void CheckOut() 
        {
            // It's code is written beneath in GetShopping Cart
        }

        public void DisplayItems()
        {
            Console.WriteLine("\nTotal Items in Inventory: " + ItemCount);
            foreach (Item item in _shoppingCart)
            {
                item.DisplayInfo();
            }
        }

        public List<Item> GetShoppingCart()
        {
            return _shoppingCart;
        }
    }
}
