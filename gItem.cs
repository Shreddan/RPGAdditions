using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RPGAdditions.Items
{
    class Gitem : GlobalItem
    {
        public override void OnConsumeItem(Item item, Player player)
        {
            if (item.type == ItemID.LifeCrystal)
            {
                item.healLife = Main.LocalPlayer.statLifeMax;
            }
            base.OnConsumeItem(item, player);
        }
    }
}
