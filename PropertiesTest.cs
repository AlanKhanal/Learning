using System;

/// <summary>

/// </summary>
public class PropertiesTest
{
    private static string playerName;

    public static string PlayerName
    {
        get
        {
            if (playerName == null)
            {
                return "Unknown";

            }
            return playerName;
        }
        private set
        {
            if (value == "Alan")
            {
                throw new Exception("Can't name Player Alan");
            }
            playerName = value;
        }
    }
    public static void SetPlayerName(string name)
    {
        PlayerName = name;
    }
}