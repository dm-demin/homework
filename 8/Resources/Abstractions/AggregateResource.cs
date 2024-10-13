using System.ComponentModel;
using Resources.Interfaces;

namespace Resources.Abstractions;

public abstract class AggregateResource : BaseResource, IRepairable, IBreakable
{
    protected List<IConsumable> resources;
    protected List<PersonnelResource> technicians;

    protected AggregateResource()
    {
        resources = [];
        technicians = [];
        State = ResourceState.Created;
    }
    
    public AggregateResource AddResource(MaterialResource resource)
    {
        resources.Add(resource);
        return this;
    }

    public AggregateResource AddTechnician(PersonnelResource technician)
    {
        technicians.Add(technician);
        return this;
    } 

    public AggregateResource Fail()
    {
        State = ResourceState.Unavailable;
        return this;
    }

    public abstract bool Repair();
}
