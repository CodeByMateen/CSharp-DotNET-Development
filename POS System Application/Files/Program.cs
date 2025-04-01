using System; 
using System.Collections.Generic;

// Main Driver Class or POS System Class

/// <summary>

/// 1. Item class is Parent class of Clothes, Electronics, Groceries(like packages stuffs e.g oil, soup, noodels)

/// 2. Shopkeeper will add items so Items will have composition relation on it

/// </summary>

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {

            Item item;
            ShopKeeper shopkeeper = new ShopKeeper();
            Customer customer = new Customer();
            Cashier cashier = new Cashier();
            ShoppingReportGeneration receipt;

            List<Item> _maininventory;
            List<Item> _shoppingCart;

            item = new Electonics(1101, "Iron", "Silver", "Philips", 7.8f, "12 Months");
            shopkeeper.AddItem(item);
            item = new Clothes(2101, "Shirt", "Black", "Levis", 3.4f, "Formal");
            shopkeeper.AddItem(item);
            item = new Groceries(3101, "Ketchup", "Red", "National", 2.3f, "16 Months");
            shopkeeper.AddItem(item);
            item = new Clothes(2102, "Pant", "Grey", "US Polo", 4.3f, "Dress");
            shopkeeper.AddItem(item);



            char press;
            bool loop = true;
            int counter = 3;

            while (loop)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t\t------------------Welcome To POS System------------------");
                Console.WriteLine("\n");
                Console.WriteLine("Press 1. If you're ShopKeeper!");
                Console.WriteLine("Press 2. If your're Customer");
                Console.WriteLine("Press 3 to Exit Program!");

                press = Console.ReadKey().KeyChar;
                switch (press)
                {
                    case '1':
                        Console.Clear();
                        string username, password;

                        int id;
                        string name, color, brandName;
                        float price;

                        Console.Write("Enter Username: ");
                        username = Console.ReadLine();
                        Console.Write("Enter Password: ");
                        password = Console.ReadLine();

                        if(username == "admin" && password == "123")
                        {
                            Console.Clear();

                            Console.WriteLine("WELCOME SIR!");
                            Console.WriteLine("What do you like to do?");
                            Console.WriteLine("Press 1. To Add Item in Inventory!");
                            Console.WriteLine("Press 2. To Remove Item in Inventory!");
                            Console.WriteLine("Press 3. To Update Item Price in Inventory!");
                            Console.WriteLine("Press 4. To See Inventory!");
                            Console.WriteLine("Press any other To Exit!");

                            press = Console.ReadKey().KeyChar;
                            switch (press)
                            {
                                case '1':
                                    Console.Clear();
                                    Console.WriteLine("Press 1. To Add Electronics!");
                                    Console.WriteLine("Press 2. To Add Clothes!");
                                    Console.WriteLine("Press 3. To Add Groceries!");

                                    press = Console.ReadKey().KeyChar;
                                    switch (press)
                                    {
                                        case '1':
                                            Console.Clear();
                                            string warranty;

                                            Console.Write("Enter The ID of Electronic: ");
                                            id = int.Parse(Console.ReadLine());
                                            Console.Write("Enter The Name of Electronic: ");
                                            name = Console.ReadLine();
                                            Console.Write("Enter The Color of Electronic: ");
                                            color = Console.ReadLine();
                                            Console.Write("Enter The Brand Name of Electronic: ");
                                            brandName = Console.ReadLine();
                                            Console.Write("Enter The Price of Electronic: ");
                                            price = float.Parse(Console.ReadLine());
                                            Console.Write("Enter The Warranty of Electronic: ");
                                            warranty = Console.ReadLine();

                                            item = new Electonics(id, name, color, brandName, price, warranty);
                                            shopkeeper.AddItem(item);

                                            Console.WriteLine("\nData Inserted Successfully...");
                                            Console.WriteLine("Press Enter to Continue!");
                                            Console.ReadLine();
                                            break;

                                        case '2':
                                            Console.Clear();
                                            string style;

                                            Console.Write("Enter The ID of Cloth: ");
                                            id = int.Parse(Console.ReadLine());
                                            Console.Write("Enter The Name of Cloth: ");
                                            name = Console.ReadLine();
                                            Console.Write("Enter The Color of Cloth: ");
                                            color = Console.ReadLine();
                                            Console.Write("Enter The Brand Name of Cloth: ");
                                            brandName = Console.ReadLine();
                                            Console.Write("Enter The Price of Cloth: ");
                                            price = float.Parse(Console.ReadLine());
                                            Console.Write("Enter The Style of Cloth: ");
                                            style = Console.ReadLine();

                                            item = new Clothes(id, name, color, brandName, price, style);
                                            shopkeeper.AddItem(item);

                                            Console.WriteLine("\nData Inserted Successfully...");
                                            Console.WriteLine("Press Enter to Continue!");
                                            Console.ReadLine();
                                            break;

                                        case '3':
                                            Console.Clear();
                                            string expiry;

                                            Console.Write("Enter The ID of Grocery: ");
                                            id = int.Parse(Console.ReadLine());
                                            Console.Write("Enter The Name of Grocery: ");
                                            name = Console.ReadLine();
                                            Console.Write("Enter The Color of Grocery: ");
                                            color = Console.ReadLine();
                                            Console.Write("Enter The Brand Name of Grocery: ");
                                            brandName = Console.ReadLine();
                                            Console.Write("Enter The Price of Grocery: ");
                                            price = float.Parse(Console.ReadLine());
                                            Console.Write("Enter The Expiry of Grocery: ");
                                            expiry = Console.ReadLine();

                                            item = new Groceries(id, name, color, brandName, price, expiry);
                                            shopkeeper.AddItem(item);

                                            Console.WriteLine("\nData Inserted Successfully...");
                                            Console.WriteLine("Press Enter to Continue!");
                                            Console.ReadLine();
                                            break;

                                    }
                                    break;

                                case '2':

                                    Console.Clear();
                                    Console.Write("Enter The ID of Item to Remove: ");
                                    id = int.Parse(Console.ReadLine());

                                    shopkeeper.RemoveItem(id);
                                    
                                    Console.WriteLine("Press Enter to Continue!");
                                    Console.ReadLine();
                                    break;

                                case '3':

                                    Console.Clear();
                                    Console.Write("Enter The ID of Item to Update: ");
                                    id = int.Parse(Console.ReadLine());
                                    Console.Write("Enter The New Price of Item: ");
                                    price = float.Parse(Console.ReadLine());

                                    shopkeeper.UpdateItem(id, price);

                                    Console.WriteLine("Press Enter to Continue!");
                                    Console.ReadLine();
                                    break;

                                case '4':
                                    Console.Clear();
                                    shopkeeper.DisplayItems();

                                    Console.WriteLine("\nPress Enter to Continue!");
                                    Console.ReadLine();
                                    break;

                                default:
                                    Console.Clear();
                                    Console.WriteLine("\nAction Terminated!");
                                    Console.WriteLine("Press Enter to Continue!");
                                    Console.ReadLine();
                                    break;
                            }
                        }
                        else
                        {
                            Console.Clear();
                            counter -= 1;
                            Console.WriteLine("Wrong Password... ");
                            Console.WriteLine("Remaining Attempts Left: " + counter);
                            if (counter == 0)
                            {
                                Console.WriteLine("You've provided Invalid Data, \n    Program Terminated!");
                                loop = false;
                            }

                            Console.WriteLine("\nPress Enter to Continue!");
                            Console.ReadLine();
                        }
                        
                        break;

                    case '2':
                        Console.Clear();
                        _maininventory = shopkeeper.GetInventory();

                        Console.WriteLine("WELCOME SIR!");
                        Console.WriteLine("Press 0. To See Available Items in Inventory!");
                        Console.WriteLine("Press 1. To Buy Item in Inventory!");
                        Console.WriteLine("Press 2. To Drop Item in Inventory!");
                        Console.WriteLine("Press 3. To See Cart!");
                        Console.WriteLine("Press 4. To Finalize Bill!");

                        press = Console.ReadKey().KeyChar;
                        switch (press)
                        {
                            case '0':
                                Console.Clear();

                                foreach(Item i in _maininventory)
                                {
                                    i.DisplayInfo();
                                }

                                Console.WriteLine("\nPress Enter to Continue!");
                                Console.ReadLine();
                                break;

                            case '1':
                                Console.Clear();

                                Console.WriteLine("Enter the ID of Item to Add: ");
                                id = int.Parse(Console.ReadLine());
                                customer.AddItem(id, _maininventory);
                                shopkeeper.ItemCount -= 1;

                                Console.WriteLine("\nData Inserted Successfully...");
                                Console.WriteLine("Press Enter to Continue!");
                                Console.ReadLine();
                                break;

                            case '2':
                                Console.Clear();

                                Console.WriteLine("Enter the ID of Item to Remove: ");
                                id = int.Parse(Console.ReadLine());
                                customer.DropItem(id, _maininventory);
                                shopkeeper.ItemCount += 1;

                                Console.WriteLine("Press Enter to Continue!");
                                Console.ReadLine();
                                break;

                            case '3':
                                Console.Clear();
                                customer.DisplayItems();
                                Console.WriteLine("\nPress Enter to Continue!");
                                Console.ReadLine();
                                break;

                            case '4':
                                Console.Clear();

                                Console.Write("Enter Your Name: ");
                                customer.Name = Console.ReadLine();
                                Console.Write("Enter Your Phone: ");
                                customer.Phone = Console.ReadLine();

                                Console.Clear();

                                _shoppingCart = customer.GetShoppingCart();
                                cashier.CalculatedPrice(_shoppingCart);
                                customer.ItemCount = 0;                               

                                price = cashier.GetPrice();
                                int itemval = cashier.GetItems();

                                receipt = new ShoppingReportGeneration(itemval, price);
                                receipt.CalculateReceipt();

                                Console.WriteLine("\n\t\t\t\t------------------Items Purchased------------------");
                                cashier.DisplayReceipt();
                                Console.WriteLine("\n\t\t\t\t------------------Receipt Details------------------");

                                Console.WriteLine("Customer Name: " + customer.Name);
                                Console.WriteLine("Customer Phone: " + customer.Phone);

                                receipt.DisplayReceipt();

                                Console.WriteLine("\nPress Enter to Continue!");
                                Console.ReadLine();
                                break;

                            default:
                                Console.Clear();
                                Console.WriteLine("Action Terminated!");

                                Console.WriteLine("Press Enter to Continue!");
                                Console.ReadLine();
                                break;
                        }

                        break;

                    case '3':
                        loop = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Please Choose Provided Inputs!");
                        Console.WriteLine("Press Enter to Continue!");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
