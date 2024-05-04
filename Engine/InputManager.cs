using Microsoft.Xna.Framework.Input;

namespace ShelpixelAdventure.Engine
{
    public static class InputManager
    {
        private static KeyboardState _currentKS = Keyboard.GetState();
        private static KeyboardState _previousKS = _currentKS;

        public static bool IsKeyJustPressed(Keys key) => _currentKS.IsKeyDown(key) && !_previousKS.IsKeyDown(key);
        public static bool IsKeyPressed(Keys key) => _currentKS.IsKeyDown(key);

        public static void Update()
        {
            _previousKS = _currentKS;
            _currentKS = Keyboard.GetState();
        }
    }
}