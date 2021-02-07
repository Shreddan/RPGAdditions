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
	public class gNPCs : GlobalNPC
	{
		public override bool InstancePerEntity => true;

		public int xpGiven = 0;

		public override void NPCLoot(NPC npc)
		{
			Player player = Main.player[Main.myPlayer];
			ModPlayer mplayer = (ModPlayer)player.GetModPlayer(mod, "mplayer");
			if (npc.type == NPCID.Zombie)
			{
				Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 7;
			}
			if (npc.type == NPCID.GreenSlime)
			{
				Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 4;
			}
			if (npc.type == NPCID.IceSlime)
            {
				Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 5;
            }
			base.NPCLoot(npc);
		}
	}
}
