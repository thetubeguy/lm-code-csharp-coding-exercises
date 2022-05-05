using System;
namespace Exercises
{
    public class Exercise003
    {
        // I thought about using lists and key / value pairs, but decided to keep it simple for now.

        static readonly string[] LocalIceCreamFlavours = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };


        // Make IceCreamFlavours a read-only property
        public static string[] IceCreamFlavours
        {
            get { return LocalIceCreamFlavours; }

        }
        public int IceCreamCode(string iceCreamFlavour)
        {
            for(int i = 0; i < IceCreamFlavours.Length; i++)
                if(IceCreamFlavours[i] == iceCreamFlavour)
                    return i;
            return -1;
        }
    }
}
