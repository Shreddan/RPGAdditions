using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RPGAdditions.modPlayer
{
	public class mPlayer : ModPlayer
	{
		public int Level = 1;
		public int Exp = 0;
		public int baseLife = 100;

		public void OnLevelUp()
        {
			if (Exp >= Level * 1.5f + 10)
            {
				Level++;
				Exp = 0;
				Main.NewText("Congratulations, You have levelled up!  You are now Level" + Main.LocalPlayer.GetModPlayer<mPlayer>().Level);
            }
        }


		public override void PostUpdate()
		{
			if (this.Level == 1)
			{
				this.player.statLifeMax = this.baseLife;
			}
			else
			{
				this.player.statLifeMax = (int)(this.baseLife + this.Level * 1.3);
			}
			OnLevelUp();
			base.PostUpdate();
		}
	}
}

