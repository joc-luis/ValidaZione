using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Bs : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Polje {FieldName} mora biti prihvaćeno.";
            }
public string ActiveUrl()
        {
            return $"Polje {FieldName} nije validan URL.";
        }
public string After(string date)
        {
            return $"Polje {FieldName} mora biti datum nakon {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Polje {FieldName} mora biti datum nakon ili jednak {date}.";
        }
public string Alpha()
        {
            return $"Polje {FieldName} može sadržati samo slova.";
        }
public string AlphaDash()
        {
            return $"Polje {FieldName} može sadržati samo slova, brojeve i povlake.";
        }
public string AlphaNum()
        {
            return $"Polje {FieldName} može sadržati samo slova i brojeve.";
        }
public string Before(string date)
        {
            return $"Polje {FieldName} mora biti datum prije {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Polje {FieldName} mora biti datum prije ili jednak {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Polje {FieldName} mora sadržati između {min} i {max} stavki.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Polje {FieldName} mora imati vrijednost između {min} i {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Polje {FieldName} mora sadržati između {min} i {max} znakova.";
        }
public string Boolean()
        {
            return $"Polje {FieldName} mora biti tačno ili netačno.";
        }
public string Confirmed()
        {
            return $"Potvrda polja {FieldName} se ne poklapa.";
        }
public string Declined()
        {
            return $"{FieldName} se mora odbiti.";
        }
public string Different(string name)
        {
            return $"Polja {FieldName} i {name} moraju biti različita.";
        }
public string Distinct()
        {
            return $"Polje {FieldName} ima dvostruku vrijednost.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} se ne može završiti s jednim od sljedećih: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} možda ne počinje s jednim od sljedećih: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Format polja {FieldName} mora biti validan e-mail.";
        }
public string EndsWith(List<string> values)
        {
            return $"Polje {FieldName} se mora završiti s jednom od sljedećih vrijednosti: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"Polje {FieldName} mora sadržati više od {value} stavki.";
        }
public string GreaterThanString(int value)
        {
            return $"Polje {FieldName} mora sadržati više od {value} znakova.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Polje {FieldName} mora sadržati {value} stavki ili više.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Polje {FieldName} mora sadržati {value} znakova ili više.";
        }
public string In()
        {
            return $"Odabrano polje {FieldName} nije validno.";
        }
public string Integer()
        {
            return $"Polje {FieldName} mora biti broj.";
        }
public string Ip()
        {
            return $"Polje {FieldName} mora biti validna IP adresa.";
        }
public string Ipv4()
        {
            return $"Polje {FieldName} mora biti validna IPv4 adresa.";
        }
public string Ipv6()
        {
            return $"Polje {FieldName} mora biti validna IPv6 adresa.";
        }
public string Json()
        {
            return $"Polje {FieldName} mora biti validan JSON string.";
        }
public string Lowercase()
        {
            return $"{FieldName} mora biti malim slovima.";
        }
public string LessThanArray(long value)
        {
            return $"Polje {FieldName} mora sadržati manje od {value} stavki.";
        }
public string LessThanString(int value)
        {
            return $"Polje {FieldName} mora sadržati manje od {value} znakova.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"Polje {FieldName} ne može sadržati više od {value} stavki.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"Polje {FieldName} ne može sadržati više od {value} znakova.";
        }
public string MacAddress()
        {
            return $"{FieldName} mora biti važeća MAC adresa.";
        }
public string MaxArray(long max)
        {
            return $"Polje {FieldName} mora sadržati manje od {max} stavki.";
        }
public string MaxNumeric(string max)
        {
            return $"Polje {FieldName} mora imati vrijednost manju od {max}.";
        }
public string MaxString(int max)
        {
            return $"Polje {FieldName} mora sadržati manje od {max} znakova.";
        }
public string MinArray(long min)
        {
            return $"Polje {FieldName} mora sadržati najmanje {min} stavki.";
        }
public string MinNumeric(string min)
        {
            return $"Polje {FieldName} mora biti najmanje {min}.";
        }
public string MinString(int min)
        {
            return $"Polje {FieldName} mora sadržati najmanje {min} znakova.";
        }
public string NotIn()
        {
            return $"Odabrani element polja {FieldName} nije validan.";
        }
public string NotRegex()
        {
            return $"Format polja {FieldName} nije ispravan.";
        }
public string Numeric()
        {
            return $"Polje {FieldName} mora biti broj.";
        }
public string Regex()
        {
            return $"Format polja {FieldName} nije ispravan.";
        }
public string Required()
        {
            return $"Polje {FieldName} je obavezno.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Polje {FieldName} je obavezno kada {name} ima vrijednost {value}.";
        }
public string Same(string name)
        {
            return $"Polja {FieldName} i {name} se moraju poklapati.";
        }
public string SizeArray(long size)
        {
            return $"Polje {FieldName} mora biti {size} znakova.";
        }
public string SizeString(int size)
        {
            return $"Polje {FieldName} mora biti {size} znakova.";
        }
public string StartsWith(List<string> values)
        {
            return $"Polje {FieldName} mora početi s jednom od sljedećih vrijednosti: {String.Join(", ", values)}.";
        }
public string Unique()
                {
                    return $"Polje {FieldName} već postoji.";
                }
public string Uppercase()
        {
            return $"{FieldName} mora biti velikim slovima.";
        }
public string Url()
        {
            return $"Format polja {FieldName} nije validan.";
        }
    }
        }