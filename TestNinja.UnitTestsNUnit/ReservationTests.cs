using TestNinja.Fundamentals;

namespace ReservationTests;

[TestFixture]
public class ReservationTests
{
    // [SetUp]
    // public void Setup()
    // {
    // }

    [Test]
    public void CanBeCancelledBy_UserIsAdmin_ReturnsTrue()
    {
        var user = new User();
        var reservation = new Reservation { MadeBy = user };
        var admin = new User{ IsAdmin = true};
        var result = reservation.CanBeCancelledBy(admin);
        
        
        Assert.That(result, Is.True);

    }
    
    [Test]
    public void CanBeCancelledBy_UserWhoReserved_ReturnsTrue()
    {
        var user = new User();
        var reservation = new Reservation { MadeBy = user };

        var result = reservation.CanBeCancelledBy(user);
        
        
        Assert.IsTrue(result);

    }
    
    [Test]
    public void CannotBeCancelledBy_ReturnsFalse()
    {
        var user = new User();
        var reservation = new Reservation { MadeBy = user };
        var user2 = new User();
        var result = reservation.CanBeCancelledBy(user2);
        
        
        Assert.IsFalse(result);

    }
}