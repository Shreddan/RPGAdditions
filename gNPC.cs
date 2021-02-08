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
			
			switch (npc.type)
			{
				case NPCID.ZombieRaincoat:
                    {
						Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 7;
						break;
					}
				case NPCID.FemaleZombie:
                    {
						Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 7;
						break;
                    }
				case NPCID.SlimedZombie:
                    {
						Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 7;
						break;
                    }
				case NPCID.BaldZombie:
                    {
						Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 7;
						break;
                    }
				case NPCID.ZombieEskimo:
                    {
						Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 8;
						break;
                    }
				case NPCID.Zombie:
                    {
						Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 7;
						break;
                    }
				case NPCID.GreenSlime:
                    {
						Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 4;
						break;
                    }
				case NPCID.IceSlime:
                    {
						Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 5;
						break;
					}
				case NPCID.DemonEye:
                    {
						Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 6;
						break;
                    }
				case NPCID.DemonEye2:
                    {
						Main.LocalPlayer.GetModPlayer<mPlayer>().Exp += 6;
						break;
                    }
			}	
			base.NPCLoot(npc);
		}

	}
}
