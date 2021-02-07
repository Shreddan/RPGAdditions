﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.IO;

namespace RPGAdditions.modPlayer
{
	public class mPlayer : ModPlayer
	{
		public int Level = 1;
		public int Exp = 0;
		public int baseLife = 100;
		//public int ExpNext = Level * 1.5f + 10;


		public void OnLevelUp()
		{
			if (Exp >= Level * 1.5f + 10)
			{
				Level++;
				Exp = 0;
				player.statLife = player.statLifeMax;
				Main.NewText("Congratulations, You have levelled up!  You are now Level " + Main.LocalPlayer.GetModPlayer<mPlayer>().Level);
			}
		}

		public override void Load(TagCompound tag)
		{
			if (tag.ContainsKey("Level"))
			{
				Level = tag.GetInt("Level");
			}
			if (tag.ContainsKey("Exp"))
			{
				Exp = tag.GetInt("Exp");
			}
		}

		public override TagCompound Save()
		{
			return new TagCompound
				{
					{"Level", Level },
					{"Exp", Exp }
				};
		}


		public override void PostUpdate()
		{
			if (this.Level == 1)
			{
				this.player.statLifeMax = this.baseLife;
			}
			else
			{
				this.player.statLifeMax = (int)(this.baseLife + this.Level * 1.8);
			}
			OnLevelUp();
		}
	}
}

