public class Address{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country){
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string _GetStreet(){
        return _street;
    }
    public string _GetCity(){
        return _city;
    }
    public string _GetState(){
        return _state;
    }
    public string _GetCountry(){
        return _country;
    }

    public bool _isUSA(){
        // check if country = USA
        if (_GetCountry() == "USA"){
            return true;
        }
        return false;
    }

    public string _DisplayAddress(){
        string addy =  _GetStreet() + "\n" + _GetCity() + ", " + _GetState() + "\n" + _GetCountry();
        return addy;
    }
}