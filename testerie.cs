
using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.InteropServices;
using Windows.Gaming.Input;
using Windows.Perception.People;
using Windows.Security.Cryptography.Certificates;

Console.WriteLine("Welcome to Testerie!");
Console.WriteLine("You are on Beta 2");
Console.WriteLine("This game is in beta, so please give feedback!");
Console.WriteLine("GitHub: https://github.com/JasperRedI/Testerie");
Console.WriteLine("Itch: https://jaspertop.itch.io/testerie");
Console.WriteLine("Made by Jasperredis");
Console.WriteLine("You are locked in a room. What will you do?");

Boolean foundhatch = false;
Boolean hasbomb = false;
Boolean lookingaround = false;
String location = "start";
Boolean foundbomb = false;
Boolean run = true;
Boolean cangetbomb = true;
Boolean winplode = false;
Boolean founddoor = false;
Boolean foundelevator = false;
Boolean foundelevatorgaurds = false;
Boolean gaurdshere = true;
Boolean foundcrowbar = false;
Boolean hascrowbar = false;
var unk = 1;


while (run == true)
{
        String response = Console.ReadLine();
        if (response == "unk")
        {
            Console.WriteLine(unk);
        }
        else if (response == "where am i")
        {
            Console.WriteLine("You are in the " + location + ".");
        }
        if (location == "start")
        {
            if (response == "jump out window")
            {
                if (winplode == true)
                {
                    Console.WriteLine("You jumped out the window.");
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
                if (hasbomb == true)
                {
                    Console.WriteLine("'use the bomb'");
                }
                if (winplode == true)
                {
                    Console.WriteLine("'jump out window'");
                }
            }
            else if (response == "open the door")
            {
                Console.WriteLine("There is no door.");
            }
            else if (response == "look around")
            {
                lookingaround = true;
                foundhatch = true;
                Console.WriteLine("All that is in the room is a hatch and a window.");
                Console.WriteLine("Which one of these would you like to investigate?");
            }
            else if (response == "hatch")
            {
                if (foundhatch == true)
                {
                    Console.WriteLine("You went into the hatch.");
                    Console.WriteLine("What will you do in the hatch?");
                    location = "hatch";
                }
                else
                {
                    if (response == "where am i")
                    {

                    }
                    else
                    {
                        Console.WriteLine("It doesn't seem like you can " + response + " right now. Maybe you made a typo?");
                    }
                }
            }
            else if (response == "use the bomb")
            {
                if (foundbomb == true)
                {
                    Console.WriteLine("You used the bomb to explode the window.");
                    Console.WriteLine("You can escape the room.");
                    Console.WriteLine("You no longer have a bomb");
                    hasbomb = false;
                    winplode = true;
                }
            }
            else
            {
                if (response == "where am i")
                {

                }
                else
                {
                    Console.WriteLine("It doesn't seem like you can " + response + " right now. Maybe you made a typo?");
                    unk = unk + 1;
                }
            }
        }
        else if (location == "hatch")
        {
            if (response == "what can i do")
            {
                Console.WriteLine("In the hatch, you can:");
                Console.WriteLine("'look around'");
                Console.WriteLine("'leave hatch'");
                Console.WriteLine("Will you 'look around' or 'leave hatch'?");
            }
            else if (response == "leave hatch")
            {
                Console.WriteLine("You left the hatch.");
                location = "start";
            }
            else if (response == "look around")
            {
                if (cangetbomb == true)
                {
                    foundbomb = true;
                    Console.WriteLine("All that is in the hatch is a bomb.");
                }
                else
                {
                    Console.WriteLine("There is nothing in the hatch");
                }
            }
            else if (response == "collect the bomb")
            {
                if (cangetbomb == true)
                {
                    if (foundbomb == true)
                    {
                        Console.WriteLine("You collected the bomb.");
                        hasbomb = true;
                        cangetbomb = false;
                    }
                }
                else
                {
                    Console.WriteLine("You already collected the bomb.");
                }
            }
            else
            {
                if (response == "where am i")
                {

                }
                else
                {
                    Console.WriteLine("It doesn't seem like you can " + response + " right now. Maybe you made a typo?");
                    unk = unk + 1;
                }
            }
        }
        else if (location == "hallway")
        {
            if (response == "what can i do")
            {
                Console.WriteLine("Currently, you can:");
                Console.WriteLine("'look around'");
                Console.WriteLine("'door'");
                Console.WriteLine("'open the door'");
                Console.WriteLine("'elevator'");
                Console.WriteLine("'other hallway'");
            }
            else if (response == "look around")
            {
                Console.WriteLine("In the hallway, there is:");
                Console.WriteLine("A door");
                Console.WriteLine("An elevator");
                Console.WriteLine("Another hallway");
                Console.WriteLine("Which of these would you like to investigate?");
                founddoor = true;
                foundelevator = true;
            }
            else if (response == "door")
            {
                Console.WriteLine("It's locked.");
            }
            else if (response == "open the door")
            {
                Console.WriteLine("It's locked.");
            }
            else if (response == "elevator")
            {
                if (gaurdshere == true)
                {
                    if (foundelevatorgaurds == false)
                    {
                        Console.WriteLine("There's a couple gaurds in the way. You're gonna have to get rid of them.");
                        foundelevatorgaurds = true;
                    }
                    else if (foundelevatorgaurds == true)
                    {
                        Console.WriteLine("The gaurds didn't leave or something.");
                    }
                }
            }
            else if (response == "other hallway")
            {
                Console.WriteLine("You went into the other hallway");
                location = "other hallway";
            }
        }
        else if (location == "other hallway")
        {
            if (response == "what can i do")
            {
                Console.WriteLine("Currently, you can:");
                Console.WriteLine("'look around'");
                Console.WriteLine("'leave hallway'");
                if (foundcrowbar == true)
                {
                    Console.WriteLine("'collect crowbar'");
                }
            }
            else if (response == "look around")
            {
                Console.WriteLine("All that is in the hallway is a crowbar.");
                foundcrowbar = true;
            }
            else if (response == "collect crowbar")
            {
                Console.WriteLine("You collected the crowbar.");
                hascrowbar = true;
            }
            else if (response == "leave hallway")
            {
                Console.WriteLine("You left the other hallway.");
                location = "hallway";
            }

        }
        else
        {
            Console.WriteLine("Error: Invalid Location");
        }
    }