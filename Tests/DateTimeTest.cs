using ValidaZione;
using ValidaZione.Langs;
using ValidaZione.Rules;

namespace Tests;

public class DateTimeTest
{
    [Test]
    public void After()
    {
        RulesDates rules = new RulesDates(Language.Ja, "Test", DateTime.Now.AddDays(1));
        rules.After(DateTime.Now);
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());

        rules.After(DateTime.Now.AddDays(1));
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());

    }

    [Test]
    public void AfterOrEqual()
    {
        RulesDates rules = new RulesDates(Language.Ja, "Test", DateTime.Now.AddDays(1));
        rules.AfterOrEqual(DateTime.Now);
        rules.AfterOrEqual(DateTime.Now.AddDays(1));
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());

        rules.AfterOrEqual(DateTime.Now.AddDays(2));
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());

    }

    [Test]
    public void Before()
    {
        RulesDates rules = new RulesDates(Language.Ja, "Test", DateTime.Now.AddDays(-1));
        rules.Before(DateTime.Now);
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());

        rules.Before(DateTime.Now.AddDays(-1));
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());

    }

    [Test]
    public void BeforeOrEqual()
    {
        RulesDates rules = new RulesDates(Language.Ja, "Test", DateTime.Now.AddDays(-1));
        rules.BeforeOrEqual(DateTime.Now);
        rules.BeforeOrEqual(DateTime.Now.AddDays(-1));
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());

        rules.BeforeOrEqual(DateTime.Now.AddDays(-2));
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());
    }

    [Test]
    public void Beetween()
    {
        RulesDates rules = new RulesDates(Language.Ja, "Test", DateTime.Now);
        rules.Between(DateTime.Now.AddDays(-1), DateTime.Now.AddDays(1));
        rules.Between(DateTime.Now.AddHours(-1), DateTime.Now.AddHours(1));
        rules.Between(DateTime.Now.AddMinutes(-1), DateTime.Now.AddMinutes(1));
        rules.Between(DateTime.Now.AddSeconds(-1), DateTime.Now.AddSeconds(1));
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());

        rules.Between(DateTime.Now, DateTime.Now);
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());
    }

    [Test]
    public void Confirmed()
    {
        DateTime value = DateTime.Now;
        RulesDates rules = new RulesDates(Language.Lt, "Test", value);
        rules.Confirmed(value);
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());

        rules.Confirmed(DateTime.Now.AddDays(1));
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());

        rules = new RulesDates(Language.Lt, "Test", null);
        rules.Confirmed(null);
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());

        rules = new RulesDates(Language.Lt, "Test", null);
        rules.Confirmed(value);
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());
    }


    [Test]
    public void Different()
    {
        DateTime value = DateTime.Now;
        RulesDates rules = new RulesDates(Language.Lt, "Test", value);
        rules.Different("Another", DateTime.Now.AddDays(1));
        rules.Different("Nullable", null);
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());

        rules = new RulesDates(Language.Lt, "Test", value);
        rules.Different("Another", value);
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());

        rules = new RulesDates(Language.Lt, "Test", null);
        rules.Different("Another", null);
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());
    }

    [Test]
    public void In()
    {
        DateTime value = DateTime.Now.Date;

        List<DateTime> allowed = new List<DateTime>()
        {
            DateTime.Now.AddDays(3).Date,
            DateTime.Now.AddDays(2).Date,
            DateTime.Now.AddDays(1).Date,
            DateTime.Now.Date,
            DateTime.Now.AddDays(1).Date,
            DateTime.Now.AddDays(2).Date,
            DateTime.Now.AddDays(3).Date,
        };

        RulesDates rules = new RulesDates(Language.Zh_CN, "Test", value);
        rules.In(allowed);
        rules.In(allowed.ToArray());
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());

        rules = new RulesDates(Language.Zh_CN, "Test", value.AddDays(7));
        rules.In(allowed);
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());
    }

    [Test]
    public void Max()
    {
        DateTime value = DateTime.Now;

        RulesDates rules = new RulesDates(Language.Cs, "Test", value);
        rules.Max(value);
        rules.Max(DateTime.Now.AddDays(1));
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());

        rules = new RulesDates(Language.Cs, "Test", value);
        rules.Max(DateTime.Now.AddMinutes(-1));
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());
    }

    [Test]
    public void Min()
    {
        DateTime value = DateTime.Now;

        RulesDates rules = new RulesDates(Language.Cs, "Test", value);
        rules.Min(DateTime.Now.AddDays(1));
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());

        rules = new RulesDates(Language.Cs, "Test", value);
        rules.Min(value);
        rules.Min(DateTime.Now.AddMinutes(-1));
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());
    }

    [Test]
    public void NotIn()
    {
        DateTime value = DateTime.Now.Date.AddDays(7);

        List<DateTime> allowed = new List<DateTime>()
        {
            DateTime.Now.AddDays(3).Date,
            DateTime.Now.AddDays(2).Date,
            DateTime.Now.AddDays(1).Date,
            DateTime.Now.Date,
            DateTime.Now.AddDays(1).Date,
            DateTime.Now.AddDays(2).Date,
            DateTime.Now.AddDays(3).Date,
        };

        RulesDates rules = new RulesDates(Language.Zh_CN, "Test", value);
        rules.NotIn(allowed);
        rules.NotIn(allowed.ToArray());
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());

        rules = new RulesDates(Language.Zh_CN, "Test", value.AddDays(-7));
        rules.NotIn(allowed);
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());
    }
    
    
    [Test]
    public void Nullable()
    {
        DateTime? value = null;

        RulesDates rules = new RulesDates(Language.Cs, "Test", value);
        rules.Nullable().Min(DateTime.Now.AddDays(1));
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());
        
        rules = new RulesDates(Language.Cs, "Test", value);
        rules.Nullable().Min(DateTime.Now);
        rules.Nullable().Min(DateTime.Now.AddMinutes(-1));
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());
    }

    [Test]
    public void Same()
    {
        DateTime value = DateTime.Now;
        RulesDates rules = new RulesDates(Language.Bn, "Test", value);
        rules.Same("Another", value);
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());
        
        rules = new RulesDates(Language.Bn, "Test", null);
        rules.Same("Another", null);
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());
        
        rules = new RulesDates(Language.Bn, "Test", value);
        rules.Same("Another", null);
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());
        
        rules = new RulesDates(Language.Bn, "Test", value);
        rules.Same("Another", DateTime.Now.AddDays(1));
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());
    }

}