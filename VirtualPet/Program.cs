using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet = new Pet();
            Console.WriteLine("Hello! Welcome to Virtual Pets");


            Console.WriteLine("What Species is Your Pet? ");

            pet.SetSpecies(Console.ReadLine());

            Console.WriteLine("Please Enter the Name of Your Pet: ");

            pet.SetName(Console.ReadLine());

            bool keepPlaying = true;
            while(keepPlaying)
            { 

                
                Console.WriteLine("1. Check On Pet"); // Outputs data of your pet
                Console.WriteLine("2. Feed Pet");       
                Console.WriteLine("3. Play with Pet");
                Console.WriteLine("4. See the Vet");   // see doctor
                Console.WriteLine("5. Exit Game");

                string menuChoice = Console.ReadLine();



                int petBoredom = pet.GetBoredom();
                int petHealth = pet.GetHealth();
                int petHunger = pet.GetHunger();

                switch (menuChoice)
                {
                    case "1":
                    
                        Console.WriteLine(pet.Name);
                        Console.WriteLine(pet.Species);
                        Console.WriteLine(pet.Name + "'s boredom level is: " + petBoredom);//if/else over 50 = happy less than = bored
                        Console.WriteLine(pet.Name + "'s health level is: " + petHealth);
                        Console.WriteLine(pet.Name + "'s hunger level is: " + petHunger);

                        break;
                    case "2":
                        pet.Feed();
                        Console.WriteLine("You Fed " + pet.Name);
                        break;
                    case "3":
                        pet.Play();
                        Console.WriteLine("You played with " + pet.Name);
                        break;
                    case "4":
                        pet.SeeDoctor();
                        Console.WriteLine("You took " + pet.Name + " to the vet!");
                        break;
                    case "5":
                        Console.WriteLine("Thank's for Playing!");
                        keepPlaying = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;

                }

                pet.Tick();

                Console.WriteLine("Press Any Key to Continue");
                Console.ReadKey();
                Console.Clear();

            }

           

        }
    }
}
