using System;

class Program
{
    static void Main(string[] args)
    {
        List <Videos> _videos = new List<Videos>();
        _videos.Add(new Videos());
        _videos.Add(new Videos());
        _videos.Add(new Videos());

        _videos[0]._title = "Peaches";
        _videos[0]._author = "Bowser";
        _videos[0]._seconds = 110;

        _videos[0]._addComment("mario","Love this song");
        _videos[0]._addComment("luigi", "You killed it");
        _videos[0]._addComment("Yoshi", "Yoshi!");

        _videos[1]._title = "Enchiladas Rojas";
        _videos[1]._author = "Jauja Cocina Mexicana";
        _videos[1]._seconds = 365;

        _videos[1]._addComment("User1", "Loved this recipe");
        _videos[1]._addComment("User2", "I love to add two more chilis to make them spicier");
        _videos[1]._addComment("User3", "The came out really bad for me. Have to try it again");
        _videos[1]._addComment("User4", "I love all of her videos!");

        _videos[2]._title = "Can Mexican Moms Taste The Difference? Real Mexican Food Vs. Mexican Fast Food";
        _videos[2]._author = "mamah!";
        _videos[2]._seconds = 569;

        _videos[2]._addComment("Javier", "I don't think this is real");
        _videos[2]._addComment("Jose", "That is how my mom would react");
        _videos[2]._addComment("Joel", "They actually loved the fast food?!");


        foreach (Videos video in _videos)
        {
            video._displayInfo();
        }
    }
}