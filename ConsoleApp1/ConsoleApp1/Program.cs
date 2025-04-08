using System;

class Rectangle
{
    public float Width, Height;
    public Rectangle(float width, float height)
    {
        Width = width;
        Height = height;

    }
    public void Deconstruct(out float width, out float height)
    {
        width = Width;
        height = Height;
    }
    static void Main(string[] args)
    {
        var rect = new Rectangle(3, 4);
        (float width, float height) = rect; // Deconstruction
        Console.WriteLine(width + " " + height);
    }
}