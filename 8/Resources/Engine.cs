using Resources.Abstractions;

namespace Resources;

public sealed class Engine : AggregateResource
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
}
