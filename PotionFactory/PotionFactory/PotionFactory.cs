using PotionFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPotion
{
    public class PotionFactory
    {
        public IPotion returnInstance;
        public IPotion getPotion(string potionType)
        {
            if (potionType.ToLower().Equals("health"))
            {
                returnInstance = new HealthPotion();
            }
            else if (potionType.ToLower().Equals("mana"))
            {
                returnInstance = new ManaPotion();
            }
            else
            {
                returnInstance = new PlainPotion();
            }
            return returnInstance;
        }
    }
}
