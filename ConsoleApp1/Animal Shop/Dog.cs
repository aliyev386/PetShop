using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Animal_Shop
{
    class Dog : Animal
    {
        public override string nickName { get; set; }
        public override double age { get; set; }
        public override string gender { get; set; }
        public override int energy { get; set; }
        public override double price { get; set; }
        public override int mealQuantity { get; set; }

        public Dog() { }
        public Dog(string NickName, double Age, string Gender, int Energy, double Price, int MealQuantity)
        {
            this.nickName = NickName;
            this.age = Age;
            this.gender = Gender;
            this.energy = Energy;
            this.price = Price;
            this.mealQuantity = MealQuantity;
        }
        
        public override void Eat() // bunu elemekde meksedim base classdaki metodumuzda parametr olmamasidir
        {
            Eat(mealQuantity);
        }
        public void Eat(int MealQuantity)
        {
            if (MealQuantity <= mealQuantity)
            {
                int totalEnergy = MealQuantity * 10;
                int ttotalEnetgy = totalEnergy + energy;
                if (ttotalEnetgy < 100)
                {
                    age += 0.1;
                    Console.WriteLine($"Energy: {ttotalEnetgy} %");
                    energy = ttotalEnetgy;
                }
                else if (ttotalEnetgy == 100)
                {
                    Console.WriteLine("Energy is full");
                    Console.WriteLine($"Energy: {ttotalEnetgy} %");
                    energy = ttotalEnetgy;
                }
                else if (ttotalEnetgy > 100)
                {
                    ttotalEnetgy = 100;
                    Console.WriteLine($"Energy: {ttotalEnetgy} %");
                    energy = ttotalEnetgy;
                }
            }
            else
            {
                Console.WriteLine("You have not enough meal!!!");
            }
        }
        public override void Sleep()
        {
            if (energy == 100)
            {
                Console.WriteLine("Your energy is full");
            }
            else
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine($"Energy: {energy} %");
                    energy += 10;
                    Thread.Sleep(1000);
                    if (energy > 100)
                    {
                        energy = 100;
                        Console.WriteLine("Good Morning");
                        break;
                    }
                }
            }
        }
        public void Play()
        {
            if (energy > 0)
            {
                Console.WriteLine($"{nickName} is playing...");
                while (true)
                {
                    energy -= 10;
                    if (energy == 0)
                    {
                        energy = 0;
                        Console.WriteLine("You're out of energy");
                        Console.WriteLine("You have to sleap !!!");
                        break;
                    }
                    Console.WriteLine($"Your energy {energy} %\nDo you want to continue?\n1. Yes 2. No\nChoice: ");
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 2)
                    {
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine($"{nickName}' not have enough energy!!!");
            }
        }


    }
}
