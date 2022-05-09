using System;
namespace Exercises
{
    public class Exercise003
    {
        public string[] IceCreamFlavours { get; } = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        public int IceCreamCode(string icecreamFlavour)
        {
            return Array.IndexOf(IceCreamFlavours, icecreamFlavour);

        }
    }
}
