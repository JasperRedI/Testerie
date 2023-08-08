
using System.ComponentModel.Design;
using System.Numerics;

Console.WriteLine("Welcome to Testerie!");
Console.WriteLine("This game is in beta, so please give feedback!");
Console.WriteLine("GitHub: https://github.com/JasperRedI/Testerie");
Console.WriteLine("Itch: https://jaspertop.itch.io/testerie");
Console.WriteLine("Made by Jasperredis");
Console.WriteLine("You are locked in a room. What will you do?");

String foundhatch = "no";
String hasbomb = "no";
String lookingaround = "no";
String location = "start";
String foundbomb = "no";
String run = "yes";
String cangetbomb = "yes";
String winplode = "no";

while (run == "yes")
{
    String response = Console.ReadLine();
    if (response == "where am i")
    {
        Console.WriteLine("You are in the " + location + ".");
    }
    if (location == "start")
    {
        if (response == "jump out window")
        {
           if (winplode == "yes")
            {
                Console.WriteLine("You jump out the window.");
                Console.WriteLine("You are now in the hallway.");
                location = "hallway";
            }
           else
                {
                Console.WriteLine("The window is still there, so how are you going to do that?");
            }
        }
        else if (response == "what can i do")
        {
            Console.WriteLine("Currently, you can:");
            Console.WriteLine("'open the door'");
            Console.WriteLine("'look around'");
            Console.WriteLine("'jump out window'");
            if (hasbomb == "yes")
            {
                Console.WriteLine("'use the bomb'");
            }
        }
        else if (response == "open the door")
        {
            Console.WriteLine("There is no door.");
        }
        else if (response == "look around")
        {
            lookingaround = "yes";
            foundhatch = "yes";
            Console.WriteLine("All that is in the room is a hatch and a window.");
            Console.WriteLine("Which one of these would you like to investigate?");
        }
        else if (response == "hatch")
        {
            if (foundhatch == "yes")
            {
                Console.WriteLine("You went into the hatch.");
                Console.WriteLine("What will you do in the hatch?");
                location = "hatch";
            }
            else
            {
                Console.WriteLine("Sorry, it doesn't seem like you can hatch. Please try this in another point in progression or a different location. If you can't, then the feature might not be implemented yet, or might not even exist.");
            }
        }
        else if (response == "use the bomb")
        {
            if (foundbomb == "yes")
            {
                Console.WriteLine("You used the bomb to explode the window.");
                Console.WriteLine("You can escape the room, but there are gaurds after you now.");
                Console.WriteLine("You no longer have a bomb");
                hasbomb = "no";
                winplode = "yes";
            }
        }
        else
        {
            Console.WriteLine("It doesn't seem like you can " + response +" right now.");
            Console.WriteLine("Please try this in:");
            Console.WriteLine("A later point in progression");
            Console.WriteLine("or");
            Console.WriteLine("A different location");
            Console.WriteLine("If neither of these work, the feature might not be implemented yet.");
            Console.WriteLine("Or, it might not even exist.");
            Console.WriteLine("If you need help, please ask on the Itch page or the GitHub page.");
        }
    }
    else if (location == "hatch")
    {
        if (response == "what can i do")
        {
            Console.WriteLine("In the hatch, you can:");
            Console.WriteLine("'look around'");
            Console.WriteLine("'leave the hatch'");
            Console.WriteLine("Will you 'look around' or 'leave the hatch'?");
        }
        else if (response == "leave the hatch")
        {
            Console.WriteLine("You left the hatch.");
            location = "start";
        }
        else if (response == "look around")
        {
            if (cangetbomb == "yes")
            {
                foundbomb = "yes";
                Console.WriteLine("All that is in the hatch is a bomb.");
            }
            else
            {
                Console.WriteLine("There is nothing in the hatch");
            }
        }
        else if (response == "collect the bomb")
        {
            if (cangetbomb == "yes")
            {
                if (foundbomb == "yes")
                {
                    Console.WriteLine("You collected the bomb.");
                    hasbomb = "yes";
                    cangetbomb = "no";
                }
            }
            else
            {
                Console.WriteLine("You already collected the bomb.");
            }
        }
        else
        {
            Console.WriteLine("It doesn't seem like you can '" + response + "'right now.");
        }
    }
}