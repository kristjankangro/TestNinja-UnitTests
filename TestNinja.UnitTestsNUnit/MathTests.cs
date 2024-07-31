namespace ReservationTests;
using TestNinja.Fundamentals;

[TestFixture]
public class MathTests
{
    private Math _math;
    [SetUp]
    public void Setup()
    {
        _math = new Math();
    }
    
    [Test]
    public void Add_CallReturnsSumOfArguments()
    {
        var result = _math.Add(2, 4);
        
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    [TestCase(2,1,2)]
    [TestCase(2,3,3)]
    [TestCase(3,3,3)]
    public void Max_WhenCalled_ReturnGreaterArgument(int a, int b, int expected)
    {
        var result = _math.Max(a, b);
        
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void GetOddTest_LimitIsGreaterThanZero_REturnOddNumbersUpToLimit()
    {
        var res = _math.GetOddNumbers(5);
        
        // Assert.That(res, Is.Not.Empty);
        // Assert.That(res.Count(), Is.EqualTo(3));
        // Assert.That(res, Does.Contain(1));
        // Assert.That(res, Does.Contain(2));
        // Assert.That(res, Does.Contain(3));
        Assert.That(res, Is.EquivalentTo(new [] {1,3,5}));
    }
}