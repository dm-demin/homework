using Resources.Abstractions;

namespace Resources;

public sealed class Engine : AggregateResource, ICloneable
{
    private Engine() : base()
    {
        State = ResourceState.Created;
    }

    public static new Engine Create()
    {
        var engine = new Engine();
        engine.AddResource(Fuel.Create());
        engine.State = ResourceState.Available;
        return engine;
    }

    public override bool Repair()
    {
        if (State != ResourceState.Unavailable)
        {
            return true;
        }

        if (technicians.Where(x => x.State == ResourceState.Available).Any())
        {
            State = ResourceState.Available;
            return true;
        }

        return false;
    }

    public override Engine MyClone()
    {
        var clone = new Engine();
        clone.State = ResourceState.Available;
        
        foreach(var resource in resources)
        {
            clone.AddResource(resource.MyClone());
        }

        clone.technicians = technicians;
        return clone;
    }

    public object Clone()
    {
        return MyClone();
    }
}
