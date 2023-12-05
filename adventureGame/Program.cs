using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace adventureGame
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            bool isRunning = true;
            bool hasStaff = false;
            bool goShop = false;

            bool EndGame = false;
            
            
            string playerChoice = "";

            Console.WriteLine("welcome to the adveture game");
            Console.WriteLine("Your choices matter!");

            //character sheet
            Random random = new Random();

            Console.WriteLine("Character sheet creator");

            Console.Write("Enter character name: ");
            string characterName = Console.ReadLine();

            Console.Write("Enter character Age: ");
            int age = int.Parse(Console.ReadLine());

            Console.Write("Enter character height: ");
            float height = float.Parse(Console.ReadLine());

            Console.Write("Is your character  a magic user? (yes/no):  ");
            bool isMagicUser = Console.ReadLine().ToLower() == "yes";

            int charisma = random.Next(0, 20) + 1;
            int strength = random.Next(0, 20) + 1;

            // display the character sheet
            Console.WriteLine("\nCharacter Sheet");
            Console.WriteLine($"Name: {characterName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Height: {height:0.00}");
            Console.WriteLine($"Magic user: {isMagicUser}");
            Console.WriteLine($"Charisma: {charisma}");
            Console.WriteLine($"Strength: {strength}");

            Restart();
             void Restart()
            {
                while (isRunning == true)
                {
                    //Story and choices
                    Console.WriteLine("you begin your adventure"); //maybe use keys
                    Console.WriteLine("you find yourself at a fork in the road. Do you go left or right?");
                    playerChoice = Console.ReadLine().ToLower();

                    if (playerChoice == "left")
                    {
                        Console.WriteLine("You see a man infront of you. Are you worthy for this Staff?");
                        Console.WriteLine("do you take the staff? (take/leave)");

                        playerChoice = Console.ReadLine().ToLower();

                        if (playerChoice == "take")
                        {
                            //Console.WriteLine("you need to fight me for it");
                            if (isMagicUser == true)
                            {
                                Console.WriteLine("you grab the staff and shoot a bolt at the tree. The wizard congratulates you!");
                            }
                            else
                            {
                                Console.WriteLine("you grab the staff but nothing happens. The wizard takes it back as you are not worthy");
                                hasStaff = true;
                            }
                        }
                        else if (playerChoice == "leave")
                        {
                            Console.WriteLine("the wizard sighs as you walk away");
                        }
                        else
                        {
                            Console.WriteLine("the wizard stares at you and walks away");
                        }
                    }
                    else if (playerChoice == "right")
                    {
                        Console.WriteLine("You find a treasure chest at the side of the road");
                    }
                    else
                    {
                        Console.WriteLine("you wander aimlessly and get lost. Game over!");
                    }

                    if (goShop == true)
                    {
                        Console.WriteLine("Welcome to the shop what can I get for you?");
                        Console.WriteLine("potions, weapons, shields");
                    }

                    Console.WriteLine("Do you want to quit or restart (quit/restart)");
                    playerChoice = Console.ReadLine().ToLower();


                    if (playerChoice == "restart")
                    {
                        Restart();
                    }
                    else
                    {
                        isRunning = false;
                    }
                }
            }
        } 
    }
}