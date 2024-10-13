using Resources.Abstractions;

namespace Resources.Interfaces;

public interface IMyClonable<T>
    where T : BaseResource
{
    public T MyClone();
}
