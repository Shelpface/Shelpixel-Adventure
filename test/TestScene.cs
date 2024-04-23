using ShelpixelAdventure.Engine;
using System.Runtime.CompilerServices;

namespace ShelpixelAdventure.test
{
    public class TestScene : Scene
    {
        public TestScene()
        {
            AddChild(new TestGO());
        }
    }
}
