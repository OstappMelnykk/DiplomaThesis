namespace CADeditor.Domain;

public class Point : ICloneable
{
    public decimal X { get; set; }
    public decimal Y { get; set; }
    public decimal Z { get; set; }
    
    public int LocalID { get; set; }
    public int GlobalID { get; set; }
    

    public Point(
        decimal X,
        decimal Y,
        decimal Z,
        
        int LocalID = 0,
        int GlobalID = 0)
    {
        this.X = X;
        this.Y = Y;
        this.Z = Z;
        this.LocalID = LocalID;
        this.GlobalID = GlobalID;
    }
    
    
    public object Clone()
    {
        return new Point(this.X, this.Y, this.Z, this.LocalID, this.GlobalID);
    }
    
    public override string ToString()
    {
        //string str = $"X: {X} Y: {Y} Z: {Z} Neighbors:{numberOFNeighbors} Local id: {LocalID} Global id: {GlobalID}";
        string str = $"{X} {Y} {Z}";

        return str;
    }
}