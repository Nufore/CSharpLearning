namespace XandO;

class Program
{
    public enum Mark
    {
        Empty,
        Cross,
        Circle
    }

    public enum GameResult
    {
        CrossWin,
        CircleWin,
        Draw
    }

    public static void Main()
    {
        Run("XXX OO. ...");
        Run("OXO XO. .XO");
        Run("OXO XOX OX.");
        Run("XOX OXO OXO");
        Run("... ... ...");
        Run("XXX OOO ...");
        Run("XOO XOO XX.");
        Run(".O. XO. XOX");
    }

    private static void Run(string description)
    {
        Console.WriteLine(description.Replace(" ", Environment.NewLine));
        Console.WriteLine(GetGameResult(CreateFromString(description)));
        Console.WriteLine();
    }

    private static Mark[,] CreateFromString(string str)
    {
        var field = str.Split(' ');
        var ans = new Mark[3, 3];
        for (int x = 0; x < field.Length; x++)
        for (var y = 0; y < field.Length; y++)
            ans[x, y] = field[x][y] == 'X' ? Mark.Cross : (field[x][y] == 'O' ? Mark.Circle : Mark.Empty);
        return ans;
    }
    
    public static GameResult GetGameResult(Mark[,] field)
    {
        bool crossWin = HasWinSequence(field, Mark.Cross);
        bool circleWin = HasWinSequence(field, Mark.Circle);

        if (crossWin & circleWin) return GameResult.Draw;
        if (crossWin) return GameResult.CrossWin;
        if (circleWin) return GameResult.CircleWin;
        return GameResult.Draw;
    }

    public static bool HasWinSequence(Mark[,] field, Mark mark)
    {
        for (int x = 0; x < 3; x++)
        {
            int y = 1;
            if (field[x, y] == mark & field[x, y - 1] == mark & field[x, y + 1] == mark)
            {
                return true;
            }
        }

        for (int y = 0; y < 3; y++)
        {
            int x = 1;
            if (field[x, y] == mark & field[x - 1, y] == mark & field[x + 1, y] == mark)
            {
                return true;
            }
        }

        if ((field[0, 0] == mark & field[1, 1] == mark & field[2, 2] == mark) 
            || (field[0, 2] == mark & field[1, 1] == mark & field[2, 0] == mark))
        {
            return true;
        }
        
        return false;
    }
}