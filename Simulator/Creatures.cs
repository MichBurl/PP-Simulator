namespace Simulator;

public class Creature
{
    private string _name = "Unknown";
    private int _level = 1;

    public string Name
    {
        get => _name;
        set
        {
            if (_name != "Unknown")
            {
                throw new InvalidOperationException("Name can only be set once.");
            }

            value = value.Trim();
            if (value.Length < 3)
            {
                value = value.PadRight(3, '#');
            }

            value = value.Length > 25 ? value.Substring(0, 25).TrimEnd() : value;
            if (value.Length < 3)
            {
                value = value.PadRight(3, '#');
            }

            if (char.IsLower(value[0]))
            {
                value = char.ToUpper(value[0]) + value.Substring(1);
            }

            _name = value;
        }
    }

    public int Level
    {
        get => _level;
        set
        {
            if (_level != 1 && value != _level)
            {
                throw new InvalidOperationException("Level can only be set once.");
            }

            _level = Math.Clamp(value, 1, 10);
        }
    }

    public Creature(string name, int level = 1)
    {
        Name = name;
        Level = Math.Clamp(level, 1, 10);
    }

    public Creature()
    {
    }

    public string Info => $"Name: {Name}, Level: {Level}";

    public void SayHi()
    {
        Console.WriteLine($"Hi! I am {Name}, level {Level} creature.");
    }

    public void Upgrade()
    {
        if (Level < 10)
        {
            _level++;
        }
    }
    public void Go(Direction direction)
    {
        string directionText = direction.ToString().ToLower();
        Console.WriteLine($"{Name} goes {directionText}.");
    }

    // Druga metoda Go - przyjmuje tablicę kierunków
    public void Go(Direction[] directions)
    {
        foreach (var direction in directions)
        {
            Go(direction);
        }
    }

}
