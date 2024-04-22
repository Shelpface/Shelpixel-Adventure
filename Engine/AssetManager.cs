using Microsoft.Xna.Framework.Content;

namespace ShelpixelAdventure.Engine
{
    public static class AssetManager
    {
        private static ContentManager _content;

        public static void Initialize(ContentManager contentManager)
        {
            _content = contentManager;
        }

        public static T Load<T>(string assetName)
        {
            return _content.Load<T>(assetName);
        }
    }
}
