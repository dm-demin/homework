using Resources.Abstractions;

namespace Resources;

public sealed class Cabbage : MaterialResource
{
    public static new Cabbage Create()
    {
        var resource = new Cabbage();
        resource.Consumption = 1;
        resource.MaxQty = 10;
        resource.CurrentQty = 10;
        return resource;
    }

    public override Cabbage MyClone()
    {
        var clone = new Cabbage();
        clone.MaxQty = MaxQty;
        clone.Consumption = Consumption;
        clone.CurrentQty = MaxQty;
        return clone;
    }
}
