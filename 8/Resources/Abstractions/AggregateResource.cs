using Resources.Interfaces;

namespace Resources.Abstractions;

public abstract class AggregateResource : BaseResource, IRepairable, IBreakable
{
    protected List<MaterialResource> _resources;
    protected List<PersonnelResource> _technicians;

    protected AggregateResource()
    {
        _resources = [];
        _technicians = [];
        State = ResourceState.Created;
    }

    public AggregateResource AddResource(MaterialResource resource)
    {
        _resources.Add(resource);
        return this;
    }

    public AggregateResource AddTechnician(PersonnelResource technician)
    {
        _technicians.Add(technician);
        return this;
    }

    public AggregateResource Fail()
    {
        State = ResourceState.Unavailable;
        return this;
    }

    public abstract bool Repair();
}
