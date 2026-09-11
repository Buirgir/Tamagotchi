public class Tamagotchi()
{
    //Stats
    public string name;
    int boredom = 10;
    int hunger = 10;
    List<string> words = ["hi"];
    bool isAlive;




    //Functions
    public void Feed()
    {
        hunger -= 5;
        if(hunger < 0) hunger = 0;
    }

    public void Hi()
    {
        int wordnumber = Random.Shared.Next(0, words.Count);
        Console.WriteLine($"{name} says {words[wordnumber]}");
        Tick();
    }

    public void Teach()
    {
        Console.WriteLine($"What word do you wish to teach {name}");
        words.Add(Console.ReadLine());
    }

    public void Tick()
    {
        hunger ++;
        boredom++;
        if(hunger >= 10 || hunger >= 10) isAlive = false;
    }
    public void PrintStats()
    {
        string state;
        if(isAlive == true) state = "Alive";
        else state = "dead";
        Console.WriteLine($"{name} is {state}");
        Console.WriteLine($"{name} hunger is at {hunger}");
    }
    public bool GetAlive()
    {
        if(isAlive) return true;
        else return false;
    }
    public void ReduceBoredom()
    {
        boredom -= 5;
        if(boredom < 0) boredom = 0;
    }
    public string GetMood()
    {
        if(boredom < 5) return "🥱";
        else if(hunger < 5) return "🥺🍴";
        else if(boredom <= 1 || hunger <= 1) return "🤒";
        else return "😁";
    }
}
