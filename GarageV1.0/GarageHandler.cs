using System;

namespace GarageV1._0
{
    internal class GarageHandler
    {
        internal object CreatGarage(string name, int capacity)
        {
            return new Garage(name, capacity);
        }

        internal void ListOfAllParkedVehicles(Garage<Vehicle> garage)
        {
            throw new NotImplementedException();
        }
    }
}