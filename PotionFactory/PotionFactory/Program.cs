using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PotionFactory;

namespace FactoryPotion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PotionFactory factory = new PotionFactory();
            Console.WriteLine("Please enter your potion");
            String selectedPotion = Console.ReadLine();
            IPotion potion = factory.getPotion(selectedPotion);
            Console.WriteLine("{0} ingredient, brewed for {1} minutes at {2} heat, with effect: {3}",
                potion.getIngredient(), potion.getBrewingTime(), potion.getHeatLevel(), potion.getEffect());
        }
    }
}
