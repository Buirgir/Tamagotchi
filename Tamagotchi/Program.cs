//Create first tamagotchi and lets you pick a name
using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

Tamagotchi pet = new Tamagotchi();
Console.WriteLine("What do you wish to name your Tamagotchi?");
pet.name = Console.ReadLine();
int choice;
while(true)
{
 //   Console.WriteLine($"{pet.name} : {pet.GetMood()}");
    choice = chooseAction(pet);
    action(pet, choice);
    //if tomagotchi dies
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
    4. Check up on {pet.name}
    5. Play with {pet.name}");
    string choice = Console.ReadLine();

    while(true)
    {    
        if(int.TryParse(choice, out int choiceInt))
            {
                if(choiceInt <= 5 && choiceInt > 0)
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
    if(choice == 5) pet.ReduceBoredom();
    Console.WriteLine("press enter to continue");
    Console.ReadLine();
}
