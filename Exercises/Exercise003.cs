using System.Collections.Generic;
using System.Linq;
namespace Exercises
{
    public class Exercise003
    {
        public string[] IceCreamFlavours { get; } = { "Pistachio", "Raspberry Ripple", "Vanilla", "Mint Chocolate Chip", "Chocolate", "Mango Sorbet" };

        public int IceCreamCode(string icecreamflavour)
        {
            return IceCreamFlavours.ToList().FindIndex(flavour => flavour == icecreamflavour);

        }
    }
}
