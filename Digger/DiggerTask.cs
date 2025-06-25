using System;
using System.IO;
using Avalonia.Controls.Shapes;
using Avalonia.Input;
using Digger.Architecture;
using Path = System.IO.Path;

namespace Digger;

public class Terrain : ICreature
{
    public string GetImageFileName()
    {
        return "Terrain.png";
    }

    public int GetDrawingPriority()
    {
        return 1;
    }

    public CreatureCommand Act(int x, int y)
    {
        return new CreatureCommand() { DeltaX = 0, DeltaY = 0 };
    }

    public bool DeadInConflict(ICreature conflictedObject)
    {
        return true;
    }
}

public class Player : ICreature
{
    public string GetImageFileName()
    {
        return "Digger.png";
    }

    public int GetDrawingPriority()
    {
        return 0;
    }

    public CreatureCommand Act(int x, int y)
    {
        if (Game.KeyPressed == Key.Up)
            return new CreatureCommand() { DeltaX = 0, DeltaY = -1 };
        if (Game.KeyPressed == Key.Down)
            return new CreatureCommand() { DeltaX = 0, DeltaY = 1 };
        if (Game.KeyPressed == Key.Left)
            return new CreatureCommand() { DeltaX = -1, DeltaY = 0 };
        if (Game.KeyPressed == Key.Right)
            return new CreatureCommand() { DeltaX = 1, DeltaY = 0 };

        return new CreatureCommand() { DeltaX = 0, DeltaY = 0 };
    }

    public bool DeadInConflict(ICreature conflictedObject)
    {
        return false;
    }
}