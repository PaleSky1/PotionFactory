using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotionFactory
{
    public interface IPotion
    {
        String getIngredient();
        int getBrewingTime();
        String getHeatLevel();
        String getEffect();
    }
}

