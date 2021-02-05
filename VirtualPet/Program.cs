using System;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet myPet = new Pet();
            Shelter myShelter = new Shelter();
            Organic myOrganic = new Organic();
            Robot myRobot = new Robot();
           

            Console.WriteLine("Hello! Welcome to Virtual Pet Shelter");

           
            bool keepPlaying = true;
            while(keepPlaying)
            { 

                
                Console.WriteLine("1. Create Robot Pet");
                Console.WriteLine("2. Create Organic Pet");
                Console.WriteLine("3. Check On All Pets"); 
                Console.WriteLine("4. Feed or Oil All Pets");       
                Console.WriteLine("5. Select a Pet to Feed or Oil.");
                Console.WriteLine("6. Play with All Pets");
                Console.WriteLine("7. Select a Pet to Play with.");
                Console.WriteLine("8. Take All Pets to the Vet or Mechanic");  
                Console.WriteLine("9. Select a Pet to take to the Vet or Mechanic.");
                Console.WriteLine("10. Select a Pet to be Adopted from the Shelter.");
                Console.WriteLine("11. Exit Game");

                string menuChoice = Console.ReadLine();



                int petBoredom = myPet.GetBoredom();
                int petHealth = myPet.GetHealth();
                int petHunger = myPet.GetHunger();
                int robotPerformance = myRobot.GetPerformance();
                int robotOil = myRobot.GetOil();
                

                switch (menuChoice)
                {
                    case "1":
                        myShelter.AddPet(myRobot);

                        Console.WriteLine("What Species is Your Robot Pet? ");
                        myRobot.SetSpecies(Console.ReadLine());

                        Console.WriteLine("Please Enter the Name of Your Robot " + myRobot.Species + ": ");
                        myRobot.SetName(Console.ReadLine());
                        break;
                    case "2":
                        myShelter.AddPet(myOrganic);

                        Console.WriteLine("What Species is Your Organic Pet? ");
                        myOrganic.SetSpecies(Console.ReadLine());

                        Console.WriteLine("Please Enter the Name of Your Organic " + myOrganic.Species + ": ");
                        myOrganic.SetName(Console.ReadLine());
                        break;
                    case "3":
                        foreach (Pet pet in myShelter.ListofPets)
                        {
                            Console.WriteLine("The Current Boredom level of " + pet.Name + " is " + petBoredom);

                            if (pet == myOrganic)
                            {
                                Console.WriteLine("The Current Health Level of " + pet.Name + " is " + petHealth);
                                Console.WriteLine("The Current Hunger Level of " + pet.Name + " is " + petHunger);
                            }
                            else if (pet == myRobot)
                            {
                                Console.WriteLine("The Current Oil Level of " + pet.Name + " is " + robotOil);
                                Console.WriteLine("The Current Performance Level of " + pet.Name + " is " + robotPerformance);
                            }
                        }
                        break;
                    case "4":
                        foreach (Pet pet in myShelter.ListofPets) 
                        {
                            if (pet == myOrganic)
                            {
                                myPet.Feed();
                                Console.WriteLine("You Fed " + pet.Name);
                            }
                            else if (pet == myRobot)
                            {
                                myRobot.GetOil();
                                Console.WriteLine("You gave oil to " + pet.Name);
                            }
                        }
                        break;
                    case "5":
                        myPet = myShelter.SelectPet();
                        if (myPet == myOrganic)
                        {
                            myPet.Feed();
                            Console.WriteLine("You Fed " + myPet.Name);
                        }
                        else if (myPet == myRobot)
                        {
                            myRobot.GetOil();
                            Console.WriteLine("You gave oil to " + myPet.Name);
                        }
                        break;
                    case "6":
                        foreach (Pet pet in myShelter.ListofPets)
                        {
                        pet.Play();
                        Console.WriteLine("You played with " + pet.Name);
                        }
                        break;
                    case "7":
                        myPet = myShelter.SelectPet();
                        myPet.Play();
                        Console.WriteLine("You played with " + myPet.Name);
                       break;
                    case "8":
                        foreach (Pet pet in myShelter.ListofPets)
                        {
                            if(pet == myOrganic)
                            {
                            pet.SeeDoctor();
                            Console.WriteLine("You took " + pet.Name + " to the vet!");
                            }
                            else if(pet == myRobot)
                            {
                            myRobot.SeeMechanic();
                                Console.WriteLine("You took " + pet.Name + " to the mechanic!");
                            }
                        }
                        break;
                    case "9":
                        myPet = myShelter.SelectPet();
                        if (myPet == myOrganic)
                        {
                            myPet.SeeDoctor();
                            Console.WriteLine("You took " + myPet.Name + " to the vet!");
                        }
                        else if (myPet == myRobot)
                        {
                            myRobot.SeeMechanic();
                            Console.WriteLine("You took " + myPet.Name + " to the mechanic!");
                        }
                        break;
                    case "10":
                        myShelter.AdoptPet();
                        Console.WriteLine("That pet has been adopted!");
                        break;
                    case "11":
                        Console.WriteLine("Thank's for Playing!");
                        keepPlaying = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;

                }

                myPet.Tick();

                Console.WriteLine("Press Any Key to Continue");
                Console.ReadKey();
                Console.Clear();

            }

           

        }
    }
}
