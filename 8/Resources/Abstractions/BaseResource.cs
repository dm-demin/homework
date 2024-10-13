using Resources.Interfaces;

namespace Resources.Abstractions;

public abstract class BaseResource : IMyClonable<BaseResource>
{
    public ResourceState State { get; protected set; }

    public static BaseResource Create()
    {
        throw new NotImplementedException();
    }

    public abstract BaseResource MyClone();
}
