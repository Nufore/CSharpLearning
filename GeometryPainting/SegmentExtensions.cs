using System.Collections.Generic;
using Avalonia.Media;
// using GeometryTasks;
using Geometry;

namespace GeometryPainting;

public static class SegmentExtensions
{
    public static Color GetColor(this Segment segment)
    {
        if (segment._color == new Color(0,0,0,0)) return Colors.Black;
        return segment._color;
    }

    public static void SetColor(this Segment segment, Color color)
    {
        segment._color = color;
    }
}

public class Segment
{
    public Color _color;
    Geometry.Segment _segment;
    public Geometry.Vector Begin;
    public Geometry.Vector End;

    public Segment()
    {
        _segment = new Geometry.Segment();
        Begin = _segment.Begin;
        End = _segment.End;
    }
}