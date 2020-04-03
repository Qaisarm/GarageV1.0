using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GarageV1._0
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
