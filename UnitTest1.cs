using ApprovalTests;
using ApprovalTests.Core;
using ApprovalTests.Reporters;
using NuGet.Frameworks;

namespace Bowling
{
    [UseReporter(typeof(VisualStudioReporter))]
    [TestClass]
    public class BowlingTest
    {
        [TestMethod]
        public void TestBowling()
        {
            var game = new BowlingGame();
            game.Roll(5, 4, 4, 3, 1, 2, 4, 6, 3, 6, 8, 2, 1, 2, 10, 2, 3, 10, 10, 6);
            Approvals.Verify(game);   
        }
    }
}