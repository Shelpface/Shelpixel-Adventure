using Microsoft.Xna.Framework.Input;

namespace ShelpixelAdventure.Engine
{
    public static class InputManager
    {
        private static KeyboardState _previousKS;

        public static bool IsKeyPressed(Keys key)
        {
            bool isKeyDown = Keyboard.GetState().IsKeyDown(key);
            bool wasKeyDownInPreviousFrame = _previousKS.IsKeyDown(key);
            _previousKS = Keyboard.GetState();

            return isKeyDown && !wasKeyDownInPreviousFrame;
        }

        public static bool IsKeyDown(Keys key)
        {
            return Keyboard.GetState().IsKeyDown(key);
        }
    }
}