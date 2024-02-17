public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsDomestic()
    {
        if (_address.IsDomestic())
        {
            return true;
        }
        else{
            return false;
        }
    }

    public string GetName()
    {
        return _name;
    }

    public string GetAddress()
    {
        string customerAddress = _address.GetFormattedAddress();
        return customerAddress;
    }
}