using System;
using RPGAdditions.NPCs;
using RPGAdditions.UI;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI;
using System.Collections.Generic;

namespace RPGAdditions
{
	public class RPGAdditions : Mod
	{
		public Player player;
		public ModPlayer mplayer;
		internal UiElem LevelUI;
		private UserInterface _LevelUI;

		public RPGAdditions()
		{
			player = Main.player[Main.myPlayer];
			mplayer = (ModPlayer)player.GetModPlayer(this, "mplayer");
		}

        public override void Load()
        {
			LevelUI = new UiElem();
			LevelUI.Activate();
			_LevelUI = new UserInterface();
			_LevelUI.SetState(LevelUI);
        }

        public override void UpdateUI(GameTime gameTime)
        {
            _LevelUI.Update(gameTime);
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {
            int mouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (mouseTextIndex != -1)
            {
                layers.Insert(mouseTextIndex, new LegacyGameInterfaceLayer(
                    "YourMod: A Description",
                    delegate
                    {
                        _LevelUI.Draw(Main.spriteBatch, new GameTime());
                        return true;
                    },
                    InterfaceScaleType.UI)
                );
            }
        }
    }
}