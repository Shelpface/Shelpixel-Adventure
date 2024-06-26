﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ShelpixelAdventure.Engine;

namespace ShelpixelAdventure.test
{
    public class TestGO : GameObject
    {
        Texture2D texture;
        public override void Ready()
        {
            texture = AssetManager.Load<Texture2D>("2d_girl_pink_hair");

            base.Ready();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Vector2(64, 64), new Rectangle(400, 100, 100, 100), Color.White);

            base.Draw(spriteBatch);
        }
    }
    
}
