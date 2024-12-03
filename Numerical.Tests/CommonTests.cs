using Numerical;

namespace Numerical.Tests;

public class CommonTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GCPTest1()
    {
        var divisor = Common.GCD(15, 20);
        Assert.That(divisor, Is.EqualTo(5));
    }
    [Test]
    public void GCPTest2()
    {
        var divisor = Common.GCD(7, 13);
        Assert.That(divisor, Is.EqualTo(1));
    }
}