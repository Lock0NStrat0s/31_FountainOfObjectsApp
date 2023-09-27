namespace _31_FountainOfObjects;

public class Program
{
    static void Main(string[] args)
    {
        // Create grid map
        GridMap gridMap = CreateMap();

        // Create Player
        Player player = new Player();

        bool gameRunning = true;
        DisplayMap(gridMap, player);

        PlayerAction(gridMap, player);

        // runs main loop
        do
        {


        } while (gameRunning);

        Console.ReadLine();
    }

    private static void PlayerAction(GridMap gridMap, Player player)
    {
        "Select action: ".Print();
        string action = Console.ReadLine().ToLower();

        switch (action)
        {
            case "east":
                MovePlayer(0,1);
        }
    }

    private static void MovePlayer(int v1, int v2)
    {
        
    }

    private static void DisplayMap(GridMap gridMap, Player player)
    {
        "--------------------".PrintLine();
        foreach (GridSpot map in gridMap.Map)
        {
            if (map.Column == player.Column && map.Row == player.Row)
            {
                "| X |".PrintColour(ConsoleColor.Magenta);
            }
            else
            {
                $"({map.Row},{map.Column})".PrintColour(ConsoleColor.Gray);
            }

            if (map.Row == 3)
            {
                "\n--------------------".PrintLine();
            }
        }

    }

    private static GridMap CreateMap()
    {
        GridMap output = new GridMap();

        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                GridSpot spot = new GridSpot
                {
                    Row = j,
                    Column = i,
                    Status = GridSpotStatus.Empty
                };

                if (j == 0 && i == 2) spot.Status = GridSpotStatus.Fountain;
                if (j == 0 && i == 0) spot.Status = GridSpotStatus.Player;

                output.Map.Add(spot);
            }
        }

        return output;
    }
}

public class GridMap
{
    public List<GridSpot> Map { get; set; } = new List<GridSpot>();
    public Player? _Player { get; set; }
}

public class Player
{
    public int Row { get; set; } = 0;
    public int Column { get; set; } = 0;
    public GridSpotStatus Status { get; set; } = GridSpotStatus.Player;
}

public class GridSpot
{
    public int Row { get; set; }
    public int Column { get; set; }
    public GridSpotStatus Status { get; set; } = GridSpotStatus.Empty;
}

public enum GridSpotStatus
{
    Empty, Player, Entrance, Fountain
}