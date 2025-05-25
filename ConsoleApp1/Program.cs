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
                Console.Clear();
                Console.WriteLine(@"           
                        _       
               ___ __ _| |_ ___ 
              / __/ _` | __/ __|
             | (_| (_| | |_\__ \
              \___\__,_|\__|___/");
                for (int i = 0; i < cats.Length; i++)
                {
                    Console.WriteLine($"\t------------------Cat {i + 1}-------------------");
                    Console.WriteLine($"\tName: {cats[i].nickName}");
                    Console.WriteLine($"\tAge: {cats[i].age}");
                    Console.WriteLine($"\tGender: {cats[i].gender}");
                    Console.WriteLine($"\tEnergy: {cats[i].energy}");
                    Console.WriteLine($"\tPrice: {cats[i].price}");
                    Console.WriteLine($"\tMeal Quantity: {cats[i].mealQuantity}");
                }
                Console.Write("\n\tEnter Choice: ");
                int choiceCat = int.Parse(Console.ReadLine());
                Console.Clear();
                if(choiceCat <= cats.Length)
                {
                    while (true)
                    {
                    Console.WriteLine($"{cats[choiceCat-1].nickName}'s Energy is:{cats[choiceCat-1].energy} and Age: {cats[choiceCat- 1].age}");
                        Console.WriteLine("1. Eat\n2. Sleep\n3. Play\nChoice: ");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            if (cats[choiceCat-1].energy == 0)
                            {
                                Console.WriteLine("You have to sleap!!!!");
                            }
                            else
                            {
                                Console.WriteLine("Eating...");
                                Console.WriteLine("How mani meal do you want?: ");
                                int meal = int.Parse(Console.ReadLine());
                                cats[choiceCat-1].Eat(meal);
                            }
                            
                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("Sleaping...");
                           cats[choiceCat - 1].Sleep();

                        }
                        else if (choice == 3)
                        {
                            cats[choiceCat - 1].Play();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Error!!!");
                }
                    
            }
            if (selectedIndex == 1)
            {
                Console.Clear();
                Console.WriteLine("      _                 \r\n   __| | ___   __ _ ___ \r\n  / _` |/ _ \\ / _` / __|\r\n | (_| | (_) | (_| \\__ \\\r\n  \\__,_|\\___/ \\__, |___/\r\n              |___/     ");
                for (int i = 0; i < dogs.Length; i++)
                {
                    Console.WriteLine($"------------------Dog {i + 1}-------------------");
                    Console.WriteLine($"Name: {dogs[i].nickName}");
                    Console.WriteLine($"Age: {dogs[i].age}");
                    Console.WriteLine($"Gender: {dogs[i].gender}");
                    Console.WriteLine($"Energy: {dogs[i].energy}");
                    Console.WriteLine($"Price: {dogs[i].price}");
                    Console.WriteLine($"Meal Quantity: {dogs[i].mealQuantity}");
                }
                Console.Write("Enter Choice: ");
                int choiceDog = int.Parse(Console.ReadLine());
                Console.Clear();
                if(choiceDog < dogs.Length)
                {

                    while (true)
                    {
                    Console.WriteLine($"{dogs[choiceDog - 1].nickName}'s Energy is:{dogs[choiceDog - 1].energy} and Age: {dogs[choiceDog - 1].age}");
                        Console.WriteLine("1. Eat\n2. Sleep\n3. Play\nChoice: ");
                        int choice = int.Parse(Console.ReadLine());
                        if (choice == 1)
                        {
                            Console.WriteLine("Eating...");
                            Console.WriteLine("How mani meal do you want?: ");
                            int meal = int.Parse(Console.ReadLine());
                            dogs[choiceDog - 1].Eat(meal);

                        }
                        else if (choice == 2)
                        {
                            Console.WriteLine("Sleaping...");
                            dogs[choiceDog - 1].Sleep();

                        }
                        else if (choice == 3)
                        {
                            dogs[choiceDog - 1].Play();
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
}
