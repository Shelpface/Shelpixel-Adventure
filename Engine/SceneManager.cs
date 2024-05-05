namespace ShelpixelAdventure.Engine
{
    public static class SceneManager
    {
        public static Scene CurrentScene { get; private set; }

        public static void Load(Scene scene)
        {
            if (scene == null)
                throw new System.Exception("You are trying to load a scene with a null value. You need to instantiate the scene");

            CurrentScene = scene;
        }
    }
}
