using Resources.Abstractions;

namespace Resources;

public sealed class Fuel : MaterialResource, ICloneable
{
    public static new Fuel Create()
    {
        var fuel = new Fuel();
        fuel.MaxQty = 100;
        fuel.CurrentQty = 100;
        fuel.Consumption = 5;
        return fuel;
    }

    public override Fuel MyClone()
    {
        var clone = new Fuel();
        clone.MaxQty = MaxQty;
        clone.Consumption = Consumption;
        clone.CurrentQty = MaxQty;
        return clone;
    }

    public object Clone()
    {
        return MyClone();
    }
}
