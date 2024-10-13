using Resources.Abstractions;

namespace Resources.Interfaces;

public interface IRenewable
{
    public MaterialResource Renew();
}