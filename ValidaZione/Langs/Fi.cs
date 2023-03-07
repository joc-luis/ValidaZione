using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Fi : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Kenttä {FieldName} tulee hyväksyä.";
            }
public string ActiveUrl()
        {
            return $"Kentän {FieldName} tulee olla kelvollinen URL-osoite.";
        }
public string After(string date)
        {
            return $"Kentän {FieldName} päiväyksen tulee olla jälkeen {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Kentän {FieldName} päiväyksen tulee olla sama ja jälkeen {date}";
        }
public string Alpha()
        {
            return $"Kenttä {FieldName} voi sisältää vain kirjaimia.";
        }
public string AlphaDash()
        {
            return $"Kenttä {FieldName} voi sisältää vain kirjaimia, numeroita ja viivoja.";
        }
public string AlphaNum()
        {
            return $"Kenttä {FieldName} voi sisältää vain kirjaimia ja numeroita.";
        }
public string Before(string date)
        {
            return $"Kentän {FieldName} päiväyksen tulee olla ennen {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Kentän {FieldName} päiväyksen tulee olla sama tai ennen kuin {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Kentän {FieldName} tulee sisältää välillä {min} - {max} arvoa.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Kentän {FieldName} tulee olla välillä {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Kentän {FieldName} tulee olla {min} - {max} merkkiä pitkä.";
        }
public string Boolean()
        {
            return $"Kentän {FieldName} arvon tulee olla tosi tai epätosi.";
        }
public string Confirmed()
        {
            return $"Kentän {FieldName} vahvistus ei täsmää.";
        }
public string Declined()
        {
            return $"{FieldName} on hylättävä.";
        }
public string Different(string name)
        {
            return $"Kenttien {FieldName} ja {name} tulee olla eriarvoisia.";
        }
public string Distinct()
        {
            return $"Kentän {FieldName} arvo ei ole uniikki.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} ei saa päättyä johonkin seuraavista: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} ei voi alkaa jollakin seuraavista: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Kentän {FieldName} arvo ei ole validi sähköpostiosoite.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName}:n on päätyttävä johonkin seuraavista: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"Kentän {FieldName} tulee sisältää enemmän kuin {value} arvoa.";
        }
public string GreaterThanString(int value)
        {
            return $"Kentän {FieldName} arvo tulee olla pidempi kuin {value} merkkiä.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Kentän {FieldName} tulee sisältää {value} arvoa tai enemmän.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Kentän {FieldName} arvo tulee olla pidempi tai yhtä pitkä kuin {value} merkkiä.";
        }
public string In()
        {
            return $"Kentän {FieldName} arvo on virheellinen.";
        }
public string Integer()
        {
            return $"Kentän {FieldName} arvon tulee olla numero.";
        }
public string Ip()
        {
            return $"Kentän {FieldName} arvon tulee olla validi IP-osoite.";
        }
public string Ipv4()
        {
            return $"Kentän {FieldName} arvon tulee olla validi IPv4-osoite.";
        }
public string Ipv6()
        {
            return $"Kentän {FieldName} arvon tulee olla validi IPv6-osoite.";
        }
public string Json()
        {
            return $"Kentän {FieldName} arvon tulee olla validia JSON:ia.";
        }
public string Lowercase()
        {
            return $"{FieldName} on oltava pieniä kirjaimia.";
        }
public string LessThanArray(long value)
        {
            return $"Kentän {FieldName} tulee sisältää vähemmän kuin {value} arvoa.";
        }
public string LessThanString(int value)
        {
            return $"Kentän {FieldName} arvo tulee olla lyhyempi kuin {value} merkkiä.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"Kentän {FieldName} tulee sisältää {value} arvoa tai vähemmän.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"Kentän {FieldName} arvo tulee olla lyhyempi tai yhtä pitkä kuin {value} merkkiä.";
        }
public string MacAddress()
        {
            return $"{FieldName}:n on oltava kelvollinen MAC-osoite.";
        }
public string MaxArray(long max)
        {
            return $"Kentän {FieldName} ei tule sisältää enempää kuin {max} arvoa.";
        }
public string MaxNumeric(string max)
        {
            return $"Kentän arvon {FieldName} tulee olla enintään {max}.";
        }
public string MaxString(int max)
        {
            return $"Kentän {FieldName} arvon tulee olla enintään {max} merkkiä pitkä.";
        }
public string MinArray(long min)
        {
            return $"Kentän {FieldName} tulee sisältää vähintään {min} arvoa.";
        }
public string MinNumeric(string min)
        {
            return $"Kentän {FieldName} arvon tulee olla vähintään {min}.";
        }
public string MinString(int min)
        {
            return $"Kentän {FieldName} arvon tulee olla vähintään {min} merkkiä.";
        }
public string NotIn()
        {
            return $"Kentän {FieldName} arvo on virheellinen.";
        }
public string NotRegex()
        {
            return $"Kentän {FieldName} formaatti on virheellinen.";
        }
public string Numeric()
        {
            return $"Kentän {FieldName} arvon tulee olla numero.";
        }
public string Regex()
        {
            return $"Kentän {FieldName} arvo on väärää muotoa.";
        }
public string Required()
        {
            return $"Kenttä {FieldName} vaaditaan.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Kenttä {FieldName} vaaditaan kun {name} on {value}.";
        }
public string Same(string name)
        {
            return $"Kenttien {FieldName} ja {name} on oltava samanarvoiset.";
        }
public string SizeArray(long size)
        {
            return $"Kentän {FieldName} tulee sisältää {size} arvoa.";
        }
public string SizeString(int size)
        {
            return $"Kentän {FieldName} arvon tulee olla kokoa {size} merkkiä.";
        }
public string StartsWith(List<string> values)
        {
            return $"Attribuutin {FieldName} tulee alkaa yhdellä seuraavista: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"{FieldName} on oltava isoilla kirjaimilla.";
        }
public string Url()
        {
            return $"Kentän {FieldName} arvon tulee olla validi URL-osoite.";
        }
    }
        }