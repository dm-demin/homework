using Resources;

namespace ResourcesTest;

public class Tests
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

        var clone = original.MyClone();
        
        Assert.That(clone.CurrentQty, Is.Not.EqualTo(original.CurrentQty));
    }

    [Test]
    public void PersonnelResourceCloneTest_Fail()
    {
        var original = Engineer.Create();        
        Assert.Throws<NotImplementedException>( () => {original.MyClone();});
    }

    [Test]
    public void EngineCloneTest_Success()
    {
        var original = Engine.Create();
        original.AddTechnician(Engineer.Create());

        var clone = original.MyClone();
        Assert.That(clone, Is.Not.EqualTo(original));

        clone.Fail();
        Assert.That(clone.State, Is.Not.EqualTo(original.State));
    }
}