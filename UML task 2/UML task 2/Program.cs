using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tcheck = true;
            bool fcheck = false;
            do
            {
                ShoppingCart s1 = new ShoppingCart();
                Console.WriteLine("Enter Username: ");
                s1.Username = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                s1.Password = Console.ReadLine();

                do
                {
                    Console.WriteLine("Add items to Cart: ");
                    s1.Cart.Add(Console.ReadLine());
                    Console.WriteLine("Please enter price of item");
                    s1.CartTotal += double.Parse(Console.ReadLine());
                } while (fcheck);
                Console.WriteLine("Add another item? y/n: ");
                string input = Console.ReadLine().ToLower();
                if (input == "n")
                    fcheck = false;

            } while (tcheck);

            

        } 
    }
    class ShoppingCart
    {
        private string username;
        private string password;
        private string cartTotal;
        List<string> cart = new List<string>();

        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string CartTotal { get { return cartTotal; } set { cartTotal = value; } }
        public List<string> Cart { get { return cart; } set { cart = value; } }

    }
}
