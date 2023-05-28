public class Scriptures{
    private List <Words> _displayScripture = new List<Words>();
    private List <Words> _hiddenScripture = new List<Words>();
    private Reference scriptReference;
    private string _scripture;
    private string _reference;
    private string _scriptHidden;
    private string _text = "";
    private List<int> _randomWord = new List<int>();
    private Random _random = new Random();

    public Scriptures(string filename1, string filename2){
        _loadScripture(filename1);
        _loadHidden(filename2);

        string book = "";
        int chap = 0;
        int verse = 0;
        int lastVerse = 0;

        string [] refer = _reference.Split(new char [] {' ', ':', '-'});
        int x = 0;
        foreach (string word in refer){
            if (x == 0)
            {
                book = word;
                x = x+1;
            }
            else if (x == 1){
                chap = int.Parse(word);
                x = x+1;
            }
            else if (x == 2){
                verse = int.Parse(word);
                x = x+1;
            }
            else if (x == 3){
                lastVerse = int.Parse(word);
                x = x+1;
            }
        }
        if (x == 3){
            scriptReference = new Reference(book, chap, verse);
        }
        else if (x == 4){
            scriptReference = new Reference(book, chap, verse, lastVerse);
        }

        string [] script = _scripture.Split(' ');
        foreach (string word in script){
            _displayScripture.Add(new Words(word));
        }

        string [] hide = _scriptHidden.Split(' ');
        foreach (string word in hide){
            _hiddenScripture.Add(new Words(word));
        }

    }

    public void _loadScripture(string filename){
        if (File.Exists(filename)){
            string[] loadedScripture = System.IO.File.ReadAllLines(filename);
            int x = 0;
            foreach (string line in loadedScripture){
                if (x == 0){
                    _addReference(line);
                    x = x+1;
                }
                else{
                   _addScripture(line);
                }
            }
        }
    }

    public void _loadHidden(string filename){
        if (File.Exists(filename)){
            string [] loadedHidden = System.IO.File.ReadAllLines(filename);
            foreach (string line in loadedHidden){
                _addHidden(line);
            }
        }
    }


    public void _addReference(string words){
        _reference = words;
    }

    public void _addScripture(string words){
        _scripture = words;
    }

    public void _addHidden(string words){
        _scriptHidden = words;
    }

    public string _getScriptureText(int i){
        return _displayScripture[i]._getWord();
    }

    public void _makeHiddenList(){
        for (int i = 0; i < _displayScripture.Count; i++){
            if(!_displayScripture[i]._getHidden()){
                _randomWord.Add(i);
            }
        }
    }

    // public void _removeHiddenfromList(){
    //     for (int i = 0; i < _randomWord.Count; i++){
    //         if (_displayScripture[_randomWord[i]]._getHidden())
    //         {
    //             _randomWord.Remove(i);
    //         }
    //     }
    // }

    public void _removeWords(){
        bool done = false;
        while (!done){
            int magicNumber = _random.Next(0, _randomWord.Count);
            if (_getCountofNonHiddenWords() == 0)
            {
                done = true;
            }
            else if (!_displayScripture[_randomWord[magicNumber]]._getHidden()){
                done = true;
                _displayScripture[magicNumber]._setHidden();
                _displayScripture[magicNumber]._setWord(_hiddenScripture[magicNumber]._getWord());
            }    
        }
    }

    public int _getCountofNonHiddenWords(){
        return _randomWord.Count;
    }

    public void _display(){
        _text = "";
        _text = _text + scriptReference._getRef();

        for (int i = 0; i < _displayScripture.Count; i++)
        {
           _text = _text + " " + _getScriptureText(i);
        }

        Console.WriteLine(_text);
    }
}