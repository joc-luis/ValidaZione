using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Nb : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} må aksepteres.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} er ikke en gyldig URL.";
        }
public string After(string date)
        {
            return $"{FieldName} må være en dato etter {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} må være en dato etter eller lik {date}.";
        }
public string Alpha()
        {
            return $"{FieldName} må kun bestå av bokstaver.";
        }
public string AlphaDash()
        {
            return $"{FieldName} må kun bestå av bokstaver, tall og bindestreker.";
        }
public string AlphaNum()
        {
            return $"{FieldName} må kun bestå av bokstaver og tall.";
        }
public string Before(string date)
        {
            return $"{FieldName} må være en dato før {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} må være en dato før eller lik {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} må ha mellom {min} - {max} elementer.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} må være mellom {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} må være mellom {min} - {max} tegn.";
        }
public string Boolean()
        {
            return $"{FieldName} må være sann eller usann";
        }
public string Confirmed()
        {
            return $"{FieldName} er ikke likt bekreftelsesfeltet.";
        }
public string Declined()
        {
            return $"{FieldName} må avvises.";
        }
public string Different(string name)
        {
            return $"{FieldName} og {name} må være forskellige.";
        }
public string Distinct()
        {
            return $"{FieldName} har en duplisert verdi.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"De {FieldName} slutter kanskje ikke med ett av følgende: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"De {FieldName} starter kanskje ikke med ett av følgende: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} må være en gyldig e-postadresse.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} må ende med en av følgende: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} må ha flere enn {value} elementer.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} må være større enn {value} tegn.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} må ha {value} elementer eller flere.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} må være større enn eller lik {value} tegn.";
        }
public string In()
        {
            return $"Det valgte {FieldName} er ugyldig.";
        }
public string Integer()
        {
            return $"{FieldName} må være et heltall.";
        }
public string Ip()
        {
            return $"{FieldName} må være en gyldig IP-adresse.";
        }
public string Ipv4()
        {
            return $"{FieldName} må være en gyldig IPv4-adresse.";
        }
public string Ipv6()
        {
            return $"{FieldName} må være en gyldig IPv6-addresse.";
        }
public string Json()
        {
            return $"{FieldName} må være på JSON-format.";
        }
public string Lowercase()
        {
            return $"{FieldName} må være små bokstaver.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} må ha færre enn {value} elementer.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} må være kortere enn {value} tegn.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} må ikke ha flere enn {value} elementer.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} må være kortere enn eller lik {value} tegn.";
        }
public string MacAddress()
        {
            return $"{FieldName} må være en gyldig MAC-adresse.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} må ikke ha flere enn {max} elementer.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} må ikke være større enn {max}.";
        }
public string MaxString(int max)
        {
            return $"{FieldName} må ikke være større enn {max} tegn.";
        }
public string MinArray(long min)
        {
            return $"{FieldName} må ha minst {min} elementer.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} må være minst {min}.";
        }
public string MinString(int min)
        {
            return $"{FieldName} må være minst {min} tegn.";
        }
public string NotIn()
        {
            return $"Den valgte {FieldName} er ugyldig.";
        }
public string NotRegex()
        {
            return $"Formatet på {FieldName} er ugyldig.";
        }
public string Numeric()
        {
            return $"{FieldName} må være et tall.";
        }
public string Regex()
        {
            return $"Formatet på {FieldName} er ugyldig.";
        }
public string Required()
        {
            return $"{FieldName} må fylles ut.";
        }
public string RequiredIf(string name, string value)
        {
            return $"{FieldName} må fylles ut når {name} er {value}.";
        }
public string Same(string name)
        {
            return $"{FieldName} og {name} må være like.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} må inneholde {size} elementer.";
        }
public string SizeString(int size)
        {
            return $"{FieldName} må være {size} tegn lang.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} må starte med en av følgende: {String.Join(", ", values)}.";
        }
public string Uppercase()
        {
            return $"{FieldName} må være store bokstaver.";
        }
public string Url()
        {
            return $"Formatet på {FieldName} er ugyldig.";
        }
    }
        }