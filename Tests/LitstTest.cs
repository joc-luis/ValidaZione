using ValidaZione;
using ValidaZione.Langs;

namespace Tests;

public class LitstsTest
{
    [Test]
    public void DistinctTest()
    {
        Validazione validazione = new Validazione(new Es());
        validazione.Field("test", new List<Person>()
        {
            new Person("Terry" , "Bogard"),
            new Person("Terry" , "Bogards")
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