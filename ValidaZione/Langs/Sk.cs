using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Sk : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} musí byť akceptovaný.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} má neplatnú URL adresu.";
        }
public string After(string date)
        {
            return $"{FieldName} musí byť dátum po {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} musí byť dátum po alebo presne {date}.";
        }
public string Alpha()
        {
            return $"{FieldName} môže obsahovať len písmená.";
        }
public string AlphaDash()
        {
            return $"{FieldName} môže obsahovať len písmená, čísla a pomlčky.";
        }
public string AlphaNum()
        {
            return $"{FieldName} môže obsahovať len písmená, čísla.";
        }
public string Before(string date)
        {
            return $"{FieldName} musí byť dátum pred {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} musí byť dátum pred alebo presne {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} musí mať rozsah {min} - {max} prvkov.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} musí mať rozsah {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} musí mať rozsah {min} - {max} znakov.";
        }
public string Boolean()
        {
            return $"{FieldName} musí byť pravda alebo nepravda.";
        }
public string Confirmed()
        {
            return $"{FieldName} konfirmácia sa nezhoduje.";
        }
public string Declined()
        {
            return $"{FieldName} musí byť zamietnuté.";
        }
public string Different(string name)
        {
            return $"{FieldName} a {name} musia byť odlišné.";
        }
public string Distinct()
        {
            return $"{FieldName} je duplicitný.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} nemusí končiť jedným z nasledujúcich: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"Číslo {FieldName} nemusí začínať jednou z nasledujúcich možností: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} má neplatný formát.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} musí obsahovať jednú z týchto hodnôt: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} musí mať viac prvkov ako {value}.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} musí mať viac znakov ako {value}.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} musí mať rovnaký alebo väčší počet prvkov ako {value}.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} musí mať rovnaký alebo väčší počet znakov ako {value}.";
        }
public string In()
        {
            return $"označený {FieldName} je neplatný.";
        }
public string Integer()
        {
            return $"{FieldName} musí byť celé číslo.";
        }
public string Ip()
        {
            return $"{FieldName} musí byť platná IP adresa.";
        }
public string Ipv4()
        {
            return $"{FieldName} musí byť platná IPv4 adresa.";
        }
public string Ipv6()
        {
            return $"{FieldName} musí byť platná IPv6 adresa.";
        }
public string Json()
        {
            return $"{FieldName} musí byť platný JSON reťazec.";
        }
public string Lowercase()
        {
            return $"Číslo {FieldName} musí byť malé.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} musí mať menej prvkov ako {value}.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} musí mať menej znakov ako {value}.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} musí mať rovnaký alebo menší počet prvkov ako {value}.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} musí mať rovnaký alebo menší počet znakov ako {value}.";
        }
public string MacAddress()
        {
            return $"{FieldName} musí byť platná adresa MAC.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} nemôže mať viac ako {max} prvkov.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} nemôže byť väčší ako {max}.";
        }
public string MaxString(int max)
        {
            return $"{FieldName} nemôže byť väčší ako {max} znakov.";
        }
public string MinArray(long min)
        {
            return $"{FieldName} musí mať aspoň {min} prvkov.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} musí mať aspoň {min}.";
        }
public string MinString(int min)
        {
            return $"{FieldName} musí mať aspoň {min} znakov.";
        }
public string NotIn()
        {
            return $"označený {FieldName} je neplatný.";
        }
public string NotRegex()
        {
            return $"{FieldName} má neplatný formát.";
        }
public string Numeric()
        {
            return $"{FieldName} musí byť číslo.";
        }
public string Regex()
        {
            return $"{FieldName} má neplatný formát.";
        }
public string Required()
        {
            return $"{FieldName} je požadované.";
        }
public string RequiredIf(string name, string value)
        {
            return $"{FieldName} je požadované keď {name} je {value}.";
        }
public string Same(string name)
        {
            return $"{FieldName} a {name} sa musia zhodovať.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} musí obsahovať {size} prvkov.";
        }
public string SizeString(int size)
        {
            return $"{FieldName} musí mať {size} znakov.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} musí začínať niektorou z hodnôt: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"Číslo {FieldName} musí byť veľké.";
        }
public string Url()
        {
            return $"{FieldName} musí mať formát URL.";
        }
    }
        }