using TestNinja.Fundamentals;

namespace ReservationTests;

[TestFixture]
public class CustomerControllerTests
{
    [Test]
    public void GetCustomer_IdZero_ReturnNotFound()
    {
        var controller = new CustomerController();

        var res = controller.GetCustomer(0);
        //NotFound
        Assert.That(res, Is.TypeOf<NotFound>());

        //NotFound or derivatives
        //Assert.That(res, Is.InstanceOf<NotFound>());
    }

    [Test]
    public void GetCustomer_IdNotZero_ReturnOk()
    {
    }
}