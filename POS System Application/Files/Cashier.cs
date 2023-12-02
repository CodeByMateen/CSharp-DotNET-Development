using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Cashier
    {
        float _totalPrice;
        int _totalItems;

        private List<Item> _customerCart;

        public Cashier()
        {
            _customerCart = new List<Item>();
            TotalPrice = 0;
            TotalItems = 0;
        }

        public float TotalPrice { get => _totalPrice; set => _totalPrice = value; }
        public int TotalItems { get => _totalItems; set => _totalItems = value; }

        public void CalculatedPrice(List<Item> _shoppingCart)
        {
            foreach(Item item in _shoppingCart)
            {
                TotalPrice += item.Price;
                _customerCart.Add(item);
                TotalItems += 1;
            }
            _shoppingCart.Clear();
        }

        public virtual void DisplayReceipt()
        {
            foreach(Item item in _customerCart)
            {
                item.DisplayInfo();
            }

            ClearRecord();
        }

        public int GetItems()
        {
            return TotalItems;
        }

        public float GetPrice()
        {
            return TotalPrice;
        }

        public void ClearRecord()
        {
            _customerCart.Clear();
            TotalItems = 0;
            TotalPrice = 0;
        }
        public List<Item> GetSelectedCart()
        {
            return _customerCart;
        }

    }
}
