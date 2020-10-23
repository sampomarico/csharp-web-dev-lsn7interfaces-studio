using System;
namespace SpinningDiscs
{
    public class CD : BaseDisc, IOpticalDisc
    {
        // TODO: Implement your custom interface.

        // TODO: Determine which fields, methods, and constructors can be extended from the base class and which ones
        //  need to be declared separately. 

        public string Audio { get; set; }

        public CD(string spinRate, string storageCapacity, string diameter, string audio) : base(spinRate, storageCapacity, diameter)
        {
            Audio = audio;
        }

        public override void PlayMedia()
        {
            Console.WriteLine("This disc is now playing an album by " + this.Audio + ".");
        }

        public void SpinDisc()
        {
                Console.WriteLine("Disc is spinning at rate of " + this.SpinRate + ".");  
        }

        public void ReadDiscFacts()
        {
            Console.WriteLine("This disc has a diameter of " + this.Diameter + " and has a storage capacity of " + this.StorageCapacity + ".");
        }
    }
}
