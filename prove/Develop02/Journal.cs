using System;
using System.IO;
using System.Text;

public class Journal{
    public string _filename;
    public List<Entry> _entries = new List<Entry>();

    public void _displayJournal(){
        Console.WriteLine("My Journal\n");
        foreach (Entry b in _entries){
            b._Display();
        }
    }

    public void _saveJournal(){
        bool a = false;
        if (File.Exists(_filename)){
            a = true;
        }
        using (StreamWriter outputFile = new StreamWriter(_filename)){
            foreach (Entry b in _entries){
                b._writeFile(outputFile);
            }   
        }
        if (a){
            Console.WriteLine("File saved!\n");
        }
        else{
            Console.WriteLine("File was created and Journal was saved!\n");
        }
    }

    public void _loadJournal(){
        if (File.Exists(_filename)){
            string[] loadedJournal = System.IO.File.ReadAllLines(_filename);
            int x = 0;
            Entry b = new Entry();
            foreach (string line in loadedJournal){
                if (x == 0){
                    b._date = line;
                    x = x+1;
                }
                else if (x == 1){
                    b._promptGiven = line;
                    x = x+1;
                }
                else if (x == 2){
                    b._userEntry = line;
                    _entries.Add(b);
                    x = 0;
                }
            }
            Console.WriteLine($"Loaded {_filename} into your journal.\n");
        }
        else Console.WriteLine("There is no such file.\nMake sure you write the file correctly next time.\n");
    }
}