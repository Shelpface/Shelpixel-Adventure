using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace ShelpixelAdventure.Engine
{
    public class Scene
    {
        private List<GameObject> _gameObjects;

        public Scene()
        {
            _gameObjects = new List<GameObject>();
        }

        public void AddGO(GameObject gameObject)
        {
            gameObject.Initialize(this);
        }

        public void AddInitializedGO(GameObject initializedGameObject)
        {
            if (initializedGameObject.IsInitialized)
            {
                _gameObjects.Add(initializedGameObject);
            }
            else
            {
                throw new System.Exception("You are trying to add an uninitialized GameObject! Use AddChild instead.");
            }
        }

        public virtual void Update()
        {
            foreach (var go in _gameObjects)
            {
                go.Update();
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            foreach (var go in _gameObjects)
            {
                go.Draw(spriteBatch);
            }
        }

    }

}
