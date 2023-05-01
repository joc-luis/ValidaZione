using ValidaZione;
using ValidaZione.Langs;
using ValidaZione.Rules;

namespace Tests;

public class NumericTest
{
    [Test]
    [TestCase(0, 10, ExpectedResult = false)]
    [TestCase(10, 10, ExpectedResult = false)]
    [TestCase(0, 9, ExpectedResult = true)]
    [TestCase(11, 12, ExpectedResult = true)]
    public bool Between(int min, int max)
    {
        RulesNumbers<int> rules = new RulesNumbers<int>(Language.Af, "Test", 10);
        rules.Between(min, max);
        return rules.ErrorsByField().Errors.Any();
    }

    [Test]
    [TestCase(0, 0, ExpectedResult = false)]
    [TestCase(1, 1, ExpectedResult = false)]
    [TestCase(int.MaxValue, int.MaxValue, ExpectedResult = false)]
    [TestCase(int.MinValue, int.MaxValue, ExpectedResult = true)]
    [TestCase(982137, 0, ExpectedResult = true)]
    [TestCase(0, 12837912, ExpectedResult = true)]
    public bool Confirmed(int value, int confirmed)
    {
        RulesNumbers<int> rules = new RulesNumbers<int>(Language.Sq, "Test", value);
        rules.Confirmed(confirmed);
        return rules.ErrorsByField().Errors.Any();
    }
    
    [Test]
    [TestCase(0, 0, ExpectedResult = true)]
    [TestCase(1, 1, ExpectedResult = true)]
    [TestCase(int.MaxValue, int.MaxValue, ExpectedResult = true)]
    [TestCase(int.MinValue, int.MaxValue, ExpectedResult = false)]
    [TestCase(982137, 0, ExpectedResult = false)]
    [TestCase(0, 12837912, ExpectedResult = false)]
    public bool Different(int value, int confirmed)
    {
        RulesNumbers<int> rules = new RulesNumbers<int>(Language.Sq, "Test", value);
        rules.Different("Another", confirmed);
        return rules.ErrorsByField().Errors.Any();
    }

    [Test]
    [TestCase(10.5, ExpectedResult = false)]
    [TestCase(90, ExpectedResult = false)]
    [TestCase(45, ExpectedResult = false)]
    [TestCase(10.2, ExpectedResult = false)]
    [TestCase(100, ExpectedResult = true)]
    public bool In(double value)
    {
        double[] allowed = new[] { 10.2, 10.5, 10.7, 85, 90, 45 };
        RulesNumbers<double> rules = new RulesNumbers<double>(Language.Fa, "Test", value);
        rules.In(allowed);
        rules.In(allowed.ToList());
        return rules.ErrorsByField().Errors.Any();
    }

    [Test]
    [TestCase(10, 10, ExpectedResult = false)]
    [TestCase(11, 10, ExpectedResult = true)]
    [TestCase(5, 10, ExpectedResult = false)]
    [TestCase(1, 10, ExpectedResult = false)]
    [TestCase(0, 0, ExpectedResult = false)]
    public bool Max(double value, double max)
    {
        RulesNumbers<double> rules = new RulesNumbers<double>(Language.He, "Test", value);
        rules.Max(max);
        return rules.ErrorsByField().Errors.Any();
    }
    
    [Test]
    [TestCase(10, 10, ExpectedResult = false)]
    [TestCase(11, 10, ExpectedResult = false)]
    [TestCase(5, 10, ExpectedResult = true)]
    [TestCase(1, 10, ExpectedResult = true)]
    [TestCase(0, 0, ExpectedResult = false)]
    public bool Min(double value, double min)
    {
        RulesNumbers<double> rules = new RulesNumbers<double>(Language.He, "Test", value);
        rules.Min(min);
        return rules.ErrorsByField().Errors.Any();
    }
    
    [Test]
    [TestCase(10, 10, ExpectedResult = false)]
    [TestCase(11, 10, ExpectedResult = false)]
    [TestCase(5, 10, ExpectedResult = true)]
    [TestCase(1, 10, ExpectedResult = true)]
    [TestCase(0, 0, ExpectedResult = false)]
    public Boolean MinNullable(double? value, double min)
    {
        RulesNumbers<double?> rules = new RulesNumbers<double?>(Language.He, "Test", value);
        rules.Min(min);
        return rules.ErrorsByField().Errors.Any();
    }
    
    [Test]
    [TestCase(10.5, ExpectedResult = true)]
    [TestCase(90, ExpectedResult = true)]
    [TestCase(45, ExpectedResult = true)]
    [TestCase(10.2, ExpectedResult = true)]
    [TestCase(100, ExpectedResult = false)]
    public bool NotIn(double value)
    {
        double[] notAlloweed = new[] { 10.2, 10.5, 10.7, 85, 90, 45 };
        RulesNumbers<double> rules = new RulesNumbers<double>(Language.Fa, "Test", value);
        rules.NotIn(notAlloweed);
        rules.NotIn(notAlloweed.ToList());
        return rules.ErrorsByField().Errors.Any();
    }


    [Test]
    [TestCase(10, 10, ExpectedResult = false)]
    [TestCase(10.5, 10.5, ExpectedResult = false)]
    [TestCase(10, 9, ExpectedResult = true)]
    [TestCase(-10, -10, ExpectedResult = false)]
    [TestCase(0, 10, ExpectedResult = true)]
    public bool Same(double value, double same)
    {
        RulesNumbers<double> rules = new RulesNumbers<double>(Language.Ja, "Test", value);
        rules.Same("Another", same);
        return rules.ErrorsByField().Errors.Any();
    }
}