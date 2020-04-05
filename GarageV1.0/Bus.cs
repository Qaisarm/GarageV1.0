using System;
using System.Collections.Generic;
using System.Text;

namespace GarageV1._0
{
    class Bus : Vehicle
    {
        public Bus(string regNr, string color, int numberOfWheels,
            string manufacturer, int modelYear, int numberOfSeats) : base(regNr, color, numberOfWheels,
            manufacturer, modelYear)
        {
            NumberOfSeats = numberOfSeats;
        }

        public int NumberOfSeats { get;  private set; }
    }
}
