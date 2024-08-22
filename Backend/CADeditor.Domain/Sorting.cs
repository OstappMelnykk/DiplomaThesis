namespace CADeditor.Domain;

public static class Sorting
{
    public static void GlobalNumerationSorting(List<Point> points)
    {
        var sortedPoints = points
            .OrderBy(p => p.Y)  
            .ThenBy(p => p.Z)   
            .ThenBy(p => p.X)   
            .ToList();          

        for (int i = 0; i < points.Count; i++)
            points[i] = sortedPoints[i];
    }
    
    public static void LocalNumerationSorting(List<Point> points)
    {
        var sortedPoints = points
            .OrderBy(p => p.LocalID)  
            .ToList();          

        for (int i = 0; i < points.Count; i++)
            points[i] = sortedPoints[i];
    }
}