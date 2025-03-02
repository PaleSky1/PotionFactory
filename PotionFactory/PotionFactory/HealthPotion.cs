using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionFactory
{
    internal class HealthPotion : IPotion
    {
        public string getIngredient()
        {
            return "Herbs";
        }

        public int getBrewingTime()
        {
            return 5;
        }

        public string getHeatLevel()
        {
            return "Medium";
        }

        public string getEffect()
        {
            return "Restores 50 HP.";
        }
    }

}
