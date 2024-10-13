namespace Resources.Abstractions;

public abstract class BaseResource
{
    public ResourceState State { get; protected set; }

    public static BaseResource Create()
    {
        throw new NotImplementedException();
    }
}
