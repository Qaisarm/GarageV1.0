using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GarageV1._0
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private Vehicle[] vehicles;
        public int Capacity { get; }
        public int Count { get; private set; }

        public Garage(int capacity)
        {
            Capacity = capacity;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
