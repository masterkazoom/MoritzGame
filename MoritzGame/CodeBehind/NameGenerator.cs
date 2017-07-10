using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoritzGame.CodeBehind
{
    class NameGenerator
    {
        public string[] magicweaponprefixnames;
        public string[] magicweaponsuffixnames;
        public string[] magicarmorprefixnames;
        public string[] magicarmorsuffixnames;

        public NameGenerator()
        {
            magicweaponprefixnames = new string[10] {"Sharp", "Keen", "Strong", "Powerful", "Holy", "Unholy", "Deadly", "Magical", "Brilliant", "Glorious"};
            magicweaponsuffixnames = new string[10] { "of Death", "of Life", "of Rending", "of the Holy Order", "of the Occult", "of Nature", "of Blades", "of the Sentinel", "of Perfection", "of Malice" };
            magicarmorprefixnames = new string[10] { "Wooden", "Metal", "Adamantite", "Leather", "Sturdy", "Warlord's", "Shadow", "Magical", "Apprentice", "Glorious" };
            magicarmorsuffixnames = new string[10] { "of Death", "of Life", "of Mending", "of the Holy Order", "of the Occult", "of Nature", "of Shadows", "of the Sentinel", "of Perfection", "of Malice" };
        }

    }
}
