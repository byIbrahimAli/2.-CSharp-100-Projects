// RULES
// You'll never win rock, paper, scissors
// allow user input, reject anything else, allow shorthands

// Description
// This represents my first csharp project, a console rigged rock, paper, scissors.
// AI iterated over this and recommended an improved solution, see ProgramAIEnhanced.cs

public class Program
{
    public static void Main(string[] args)
    {
        ImpossibleRockPaperScissors.PlayGame();
    }
}

public class ImpossibleRockPaperScissors
{
    enum User
    {
        Human,
        Computer
    }

    enum GameMove
    {
        Rock,
        Paper,
        Scissors,
        Exit
    }
    
    // record user input
    static GameMove GetUserGameMove()
    {
        while (true)
        {
            Console.Write("Alright mate, make your move. rock, paper, scissors or r, p, s?");
            string? input = Console.ReadLine().Trim().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Erm hello? Ghosting me I see.");
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
                case "q":
                case "quit":
                    return GameMove.Exit;
                default:
                    Console.WriteLine("Okay, so you're playing the throwing-a-brick-at-my-face game. Fine. I just forgot your move.");
                    break;
            }
        }
    }
    
    static GameMove ComputersResponse(GameMove usersMove)
    {
        return usersMove switch
        {
            GameMove.Rock => GameMove.Paper,
            GameMove.Paper => GameMove.Scissors,
            GameMove.Scissors => GameMove.Rock,
            _ => throw new ArgumentException("Users move is invalid")
        };
    }

    static User WhoWon(GameMove usersMove, GameMove computersMove)
    {
        bool computerWins = usersMove == GameMove.Rock && computersMove == GameMove.Paper
                            || usersMove == GameMove.Paper && computersMove == GameMove.Scissors
                            || usersMove == GameMove.Scissors && computersMove == GameMove.Rock;
        
        if (usersMove == computersMove)
        {
            throw new ArgumentException("Draws not allowed, how'd you manage that?");
        } else if (computerWins)
        {
            return User.Computer;
        } else
        {
            throw new ArgumentException("Hang on, you won? Cheeky *******!?");
        }
    }
    
    public static void PlayGame()
    {
        while (true)
        {
            var usersMove = ImpossibleRockPaperScissors.GetUserGameMove();

            if (usersMove == GameMove.Exit)
            {
                Console.WriteLine("Bye bye");
                return;
            }
            
            var computersMove = ImpossibleRockPaperScissors.ComputersResponse(usersMove);
            Console.WriteLine("You chose: " + usersMove + " VS. Computer chose: " + computersMove);
            Console.WriteLine(ImpossibleRockPaperScissors.WhoWon(usersMove, computersMove) + " wins, get sent 🖕");
            Console.WriteLine();
        }
    }
}