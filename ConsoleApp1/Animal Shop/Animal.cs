using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Animal_Shop
{
    abstract class Animal
    {
        public virtual string nickName { get; set; }
        public virtual double age { get; set; }
        public virtual string gender { get; set; }
        public virtual int energy { get; set; }
        public virtual double price { get; set; }
        public virtual int mealQuantity { get; set; }

        public virtual void Eat()
        {

        }
        public virtual void Sleep()
        {

        }
        public virtual void Play()
        {

        }
    }
}
