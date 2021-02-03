using System;
using System.Collections.Generic;
using System.Text;

namespace VirtualPet
{
    public class Robot : Pet
    {
        public int Oil { get; set; } = 50;

        public int GetOil()
        {
            return Oil;
        }
        public void AddOil()
        {
            Oil += 40;
        }
    }
}
