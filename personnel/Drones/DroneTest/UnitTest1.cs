using Drones;

namespace DroneTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Drone_Charge_Is_Equal_1000()
        {
            //Arrange
            Drone drone;

            //Act
            drone = new Drone("toto", 10, 10);

            //Assert 
            Assert.AreEqual(Drone.DEFAULT_CHARGE, drone.Charge, "La charge doit être égale à 1000 après création");
        }
        [TestMethod]
        public void Drone_Charge_Is_Lower_Each_Update()
        {
            //Arrange
            Drone drone = new Drone("toto", 10, 10);
            int LastCharge = drone.Charge;

            //Act
            drone.Update(10);

            //Assert
            Assert.IsTrue(LastCharge > drone.Charge, "La charge doit diminuer après une Update");
        }
        [TestMethod]
        public void Drone_Charge_Is_Lower_Than_20_LowBattery_Equal_True()
        {
            //Arrange
            Drone drone = new Drone("toto", 10, 10);

            //Act
            drone.Update(10);

            //Assert 
            Assert.IsTrue(drone.Charge < Drone.DEFAULT_CHARGE / 5 && drone.LowBattery == true);
        }
        [TestMethod]
        public void Test_that_drone_is_taking_orders()
        {
            // Arrange
            Drone drone = new Drone("Parker", 500, 500);

            // Act
            EvacuationState state = drone.GetEvacuationState();

            // Assert
            Assert.AreEqual(EvacuationState.Free, state);

            // Arrange a no-fly zone around the drone
            bool response = drone.Evacuate(new System.Drawing.Rectangle(400, 400, 200, 200));

            // Assert
            Assert.IsFalse(response); // because the zone is around the drone
            Assert.AreEqual(EvacuationState.Evacuating, drone.GetEvacuationState());

            // Arrange: remove no-fly zone
            drone.FreeFlight();

            // Assert
            Assert.AreEqual(EvacuationState.Free, drone.GetEvacuationState());
        }


    }
}