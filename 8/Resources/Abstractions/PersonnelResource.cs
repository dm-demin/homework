using Resources.Interfaces;

namespace Resources.Abstractions;

public abstract class PersonnelResource : BaseResource, IQualifiable, IConsumable, ICloneable
{
    private List<IConsumable> resources;
    private List<IRepairable> qualifications;
    protected PersonnelResource()
    {
        resources = [];
        qualifications = [];
        State = ResourceState.Suspend;
    }

    protected List<IConsumable> Resources { get => resources; set => resources = value; }
    protected List<IRepairable> Qualifications { get => qualifications; set => qualifications = value; }

    public bool Consume()
    {
        if (State == ResourceState.Suspend)
        {
            return true;
        }

        foreach (var resource in resources)
        {
            if (!resource.Consume())
            {
                return false;
            }
        }

        return true;
    }

    public bool HasQualification(IRepairable resource)
    {
        if (qualifications.Where(x => x.Equals(resource)).Any())
        {
            return true;
        }

        return false;
    }

    public PersonnelResource AddResources(IConsumable resource)
    {
        resources.Add(resource);
        return this;
    }

    public IQualifiable AddQualification(IRepairable aggregate)
    {
        qualifications.Add(aggregate);
        return this;
    }

    public override PersonnelResource MyClone()
    {
        // Это не этично, в обществе еще не утихли споры о клонировании:
        throw new NotImplementedException();
    }

    public object Clone()
    {
        return MyClone();
    }
}
