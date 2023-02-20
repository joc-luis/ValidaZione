using ValidaZione;
using ValidaZione.Langs;

namespace Tests;

public class BooleansTest
{
    [Test]
    public void Accepted()
    {
        Validazione validazione = new Validazione(Language.En);
        validazione.Field("Terminos y condiciones", false).Accepted();
        Assert.That(validazione.Errors().Count, Is.EqualTo(1));
    }
}