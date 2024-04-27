using ShelpixelAdventure.Engine;
using System.Runtime.CompilerServices;

namespace ShelpixelAdventure.test
{
    public class TestScene : Scene
    {
        GameObject testgo;
        public TestScene()
        {
            testgo = new TestGO();
            AddGO(testgo);

        }
    }
}
