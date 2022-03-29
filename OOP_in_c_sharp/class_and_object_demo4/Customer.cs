class Customer {
    //fill your code
    private string _customerName;
    private string _customerEmail;
    private string _customerType;
    private string _customerAddress;

    public string CustomerName
    {
        get { return _customerName; }
        set { _customerName = value; }
    }

    public string CustomerEmail
    {
        get { return _customerEmail; }
        set { _customerEmail = value; }
    }

    public string CustomerType
    {
        get { return _customerType; }
        set { _customerType = value; }
    }

    public string CustomerAddress
    {
        get { return _customerAddress; }
        set { _customerAddress = value; }
    }

    public Customer ()
    {

    }

    public Customer (string name, string email, string type, string address)
    {
        _customerName = name;
        _customerEmail = email;
        _customerType = type;
        _customerAddress = address;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"Customer Details\n" +
            $"Name: {_customerName}\n" +
            $"E-mail: {_customerEmail}\n" +
            $"Type: {_customerType}\n" +
            $"Location: {_customerAddress}\n");
    }
}
