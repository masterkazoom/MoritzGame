using MoritzGame.CodeBehind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Level
    {
        public int LevelNr = 99;
        public int CurrentLevel = 1;
        Random rnd = new Random();
        public NPC[] Enemies;
        Combat combat1;

        public void SetupLevel()
        {            
            double chance = CurrentLevel+1;
            if (chance < 1)
            {
                chance = 1;
            }
            SpawnEnemy((int)chance);
        }
        
        public void ExploreLevel(NPC npc1)
        {
            combat1 = new Combat();    
            foreach (NPC enemy in Enemies)
            {                
                bool success = combat1.Fight(npc1, enemy, rnd);
                if (!success)
                    break;              
            }
        }

        public void SpawnEnemy(int amount)
        {
            Enemies = new NPC[amount];
            for (int i = 0; i < Enemies.Length; i++)
            {
                Enemies[i] = new NPC();
            }
        }
    }
}
