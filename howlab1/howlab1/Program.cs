using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examlaboneandtwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            //Console.WriteLine("Enter animal:");
            animal.AnimalTyp = "Cat";
            animal.Color = "Red";
            animal.Weight = 2.5;
            animal.Show();
           

            Pet pet = new Pet();
            pet.AnimalTyp = "Dog";
            pet.Color = "Blue";
            pet.Weight = 6.66;
            pet.Nikname = "Pap";
            pet.Show();
        }
        public class Animal
        {
            public string AnimalTyp, Color;
            public double Weight;
            virtual public void Show()
            {
                Console.WriteLine("Typ: {0} Color:{1} Weight:{2}", AnimalTyp, Color, Weight);

            }
        }
        public class Pet : Animal
        {
            public string Nikname;
            override
                public void Show()
            {
                Console.WriteLine("Typ: {0} Color:{1} Weight:{2} Nikname:{3}", AnimalTyp, Color, Weight, Nikname);
            }
        }



    }
}