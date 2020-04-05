using System;
using System.Collections.Generic;
using System.Text;

namespace GarageV1._0
{
    class Car: Vehicle
    {
        public Car(string regNr, string color, int numberOfWheels,
            string manufacturer, int modelYear, string fuelType) : base(regNr, color, numberOfWheels,
            manufacturer, modelYear)
        {
            FuelType = fuelType;
        }

        public string FuelType { get; private set; }
    }
}
