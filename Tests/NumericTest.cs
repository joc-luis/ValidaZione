using ValidaZione;
using ValidaZione.Langs;

namespace Tests;

public class NumericTest
{
    [Test]
    public void BetweenFail()
    {
        Validazione validazione = new Validazione(Language.Es);
        validazione.Field("test", 10).Between(5, 6);
        Assert.IsFalse(validazione.Pass());
        Assert.That(validazione.Errors().Count, Is.EqualTo(1));
    }
}