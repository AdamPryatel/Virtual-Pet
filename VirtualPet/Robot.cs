using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Robot : Pet
    {
        public int Oil { get; set; } = 50;
        public int Performance { get; set; } = 30;

        public Robot()
        {

        }
        
        
        public int GetOil()
        {
            return Oil;
        }
        public void AddOil()
        {
            Oil += 40;
        }

        public int GetPerformance()
        {
            return Performance;
        }

        public void Maintenance()
        {
            Performance += 30;
        }

        public override void Play()
        {
            Oil -= 10;
            Boredom -= 20;
            Performance -= 10;
        }


        public override void Tick()
        {
            Oil -= 5;
            Boredom += 5;
            Performance -= 5;
        }

    }
}
