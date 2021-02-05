using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
   public class Shelter
    {

        public List<Pet> ListofPets = new List<Pet>();

        public void AddPet(Pet pet)
        {
            ListofPets.Add(pet);
        }

        public Pet SelectPet()
        {
            int index = 1;

            Console.WriteLine("Please select a pet from the list:");

            foreach(Pet pet in ListofPets)
            {
                Console.WriteLine(index + ". " + pet.Species + " " + pet.Name);
                index++;
            }

            int indexSelected = Convert.ToInt32(Console.ReadLine());

            return ListofPets[indexSelected - 1];
        }
        public Pet AdoptPet()
        {
            int index = 1;

            Console.WriteLine("Please select a pet from the list:");

            foreach (Pet pet in ListofPets)
            {
                Console.WriteLine(index + ". " + pet.Species + " " + pet.Name);
                index++;
                
            }
            int indexSelected = Convert.ToInt32(Console.ReadLine());
            ListofPets.RemoveAt(indexSelected -1);
            return ListofPets[indexSelected - 1];
        }
    }
}
