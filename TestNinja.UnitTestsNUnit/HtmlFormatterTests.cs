using TestNinja.Fundamentals;

namespace ReservationTests;

[TestFixture]
public class HtmlFormatterTests
{
    [Test]
    public void FormatAsBold_WhenCalledAddStrongCodes()
    {
        var formatter = new HtmlFormatter();
        var res = formatter.FormatAsBold("test");
        
        Assert.That(res, Is.EqualTo("<strong>test</strong>").IgnoreCase );
        // Assert.That(res, Does.StartWith("<strong>"));
        // Assert.That(res, Does.EndWith("</strong>"));
        // Assert.That(res, Does.Contain("test"));
    }
}