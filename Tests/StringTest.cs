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
        RulesStrings right = new RulesStrings(Language.Bn, "Test", "asdfg1213-+*/");
        right.AlphaDash();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "fasdddDDsadas.-+");
        right.AlphaDash();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "AAAAAAAADDDFFFGGGGG85445/*-");
        right.AlphaDash();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", "https//*55455");
        right.AlphaDash();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesStrings(Language.Bn, "Test", null);
        right.Nullable().AlphaDash();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesStrings wrong = new RulesStrings(Language.Bn, "Test", "0nÑññ");
        wrong.AlphaDash();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "Tru3Ç");
        wrong.AlphaDash();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "0Ç");
        wrong.AlphaDash();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesStrings(Language.Bn, "Test", "Ye5Ç");
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
        right.Nullable().Confirmed(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


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
        
        
        RulesStrings wrong = new RulesStrings(Language.De, "Test", "127.0.0.852");
        wrong.Ip();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesStrings(Language.De, "Test", another.Substring(0,4));
        wrong.Ip();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }
}