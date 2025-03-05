using System;

namespace RockPaperScissorsGame
{
    /// <summary>
    /// Represents the possible moves in the game.
    /// </summary>
    public enum GameMove
    {
        Rock,
        Paper,
        Scissors,
        Exit
    }

    /// <summary>
    /// Represents the outcome of a game round.
    /// </summary>
    public enum GameOutcome
    {
        ComputerWins,
        HumanWins,
        Draw
    }

    /// <summary>
    /// Encapsulates the game logic for the "Impossible Rock, Paper, Scissors" game.
    /// </summary>
    public class GameEngine
    {
        /// <summary>
        /// Runs the game loop until the user decides to exit.
        /// </summary>
        public void Run()
        {
            while (true)
            {
                GameMove userMove = GetUserMove();
                if (userMove == GameMove.Exit)
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                GameMove computerMove = GetComputerMove(userMove);
                GameOutcome outcome = DetermineOutcome(userMove, computerMove);
                DisplayResult(userMove, computerMove, outcome);
            }
        }

        /// <summary>
        /// Prompts the user for a move and validates the input.
        /// </summary>
        /// <returns>A valid <see cref="GameMove"/> selected by the user.</returns>
        private GameMove GetUserMove()
        {
            while (true)
            {
                Console.Write("Enter your move (rock, paper, scissors) or 'exit' to quit: ");
                string? input = Console.ReadLine()?.Trim().ToLower();

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("No input detected. Please try again.");
                    continue;
                }

                switch (input)
                {
                    case "rock":
                    case "r":
                        return GameMove.Rock;
                    case "paper":
                    case "p":
                        return GameMove.Paper;
                    case "scissors":
                    case "s":
                        return GameMove.Scissors;
                    case "exit":
                    case "quit":
                    case "q":
                        return GameMove.Exit;
                    default:
                        Console.WriteLine("Invalid move. Please enter 'rock', 'paper', 'scissors', or 'exit'.");
                        break;
                }
            }
        }

        /// <summary>
        /// Determines the computer's move. This game is rigged so that the computer always wins.
        /// </summary>
        /// <param name="userMove">The move chosen by the user.</param>
        /// <returns>The move that ensures the computer wins.</returns>
        private GameMove GetComputerMove(GameMove userMove)
        {
            return userMove switch
            {
                GameMove.Rock => GameMove.Paper,
                GameMove.Paper => GameMove.Scissors,
                GameMove.Scissors => GameMove.Rock,
                _ => throw new ArgumentException("Invalid user move encountered.")
            };
        }

        /// <summary>
        /// Determines the outcome of the round.
        /// </summary>
        /// <param name="userMove">The move chosen by the user.</param>
        /// <param name="computerMove">The move chosen by the computer.</param>
        /// <returns>The result of the round as a <see cref="GameOutcome"/>.</returns>
        private GameOutcome DetermineOutcome(GameMove userMove, GameMove computerMove)
        {
            if (userMove == computerMove)
            {
                return GameOutcome.Draw;
            }

            // In this rigged game, the computer always wins.
            return GameOutcome.ComputerWins;
        }

        /// <summary>
        /// Displays the result of the round.
        /// </summary>
        /// <param name="userMove">The move chosen by the user.</param>
        /// <param name="computerMove">The move chosen by the computer.</param>
        /// <param name="outcome">The outcome of the round.</param>
        private void DisplayResult(GameMove userMove, GameMove computerMove, GameOutcome outcome)
        {
            Console.WriteLine($"You chose: {userMove}  |  Computer chose: {computerMove}");
            switch (outcome)
            {
                case GameOutcome.ComputerWins:
                    Console.WriteLine("Computer wins!");
                    break;
                case GameOutcome.HumanWins:
                    Console.WriteLine("You win! (Unexpected outcome)");
                    break;
                case GameOutcome.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
            }
            Console.WriteLine();
        }
    }

    /// <summary>
    /// The application entry point.
    /// </summary>
    public static class Program
    {
        // public static void Main(string[] args)
        // {
        //     GameEngine game = new GameEngine();
        //     game.Run();
        // }
    }
}
