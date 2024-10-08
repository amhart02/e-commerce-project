using System.Runtime.CompilerServices;

class Products
{
    private List<Product> _products;
    public Products()
    {
        _products = new List<Product>();
    }
    public void DisplayProducts()
    {
        int productNumber = 0;
        foreach (Product product in _products)
        {
            productNumber += 1;
            Console.WriteLine();
            product.DisplayProduct(productNumber);
        }
        Console.WriteLine();
    }
    public static List<Product> ReadFromFile(string filename)
    {
        List<Product> products = new List<Product>();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('#');

            string name = parts[0];
            double price = double.Parse(parts[1]);
            string description = parts[2];
            string category = parts[3];

            Product product;
            //regular product
            if (parts.Length == 4)
            {
                product = new Product(name, price, description, category);
            }
            //subscription product
            else if (parts.Length == 6)
            {
                string subscriptionDuration = parts[4];
                double renewalPrice = double.Parse(parts[5]);
                product = new Subscription(name, price, description, category, subscriptionDuration, renewalPrice);
            }
            //sale product 
            else if (parts.Length == 7)
            {
                double discount = double.Parse(parts[4]);
                string saleEndDate = parts[5];
                int stock = int.Parse(parts[6]);
                product = new Sale(name, price, description, category, discount, saleEndDate, stock);
            }
            else
            {
                continue;
            }
            products.Add(product);
        }
        return products;
    }
    public void LoadProducts(List<Product> products)
    {
        _products = products;
    }
}