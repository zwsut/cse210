using System.Reflection.Emit;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public float GetCost()
    {
        float total = 0;
        foreach (Product x in _products)
        {
            float cost = x.CalculateCost();
            total +=  cost;
        }
        if (_customer.IsDomestic())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }
        return total;
    }

    public string CreatePackingLabel()
    {
        string packingLabel = "";
        foreach (Product x in _products)
        {
            string formattedProduct = x.GetFormattedString();
            packingLabel += formattedProduct;
            packingLabel += "\n";
        }
        return packingLabel;
    }

    public string CreateShippingLabel()
    {
        string add = _customer.GetAddress();
        return $"{_customer.GetName()}\n{add}";
    }

    public void DisplayAll()
    {
        float totalCost = this.GetCost();
        Console.WriteLine("-------------------------------------------------------------------");
        Console.WriteLine($"                Total cost of order: {totalCost}\n\n");
        Console.WriteLine("\n\n                Packing List");
        Console.WriteLine(CreatePackingLabel());
        if (_customer.IsDomestic())
        {
            Console.WriteLine("                Shipping Label - Domestic");
        }
        else
        {
            Console.WriteLine("                Shipping Label - International");
        }
        Console.WriteLine(CreateShippingLabel());
        Console.WriteLine("\n\n");



        

    }
}