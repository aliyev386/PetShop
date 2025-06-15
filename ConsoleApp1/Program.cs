using ConsoleApp1.Animal_Shop;
using System;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Console.Title = "Amgela and Tom";
            Console.SetWindowSize(80, 45);
            Console.WriteLine(@"              
                           _                 _     
                __ _ _ __ (_)_ __ ___   __ _| |___ 
               / _` | '_ \| | '_ ` _ \ / _` | / __|
              | (_| | | | | | | | | | | (_| | \__ \
               \__,_|_| |_|_|_| |_| |_|\__,_|_|___/");
            Console.WriteLine("");
            Cat cat1 = new Cat("Tom", 9, "erkey", 100, 150, 55);
            Cat cat2 = new Cat("Badi", 5, "erkey", 100, 560, 50);
            Cat cat3 = new Cat("Mila", 13, "disi", 100, 654, 250);
            Cat cat4 = new Cat("Maya", 15, "disi", 100, 963, 300);
            Cat[] cats = new Cat[] { cat1, cat2, cat3, cat4 };
            Dog dog1 = new Dog("Max", 9, "erkey", 100, 150, 55);
            Dog dog2 = new Dog("Rocky", 5, "erkey", 100, 560, 50);
            Dog dog3 = new Dog("Bella", 13, "disi", 100, 654, 250);
            Dog dog4 = new Dog("karamel", 15, "disi", 100, 963, 300);
            Dog[] dogs = new Dog[] { dog1, dog2, dog3, dog4 };

            for (int i = 0; i < cats.Length; i++)
            {
                Console.WriteLine($"\t---------Cat {i + 1}----------|-----------Dog {i + 1}-----------");
                Console.WriteLine($"\tName: {cats[i].nickName}\t\t| Name: {dogs[i].nickName}");
                Console.WriteLine($"\tAge: {cats[i].age}\t\t\t| Age: {dogs[i].age}");
                Console.WriteLine($"\tGender: {cats[i].gender}\t\t| Gender: {dogs[i].gender}");
                Console.WriteLine($"\tEnergy: {cats[i].energy}\t\t| Energy: {dogs[i].energy}");
                Console.WriteLine($"\tPrice: {cats[i].price}\t\t| Price: {dogs[i].price}");
                Console.WriteLine($"\tMeal Quantity: {cats[i].mealQuantity}\t| Meal Quantity {dogs[i].mealQuantity}");
            }

            string[] options = {
                @"
            _       
   ___ __ _| |_ ___ 
  / __/ _` | __/ __|
 | (_| (_| | |_\__ \
  \___\__,_|\__|___/",
      @"
      _                 
   __| | ___   __ _ ___ 
  / _` |/ _ \ / _` / __|
 | (_| | (_) | (_| \__ \
  \__,_|\___/ \__, |___/
              |___/     "
            };

            int selectedIndex = 0;
            ConsoleKey key;

            int baseY = cats.Length * 7 + 6;

            do
            {
                for (int i = 0; i < options.Length; i++)
                {
                    int xPos = (i == 0) ? 5 : 35;
                    string[] lines = options[i].Split('\n');
                    for (int j = 0; j < lines.Length; j++)
                    {
                        Console.SetCursorPosition(xPos, baseY + j);
                        if (i == selectedIndex)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("" + lines[j]);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write("" + lines[j]);
                        }
                    }
                }

                key = Console.ReadKey(true).Key;
                if (key == ConsoleKey.LeftArrow)
                    selectedIndex = (selectedIndex == 0) ? options.Length - 1 : selectedIndex - 1;
                else if (key == ConsoleKey.RightArrow)
                    selectedIndex = (selectedIndex == options.Length - 1) ? 0 : selectedIndex + 1;

            } while (key != ConsoleKey.Enter);

            
            Console.WriteLine("\nSeçiminiz: " + (selectedIndex == 0 ? "cats" : "dogs"));
            if (selectedIndex == 0)
            {
                int selected = 0;
                ConsoleKey keyCats;

                do
                {
                    Console.Clear();
                    Console.WriteLine(@"           
                        _       
               ___ __ _| |_ ___ 
              / __/ _` | __/ __|
             | (_| (_| | |_\__ \
              \___\__,_|\__|___/");
                    for (int i = 0; i < cats.Length; i++)
                    {
                        if (i == selected)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\t>> ------------------Cat {i + 1}-------------------");
                        }
                        else
                        {
                            Console.WriteLine($"\t   ------------------Cat {i + 1}-------------------");
                        }

                        Console.WriteLine($"\t\tName: {cats[i].nickName}");
                        Console.WriteLine($"\t\tAge: {cats[i].age}");
                        Console.WriteLine($"\t\tGender: {cats[i].gender}");
                        Console.WriteLine($"\t\tEnergy: {cats[i].energy}");
                        Console.WriteLine($"\t\tPrice: {cats[i].price}");
                        Console.WriteLine($"\t\tMeal Quantity: {cats[i].mealQuantity}");
                        Console.WriteLine();
                        Console.ResetColor();
                    }

                    keyCats = Console.ReadKey(true).Key;

                    if (keyCats == ConsoleKey.UpArrow)
                    {
                        selected = (selected == 0) ? cats.Length - 1 : selected - 1;
                    }
                    else if (keyCats == ConsoleKey.DownArrow)
                    {
                        selected = (selected == cats.Length - 1) ? 0 : selected + 1;
                    }

                } while (keyCats != ConsoleKey.Enter);
                Console.Clear();
                Console.WriteLine("Your new cat:\n");
                while (true)
                {
                    
                    string[] options2 = {
            "1) Eat",
            "2) Sleap",
            "3) Play",
        };

                    int selectedIndex2 = 0;
                    ConsoleKey key2;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine($"{cats[selected].nickName}'s Energy is:{cats[selected].energy} and Age: {cats[selected].age}\n");

                        for (int i = 0; i < options2.Length; i++)
                        {
                            if (i == selectedIndex2)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("-> " + options2[i]);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("   " + options2[i]);
                            }
                        }

                        key2 = Console.ReadKey(true).Key;

                        if (key2 == ConsoleKey.UpArrow)
                        {
                            selectedIndex2 = (selectedIndex2 == 0) ? options2.Length - 1 : selectedIndex2 - 1;
                        }
                        else if (key2 == ConsoleKey.DownArrow)
                        {
                            selectedIndex2 = (selectedIndex2 + 1) % options2.Length;
                        }

                    } while (key2 != ConsoleKey.Enter);

                    if (selectedIndex2 == 0)
                    {
                        Console.WriteLine("Eating...");
                        Console.Write("How many meal do you want?: ");

                        string input = Console.ReadLine();
                        int meal;

                        if (int.TryParse(input, out meal))
                        {
                            cats[selected].Eat(meal);
                        }
                        else
                        {
                            Console.WriteLine("Wrong input");
                        }
                        Console.WriteLine("Press any key for continue...");
                        Console.ReadLine();
                    }
                    else if (selectedIndex2 == 1)
                    {
                        Console.WriteLine("Sleaping...");
                        cats[selected].Sleep();

                    }
                    else if (selectedIndex2 == 2)
                    {
                        cats[selected].Play();
                    }
                }
            }
            if (selectedIndex == 1)
            {
                int selected = 0;
                ConsoleKey keyDogs;

                do
                {
                    Console.Clear();
                    Console.WriteLine("\t\t      _                 \r\n\t\t   __| | ___   __ _ ___ \r\n\t\t  / _` |/ _ \\ / _` / __|\r\n\t\t | (_| | (_) | (_| \\__ \\\r\n\t\t  \\__,_|\\___/ \\__, |___/\r\n\t\t              |___/");
                    for (int i = 0; i < dogs.Length; i++)
                    {
                        if (i == selected)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine($"\t>> ------------------Dog {i + 1}-------------------");
                        }
                        else
                        {
                            Console.WriteLine($"\t   ------------------Dog {i + 1}-------------------");
                        }

                        Console.WriteLine($"\t\tName: {dogs[i].nickName}");
                        Console.WriteLine($"\t\tAge: {dogs[i].age}");
                        Console.WriteLine($"\t\tGender: {dogs[i].gender}");
                        Console.WriteLine($"\t\tEnergy: {dogs[i].energy}");
                        Console.WriteLine($"\t\tPrice: {dogs[i].price}");
                        Console.WriteLine($"\t\tMeal Quantity: {dogs[i].mealQuantity}");
                        Console.WriteLine();
                        Console.ResetColor();
                    }

                    keyDogs = Console.ReadKey(true).Key;

                    if (keyDogs == ConsoleKey.UpArrow)
                    {
                        selected = (selected == 0) ? dogs.Length - 1 : selected - 1;
                    }
                    else if (keyDogs == ConsoleKey.DownArrow)
                    {
                        selected = (selected == dogs.Length - 1) ? 0 : selected + 1;
                    }

                } while (keyDogs != ConsoleKey.Enter);
                Console.Clear();
                Console.WriteLine("Your new cat:\n");
                while (true)
                {
                    string[] options2 = {
            "1) Eat",
            "2) Sleap",
            "3) Play",
        };

                    int selectedIndex2 = 0;
                    ConsoleKey key2;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine($"{dogs[selected].nickName}'s Energy is:{dogs[selected].energy} and Age: {dogs[selected].age}\n");

                        for (int i = 0; i < options2.Length; i++)
                        {
                            if (i == selectedIndex2)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("-> " + options2[i]);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("   " + options2[i]);
                            }
                        }

                        key2 = Console.ReadKey(true).Key;

                        if (key2 == ConsoleKey.UpArrow)
                        {
                            selectedIndex2 = (selectedIndex2 == 0) ? options2.Length - 1 : selectedIndex2 - 1;
                        }
                        else if (key2 == ConsoleKey.DownArrow)
                        {
                            selectedIndex2 = (selectedIndex2 + 1) % options2.Length;
                        }

                    } while (key2 != ConsoleKey.Enter);
                    if (selectedIndex2 == 0)
                    {
                        Console.WriteLine("Eating...");
                        Console.Write("How many meal do you want?: ");

                        string input = Console.ReadLine();
                        int meal;

                        if (int.TryParse(input, out meal))
                        {
                            cats[selected].Eat(meal);
                        }
                        else
                        {
                            Console.WriteLine("Wrong input");
                        }
                        Console.WriteLine("Press any key for continue...");
                        Console.ReadLine();

                    }
                    else if (selectedIndex2 == 1)
                    {
                        Console.WriteLine("Sleaping...");
                        dogs[selected].Sleep();
                        Console.WriteLine("Press any key for continue...");
                        Console.ReadLine();

                    }
                    else if (selectedIndex2 == 2)
                    {
                        dogs[selected].Play();
                        Console.WriteLine("Press any key for continue...");
                        Console.ReadLine();
                    }
                }
            }
                else
                {
                    Console.WriteLine("Error!!!");
                }
            }

    }
}
