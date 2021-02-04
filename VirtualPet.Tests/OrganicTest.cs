using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class OrganicTest
    {
        Organic testOrganic;

        public OrganicTest()
        {
            testOrganic = new Organic();
        }

        [Fact]
        public void Organic_Constructor_Should_Instantiate_Organic_Object()
        {
            Assert.NotNull(testOrganic);
        }

    }
}
