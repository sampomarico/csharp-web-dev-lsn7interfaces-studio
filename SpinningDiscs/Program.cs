using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Declare and initialize a CD and a DVD object.
            DVD newDVD = new DVD("570 - 1600 rpm", "50GB", "12cm", "Lord of the Rings");
            CD newCD = new CD("200 - 500 rpm", "900mb", "8cm", "Fleet Foxes");

            // TODO: Call each CD and DVD method to verify that they work as expected.

            newDVD.SpinDisc();
            newDVD.PlayMedia();
            newDVD.ReadDiscFacts();

            newCD.SpinDisc();
            newCD.PlayMedia();
            newCD.ReadDiscFacts();
        }
    }
}
