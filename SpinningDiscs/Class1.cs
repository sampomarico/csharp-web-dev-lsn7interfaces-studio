using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class BaseDisc
    {
        public string SpinRate { get; set; }
        public string StorageCapacity { get; set; }
        public string Diameter { get; set; }

        public BaseDisc(string spinRate, string storageCapacity, string diameter)
        {
            SpinRate = spinRate;
            StorageCapacity = storageCapacity;
            Diameter = diameter;
        }

        public abstract void PlayMedia();
    }
}
