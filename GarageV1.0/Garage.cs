using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GarageV1._0
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private Vehicle[] ParkedVehicles;

        public string Name;
        public int MaxCapacity;

        // Count all occupied spaces
        public int Count => ParkedVehicles.Count(c => c != null);

        // Check whether the Garage is full or not

        public bool IsFull => MaxCapacity <= Count;
        public Garage(string name, int capacity)
        {
            Name = name;
            MaxCapacity = capacity;
            ParkedVehicles = new Vehicle[MaxCapacity];
        }
        internal class DisplayListOfVehicals
        {
            internal int ParkingPlace { get; set; }
            internal string Manufacturer { get; set; }
            internal string RegNr { get; set; }
            internal string Color { get; set; }
            internal string VehecalType { get; set; }
            internal int NumberOfWheels { get; set; }
            internal int ModelYear { get; set; }

        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var vehicle in ParkedVehicles.Where(v => v != null))
                yield return (T)vehicle;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
