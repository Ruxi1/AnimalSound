using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
           
            animals.Add(new Animal("duck", "mack"));
            animals.Add(new Animal("bee", "buzz"));
            animals.Add(new Animal("cat", "meow"));
            animals.Add(new Animal("dog", "ham"));

            for (int i = 0; i < animals.Count; i++)
            {
                animals[i].MakesSound();
            }

            Console.ReadKey();
        }
    }
}
