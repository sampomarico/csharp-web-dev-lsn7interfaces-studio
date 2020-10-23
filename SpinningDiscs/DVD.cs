using System;
namespace SpinningDiscs
{
    public class DVD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately.

        string Video { get; set; }

        public DVD(string spinRate, string storageCapacity, string diameter, string video) : base(spinRate, storageCapacity, diameter)
        {
            Video = video;
        }

        public void SpinDisc()
        {
            Console.WriteLine("Disc is spinning at rate of " + this.SpinRate + ".");
        }

        public override void PlayMedia()
        {
            Console.WriteLine("Disc is currently playing " + this.Video + ".");
        }

        public void ReadDiscFacts()
        {
            Console.WriteLine("This disc has a diameter of " + this.Diameter + " and has a storage capacity of " + this.StorageCapacity + ".");
        }
    }
}
