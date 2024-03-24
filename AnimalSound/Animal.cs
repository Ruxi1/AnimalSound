using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound
{
    public class Animal
    {
        private string name;
        private string sound;

        public Animal(string name, string sound)
        {
            this.name = name;
            this.sound = sound;
        }
        public string GetName(string name)
        {
            return name;
        }
        public string GetSound(string sound)
        {
            return sound;
        }

        public void MakesSound()
        {
            Console.WriteLine("{0} makes sound: {1}",this.name,this.sound);
        }
    }
}
