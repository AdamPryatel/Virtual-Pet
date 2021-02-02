using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            Console.WriteLine("Hello! Welcome to Virtual Pets");


            Console.WriteLine("What Species is Your Pet?");
            Console.WriteLine("Please Enter the Name of Your Pet");


                
            Console.WriteLine("1. Check On Pet"); // Outputs data of your pet
            Console.WriteLine("2. Feed Pet");       
            Console.WriteLine("3. Play with Pet");
            Console.WriteLine("4. See the Vet");   // see doctor
            Console.WriteLine("5. Exit Game");

            string menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    string petName = pet.GetName();
                    string petSpecies = pet.GetSpecies();
                    int petBoredom = pet.GetBoredom();
                    int petHealth = pet.GetHealth();
                    int petHunger = pet.GetHunger();
                    Console.WriteLine(petName);
                    Console.WriteLine(petSpecies);
                    Console.WriteLine(petName + "'s boredom level is: " + petBoredom);//if/else over 50 = happy less than = bored
                    Console.WriteLine(petName + "'s health level is: " + petHealth);
                    Console.WriteLine(petName + "'s hunger level is: " + petHunger);

                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    break;

            }

            Console.WriteLine("Continue With Your Pet");
                Console.WriteLine("Check On Pet");











        }
    }
}
