using System;

class Program
{
    static void Main(string[] args)
    {
        // int number1 = 6;
        // int number2 = 7;
        // fraction fractionOne = new fraction();
        // fraction fractionTwo = new fraction(number1);
        // fraction fractionThree = new fraction(number1, number2);

        // fractionOne.SetTop(6);
        // Console.WriteLine(fractionOne.GetTop());

        // fractionOne.SetBottom(7);
        // Console.WriteLine(fractionOne.GetBottom());

        fraction fractionOne = new fraction();
        Console.WriteLine(fractionOne.GetFractionString());
        Console.WriteLine(fractionOne.GetDecimalValue());

        fractionOne.SetTop(5);
        Console.WriteLine(fractionOne.GetFractionString());
        Console.WriteLine(fractionOne.GetDecimalValue());

        fraction fractionTwo = new fraction(3,4);
        Console.WriteLine(fractionTwo.GetFractionString());
        Console.WriteLine(fractionTwo.GetDecimalValue());

        fractionTwo.SetBottom(3);
        fractionTwo.SetTop(1);
        Console.WriteLine(fractionTwo.GetFractionString());
        Console.WriteLine(fractionTwo.GetDecimalValue());
    }
}