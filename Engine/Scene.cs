using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace ShelpixelAdventure.Engine
{
    public class Scene
    {
        private List<GameObject> _children;

        public Scene()
        {
            _children = new List<GameObject>();
        }

        public void AddChild(GameObject child)
        {
            child.Initialize(this);
        }

        public void AddInitializedChild(GameObject initChild)
        {
            if (initChild.IsInitialized)
            {
                _children.Add(initChild);
            }
            else
            {
                throw new System.Exception("You are trying to add an uninitialized GameObject! Use AddChild instead.");
            }
        }

        public virtual void Update()
        {
            if (_children != null)
            {
                foreach (var child in _children)
                {
                    child.Update();
                }
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (_children != null )
            {
                foreach (var child in _children)
                {
                    child.Draw(spriteBatch);
                }
            }
        }

    }

}
