public class Product{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(string name, string id,double price, int quantity){
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public double _PriceOfProduct(){
        return _price;
    }

    public string _getName(){
        return _name;
    }

    public string _getID(){
        return _id;
    }

    public int _getQuantity(){
        return _quantity;
    }

    public double _getTotal(){
        return _price * _quantity;
    }
}