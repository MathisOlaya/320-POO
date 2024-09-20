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
            Assert.AreEqual(Drone.DEFAULT_CHARGE, drone.Charge, "La charge doit �tre �gale � 1000 apr�s cr�ation");
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
            Assert.IsTrue(LastCharge > drone.Charge, "La charge doit diminuer apr�s une Update");
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
    }
}