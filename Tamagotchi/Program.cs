Console.OutputEncoding = System.Text.Encoding.UTF8;
//Create first tamagotchi and lets you pick a name
Tamagotchi pet = new Tamagotchi();
Console.WriteLine("What do you wish to name your Tamagotchi?");
pet.name = Console.ReadLine();
int choice;
while(true)
{
    Console.WriteLine($"{pet.name} : {pet.GetMood()}");
    choice = chooseAction(pet);
    action(pet, choice);
    //if tomagotchi dies
    Console.Clear();
    if(!pet.GetAlive())
    {
        Console.WriteLine($"{pet.name} has died");
        pet = new Tamagotchi();
        Console.WriteLine("What do you wish to name your next Tamagotchi?");
        pet.name = Console.ReadLine();
    }
}

static int chooseAction(Tamagotchi pet)
{
    Console.WriteLine($"What do you wish to do with {pet.name}");
    Console.WriteLine(@$"
    1. Feed {pet.name}
    2. Talk to {pet.name}
    3. Teach words to {pet.name}
    4. Check up on {pet.name}");
    string choice = Console.ReadLine();

    while(true)
    {    
        if(int.TryParse(choice, out int choiceInt))
            {
                if(choiceInt <= 4 && choiceInt > 0)
                {
                    return choiceInt;
                }
            }
    }
}

static void action(Tamagotchi pet, int choice)
{
    if(choice == 1) pet.Feed();
    if(choice == 2) pet.Hi();
    if(choice == 3) pet.Teach();
    if(choice == 4) pet.PrintStats();
    Console.WriteLine("press enter to continue");
    Console.ReadLine();
}
