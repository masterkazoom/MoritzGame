using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoritzGame.CodeBehind
{
    class Adventure
    {
        ItemGenerator itemgenerator = new ItemGenerator();
        Random rnd;
        public Adventure()
        {
            
        }

        public void BasicItems(Hero hero1)
        {
            rnd = new Random();
            hero1.Inventar.AddToInventory(itemgenerator.GenerateItem(hero1, rnd));       
            hero1.Inventar.AddToInventory(itemgenerator.GenerateItem(hero1, rnd));
        }

    }
}
