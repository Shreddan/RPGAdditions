using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using RPGAdditions.modPlayer;

namespace RPGAdditions.NPCs
{
	public class GnPCs : GlobalNPC
	{
		public override bool InstancePerEntity => true;

		public int xpGiven = 0;

        public override void NPCLoot(NPC npc)
		{
			Player player = Main.player[Main.myPlayer];
			ModPlayer mplayer = (ModPlayer)player.GetModPlayer(mod, "mplayer");

			if (npc.lifeMax >= 10 && npc.lifeMax < 20)
			{
				Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 6;
			}
			else if (npc.lifeMax >= 20 && npc.lifeMax < 30)
			{
				Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 10;
			}
			else if (npc.lifeMax >= 30 && npc.lifeMax < 40)
            {
				Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 14;
			}
			else if (npc.lifeMax >= 40 && npc.lifeMax < 50)
            {
				Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 20;
			}
			else if (npc.lifeMax >= 50 && npc.lifeMax < 60)
            {
				Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 28;
			}
			
			base.NPCLoot(npc);
		}

	}
}
