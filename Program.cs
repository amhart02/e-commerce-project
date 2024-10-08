using System;

class Program
{
    static void Main(string[] args)
    {
        //define some tings
        int userInput = 1;
        Menu menu = new Menu();
        User user = menu.DisplayLogIn();
        Products products = new Products();
        Cart cart = new Cart(0);
        Orders orders = new Orders();

        //main while loop
        while (userInput != 7)
        {
            Console.Clear();
            Console.SetCursorPosition(0, 0);
            userInput = menu.DisplayMainMenu();

            //display products
            if (userInput == 1)
            {
                List<Product> loadedProducts = Products.ReadFromFile("products.txt");
                products.LoadProducts(loadedProducts);
                products.DisplayProducts();
                Console.WriteLine("Press any key to return to the main menu.");
                Console.ReadKey();
            }
            //add item
            else if (userInput == 2)
            {
                List<Product> loadedProducts = Products.ReadFromFile("products.txt");
                products.LoadProducts(loadedProducts);
                products.DisplayProducts();

                Console.WriteLine("Which item would you like to add to the cart (please use the number value)? ");
                int itemToAdd = int.Parse(Console.ReadLine());
                Product productToAdd = loadedProducts[itemToAdd - 1];
                cart.AddProduct(productToAdd);
                Console.WriteLine();
            }
            //remove item
            else if (userInput == 3)
            {
                cart.DisplayCart();

                Console.WriteLine("Which item would you like remove from the cart (please use the number value)? ");
                int itemToDelete = int.Parse(Console.ReadLine());
                Product productToDelete = cart.GetListProducts()[itemToDelete - 1];
                cart.DeleteProduct(productToDelete);
                Console.WriteLine();
            }
            //view cart
            else if (userInput == 4)
            {
                Console.WriteLine();
                cart.DisplayCart();
                Console.WriteLine("Press any key to return to the main menu.");
                Console.ReadKey();
            }
            //create order
            else if (userInput == 5)
            {
                Order order = new Order(cart.GetListProducts(), cart.GetTotalCost(), DateTime.Now.ToString("yyyy-MM-dd"), user.GetUserID());
                orders.AddOrder(order);
                cart.ClearCart();
                Console.WriteLine();
                Console.WriteLine("Your order has been placed!");
                Console.WriteLine();
                Console.WriteLine("Press any key to return to the main menu.");
                Console.ReadKey();
            }
            //view orders
            else if (userInput == 6)
            {
                Console.WriteLine();
                orders.DisplayOrders();
                Console.WriteLine("Press any key to return to the main menu.");
                Console.ReadKey();
            }
        }
    }
}