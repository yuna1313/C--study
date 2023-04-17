using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public enum DogBreed { Mixed, Bulldog, Jindo, Yorkshire }

    public class Dog
    {
        public int PedId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;
        public DogBreed Breed;

        public Dog(int petId, string name, string color, string gender, DogBreed breed)
        {
            this.PedId = petId;
            this.Name = name;
            this.Color = color;
            this.Gender = gender;
            this.Breed = breed;
        }

        public string MakeSound()
        {
            return "멍멍";
        }

        public string Bite()
        {
            return "물어뜯기";
        }
    }
}
