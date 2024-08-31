namespace Homework5.Models;

public class SomeType
{
    public string name { get; }
    public float weight { get; }

    public SomeType(string name, float weight)
    {
        this.name = name;
        this.weight = weight;
    }

    public override string ToString() => name;
}
