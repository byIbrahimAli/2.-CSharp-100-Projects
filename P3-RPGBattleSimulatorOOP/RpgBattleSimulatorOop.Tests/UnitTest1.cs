using NUnit.Framework;

namespace RpgBattleSimulatorOop.Tests;

[TestFixture]
public class GameWinLossMechanics
{
    [SetUp]
    public void Setup()
    {
    }

    [TestCase(100, 0, GameWinner.Player)]
    [TestCase(0, 3, GameWinner.Opponent)]
    [TestCase(0, 0, GameWinner.Tie)]
    public void Round_Winner_Calculated_Correctly(int playerHealth, int  opponentHealth, GameWinner expectedWinner)
    {
        // spin up a game
        Game game = new Game();
        
        // call the 'who-won' function
        GameWinner winner = game.RoundWinner(playerHealth, opponentHealth);
        
        // does who won match who should have won?
        Assert.AreEqual(expectedWinner, winner);
    }
}