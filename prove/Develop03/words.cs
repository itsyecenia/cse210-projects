public class Words{
    private bool _hidden;
    private string _word;

    public Words(){
        _word = "";
        _hidden = false;
    }
    public Words(string word){
        _word = word;
        _hidden = false;
    }

    public void _setHidden(){
        _hidden = true;
    }

    public void _setWord(string word){
        _word = word;
    }

    public bool _getHidden(){
        return _hidden;
    }

    public string _getWord(){
        return _word;
    }
}