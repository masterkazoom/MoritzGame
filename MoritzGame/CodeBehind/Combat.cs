using MoritzGame.CodeBehind;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Combat
    {

        public bool Fight(NPC npc1, NPC npc2, Random rnd)
        {            
            if(rnd.Next(1,3) > 1)
                return true;
            return false;
        }
    }
}
