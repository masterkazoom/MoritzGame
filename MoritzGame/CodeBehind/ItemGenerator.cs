using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoritzGame.CodeBehind
{
    class ItemGenerator
    {
        
        public Item GenerateItem(Hero hero1, Random rnd)
        {           
            if(rnd.NextDouble()<0.5)
            {
                return new Weapon(hero1.Level, hero1.ClassName, rnd);
            }
            else
            {
                return new Armor(hero1.Level, hero1.ClassName, rnd);
            }        
        }   
    }
}
