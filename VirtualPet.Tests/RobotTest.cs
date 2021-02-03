using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace VirtualPet.Tests
{
    public class RobotTest
    {

        Robot testRobot;

        public RobotTest()
        {
            testRobot = new Robot();
        }

        [Fact]
        public void Robot_Constructor_Should_Instantiate_Robot_Object()
        {
            Assert.NotNull(testRobot);
        }

        [Fact]
        public void Robot_Should_Have_Oil()
        {
            testRobot.Oil = 100;

            Assert.Equal(100, testRobot.Oil);
        }
        [Fact]
        public void GetOil_Should_Return_Initial_Oil_Level_Of_50()
        {
            int testRobotOil = testRobot.GetOil();

            Assert.Equal(50, testRobotOil);
        }
        [Fact]
        public void AddOil_Should_Increase_Oil_By_40()
        {
            testRobot.AddOil();

            Assert.Equal(90, testRobot.GetOil());
        }


        [Fact]
        public void Robot_Should_Have_Performance()
        {
            testRobot.Performance = 100;

            Assert.Equal(100, testRobot.Performance);
        }

        [Fact]
        public void GetPerformance_Should_Return_Initial_Performance_Level_Of_30()
        {
            int testRobotPerformance = testRobot.GetPerformance();

            Assert.Equal(30, testRobotPerformance);
        }

        [Fact]
        public void Maintenance_Should_Increase_Performance_By_30()
        {
            testRobot.Maintenance();

            Assert.Equal(60, testRobot.GetPerformance());

        }






    }
}
