using System;

namespace GarageV1._0
{
    internal class GarageHandler : IGarageHandler
    {
        public Garage<Vehicle> CreateGarage(string name, int capacity)
        {
            return new Garage<Vehicle>(name, capacity);
        }


        internal void ListOfAllParkedVehicles(Garage<Vehicle> garage)
        {
            throw new NotImplementedException();
        }
    }
}