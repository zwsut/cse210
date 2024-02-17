public class Product
{
    private string _name;
    private string _productId;
    private float _price;
    private int _quantity;

    public Product(string name, string productId, float price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public float CalculateCost()
    {
        return _price * _quantity;
    }

    public string GetFormattedString()
    {
        return $"Quantity: {_quantity} - Product ID: {_productId} - Product Name: {_name} - Price: {_price}";
    }
}