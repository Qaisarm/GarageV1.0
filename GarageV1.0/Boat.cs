using System;
using System.Collections.Generic;
using System.Text;

namespace GarageV1._0
{
    class Boat : Vehicle
    {
        public Boat(string regNr, string color, int numberOfWheels,
            string manufacturer, int modelYear, int lengthOfBoat) : base(regNr, color, numberOfWheels,
            manufacturer, modelYear)
        {
            LengthOfBoat = lengthOfBoat;
        }

        public int LengthOfBoat { get; private set; }
    }
}
