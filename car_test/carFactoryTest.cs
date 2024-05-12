using CarFactoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_test
{
    public class carFactoryTest
    {
        //Exception
        [Fact]
        public void NewCar_CarTypeHonda_Exception()
        {

            Assert.Throws<NotImplementedException>(() =>
            {
              
                Car? result = CarFactory.NewCar(CarTypes.Honda);
            });
        }
    }
}
