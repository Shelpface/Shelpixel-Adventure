using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace ShelpixelAdventure.Engine
{
    public class GameObject
    {   
        private bool _isInitialized = false;

        private Scene _scene;

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

        private void Initialize(Scene scene)
        {
            _scene = scene;
            Initialize();
        }

        private void Initialize(GameObject parent)
        {
            _parentObject = parent;
            Initialize();
        }

        protected virtual void Initialize()
        {
            if (_isInitialized) throw new System.Exception(this + " has already been Initialized!");

            _isInitialized = true;
            if (_parentObject != null)
            {
                _parentObject.AddInitializedChild(this);
            }
            else
            {
                //_parentObject.AddInitializedChild(this); Need to implement this method in the Scene class
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
                throw new System.Exception("You are trying to add an uninitialized object!");
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

        public virtual void Draw() // Updating by scene
        {
            if (_children.Count > 0)
            {
                foreach (GameObject child in _children)
                {
                    child.Draw();
                }
            }
        }
    }
}
