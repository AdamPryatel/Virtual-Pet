using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{

    public class ShelterTest
    {
        Shelter myShelter;

        public ShelterTest()
        {
            myShelter = new Shelter();
        }

        [Fact]
        public void AddPet_Should_Increase_List_Count_by_1()
        {
            //Arrange
            myShelter.ListofPets.Clear();
            Pet newPet = new Pet();

            //Act
            myShelter.AddPet(newPet);

            //Assert
            Assert.Single(myShelter.ListofPets);

        }



    }



}
