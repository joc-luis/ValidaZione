using ValidaZione;
using ValidaZione.Langs;
using ValidaZione.Rules;

namespace Tests;

public class LitstsTest
{
    [Test]
    public void Between()
    {
        List<int> values = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        List<int> nullable = null;
        
        RulesLists<int> right = new RulesLists<int>(Language.Af, "Test", values);
        right.Between(0, 20);
        Assert.IsFalse(right.ErrorsByField().Errors.Any(), "Deberia estar dentro del rango");

        right.Between(0, 10);
        Assert.IsFalse(right.ErrorsByField().Errors.Any(), "Es apenas lo justo.");


        right = new RulesLists<int>(Language.Af, "Test", new int[] { });
        right.Between(0, 20);
        Assert.IsFalse(right.ErrorsByField().Errors.Any(), "Se admite 0, debio pasar.");
        
        right = new RulesLists<int>(Language.Af, "Test", nullable);
        right.Nullable().Between(0, 20);
        Assert.IsFalse(right.ErrorsByField().Errors.Any(), "Se admite null, debio pasar.");


        RulesLists<int> lower = new RulesLists<int>(Language.Af, "Test", values);
        lower.Between(20, 30);
        Assert.IsTrue(lower.ErrorsByField().Errors.Any(), "Como 10 va a ser mayor que 20.");

        RulesLists<int> higer = new RulesLists<int>(Language.Af, "Test", values);
        higer.Between(1, 5);
        Assert.IsTrue(higer.ErrorsByField().Errors.Any(), "Como 5 va a ser mayor que 10");
        
        RulesLists<int> wrong = new RulesLists<int>(Language.Af, "Test", nullable);
        wrong.Between(1, 5);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any(), "Como 5 va a entrar si es nulo");
    }

    [Test]
    public void Confirmed()
    {
        List<int> values = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        List<int> confirmed = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        List<int> nullable = null, anotherNull = null; 

        RulesLists<int> right = new RulesLists<int>(Language.Af, "Test", values);
        right.Confirmed(confirmed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any(), "Son exactamente iguales");
        
        right = new RulesLists<int>(Language.Af, "Test",  nullable);
        right.Nullable().Confirmed(confirmed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any(), "Es nulo pero esta permitido");
        
        right = new RulesLists<int>(Language.Af, "Test",  nullable);
        right.Confirmed(anotherNull);
        Assert.IsFalse(right.ErrorsByField().Errors.Any(), "Ambos son nulos debio pasar la prueba");
        
        RulesLists<int> wrong = new RulesLists<int>(Language.Af, "Test", values);
        wrong.Confirmed(new List<int>() { 1, 2, 3, 4 });
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any(), "Deberia estar dentro del rango");
        
        wrong = new RulesLists<int>(Language.Af, "Test", nullable);
        wrong.Confirmed(new List<int>() { 1, 2, 3, 4 });
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any(), "El valor es nulo, debio fallar");
    }
    
    [Test]
    public void ConfirmedWithObject()
    {
        List<Person> values = new List<Person>()
        {
            new Person("Bob", "Cat"),
            new Person("Sarah", "Connor"),
            new Person("Person", "Cat"),
            new Person("Bob", "fet"),
        };

        List<Person> confirmed = new List<Person>()
        {
            new Person("Bob", "Cat"),
            new Person("Sarah", "Connor"),
            new Person("Person", "Cat"),
            new Person("Bob", "fet"),
        };

        List<Person> nullable = null, anotherNull = null; 

        RulesLists<Person> right = new RulesLists<Person>(Language.Af, "Test", values);
        right.Confirmed(confirmed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any(), "Son exactamente iguales");
        
        right = new RulesLists<Person>(Language.Af, "Test",  nullable);
        right.Nullable().Confirmed(confirmed);
        Assert.IsFalse(right.ErrorsByField().Errors.Any(), "Es nulo pero esta permitido");
        
        right = new RulesLists<Person>(Language.Af, "Test",  nullable);
        right.Confirmed(anotherNull);
        Assert.IsFalse(right.ErrorsByField().Errors.Any(), "Ambos son nulos debio pasar la prueba");
        
        RulesLists<Person> wrong = new RulesLists<Person>(Language.Af, "Test", values);
        wrong.Confirmed(new List<Person>() {   new Person("Bob", "Cat"),
            new Person("Sarah", "Connor"),});
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any(), "Deberia estar dentro del rango");
        
        wrong = new RulesLists<Person>(Language.Af, "Test", nullable);
        wrong.Confirmed(new List<Person>() {   new Person("Bob", "Cat"),
            new Person("Sarah", "Connor"),});
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any(), "El valor es nulo, debio fallar");
    }

    [Test]
    public void Different()
    {
        List<int> values = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        List<int> different = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9
        };

        List<int> nullable = null, anotherNull = null; 
        
        RulesLists<int> right = new RulesLists<int>(Language.En, "test", values);
        right.Different("test2", different);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesLists<int>(Language.En, "test", values);
        right.Different("test2", nullable);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesLists<int>(Language.En, "test", nullable);
        right.Nullable().Different("test2", different);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        different.Add(10);
        RulesLists<int> wrong = new RulesLists<int>(Language.En, "test", values);
        wrong.Different("test2", different);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesLists<int>(Language.En, "test", anotherNull);
        wrong.Different("test2", nullable);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesLists<int>(Language.En, "test", nullable);
        wrong.Nullable().Different("test2", anotherNull);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }
    
    [Test]
    public void DifferentWithObject()
    {
        List<int> values = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        List<int> different = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9
        };

        List<int> nullable = null, anotherNull = null; 
        
        RulesLists<int> right = new RulesLists<int>(Language.En, "test", values);
        right.Different("test2", different);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesLists<int>(Language.En, "test", values);
        right.Different("test2", nullable);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        right = new RulesLists<int>(Language.En, "test", nullable);
        right.Nullable().Different("test2", different);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());
        
        different.Add(10);
        RulesLists<int> wrong = new RulesLists<int>(Language.En, "test", values);
        wrong.Different("test2", different);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesLists<int>(Language.En, "test", anotherNull);
        wrong.Different("test2", nullable);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
        
        wrong = new RulesLists<int>(Language.En, "test", nullable);
        wrong.Nullable().Different("test2", anotherNull);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }


    [Test]
    public void DistinctTest()
    {
        Validazione validazione = new Validazione(new Es());
        validazione.Field("test", new List<Person>()
        {
            new Person("Terry", "Bogard"),
            new Person("Terry", "Bogards")
        }).Distinct();
        validazione.Field("test", new int[] { 1, 2, 3, 4, 5 });
        Assert.That(validazione.Errors().Count, Is.EqualTo(0));
    }

    public class Person
    {
        public String Name { get; set; }
        public String LastName { get; set; }

        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }
}