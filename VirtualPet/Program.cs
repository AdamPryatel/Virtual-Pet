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
            // Remove boolean and create two separate constrictors for robot and organic. 

            //Robot robotPet = new Robot();
            //{
            //    PetNumber = 
            //}

            Console.WriteLine("Hello! Welcome to Virtual Pet Shelter");

            //Console.WriteLine("Are you here adopt a );


            bool keepPlaying = true;
            while(keepPlaying)
            { 

                
                Console.WriteLine("1. Check On Pets"); // Outputs data of your pet
                Console.WriteLine("2. Feed Pet");       
                Console.WriteLine("3. Play with Pet");
                Console.WriteLine("4. See the Vet");   // see doctor
                Console.WriteLine("5. Exit Game");
                Console.WriteLine("6. Create Robot");
                Console.WriteLine("7. Create Organic Pet");

                string menuChoice = Console.ReadLine();



                int petBoredom = myPet.GetBoredom();
                int petHealth = myPet.GetHealth();
                int petHunger = myPet.GetHunger();
                int robotPerformance = myRobot.GetPerformance();
                int robotOil = myRobot.GetOil();
                

                switch (menuChoice)
                {
                    case "1":


                        foreach (Pet pet in myShelter.ListofPets)
                        {
                            Console.WriteLine("The current Boredom level of " + pet.Name + " is " + petBoredom);

                            if(myPet == myOrganic)
                            {
                                Console.WriteLine("The Current Health Level of " + pet.Name + " is " + petHealth);
                            }
                            else if (myPet == myRobot)
                            {
                                Console.WriteLine("The Current Oil Level of " + pet.Name + " is " + robotOil);
                            }
                        }

                            break;

                        //myPet.IsRobot = true;
                        //if (false)
                        //{
                        //    Console.WriteLine(myPet.Name);
                        //    Console.WriteLine(myPet.Species);
                        //    Console.WriteLine(myPet.Name + "'s boredom level is: " + petBoredom);
                        //    Console.WriteLine(myPet.Name + "'s health level is: " + petHealth);
                        //    Console.WriteLine(myPet.Name + "'s hunger level is: " + petHunger);

                        //}
                        //else if (true)
                        //{
                        //    Console.WriteLine(myPet.Name);
                        //    Console.WriteLine(myPet.Species);
                        //    Console.WriteLine(myPet.Name + "'s boredom level is: " + petBoredom);
                        //    Console.WriteLine(myPet.Name + "'s health level is: " + Robot.Performance);
                        //    Console.WriteLine(myPet.Name + "'s hunger level is: " + Robot.Oil);
                        //}


                        break;
                    case "2":
                        //pet.Feed();
                        //Console.WriteLine("You Fed " + pet.Name);
                        break;
                    case "3":
                        //pet.Play();
                        //Console.WriteLine("You played with " + pet.Name);
                        break;
                    case "4":
                        //pet.SeeDoctor();
                        //Console.WriteLine("You took " + pet.Name + " to the vet!");
                        break;
                    case "5":
                        Console.WriteLine("Thank's for Playing!");
                        keepPlaying = false;
                        break;
                    case "6":
                        myShelter.AddPet(myRobot);

                        //Console.WriteLine("Is your pet a robot? true or false");
                        //myPet.SetIsRobot(Convert.ToBoolean(Console.ReadLine()));

                        Console.WriteLine("What Species is Your Pet? ");
                        myRobot.SetSpecies(Console.ReadLine());

                        Console.WriteLine("Please Enter the Name of Your Pet: ");
                        myRobot.SetName(Console.ReadLine());
                        break;
                    case "7":
                        myShelter.AddPet(myOrganic);

                        Console.WriteLine("What Species is Your Pet? ");
                        myOrganic.SetSpecies(Console.ReadLine());

                        Console.WriteLine("Please Enter the Name of Your Pet: ");
                        myOrganic.SetName(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Invalid Entry");
                        break;

                }

                //pet.Tick();

                Console.WriteLine("Press Any Key to Continue");
                Console.ReadKey();
                Console.Clear();

            }

           

        }
    }
}
