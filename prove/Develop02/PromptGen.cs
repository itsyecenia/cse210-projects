public class Prompt{
    List <string> _prompts = new List<string>();

    public void _getPrompts(){
        string filename = "prompts.txt";
        _prompts = System.IO.File.ReadAllLines(filename);
    }
    public void _promptDisplay(int x){
        Console.WriteLine($"{_prompt[x]}");
    }
}