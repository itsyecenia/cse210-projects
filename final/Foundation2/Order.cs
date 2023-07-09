public class Order{
    private Customer _customer;
    private List<Product> _products = new List<Product>();

    public Order(string name, string street, string city, string state, string country){
        _customer = new Customer(name, street, city, state, country);
    }

    public void _addProducts(string name, string id, double price, int quantity){
        _products.Add(new Product(name, id, price, quantity));
    }

    public double _getTotalCost(){
        // go through the list of products and add up all total prices and then add in shipping cost.
        double total = 0;
        foreach (Product products in _products){
            total = total + products._getTotal();
        }
        double shipping = _getShippingCost();
        total = total+shipping;
        return total;
    }

    public double _getShippingCost(){
        // check if the address is in the USA.
        // if it is in the USA, charge $5
        // if not charge $35
        bool check = _customer._isUSA();
        if (check){
            return 5;
        }
        return 35;
    } 

    public void _getPackingLabel(){
        // go through the list of products and print out the names and ID of each product.
        foreach (Product products in _products){
            Console.WriteLine($"{products._getName()} ID: {products._getID()}");
        }

    }

    public /* string */ void _getShippingLabel(){
        // print out the name and address as you would see it on a package.
        Console.WriteLine($"{_customer._getName()}");
        Console.WriteLine($"{_customer._getAddress()}");
    }
}
