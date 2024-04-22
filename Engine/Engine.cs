﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace ShelpixelAdventure.Engine
{
    public class Engine : Game
    {
        private static ContentManager _content;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Engine()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            _content = Content;
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            SceneManager.Load(new Scene()); // There is currently no functionality here. Just a stab
        }

        protected override void Update(GameTime gameTime)
        {
            SceneManager.CurrentScene.Update();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();
            SceneManager.CurrentScene.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }

        public static T LoadAsset<T>(string assetName)
        {
            return _content.Load<T>(assetName);
        }

    }
}
