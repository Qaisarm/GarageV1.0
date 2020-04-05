using System;
using System.Collections.Generic;
using System.Text;

namespace GarageV1._0
{
    class Motorcycle: Vehicle
    {
        public Motorcycle(string regNr, string color, int numberOfWheels,
            string manufacturer, int modelYear, int cylinderVolume) : base(regNr, color, numberOfWheels,
            manufacturer, modelYear)
        {
            CylinderVolume = cylinderVolume;

        }

        public int CylinderVolume { get; private set; }
    }
}
