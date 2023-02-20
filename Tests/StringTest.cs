using ValidaZione;
using ValidaZione.Langs;

namespace Tests;

public class StringsTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void AcceptedTest()
    {
        Validazione validazione = new Validazione(new Es());
        validazione.Field("Test", "on").Accepted();
        validazione.Field("Test", "yes").Accepted();
        validazione.Field("Test", "true").Accepted();
        validazione.Field("Test", "1").Accepted();
        Assert.That(validazione.Errors().Count, Is.EqualTo(0));
    }
}