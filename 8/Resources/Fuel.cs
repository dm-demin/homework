using Resources.Abstractions;

namespace Resources;

public sealed class Fuel : MaterialResource
{
    public static new Fuel Create()
    {
        var fuel = new Fuel();
        fuel.MaxQty = 100;
        fuel.CurrentQty = 100;
        return fuel;
    }
}