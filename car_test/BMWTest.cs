using CarFactoryLibrary;
using Xunit;

namespace car_test
{
    public class BMWTests
    {
      
        //Boolean
        [Fact]
        public void IsStopped_WhenVelocityIsZero_ReturnsTrue()
        {
            BMW bmw = new BMW();
            bmw.velocity = 0;
            bool result = bmw.IsStopped();
            Assert.True(result);
        }

        [Fact]
        public void IsStopped_WhenVelocityIs10_ReturnsFalse()
        {
            BMW bmw = new BMW();
            bmw.velocity = 10;
            bool result = bmw.IsStopped();
            Assert.False(result);
        }

        [Fact]
        public void IncreaseVelocity_WhenAddingVelocity_UpdatesVelocityCorrectly()
        {
            BMW bmw = new BMW();
            bmw.velocity = 10;
            double addedVelocity = 20;
            bmw.IncreaseVelocity(addedVelocity);

            Assert.Equal(30, bmw.velocity);
        }

        // Number
        [Fact]
        public void IncreaseVelocity_WhenAddingVelocity_GreaterThanPreviousVelocity()
        {
            BMW bmw = new BMW();
            bmw.velocity = 10;
            double addedVelocity = 20;
            bmw.IncreaseVelocity(addedVelocity);

            Assert.True(bmw.velocity > 10);
        }


        [Fact]
        public void IncreaseVelocity_WhenAddingVelocity_DoesNotEqualPreviousVelocity()
        {
            BMW bmw = new BMW();
            bmw.velocity = 10;
            double addedVelocity = 20;

            bmw.IncreaseVelocity(addedVelocity);

            Assert.NotEqual(10, bmw.velocity);
        }


        //String 

        [Fact]
        public void GetDirection_WhenDirectionIsForward_ReturnsForward()
        {
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.Equal("Forward", result);
        }

        [Fact]
        public void GetDirection_WhenDirectionIsForward_StartsWithF()
        {
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.StartsWith("F", result);
        }

        [Fact]
        public void GetDirection_WhenDirectionIsForward_EndsWithRd()
        {
            BMW bmw = new BMW();
            bmw.drivingMode = DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.EndsWith("rd", result);
        }

        [Fact]
        public void GetDirection_WhenDirectionIsForward_ContainsWa()
        {
            BMW bmw = new BMW();
            bmw.drivingMode= DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.Contains("wa", result);
        }

        [Fact]
        public void GetDirection_WhenDirectionIsForward_DoesNotContainZx()
        {
            BMW bmw = new BMW();
            bmw.drivingMode= DrivingMode.Forward;
            string result = bmw.GetDirection();
            Assert.DoesNotContain("sa", result);
        }

        //Refrence
        [Fact]
        public void GetMyCar_ReturnsSameCarInstance()
        {
            BMW bmw = new BMW();
            Car car = bmw.GetMyCar();
            Assert.Same(bmw, car);
        }

        [Fact]
        public void GetMyCar_ReturnsDifferentCarInstances()
        {
            BMW bmw = new BMW();
            BMW bmw2 = new BMW();

            Car car = bmw.GetMyCar();
            Car car2 = bmw2.GetMyCar();

            Assert.NotSame(car, car2);
        }

        

    }
}
