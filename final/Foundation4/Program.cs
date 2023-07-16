using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activities = new List<Activity>();

        _activities.Add(new Running(7, "05 May 2020", 20));
        _activities.Add(new Cycling(25, "20 Sep 2021", 180));
        _activities.Add(new Swimming(35, "17 Jul 2022", 30));

        Console.Clear();
        foreach (Activity activity in _activities){
            Console.WriteLine(activity.GetSummary());
        }
    }
}