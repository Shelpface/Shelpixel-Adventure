using Microsoft.Xna.Framework.Graphics;

namespace ShelpixelAdventure.Engine
{
    public class GameComponent
    {
        private GameObject _parentGameObject;

        private bool _isInitialized = false;

        public GameObject ParentGO
        {
            get
            {
                return _parentGameObject;
            }
            private set
            {
                _parentGameObject = value;
            }

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

        public void Initialize(GameObject parentGameObject)
        {
            if (_isInitialized) throw new System.Exception(this + " has already been Initialized!");
            IsInitialized = true;
            
            _parentGameObject = parentGameObject;
            _parentGameObject.AddInitializedComponent(this);

            Ready();
        }

        public virtual void Ready() { }
        public virtual void Update() { }
        public virtual void Draw(SpriteBatch spriteBatch) { }
    }
}
