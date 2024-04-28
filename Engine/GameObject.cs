using Microsoft.Xna.Framework.Graphics;
using System.Collections.Generic;

namespace ShelpixelAdventure.Engine
{
    public class GameObject
    {
        private List<GameComponent> _components;

        private bool _isInitialized = false;

        private Scene _parentScene;

        public GameObject()
        {
            _components = new List<GameComponent>();
        }

        public List<GameComponent> Components
        {
            get { return _components; }
        }

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

        public void Initialize(Scene scene)
        {
            if (_isInitialized) throw new System.Exception(this + " has already been Initialized!");
            IsInitialized = true;

            _parentScene = scene;
            _parentScene.AddInitializedGO(this);

            Ready();
        }

        public void AddComponent(GameComponent component)
        {
            component.Initialize(this);
        }

        public void AddInitializedComponent(GameComponent initializedComponent)
        {
            if (initializedComponent.IsInitialized)
            {
                _components.Add(initializedComponent);
            }
            else
            {
                throw new System.Exception("You are trying to add an uninitialized GameComponent! Use AddComponent instead.");
            }
        }

        public virtual void Ready()
        {

        }

        public virtual void Update() // Updating by scene
        {
            foreach (var component in _components)
            {
                component.Update();
            }
        }

        public virtual void Draw(SpriteBatch spriteBatch) // Updating by scene
        {
            foreach (var component in _components)
            {
                component.Draw(spriteBatch);
            }
        }
    }
}
