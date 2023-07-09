using System;

class Program
{
    static void Main(string[] args)
    {
        string name1 = "Marc Rubio";
        string street1 = "231 Bonzai Ave.";
        string city1 = "Orem";
        string state1 = "UT";
        string country1 = "USA";

        string proName1 = "toothpaste";
        string proID1 = "398";
        double proPrice1 = 3.98;
        int proQuant1 = 2;

        string proName2 = "mouthwash";
        string proID2 = "695";
        double proPrice2 = 6.95;
        int proQuant2 = 1;

        string proName3 = "toothbrush";
        string proID3 = "498";
        double proPrice3 = 4.98;
        int proQuant3 = 3;

        string name2 = "Max Molina";
        string street2 = "57 N Tustin St.";
        string city2 = "Tijuana";
        string state2 = "Baja California";
        string country2 = "Mexico";

        string proName4 = "notebook";
        string proID4 = "198";
        double proPrice4 = 1.98;
        int proQuant4 = 4;

        string proName5 = "pen"; 
        string proID5 = "049";
        double proPrice5 = .49;
        int proQuant5 = 12;

        Order orderOne = new Order(name1, street1, city1, state1,country1);
        orderOne._addProducts(proName1, proID1, proPrice1, proQuant1);
        orderOne._addProducts(proName2, proID2, proPrice2, proQuant2);
        orderOne._addProducts(proName3, proID3, proPrice3, proQuant3);

        Order orderTwo = new Order(name2, street2, city2, state2, country2);
        orderTwo._addProducts(proName4, proID4, proPrice4, proQuant4);
        orderTwo._addProducts(proName5, proID5, proPrice5, proQuant5);

        Console.Clear();
        Console.WriteLine("Order number 1:");
        Console.WriteLine("Packing Label");
        orderOne._getPackingLabel();
        Console.WriteLine("\nShipping Label");
        orderOne._getShippingLabel();
        Console.WriteLine($"\nTotal Price: ${orderOne._getTotalCost()}");

        Console.WriteLine();

        Console.WriteLine("Order number 2:");
        Console.WriteLine("Packing Label");
        orderTwo._getPackingLabel();
        Console.WriteLine("\nShipping Label");
        orderTwo._getShippingLabel();
        Console.WriteLine($"\nTotal Price: ${orderTwo._getTotalCost()}");

    }
}