using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Nl : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} moet worden geaccepteerd.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} is geen geldige URL.";
        }
public string After(string date)
        {
            return $"{FieldName} moet een datum na {date} zijn.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} moet een datum na of gelijk aan {date} zijn.";
        }
public string Alpha()
        {
            return $"{FieldName} mag alleen letters bevatten.";
        }
public string AlphaDash()
        {
            return $"{FieldName} mag alleen letters, nummers, underscores (_) en streepjes (-) bevatten.";
        }
public string AlphaNum()
        {
            return $"{FieldName} mag alleen letters en nummers bevatten.";
        }
public string Before(string date)
        {
            return $"{FieldName} moet een datum vóór {date} zijn.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} moet een datum vóór of gelijk aan {date} zijn.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} moet tussen {min} en {max} waardes bevatten.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} moet tussen {min} en {max} zijn.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} moet tussen {min} en {max} karakters zijn.";
        }
public string Boolean()
        {
            return $"{FieldName} moet ja of nee zijn.";
        }
public string Confirmed()
        {
            return $"Bevestiging van {FieldName} komt niet overeen.";
        }
public string Declined()
        {
            return $"{FieldName} moet afgewezen worden.";
        }
public string Different(string name)
        {
            return $"{FieldName} en {name} moeten verschillend zijn.";
        }
public string Distinct()
        {
            return $"{FieldName} heeft een dubbele waarde.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} mag niet eindigen met één van de volgende waarden: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} mag niet beginnen met één van de volgende waarden: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} is geen geldig e-mailadres.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} moet met één van de volgende waarden eindigen: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} moet meer dan {value} waardes bevatten.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} moet meer dan {value} tekens bevatten.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} moet {value} of meer waardes bevatten.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} moet minimaal {value} tekens bevatten.";
        }
public string In()
        {
            return $"{FieldName} is ongeldig.";
        }
public string Integer()
        {
            return $"{FieldName} moet een getal zijn.";
        }
public string Ip()
        {
            return $"{FieldName} moet een geldig IP-adres zijn.";
        }
public string Ipv4()
        {
            return $"{FieldName} moet een geldig IPv4-adres zijn.";
        }
public string Ipv6()
        {
            return $"{FieldName} moet een geldig IPv6-adres zijn.";
        }
public string Json()
        {
            return $"{FieldName} moet een geldige JSON-string zijn.";
        }
public string Lowercase()
        {
            return $"{FieldName} mag alleen kleine letters bevatten.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} moet minder dan {value} waardes bevatten.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} moet minder dan {value} tekens bevatten.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} moet {value} of minder waardes bevatten.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} moet maximaal {value} tekens bevatten.";
        }
public string MacAddress()
        {
            return $"{FieldName} moet een geldig MAC-adres zijn.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} mag niet meer dan {max} waardes bevatten.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} mag niet hoger dan {max} zijn.";
        }
public string MaxString(int max)
        {
            return $"{FieldName} mag niet uit meer dan {max} tekens bestaan.";
        }
public string MinArray(long min)
        {
            return $"{FieldName} moet minimaal {min} waardes bevatten.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} moet minimaal {min} zijn.";
        }
public string MinString(int min)
        {
            return $"{FieldName} moet minimaal {min} tekens zijn.";
        }
public string NotIn()
        {
            return $"{FieldName} is ongeldig.";
        }
public string NotRegex()
        {
            return $"Het formaat van {FieldName} is ongeldig.";
        }
public string Numeric()
        {
            return $"{FieldName} moet een getal zijn.";
        }
public string Regex()
        {
            return $"Het formaat van {FieldName} is ongeldig.";
        }
public string Required()
        {
            return $"{FieldName} is verplicht.";
        }
public string RequiredIf(string name, string value)
        {
            return $"{FieldName} is verplicht indien {name} gelijk is aan {value}.";
        }
public string Same(string name)
        {
            return $"{FieldName} en {name} moeten overeenkomen.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} moet {size} waardes bevatten.";
        }
public string SizeString(int size)
        {
            return $"{FieldName} moet {size} tekens zijn.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} moet beginnen met een van de volgende: {String.Join(", ", values)}.";
        }
public string Uppercase()
        {
            return $"{FieldName} mag alleen hoofdletters bevatten.";
        }
public string Url()
        {
            return $"{FieldName} moet een geldige URL zijn.";
        }
    }
        }