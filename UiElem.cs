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
        private UIText text2;
        private UIText text3;
        private UIElement area;

        public override void OnInitialize()
        {
            area = new UIElement();
            area.Width.Set(182, 0f);
            area.Height.Set(60, 0f);
            area.Left.Set(-area.Width.Pixels - 300, 1f);
            area.Top.Set(30, 0f);
            

            text = new UIText("0/0", 1.3f); // text to show stat
            text.Width.Set(138, 0f);
            text.Height.Set(34, 0f);
            text.Top.Set(40, 0f);
            text.Left.Set(0, 0f);

            text2 = new UIText("0/0", 1.3f);
            text2.Width.Set(138, 0f);
            text2.Height.Set(34, 0f);
            text2.Top.Set(60, 0f);
            text2.Left.Set(0, 0f);

            text3 = new UIText("0/0", 1.3f);
            text3.Width.Set(138, 0f);
            text3.Height.Set(34, 0f);
            text3.Top.Set(80, 0f);
            text3.Left.Set(0, 0f);

            area.Append(text);
            area.Append(text2);
            area.Append(text3);
            Append(area);
        }

        public override void Update(GameTime gameTime)
        {
            text.SetText($"Level : {Main.LocalPlayer.GetModPlayer<mPlayer>().Level}");
            text2.SetText($"Exp : {Main.LocalPlayer.GetModPlayer<mPlayer>().Exp}");
            text3.SetText($"Exp TNL : {Main.LocalPlayer.GetModPlayer<mPlayer>().ExpNext}");
        } 
    }
}