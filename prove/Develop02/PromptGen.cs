public class Prompt{
    public string[] listPrompts;
    string prompt;

    public void _savePrompts(){
        string filename = "prompts.txt";
        listPrompts = System.IO.File.ReadAllLines(filename);
    }

    public string _getPrompt(int x){
        prompt = listPrompts[x];
        return prompt;
    }
    public void _promptDisplay(int x){
        _getPrompt(x);
        Console.WriteLine($"{prompt}");
    }
}