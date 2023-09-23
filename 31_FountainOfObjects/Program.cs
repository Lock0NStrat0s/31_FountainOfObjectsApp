namespace _31_FountainOfObjects;

public class Program
{
    static void Main(string[] args)
    {
        // Create grid map
        GridMap gridMap = CreateMap();

        bool gameRunning = true;

        do
        {
            DisplayMap(gridMap);

        } while (gameRunning);

        Console.ReadLine();
    }

    private static void DisplayMap(GridMap gridMap)
    {
        
    }

    private static GridMap CreateMap()
    {
        GridMap output = new GridMap();

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                GridSpot spot = new GridSpot
                {
                    Row = j,
                    Column = i,
                    Status = GridSpotStatus.Empty
                };

                if (j == 0 && i == 2) spot.Status = GridSpotStatus.Fountain;
                if (j == 0 && i == 0) spot.Status = GridSpotStatus.Entrance;

                output.Map.Add(spot);
            }
        }

        return output;
    }
}

public class GridMap
{
    public List<GridSpot> Map { get; set; } = new List<GridSpot>();
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