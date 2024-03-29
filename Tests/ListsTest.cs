﻿using Microsoft.VisualStudio.TestPlatform.ObjectModel;
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

        right = new RulesLists<int>(Language.Af, "Test", nullable);
        right.Nullable().Confirmed(confirmed);
        Assert.IsTrue(right.ErrorsByField().Errors.Any(), "Es nulo pero esta permitido");

        right = new RulesLists<int>(Language.Af, "Test", nullable);
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

        right = new RulesLists<Person>(Language.Af, "Test", nullable);
        right.Confirmed(confirmed);
        Assert.IsTrue(right.ErrorsByField().Errors.Any(), "Es nulo pero esta permitido");

        right = new RulesLists<Person>(Language.Af, "Test", nullable);
        right.Confirmed(anotherNull);
        Assert.IsFalse(right.ErrorsByField().Errors.Any(), "Ambos son nulos debio pasar la prueba");

        RulesLists<Person> wrong = new RulesLists<Person>(Language.Af, "Test", values);
        wrong.Confirmed(new List<Person>()
        {
            new Person("Bob", "Cat"),
            new Person("Sarah", "Connor"),
        });
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any(), "Deberia estar dentro del rango");

        wrong = new RulesLists<Person>(Language.Af, "Test", nullable);
        wrong.Confirmed(new List<Person>()
        {
            new Person("Bob", "Cat"),
            new Person("Sarah", "Connor"),
        });
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
    public void Distinct()
    {
        List<Double> values = new List<Double> { 10, 45.6, 57.8, 90, 67 };
        List<double> nullable = null;

        RulesLists<Double> right = new RulesLists<double>(Language.De, "Test", values);
        right.Distinct();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesLists<double>(Language.De, "Test", nullable);
        right.Nullable().Distinct();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        values.Add(45.6);

        RulesLists<Double> wrong = new RulesLists<double>(Language.De, "Test", values);
        wrong.Distinct();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesLists<double>(Language.De, "Test", nullable);
        wrong.Distinct();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    [Test]
    public void DistinctObject()
    {
        List<Person> values = new List<Person>
        {
            new Person("Bob", "Cat"),
            new Person("Sarah", "Connor"),
            new Person("Person", "Cat"),
            new Person("Bob", "fet"),
        };

        List<Person> nullable = null;

        RulesLists<Person> right = new RulesLists<Person>(Language.De, "Test", values);
        right.Distinct();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesLists<Person>(Language.De, "Test", nullable);
        right.Nullable().Distinct();
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        values.Add(new Person("Bob", "fet"));

        RulesLists<Person> wrong = new RulesLists<Person>(Language.De, "Test", values);
        wrong.Distinct();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesLists<Person>(Language.De, "Test", nullable);
        wrong.Distinct();
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    [Test]
    public void GreaterThan()
    {
        List<int> values = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        List<int> another = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9
        };

        List<int> nulllable = null;

        RulesLists<int> right = new RulesLists<int>(Language.Tg, "Test", values);
        right.GreaterThan(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesLists<int>(Language.Tg, "Test", nulllable);
        right.Nullable().GreaterThan(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesLists<int> wrong = new RulesLists<int>(Language.Tg, "Test", another);
        wrong.GreaterThan(another);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesLists<int>(Language.Tg, "Test", another);
        wrong.GreaterThan(values);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesLists<int>(Language.Tg, "Test", nulllable);
        wrong.GreaterThan(values);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesLists<int>(Language.Tg, "Test", nulllable);
        wrong.GreaterThan(nulllable);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    [Test]
    public void GreaterThanOrEqual()
    {
        List<int> values = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        List<int> another = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9
        };

        List<int> nulllable = null;

        RulesLists<int> right = new RulesLists<int>(Language.Tg, "Test", values);
        right.GreaterThanOrEqual(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesLists<int>(Language.Tg, "Test", values);
        right.GreaterThanOrEqual(values);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesLists<int>(Language.Tg, "Test", nulllable);
        right.Nullable().GreaterThanOrEqual(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesLists<int> wrong = new RulesLists<int>(Language.Tg, "Test", another);
        wrong.GreaterThanOrEqual(values);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesLists<int>(Language.Tg, "Test", nulllable);
        wrong.GreaterThanOrEqual(values);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesLists<int>(Language.Tg, "Test", nulllable);
        wrong.GreaterThanOrEqual(nulllable);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    [Test]
    public void LessThan()
    {
        List<int> values = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9
        };

        List<int> another = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        List<int> nulllable = null;

        RulesLists<int> right = new RulesLists<int>(Language.Tg, "Test", values);
        right.LessThan(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesLists<int>(Language.Tg, "Test", nulllable);
        right.Nullable().LessThan(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesLists<int> wrong = new RulesLists<int>(Language.Tg, "Test", another);
        wrong.LessThan(another);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesLists<int>(Language.Tg, "Test", another);
        wrong.LessThan(values);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesLists<int>(Language.Tg, "Test", nulllable);
        wrong.LessThan(values);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesLists<int>(Language.Tg, "Test", nulllable);
        wrong.LessThan(nulllable);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    [Test]
    public void LessThanOrEqual()
    {
        List<int> values = new List<int>
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9
        };

        List<int> another = new List<int>()
        {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };

        List<int> nulllable = null;

        RulesLists<int> right = new RulesLists<int>(Language.Tg, "Test", values);
        right.LessThanOrEqual(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesLists<int>(Language.Tg, "Test", values);
        right.LessThanOrEqual(values);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());

        right = new RulesLists<int>(Language.Tg, "Test", nulllable);
        right.Nullable().LessThanOrEqual(another);
        Assert.IsFalse(right.ErrorsByField().Errors.Any());


        RulesLists<int> wrong = new RulesLists<int>(Language.Tg, "Test", another);
        wrong.LessThanOrEqual(values);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesLists<int>(Language.Tg, "Test", nulllable);
        wrong.LessThanOrEqual(values);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());

        wrong = new RulesLists<int>(Language.Tg, "Test", nulllable);
        wrong.LessThanOrEqual(nulllable);
        Assert.IsTrue(wrong.ErrorsByField().Errors.Any());
    }

    [Test]
    [TestCase(0, ExpectedResult = true)]
    [TestCase(4, ExpectedResult = true)]
    [TestCase(5, ExpectedResult = false)]
    [TestCase(10, ExpectedResult = false)]
    [TestCase(14, ExpectedResult = false)]
    [TestCase(50, ExpectedResult = false)]
    public bool Max(long max)
    {
        RulesLists<int> rules = new RulesLists<int>(Language.Cy, "Test", new[] { 1, 2, 3, 4, 5 });
        rules.Max(max);
        return rules.ErrorsByField().Errors.Any();
    }

    [Test]
    [TestCase(0, ExpectedResult = false)]
    [TestCase(4, ExpectedResult = false)]
    [TestCase(5, ExpectedResult = false)]
    [TestCase(10, ExpectedResult = true)]
    [TestCase(14, ExpectedResult = true)]
    [TestCase(50, ExpectedResult = true)]
    public bool Min(long min)
    {
        RulesLists<int> rules = new RulesLists<int>(Language.Cy, "Test", new[] { 1, 2, 3, 4, 5 });
        rules.Min(min);
        return rules.ErrorsByField().Errors.Any();
    }

    [Test]
    [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5 }, ExpectedResult = false)]
    [TestCase(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 3, 4, 5 }, ExpectedResult = true)]
    [TestCase(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 2, 3, 4, 5, 6 }, ExpectedResult = true)]
    [TestCase(new int[] { }, new int[] { }, ExpectedResult = false)]
    [TestCase(null, new[] { 1, 2, 3, 4, 5 }, ExpectedResult = true)]
    [TestCase(null, null, ExpectedResult = false)]
    public bool Same(int[] values, int[] another)
    {
        RulesLists<int> rules = new RulesLists<int>(Language.Id, "Test", values);
        rules.Same("Another", another);
        return rules.ErrorsByField().Errors.Any();
    }

    [Test]
    [TestCase(new[] { 1, 2 }, 2, ExpectedResult = false)]
    [TestCase(new[] { 1, 2 }, 2, ExpectedResult = false)]
    [TestCase(new int[] { }, 0, ExpectedResult = false)]
    [TestCase(new[] { 1, 2, 4, 3 }, 4, ExpectedResult = false)]
    [TestCase(new[] { 1, 2 }, 0, ExpectedResult = true)]
    [TestCase(null, 2, ExpectedResult = true)]
    public bool Size(int[] values, long size)
    {
        RulesLists<int> rules = new RulesLists<int>(Language.Oc, "Test", values);
        rules.Size(size);
        return rules.ErrorsByField().Errors.Any();
    }
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