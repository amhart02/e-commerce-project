class Menu
{
    public User DisplayLogIn()
    {
        Console.WriteLine();
        Console.WriteLine("Please Log in:");
        Console.WriteLine();

        Console.Write("Are you a GoldStar Member (yes/no)? ");
        string input = Console.ReadLine().ToLower();
        bool goldStar = input == "yes";

        Console.Write("First and last name: ");
        string name = Console.ReadLine();

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Password: ");
        string password = Console.ReadLine();

        Console.Write("User ID Number: ");
        int userID = int.Parse(Console.ReadLine());

        if (goldStar)
        {
            Console.Write("GoldStar Member ID: ");
            int goldStarID = int.Parse(Console.ReadLine());

            GoldStar goldStarUser = new GoldStar(name, email, password, userID, goldStarID);
            return goldStarUser;
        }
        else
        {
            User user = new User(name, email, password, userID);
            return user;
        }
    }
    public int DisplayMainMenu()
    {
        int userInput = 0;

        while (userInput < 1 || userInput > 7)
        {
            Console.WriteLine("--Main Menu--");
            Console.WriteLine("1. Display products");
            Console.WriteLine("2. Add an item to cart");
            Console.WriteLine("3. Remove an item from cart");
            Console.WriteLine("4. View cart");
            Console.WriteLine("5. Create order");
            Console.WriteLine("6. View orders");
            Console.WriteLine("7. Quit");
            Console.Write("Choose a number (1-7): ");
            userInput = int.Parse(Console.ReadLine());
        }
        return userInput;
    }
}
