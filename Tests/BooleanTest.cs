using ValidaZione;
using ValidaZione.Langs;
using ValidaZione.Rules;

namespace Tests;

public class BooleansTest
{
    [Test]
    public void Accepted()
    {
        RulesBooleans correct = new RulesBooleans(Language.En, "test", true);
        correct.Accepted();
        
        RulesBooleans wrong = new RulesBooleans(Language.En, "test", false);
        wrong.Accepted();
        
        Assert.IsFalse(correct.ErrorsByField().Errors.Any());
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }
    
    [Test]
    public void Declined()
    {
        RulesBooleans wrong = new RulesBooleans(Language.En, "test", true);
        wrong.Declined();
        
        RulesBooleans correct = new RulesBooleans(Language.En, "test", false);
        correct.Declined();
        
        Assert.IsFalse(correct.ErrorsByField().Errors.Any());
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }
}