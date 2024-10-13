using Resources;

namespace ResourcesTest;

public class CloneTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void FuelCloneTest_Success()
    {
        var original = Fuel.Create();
        original.Consume();

        var clone = (Fuel)original.Clone();
        
        Assert.That(clone.CurrentQty, Is.Not.EqualTo(original.CurrentQty));
    }

    [Test]
    public void PersonnelResourceCloneTest_Fail()
    {
        var original = Engineer.Create();        
        Assert.Throws<NotImplementedException>( () => {original.Clone();});
    }

    [Test]
    public void EngineCloneTest_Success()
    {
        var original = Engine.Create();
        original.AddTechnician(Engineer.Create());

        var clone = (Engine)original.Clone();
        Assert.That(clone, Is.Not.EqualTo(original));

        clone.Fail();
        Assert.That(clone.State, Is.Not.EqualTo(original.State));
    }
}