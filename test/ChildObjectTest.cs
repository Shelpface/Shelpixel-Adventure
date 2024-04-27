﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ShelpixelAdventure.Engine;

namespace ShelpixelAdventure.test
{
    public class ChildObjectTest : GameObject
    {
        Texture2D texture;
        protected override void Initialize()
        {
            texture = AssetManager.Load<Texture2D>("2d_girl_pink_hair");

            base.Initialize();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Vector2(64, 166), new Rectangle(400, 200, 100, 100), Color.White);

            base.Draw(spriteBatch);
        }
    }
}