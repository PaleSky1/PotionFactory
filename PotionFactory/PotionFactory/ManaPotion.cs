using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionFactory
{
    internal class ManaPotion : IPotion
    {
        public string getIngredient()
        {
            return "Magic Dust";
        }

        public int getBrewingTime()
        {
            return 7;
        }

        public string getHeatLevel()
        {
            return "High";
        }

        public string getEffect()
        {
            return "Restores 40 MP.";
        }
    }
}
