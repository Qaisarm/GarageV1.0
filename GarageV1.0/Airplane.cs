using System;
using System.Collections.Generic;
using System.Text;

namespace GarageV1._0
{
    class Airplane : Vehicle
    {
        public Airplane(string regNr, string color, int numberOfWheels,
            string manufacturer, int modelYear, int numberOfEngines) : base(regNr, color, numberOfWheels,
            manufacturer, modelYear)
        {
            NumberOfEngines = numberOfEngines;

        }

        public int NumberOfEngines { get; private set; }
    }
}
