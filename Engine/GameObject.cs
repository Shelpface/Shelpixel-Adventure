using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace ShelpixelAdventure.Engine
{
    public class GameObject
    {   
        private bool _isInitialized = false;

        private Scene _parentScene;

        private GameObject _parentObject;

        private List<GameObject> _children;

        public bool IsInitialized
        {
            get
            {
                return _isInitialized;
            }
            private set
            {
                _isInitialized = value;
            }
        }

        //public Vector2 Position { get; protected set; }
        //public Vector2 GlobalPosition { get; protected set; }

        public GameObject()
        {

        }

        public void Initialize(Scene scene)
        {
            _parentScene = scene;
            Initialize();
        }

        public void Initialize(GameObject parent)
        {
            _parentObject = parent;
            Initialize();
        }

        protected virtual void Initialize()
        {
            if (_isInitialized) throw new System.Exception(this + " has already been Initialized!");

            IsInitialized = true;
            if (_parentObject != null)
            {
                _parentObject.AddInitializedChild(this);
            }
            else
            {
                _parentScene.AddInitializedChild(this);
            }
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

        public virtual void Update() // Updating by scene
        {
            if (_children.Count > 0)
            {
                foreach (GameObject child in _children)
                {
                    child.Update();
                }
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch) // Updating by scene
        {
            if (_children.Count > 0)
            {
                foreach (GameObject child in _children)
                {
                    child.Draw(spriteBatch);
                }
            }
        }
    }
}
