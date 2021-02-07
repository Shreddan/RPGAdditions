using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.UI;
using Terraria.ModLoader;
using RPGAdditions.modPlayer;


namespace RPGAdditions.UI
{
    internal class UiElem : UIState
    {

        private UIText text;
        private UIElement area;

        public override void OnInitialize()
        {
            area = new UIElement();
            area.Left.Set(-area.Width.Pixels - 600, 1f);
            area.Top.Set(30, 0f);
            area.Width.Set(182, 0f);
            area.Height.Set(60, 0f);

            text = new UIText("0/0", 0.8f); // text to show stat
            text.Width.Set(138, 0f);
            text.Height.Set(34, 0f);
            text.Top.Set(40, 0f);
            text.Left.Set(0, 0f);

            area.Append(text);
            Append(area);
        }


        public override void Update(GameTime gameTime)
        {
            text.SetText($"Level : {Main.LocalPlayer.GetModPlayer<mPlayer>().Level}");
            this.Update(gameTime);
        }
    }
}
