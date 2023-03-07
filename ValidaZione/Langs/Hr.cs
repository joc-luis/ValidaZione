using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Hr : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Polje {FieldName} mora biti prihvaćeno.";
            }
public string ActiveUrl()
        {
            return $"Polje {FieldName} nije ispravan URL.";
        }
public string After(string date)
        {
            return $"Polje {FieldName} mora biti datum nakon {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Polje {FieldName} mora biti datum veći ili jednak {date}.";
        }
public string Alpha()
        {
            return $"Polje {FieldName} smije sadržavati samo slova.";
        }
public string AlphaDash()
        {
            return $"Polje {FieldName} smije sadržavati samo slova, brojeve i crtice.";
        }
public string AlphaNum()
        {
            return $"Polje {FieldName} smije sadržavati samo slova i brojeve.";
        }
public string Before(string date)
        {
            return $"Polje {FieldName} mora biti datum prije {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Polje {FieldName} mora biti datum manji ili jednak {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Polje {FieldName} mora imati između {min} - {max} stavki.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Polje {FieldName} mora biti između {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Polje {FieldName} mora biti između {min} - {max} znakova.";
        }
public string Boolean()
        {
            return $"Polje {FieldName} mora biti false ili true.";
        }
public string Confirmed()
        {
            return $"Potvrda polja {FieldName} se ne podudara.";
        }
public string Declined()
        {
            return $"Polje {FieldName} mora biti odbijeno.";
        }
public string Different(string name)
        {
            return $"Polja {FieldName} i {name} moraju biti različita.";
        }
public string Distinct()
        {
            return $"Polje {FieldName} ima dupliciranu vrijednost.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"Polje {FieldName} ne smije završavati s jednom od sljedećih vrijednosti: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"Polje {FieldName} ne smije počinjati s jednom od sljedećih vrijednosti: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Polje {FieldName} mora biti ispravna e-mail adresa.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} bi trebao završiti s jednim od sljedećih: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"Polje {FieldName} mora biti veće od {value} stavki.";
        }
public string GreaterThanString(int value)
        {
            return $"Polje {FieldName} mora biti veće od {value} karaktera.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Polje {FieldName} mora imati najmanje {value} stavki.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Polje {FieldName} mora biti veće ili jednako {value} znakova.";
        }
public string In()
        {
            return $"Odabrano polje {FieldName} nije ispravno.";
        }
public string Integer()
        {
            return $"Polje {FieldName} mora biti broj.";
        }
public string Ip()
        {
            return $"Polje {FieldName} mora biti ispravna IP adresa.";
        }
public string Ipv4()
        {
            return $"Polje {FieldName} mora biti ispravna IPv4 adresa.";
        }
public string Ipv6()
        {
            return $"Polje {FieldName} mora biti ispravna IPv6 adresa.";
        }
public string Json()
        {
            return $"Polje {FieldName} mora biti ispravan JSON string.";
        }
public string Lowercase()
        {
            return $"Polje {FieldName} mora sadržavati samo mala slova.";
        }
public string LessThanArray(long value)
        {
            return $"Polje {FieldName} mora biti manje od {value} stavki.";
        }
public string LessThanString(int value)
        {
            return $"Polje {FieldName} mora biti manje od {value} znakova.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"Polje {FieldName} ne smije imati više od {value} stavki.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"Polje {FieldName} mora biti manje ili jednako {value} znakova.";
        }
public string MacAddress()
        {
            return $"Polje {FieldName} mora biti ispravna MAC adresa.";
        }
public string MaxArray(long max)
        {
            return $"Polje {FieldName} ne smije imati više od {max} stavki.";
        }
public string MaxNumeric(string max)
        {
            return $"Polje {FieldName} mora biti manje od {max}.";
        }
public string MaxString(int max)
        {
            return $"Polje {FieldName} mora sadržavati manje od {max} znakova.";
        }
public string MinArray(long min)
        {
            return $"Polje {FieldName} mora sadržavati najmanje {min} stavki.";
        }
public string MinNumeric(string min)
        {
            return $"Polje {FieldName} mora biti najmanje {min}.";
        }
public string MinString(int min)
        {
            return $"Polje {FieldName} mora sadržavati najmanje {min} znakova.";
        }
public string NotIn()
        {
            return $"Odabrano polje {FieldName} nije ispravno.";
        }
public string NotRegex()
        {
            return $"Format polja {FieldName} je neispravan.";
        }
public string Numeric()
        {
            return $"Polje {FieldName} mora biti broj.";
        }
public string Regex()
        {
            return $"Polje {FieldName} se ne podudara s formatom.";
        }
public string Required()
        {
            return $"Polje {FieldName} je obavezno.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Polje {FieldName} je obavezno kada polje {name} sadrži {value}.";
        }
public string Same(string name)
        {
            return $"Polja {FieldName} i {name} se moraju podudarati.";
        }
public string SizeArray(long size)
        {
            return $"Polje {FieldName} mora sadržavati {size} stavki.";
        }
public string SizeString(int size)
        {
            return $"Polje {FieldName} mora biti {size} znakova.";
        }
public string StartsWith(List<string> values)
        {
            return $"Stavka {FieldName} mora započinjati jednom od narednih stavki: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"Polje {FieldName} mora sadržavati samo velika slova.";
        }
public string Url()
        {
            return $"Polje {FieldName} mora biti ispravan URL.";
        }
    }
        }