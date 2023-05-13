using System;
using System.IO;
using System.Text;

public class Entry{
    public string _promptGiven = "";
    public string _userEntry = "";
    public string _date = "";

    public void _Display(){
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_promptGiven}");
        Console.WriteLine($"{_userEntry}");
        Console.WriteLine(" ");
    }

    public void _writeFile(StreamWriter outputFile){
        outputFile.WriteLine($"{_date}");
        outputFile.WriteLine($"{_promptGiven}");
        outputFile.WriteLine($"{_userEntry}");
    }

}