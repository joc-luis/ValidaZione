using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Af : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Die {FieldName} moet aanvaar word.";
            }
public string ActiveUrl()
        {
            return $"Die {FieldName} is nie 'n geldig URL.";
        }
public string After(string date)
        {
            return $"Die {FieldName} moet 'n datum wees na {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Die {FieldName} moet 'n datum wees na of gelyk aan {date}.";
        }
public string Alpha()
        {
            return $"Die {FieldName} mag slegs letters bevat.";
        }
public string AlphaDash()
        {
            return $"Die {FieldName} mag slegs letters, syfers, strepies en onderstrepe bevat.";
        }
public string AlphaNum()
        {
            return $"Die {FieldName} mag slegs letters en syfers bevat.";
        }
public string Before(string date)
        {
            return $"Die {FieldName} moet datum voor {date} wees.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Die {FieldName} Moet datum voor of gelyk aan {date} wees.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Die {FieldName} moet tussen {min} en {max} items hê.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Die {FieldName} moet tussen {min} en {max} wees.";
        }
public string BetweenString(int min, int max)
        {
            return $"Die {FieldName} moet tussen {min} en {max} karakters wees.";
        }
public string Boolean()
        {
            return $"Die {FieldName} veld moet waar of onwaar wees.";
        }
public string Confirmed()
        {
            return $"Die {FieldName} bevestiging stem nie ooreen nie.";
        }
public string Declined()
        {
            return $"Die {FieldName} moet geweier word.";
        }
public string Different(string name)
        {
            return $"Die {FieldName} en {name} moet anders wees.";
        }
public string Distinct()
        {
            return $"Die {FieldName} veld het 'n duplikaatwaarde.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"Die {FieldName} mag nie eindig met een van die volgende nie: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"Die {FieldName} mag nie met een van die volgende begin nie: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Die {FieldName} moet geldige epos adres wees.";
        }
public string EndsWith(List<string> values)
        {
            return $"Die {FieldName} moet eindig met een van die volgende: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"Die {FieldName} moet meer hê as {value} items.";
        }
public string GreaterThanString(int value)
        {
            return $"Die {FieldName} moet groter wees as {value} karakters.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Die {FieldName} moet {value} items hê of meer.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Die {FieldName} moet groter wees as of gelyk wees {value} characters.";
        }
public string In()
        {
            return $"Die geselketeerde {FieldName} is ongeldig.";
        }
public string Integer()
        {
            return $"Die {FieldName} moet 'n getal wees.";
        }
public string Ip()
        {
            return $"Die {FieldName} moet geldige IP adres wees.";
        }
public string Ipv4()
        {
            return $"Die {FieldName} moet geldige IPv4 address wees.";
        }
public string Ipv6()
        {
            return $"Die {FieldName} moet geldige IPv6 address wees.";
        }
public string Json()
        {
            return $"Die {FieldName} moet geldige JSON string wees.";
        }
public string Lowercase()
        {
            return $"Die {FieldName} moet kleinletters wees.";
        }
public string LessThanArray(long value)
        {
            return $"Die {FieldName} moet minder as wees {value} items.";
        }
public string LessThanString(int value)
        {
            return $"Die {FieldName} moet minder as wees than {value} karakters.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"Die {FieldName} moet nie meer as {value} items wees.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"Die {FieldName} moet kleiner of gelyk wees aan {value} karakters.";
        }
public string MacAddress()
        {
            return $"Die {FieldName} moet 'n geldige MAC-adres wees.";
        }
public string MaxArray(long max)
        {
            return $"Die {FieldName} mag nie groter as {max} items wees.";
        }
public string MaxNumeric(string max)
        {
            return $"Die {FieldName} mag nie groter as {max} wees.";
        }
public string MaxString(int max)
        {
            return $"Die {FieldName} mag nie groter as {max} karakters wees.";
        }
public string MinArray(long min)
        {
            return $"Die {FieldName} moet ten minste {min} items wees.";
        }
public string MinNumeric(string min)
        {
            return $"Die {FieldName} moet ten minste {min} wees.";
        }
public string MinString(int min)
        {
            return $"Die {FieldName} moet ten minste {min} karakters wees.";
        }
public string NotIn()
        {
            return $"Die geselketeerde {FieldName} is ongeldig.";
        }
public string NotRegex()
        {
            return $"Die {FieldName} formaat is ongeldig.";
        }
public string Numeric()
        {
            return $"Die {FieldName} moet 'n syfer wees.";
        }
public string Regex()
        {
            return $"Die {FieldName} formaat is ongeldig.";
        }
public string Required()
        {
            return $"Die {FieldName} veld is verpligtend.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Die {FieldName} veld is verpligtend wanneer {name} {value} is.";
        }
public string Same(string name)
        {
            return $"Die {FieldName} en {name} moet ooreenstem.";
        }
public string SizeArray(long size)
        {
            return $"Die {FieldName} moet {size} items bevat.";
        }
public string SizeString(int size)
        {
            return $"Die {FieldName} moet{size} karakters wees.";
        }
public string StartsWith(List<string> values)
        {
            return $"Die {FieldName} moet met een van die volgende begin: {String.Join(", ", values)}.";
        }
public string Uppercase()
        {
            return $"Die {FieldName} moet hoofletters wees.";
        }
public string Url()
        {
            return $"Die {FieldName} formaat is ongeldig.";
        }
    }
        }