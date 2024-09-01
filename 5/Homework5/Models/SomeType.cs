namespace Homework5.Models;

public class SomeType
{
    public string Name { get; }
    public float Weight { get; }

    public SomeType(string name, float weight)
    {
        Name = name;
        Weight = weight;
    }

    public override string ToString() => Name;
}
