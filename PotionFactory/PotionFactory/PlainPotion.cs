using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionFactory
{
    internal class PlainPotion : IPotion
    {
        public string getIngredient()
        {
            return "Water";
        }

        public int getBrewingTime()
        {
            return 2;
        }

        public string getHeatLevel()
        {
            return "Low";
        }

        public string getEffect()
        {
            return "No effect, just warm water.";
        }
    }
}
