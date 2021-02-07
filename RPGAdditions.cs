using System;
using RPGAdditions.NPCs;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace RPGAdditions
{
	public class RPGAdditions : Mod
	{
		public Player player;
		public ModPlayer mplayer;
		public RPGAdditions()
		{
			player = Main.player[Main.myPlayer];
			mplayer = (ModPlayer)player.GetModPlayer(this, "mplayer");
		}
	}
}