using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Pet
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public int Hunger { get; set; } = 50;
        public int Boredom { get; set; } = 60;
        public int Health { get; set; } = 30;

        public void SetName(string name)
        {
            Name = name;
        }
        public string GetName()
        {
            return Name;
        }

        public void SetSpecies(string species)
        {
            Species = species;
        }

        public string GetSpecies()
        {
            return Species;
        }

        public void SetHunger(int hunger)
        {
            Hunger = hunger;
        }

        public int GetHunger()
        {
          //  Hunger = 50;
            return Hunger;
        }
        public int GetBoredom()
        {
        //    Boredom = 60;
            return Boredom;
        }

        public int GetHealth()
        {
          //  Health = 30;
            return Health;
        }
        public void Feed()
        {
            Hunger -= 40;
        }
        public void SeeDoctor()
        {
            Health += 30;
        }
        

        public virtual void Play()
        {
            Hunger += 10;
            Boredom -= 20;
            Health += 10;
        }

        public void Tick()
        {
            Hunger += 5;
            Boredom += 5;
            Health -= 5;
        }
        
        
    } 


    
    
    

}
