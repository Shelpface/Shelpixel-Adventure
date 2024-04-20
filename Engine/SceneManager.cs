namespace ShelpixelAdventure.Engine
{
    public static class SceneManager
    {
        public static Scene CurrentScene { get; private set; }

        public static void Load(Scene scene)
        {
            if (CurrentScene != scene)
            {
                CurrentScene = scene;
            }
            else
            {
                throw new System.Exception("Use Reload method if you want to reload current scene");
            }
        }

        // Need to implement the Reload method here
    }
}
