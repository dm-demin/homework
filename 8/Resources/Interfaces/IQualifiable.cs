using Resources.Abstractions;

namespace Resources.Interfaces;

public interface IQualifiable
{
    public bool HasQualification(IRepairable resource);

    public IQualifiable AddQualification(IRepairable resource);
}