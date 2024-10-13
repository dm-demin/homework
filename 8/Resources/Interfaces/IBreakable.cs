using Resources.Abstractions;

namespace Resources.Interfaces;

public interface IBreakable
{
    public AggregateResource Fail();
}