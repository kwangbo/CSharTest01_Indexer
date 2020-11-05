using System;

namespace BodiedConstructor
{

    class Pet
    {
        public string Name { get; set; }
        public Pet(string name) => Name = name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet("야옹이");
            Console.WriteLine(pet.Name);
        }
    }
}
