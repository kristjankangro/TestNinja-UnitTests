using TestNinja.Fundamentals;

namespace ReservationTests;

[TestFixture]
public class ErrorLoggerTests
{
    [Test]
    public void Log_WhenCalled_SetLastErrorProperty()
    {
        var log = new ErrorLogger();
        log.Log("a");
        
        Assert.That(log.LastError, Is.EqualTo("a"));
    }

    [Test]
    [TestCase(null)]
    [TestCase("")]
    [TestCase(" ")]
    public void Log_InvalidError_ThrowArgumnetInvalidException(string? error)
    {
        var log = new ErrorLogger();
        
        Assert.That( () => log.Log(error), Throws.ArgumentNullException);
    }

    [Test]
    public void Log_ValidError_RaiseErrorLogged()
    {
        var logger = new ErrorLogger();
        var id = Guid.Empty;
        logger.ErrorLogged += (sender, guid) => { id = guid; };
        
        logger.Log("a");
        
        Assert.That(id, Is.Not.EqualTo(Guid.Empty));
    }
}