public class Customer{
    private string _name;
    private Address _address;

    public Customer(string name, string street, string city, string state, string country){
        _name = name;
        _address = new Address(street, city, state, country);
    }

    public string _getName(){
        return _name;
    }

    public string _getAddress(){
        return _address._DisplayAddress();
    }
    public bool _isUSA(){
        return _address._isUSA();
    }
}