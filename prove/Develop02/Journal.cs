public class Journal{
    string filename;
    public List<Entry> _entries = new List<Entry>();

    public void _displayJournal(){
        Console.WriteLine("My Journal");
        foreach (Entry b in _entries){
            b._Display();
        }
    }

    public void saveJournal(){
        
    }

    public void loadJournal(){

    }
}