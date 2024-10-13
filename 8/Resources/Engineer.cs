using Resources.Abstractions;
using Resources.Interfaces;

namespace Resources;

public sealed class Engineer : PersonnelResource
{
    public static new Engineer Create()
    {
        var engineer = new Engineer();
        engineer.AddResources(Cabbage.Create());
        return engineer;
    }

    public static Engineer Create(IEnumerable<IRepairable> aggregates)
    {
        var engineer = Create();

        foreach (var aggregate in aggregates)
        {
            engineer.AddQualification(aggregate);
        }

        return engineer;
    }
}
