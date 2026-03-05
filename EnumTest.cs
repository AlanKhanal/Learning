using System;

/// <summary>
/// EnumTest.cs
/// A class that handles interactive enum logic.
/// Does NOT run Main; methods will be called from Program.cs.
/// </summary>
public class EnumTest
{
    // Define the enum
    public enum GameState
    {
        PlayerIdle = 1,
        PlayerWalk,
        PlayerRun,
        PlayerJump
    }

    private GameState currentState;

    // Constructor: start with default state
    public EnumTest()
    {
        currentState = GameState.PlayerIdle;
    }

    // Method to show instructions
    public void ShowInstructions()
    {
        Console.WriteLine("Interactive Game State Program");
        Console.WriteLine("Press number keys to change state:");
        Console.WriteLine("1 = PlayerIdle, 2 = PlayerWalk, 3 = PlayerRun, 4 = PlayerJump");
        Console.WriteLine("Press Q to quit.\n");
    }

    // Method to start interaction
    public void Run()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("Current State: " + currentState);
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            switch (keyInfo.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    currentState = GameState.PlayerIdle;
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    currentState = GameState.PlayerWalk;
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    currentState = GameState.PlayerRun;
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    currentState = GameState.PlayerJump;
                    break;
                case ConsoleKey.Q:
                    running = false;
                    continue;
                default:
                    Console.WriteLine("Invalid key! Press 1-4 to change state or Q to quit.");
                    continue;
            }

            Console.WriteLine("State changed to: " + currentState + "\n");
        }

        Console.WriteLine("Interaction ended.");
    }
}