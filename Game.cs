using FindTheNumber.DTOs;
using FindTheNumber.Enums;

namespace FindTheNumber;

public class Game
{
    public int NumberToFind { get; private set; }
    public int? LastNumber { get; private set; }

    public int UserTries { get; private set; }
    public NumberStatus NumberStatus { get; private set; }
    public GameStatus GameStatus { get; private set; }

    private Game()
    {
        NumberToFind = 0; //TODO create a random
    }

    public static Game Start()
    {
        Game game = new()
        {
            GameStatus = GameStatus.Started
        };

        return game;
    }

    public void Stop()
    {
        GameStatus = GameStatus.Finished;
    }

    public void Pause()
    {
        GameStatus = GameStatus.Pause;
    }

    public GameStats Stats()
    {
        return new GameStats()
        {
            GameStatus = GameStatus,
            NumberStatus = NumberStatus,
            LastNumber = LastNumber,
            UserTries = UserTries,
        };
    }

    public NumberStatus? FindNumber(int value)
    {
        UpdateLastNumber(value);

        if (value < this.NumberToFind)
        {
            NumberStatus = Enums.NumberStatus.Small;
        }
        else if (value > this.NumberToFind)
        {
            NumberStatus = Enums.NumberStatus.Large;
        }
        else if (value == this.NumberToFind)
        {
            NumberStatus = Enums.NumberStatus.Equal;
        }

        return NumberStatus;
    }

    private void UpdateLastNumber(int value)
    {
        UserTries++;
        LastNumber = value;
    }
}