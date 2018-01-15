using System;
using System.Collections.Generic;

namespace Restaurant_2
{
    public class Tab
    {
        public IList<double> Entries { get; private set; }

        public void Add(double price)
        {
            Entries.Add(price);
        }

        public void Add(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}