using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoritzGame.CodeBehind
{
    class Inventory
    {

        public Item[] Slot;
        //int maxSlots = 100;

        public Inventory()
        {
            Slot = new Item[10];
        }

        public bool AddToInventory(Item item)
        {
            int countInventoryFull = 0;
            for (int i = 0; i < Slot.Length; i++)
            {
                if (Slot[i] != null)
                {
                    countInventoryFull++;
                }
                else
                {
                    if (!Slot.Contains(item))
                    {
                        Slot[i] = item;
                        item.Inventoryslot = i;                       
                        return true;
                    }
                }
            }
            return false;
        }

        public Item TakeItemFromInventory(int i)
        {
            Item tempItem = Slot[i];
            Slot[i] = null;
            return tempItem;
        }

        public Item GetItemForUse(int i)
        {
            Item tempItem = Slot[i];
            return tempItem;
        }
    }
}
