using Microsoft.Xna.Framework.Graphics;

namespace ShelpixelAdventure.Engine
{
    public class GameObject
    {   
        private bool _isInitialized = false;

        private Scene _parentScene;

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
            _parentScene.AddInitializedChild(this);

            Ready();
        }

        public virtual void Ready()
        {

        }

        public virtual void Update() // Updating by scene
        {

        }

        public virtual void Draw(SpriteBatch spriteBatch) // Updating by scene
        {

        }
    }
}
