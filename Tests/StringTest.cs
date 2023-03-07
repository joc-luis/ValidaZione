using Newtonsoft.Json;
using ValidaZione;
using ValidaZione.Langs;
using ValidaZione.Rules;

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
        RulesStrings right = new RulesStrings(Language.Bn, "Test", "on");
        right.Accepted();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "true");
        right.Accepted();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "1");
        right.Accepted();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "yes");
        right.Accepted();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Bn, "Test", "On");
        wrong.Accepted();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "True");
        wrong.Accepted();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "0");
        wrong.Accepted();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "Yes");
        wrong.Accepted();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    [Test]
    public void ActiveUrl()
    {
        RulesStrings right = new RulesStrings(Language.Bn, "Test", "https://www.sharedrop.io/");
        right.ActiveUrl();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "https://www.google.com/");
        right.ActiveUrl();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "https://www.facebook.com/");
        right.ActiveUrl();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test",
            "https://community.atlassian.com/t5/Bitbucket-questions/How-to-write-a-table-of-contents-in-a-Readme-md/qaq-p/673363");
        right.ActiveUrl();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Bn, "Test", "On");
        wrong.ActiveUrl();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "True");
        wrong.ActiveUrl();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "0");
        wrong.ActiveUrl();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "Yes");
        wrong.ActiveUrl();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    [Test]
    public void Alpha()
    {
        RulesStrings right = new RulesStrings(Language.Bn, "Test", "asdfg");
        right.Alpha();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "fasdddDDsadas");
        right.Alpha();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "AAAAAAAADDDFFFGGGGG");
        right.Alpha();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "https");
        right.Alpha();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", null);
        right.Nullable().Alpha();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Bn, "Test", "0n");
        wrong.Alpha();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "Tru3");
        wrong.Alpha();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "0");
        wrong.Alpha();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "Ye5");
        wrong.Alpha();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", null);
        wrong.Alpha();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }


    [Test]
    public void AlphaDash()
    {
        RulesStrings right = new RulesStrings(Language.Bn, "Test", "asdfg1213-");
        right.AlphaDash();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "fasdddDDsadas-_");
        right.AlphaDash();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "AAAAAAAADDDFFFGGGGG85445_-");
        right.AlphaDash();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "https55455ñÇ");
        right.AlphaDash();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", null);
        right.Nullable().AlphaDash();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Bn, "Test", "0*n");
        wrong.AlphaDash();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "Tru3+Ç");
        wrong.AlphaDash();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "0+Ç");
        wrong.AlphaDash();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "Ye+5Ç");
        wrong.AlphaDash();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.Bn, "Test", "/");
        wrong.AlphaDash();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.Bn, "Test", "*");
        wrong.AlphaDash();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.Bn, "Test", "*");
        wrong.AlphaDash();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.Bn, "Test", "`");
        wrong.AlphaDash();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", null);
        wrong.AlphaDash();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }


    [Test]
    public void AlphaNum()
    {
        RulesStrings right = new RulesStrings(Language.Bn, "Test", "asdfg1213");
        right.AlphaNum();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "fasdddDDsadas34234236756879");
        right.AlphaNum();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "AAAAAAAADDDFFFGGGGG85445");
        right.AlphaNum();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "https55455ñÑ");
        right.AlphaNum();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", null);
        right.Nullable().AlphaNum();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Bn, "Test", "%0nÑññ");
        wrong.AlphaNum();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "Tru3Ç*99");
        wrong.AlphaNum();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "0Ç-*");
        wrong.AlphaNum();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "Ye5Ç+");
        wrong.AlphaNum();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", null);
        wrong.AlphaNum();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    [Test]
    public void Between()
    {
        String value = "This is a testing", another = "", nullable = null;

        RulesStrings right = new RulesStrings(Language.Gu, "test", value);
        right.Between(0, value.Length);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Gu, "test", value);
        right.Between(value.Length, value.Length);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Gu, "test", another);
        right.Between(0, 0);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Gu, "test", another);
        right.Between(0, 10);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Gu, "test", nullable);
        right.Nullable().Between(0, 10);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Gu, "test", value);
        wrong.Between(0, value.Length - 1);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Gu, "test", value);
        wrong.Between(value.Length, value.Length - 1);

        wrong = new RulesStrings(Language.Gu, "test", another);
        wrong.Between(1, 2);

        wrong = new RulesStrings(Language.Gu, "test", another);
        wrong.Between(1, 1);

        wrong = new RulesStrings(Language.Gu, "test", nullable);
        wrong.Between(0, 10);
    }


    [Test]
    public void Boolean()
    {
        RulesStrings right = new RulesStrings(Language.Sr_Latn_ME, "Test", "true");
        right.Boolean();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Sr_Latn_ME, "Test", "1");
        right.Boolean();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Sr_Latn_ME, "Test", "false");
        right.Boolean();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Sr_Latn_ME, "Test", "0");
        right.Boolean();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Sr_Latn_ME, "Test", null);
        right.Nullable().Boolean();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Sr_Latn_ME, "Test", "trues");
        wrong.Boolean();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Sr_Latn_ME, "Test", "10");
        wrong.Boolean();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Sr_Latn_ME, "Test", "falses");
        wrong.Boolean();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Sr_Latn_ME, "Test", "01");
        wrong.Boolean();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Sr_Latn_ME, "Test", null);
        wrong.Boolean();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    [Test]
    public void Confirmed()
    {
        String value = "confirmed", another = "confirmed";

        RulesStrings right = new RulesStrings(Language.Et, "Test", value);
        right.Confirmed(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Et, "Test", null);
        right.Confirmed(null);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Et, "Test", null);
        right.Confirmed(another);
        Assert.IsTrue(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Et, "Test", value);
        wrong.Confirmed("another");
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Et, "Test", null);
        wrong.Confirmed("another");
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Et, "Test", value);
        wrong.Confirmed(null);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Et, "Test", null);
        wrong.Required().Confirmed(null);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }


    [Test]
    public void Different()
    {
        String value = "confirmed", another = "different";

        RulesStrings right = new RulesStrings(Language.Et, "Test", value);
        right.Different("another", another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Et, "Test", value);
        right.Different("another", null);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Et, "Test", null);
        right.Nullable().Different("another", another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Et, "Test", value);
        wrong.Different("another", "confirmed");
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Et, "Test", null);
        wrong.Nullable().Different("another", null);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Et, "Test", null);
        wrong.Different("another", null);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Et, "Test", null);
        wrong.Required().Different("another", null);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }
    
    [Test]
    public void DoesNotEndWith()
    {
        String[] allowed = new[] { "st", "ba", "y", "ss" };

        RulesStrings wrong = new RulesStrings(Language.Gu, "Test", "test");
        wrong.DoesNotEndWith(allowed);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Gu, "Test", "prueba");
        wrong.DoesNotEndWith(allowed.ToList());
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Gu, "Test", "try");
        wrong.DoesNotEndWith(allowed);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Gu, "Test", "pass");
        wrong.DoesNotEndWith(allowed);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Gu, "Test", null);
        wrong.DoesNotEndWith(allowed);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());


        RulesStrings right = new RulesStrings(Language.Gu, "Test", "testing");
        right.DoesNotEndWith(allowed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Gu, "Test", "pruebas");
        right.DoesNotEndWith(allowed.ToList());
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Gu, "Test", "tired");
        right.DoesNotEndWith(allowed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Gu, "Test", "passenger");
        right.DoesNotEndWith(allowed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Gu, "Test", null);
        right.Nullable().DoesNotEndWith(allowed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
    }
    
    
    [Test]
    [TestCase("End", ExpectedResult = true)]
    [TestCase("Fin", ExpectedResult = true)]
    [TestCase("Test", ExpectedResult = true)]
    [TestCase("Prueba", ExpectedResult = true)]
    [TestCase("Ninguna de las anteriores", ExpectedResult = false)]
    public bool DoesNotStartWith(string value)
    {
        RulesStrings rules = new RulesStrings(Language.Ro, "Test", value);
        rules.DoesNotStartWith(new[] { "En", "Fi", "Te", "Pr" });

        return rules.ErrorsByField().Errors.Any();
    }

    [Test]
    public void Email()
    {
        RulesStrings right = new RulesStrings(Language.Be, "Test", "email@email.com");
        right.Email();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Be, "Test", "email@email.c");
        right.Email();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Be, "Test", null);
        right.Nullable().Email();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Be, "Test", "emailemailcom");
        wrong.Email();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Be, "Test", "emailemail.c");
        wrong.Email();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Be, "Test", null);
        wrong.Email();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }


    [Test]
    public void EndsWith()
    {
        String[] allowed = new[] { "st", "ba", "y", "ss" };

        RulesStrings right = new RulesStrings(Language.Gu, "Test", "test");
        right.EndsWith(allowed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Gu, "Test", "prueba");
        right.EndsWith(allowed.ToList());
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Gu, "Test", "try");
        right.EndsWith(allowed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Gu, "Test", "pass");
        right.EndsWith(allowed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Gu, "Test", null);
        right.Nullable().EndsWith(allowed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Gu, "Test", "testing");
        wrong.EndsWith(allowed);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Gu, "Test", "pruebas");
        wrong.EndsWith(allowed.ToList());
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Gu, "Test", "tired");
        wrong.EndsWith(allowed);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Gu, "Test", "passenger");
        wrong.EndsWith(allowed);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Gu, "Test", null);
        wrong.EndsWith(allowed);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }


    [Test]
    public void GreaterThan()
    {
        string value = "testing", another = "other";

        RulesStrings right = new RulesStrings(Language.Lt, "Test", value);
        right.GreaterThan(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Lt, "Test", value);
        right.GreaterThan("");
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Lt, "Test", value);
        right.GreaterThan(null);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Lt, "Test", null);
        right.Nullable().GreaterThan(null);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.Lt, "Test", null);
        right.Nullable().GreaterThan(null);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Lt, "Test", another);
        wrong.GreaterThan(another);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Lt, "Test", another);
        wrong.GreaterThan(value);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Lt, "Test", null);
        wrong.GreaterThan(null);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Lt, "Test", null);
        wrong.GreaterThan("Fail");
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
    }


    [Test]
    public void GreaterThanOrEqual()
    {
        string value = "testing", another = "other";

        RulesStrings right = new RulesStrings(Language.Lt, "Test", value);
        right.GreaterThanOrEqual(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Lt, "Test", value);
        right.GreaterThanOrEqual(value);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Lt, "Test", value);
        right.GreaterThanOrEqual(null);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Lt, "Test", null);
        right.Nullable().GreaterThanOrEqual(null);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Lt, "Test", another);
        wrong.GreaterThanOrEqual(value);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Lt, "Test", null);
        wrong.GreaterThanOrEqual(value);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Lt, "Test", null);
        wrong.GreaterThanOrEqual("Fail");
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }


    [Test]
    public void In()
    {
        String[] allowed = new[] { "one", "two", "three", "four", "five", null };

        RulesStrings right = new RulesStrings(Language.Bn, "Test", "one");
        right.In(allowed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "two");
        right.In(allowed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "three");
        right.In(allowed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", null);
        right.In(allowed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        
        RulesStrings wrong = new RulesStrings(Language.Bn, "Test", "uno");
        wrong.In(allowed);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "dos");
        wrong.In(allowed);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "tres");
        wrong.In(allowed);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "cuatro");
        wrong.In(allowed);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    [Test]
    public void Integer()
    {

        int value = new Random().Next(Int32.MinValue, Int32.MaxValue);
        double another = new Random().NextDouble();

        RulesStrings right = new RulesStrings(Language.Pl, "Test", value.ToString());
        right.Integer();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.Pl, "Test", "1234");
        right.Integer();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.Pl, "Test", "-1234");
        right.Integer();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.Pl, "Test", "1");
        right.Integer();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.Pl, "Test", null);
        right.Nullable().Integer();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        
        
        RulesStrings wrong = new RulesStrings(Language.Pl, "Test", another.ToString());
        wrong.Integer();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.Pl, "Test", "ALPHA");
        wrong.Integer();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.Pl, "Test", "1.56");
        wrong.Integer();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.Pl, "Test", "--15");
        wrong.Integer();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.Pl, "Test", "15-");
        wrong.Integer();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.Pl, "Test", null);
        wrong.Integer();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    
    [Test]
    public void Ip()
    {
        string value = "127.0.0.1", another = "fe80::979f:6646:44ce:52ec%11";

        RulesStrings right = new RulesStrings(Language.De, "Test", value);
        right.Ip();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.De, "Test", another);
        right.Ip();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.De, "Test", null);
        right.Nullable().Ip();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        
        RulesStrings wrong = new RulesStrings(Language.De, "Test", "127.0.0.852");
        wrong.Ip();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.De, "Test", another.Substring(0,4));
        wrong.Ip();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.De, "Test", null);
        wrong.Ip();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }
    
    [Test]
    public void Ipv4()
    {
        string value = "127.0.0.1", another = "fe80::979f:6646:44ce:52ec%11";

        RulesStrings right = new RulesStrings(Language.De, "Test", value);
        right.Ipv4();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        RulesStrings wrong = new RulesStrings(Language.De, "Test", "127.0.0.852");
        wrong.Ipv4();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.De, "Test", null);
        right.Nullable().Ipv4();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.De, "Test", another);
        wrong.Ipv4();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.De, "Test", null);
        wrong.Ipv4();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }
    
    [Test]
    public void Ipv6()
    {
        string value = "fe80::979f:6646:44ce:52ec%11", another = "127.0.0.1";

        RulesStrings right = new RulesStrings(Language.De, "Test", value);
        right.Ipv6();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        RulesStrings wrong = new RulesStrings(Language.De, "Test", "127.0.0.852");
        wrong.Ipv6();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.De, "Test", null);
        right.Nullable().Ipv6();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        
        wrong = new RulesStrings(Language.De, "Test", another);
        wrong.Ipv6();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.De, "Test", null);
        wrong.Ipv6();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    [Test]
    public void Json()
    {
        string json = JsonConvert.SerializeObject(new Thing("keyboard"));

        RulesStrings right = new RulesStrings(Language.Cs, "Test", json);
        right.Json();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.Cs, "Test", null);
        right.Nullable().Json();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
    }


    [Test]
    public void Lowercase()
    {
        string value = "ajkshfkjlhdsajklfhuioslwhfeufiweuohuiohvnksdbn";

        RulesStrings right = new RulesStrings(Language.Vi, "Test", value);
        right.Lowercase();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        value = "djasdAAASDAssadafsd";
        RulesStrings wrong = new RulesStrings(Language.Vi, "Test", value);
        wrong.Lowercase();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.Vi, "Test", "213");
        wrong.Lowercase();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    [Test]
    public void LessThan()
    {
        string value = "testing", another = "other";

        RulesStrings right = new RulesStrings(Language.Lt, "Test", another);
        right.LessThan(value);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Lt, "Test", value);
        right.LessThan("123456789");
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Lt, "Test", null);
        right.Nullable().LessThan(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.Lt, "Test", "");
        right.Nullable().LessThan(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Lt, "Test", another);
        wrong.LessThan(another);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Lt, "Test", value);
        wrong.LessThan(another);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Lt, "Test", null);
        wrong.LessThan(null);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.Lt, "Test", null);
        wrong.LessThan(null);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }


    [Test]
    public void LessThanOrEqual()
    {
        string value = "testing", another = "other";
        
        RulesStrings right = new RulesStrings(Language.Lt, "Test", another);
        right.LessThanOrEqual(value);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.Lt, "Test", another);
        right.LessThanOrEqual(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Lt, "Test", null);
        right.Nullable().LessThanOrEqual(value);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Lt, "Test", "");
        right.LessThanOrEqual("");
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        
        
        RulesStrings wrong = new RulesStrings(Language.Lt, "Test", value);
        wrong.LessThanOrEqual(another);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Lt, "Test", value);
        wrong.LessThanOrEqual("1234");
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Lt, "Test", value);
        wrong.LessThanOrEqual(null);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }
    
    
    [Test]
    [TestCase("46:fe:c6:8d:4d:ed")]
    [TestCase("fa:85:61:a5:58:6c")]
    [TestCase("b1:b3:7a:00:a2:90")]
    [TestCase("ec:5a:58:0b:dd:82")]
    [TestCase("7d:31:cb:96:b0:ea")]
    [TestCase("25:aa:65:92:09:be")]
    [TestCase("85:01:cc:a2:b6:d1")]
    [TestCase("dd:97:6e:a2:b2:37")]
    [TestCase("74:d8:f1:c7:33:57")]
    [TestCase("e6:21:ec:9b:6b:bc")]
    public void MacAddress(string mac)
    {
        RulesStrings rules = new RulesStrings(Language.He, "Test", mac);
        rules.MacAddress();
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());
    }

    
    [Test]
    public void Max()
    {
        RulesStrings right = new RulesStrings(Language.Ka, "Test", "Less");
        right.Max(4);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.Ka, "Test", "Less");
        right.Max(6);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.Ka, "Test", "");
        right.Max(0);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesStrings(Language.Ka, "Test", null);
        right.Nullable().Max(0);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        
        
        RulesStrings wrong = new RulesStrings(Language.Ka, "Test", "Less than or equal");
        wrong.Max(4);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.Ka, "Test", null);
        wrong.Max(4);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    [Test]
    public void Min()
    {
        RulesStrings rules = new RulesStrings(Language.Mk, "Test", "Testing");
        rules.Min(0);
        rules.Min(7);
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());
        rules.Min(10);
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());
    }

    [Test]
    public void NotIn()
    {
        List<String> values = new List<string>()
        {
            "one",
            "two",
            "three",
            "four"
        };

        RulesStrings rules = new RulesStrings(Language.Sq, "Test", "five");
        rules.NotIn(values);
        Assert.IsFalse(rules.ErrorsByField().Errors.Any());
        
        
        values.Add("five");
        rules.NotIn(values.ToArray());
        Assert.IsTrue(rules.ErrorsByField().Errors.Any());
    }

    [Test]
    [TestCase("1", ExpectedResult = false)]
    [TestCase("1.5", ExpectedResult = false)]
    [TestCase("1337e0", ExpectedResult = false)]
    [TestCase("02471", ExpectedResult = false)]
    [TestCase("0x539", ExpectedResult = true)]
    [TestCase("not numeric", ExpectedResult = true)]
    [TestCase("0x539", ExpectedResult = true)]
    [TestCase("0b10100111001", ExpectedResult = true)]
    public bool Numeric(string value)
    {
        RulesStrings rules = new RulesStrings(Language.Lt, "Test", value);
        rules.Numeric();
        return rules.ErrorsByField().Errors.Any();
    }

    [Test]
    [TestCase(null, ExpectedResult = true)]
    [TestCase("", ExpectedResult = true)]
    [TestCase("s", ExpectedResult = false)]
    public bool Required(string value)
    {
        RulesStrings rules = new RulesStrings(Language.Cs, "Test", value);
        rules.Required();
        return rules.ErrorsByField().Errors.Any();
    }

    [Test]
    [TestCase(null, "", "", ExpectedResult = true)]
    [TestCase("", "", "", ExpectedResult = true)]
    [TestCase("aaa", "", "", ExpectedResult = false)]
    [TestCase(null, null, "", ExpectedResult = false)]
    public bool RequiredIf(string value, string another, string equal)
    {
        RulesStrings rules = new RulesStrings(Language.Cs, "Test", value);
        rules.RequiredIf("Another", another, equal);

        return rules.ErrorsByField().Errors.Any();
    }

    [Test]
    [TestCase("same", "same", ExpectedResult = false)]
    [TestCase("different", "differentt", ExpectedResult = true)]
    [TestCase(null, "", ExpectedResult = true)]
    [TestCase("", "", ExpectedResult = false)]
    [TestCase("DTE", "dte", ExpectedResult = true)]
    [TestCase("anyway", "como sea", ExpectedResult = true)]
    [TestCase(null, null, ExpectedResult = false)]
    public bool Same(string value, string another)
    {
        RulesStrings rules = new RulesStrings(Language.Sw, "Test", value);
        rules.Same("another", another);
        return rules.ErrorsByField().Errors.Any();
    }

    [Test]
    [TestCase("", 0, ExpectedResult = false)]
    [TestCase("Four", 4, ExpectedResult = false)]
    [TestCase("five", 5, ExpectedResult = true)]
    [TestCase("", 4, ExpectedResult = true)]
    [TestCase(null, 0, ExpectedResult = true)]
    public bool Size(string value, int size)
    {
        RulesStrings rules = new RulesStrings(Language.Et, "Test", value);
        rules.Size(size);
        return rules.ErrorsByField().Errors.Any();
    }


    [Test]
    [TestCase("End", ExpectedResult = false)]
    [TestCase("Fin", ExpectedResult = false)]
    [TestCase("Test", ExpectedResult = false)]
    [TestCase("Prueba", ExpectedResult = false)]
    [TestCase("Ninguna de las anteriores", ExpectedResult = true)]
    public bool StartsWith(string value)
    {
        RulesStrings rules = new RulesStrings(Language.Ro, "Test", value);
        rules.StartsWith(new[] { "En", "Fi", "Te", "Pr" });

        return rules.ErrorsByField().Errors.Any();
    }

    [Test]
    [TestCase("TODOBIEN", ExpectedResult = false)]
    [TestCase("CASI PERO no", ExpectedResult = true)]
    [TestCase("dlknjaskdljlask;jdlksa", ExpectedResult = true)]
    [TestCase("empezo mal y termino BIEN", ExpectedResult = true)]
    [TestCase("1", ExpectedResult = true)]
    [TestCase("A", ExpectedResult = false)]
    [TestCase(null, ExpectedResult = true)]
    public bool Uppercase(string value)
    {
        RulesStrings rules = new RulesStrings(Language.Ro, "Test", value);
        rules.Uppercase();

        return rules.ErrorsByField().Errors.Any();
    }

    [Test]
    [TestCase("https://github.com/Laravel-Lang/lang/blob/main/locales/en/php.json", ExpectedResult = false)]
    [TestCase("https://github.com/Laravel-Lang/lang/tree/main/locales", ExpectedResult = false)]
    [TestCase("https://github.com/Laravel-Lang", ExpectedResult = false)]
    [TestCase("https://github.com/", ExpectedResult = false)]
    [TestCase("https://github.com/joc-luis/ValidaZione", ExpectedResult = false)]
    [TestCase("https:github", ExpectedResult = true)]
    [TestCase("https://www.github.com/", ExpectedResult = false)]
    public bool Url(string value)
    {
        RulesStrings rules = new RulesStrings(Language.Ro, "Test", value);
        rules.Url();
        return rules.ErrorsByField().Errors.Any();
    }
}

public class Thing
{
    public string Name { get; set; }

    public Thing(string name)
    {
        this.Name = name;
    }
}