using NUnit.Framework;
using P3_RPGBattleSimulatorOOP;
using P3_RPGBattleSimulatorOOP.Models;

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
    public void Winner_Calculated_Correctly(int playerHealth, int  opponentHealth, GameWinner expectedWinner)
    {
        // spin up a game
        Game game = new Game();
        
        // call the 'who-won' function
        GameWinner winner = game.DetermineWinner(playerHealth, opponentHealth);
        
        // does who won match who should have won?
        Assert.That(expectedWinner, Is.EqualTo(winner));
    }
}