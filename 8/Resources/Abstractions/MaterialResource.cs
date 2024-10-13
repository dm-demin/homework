using Resources.Interfaces;

namespace Resources.Abstractions;

public abstract class MaterialResource : BaseResource, IConsumable
{
    public uint MaxQty { get; protected set; }
    public uint CurrentQty { get; protected set; }

    public uint Consumption { get; protected set; }

    public bool Consume()
    {
        if (CurrentQty < Consumption)
        {
            State = ResourceState.Unavailable;
            return false;
        }

        CurrentQty -= Consumption;
        return true;
    }

    public abstract override MaterialResource MyClone();
}
