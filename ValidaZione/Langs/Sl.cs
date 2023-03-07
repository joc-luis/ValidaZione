using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Sl : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} mora biti sprejet.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} ni pravilen.";
        }
public string After(string date)
        {
            return $"{FieldName} mora biti za datumom {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} mora biti za ali enak {date}.";
        }
public string Alpha()
        {
            return $"{FieldName} lahko vsebuje samo črke.";
        }
public string AlphaDash()
        {
            return $"{FieldName} lahko vsebuje samo črke, številke in črtice.";
        }
public string AlphaNum()
        {
            return $"{FieldName} lahko vsebuje samo črke in številke.";
        }
public string Before(string date)
        {
            return $"{FieldName} mora biti pred datumom {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} mora biti pred ali enak {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} mora imeti med {min} in {max} elementov.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} mora biti med {min} in {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} mora biti med {min} in {max} znaki.";
        }
public string Boolean()
        {
            return $"{FieldName} polje mora biti 1 ali 0";
        }
public string Confirmed()
        {
            return $"{FieldName} potrditev se ne ujema.";
        }
public string Declined()
        {
            return $"{FieldName} je treba zavrniti.";
        }
public string Different(string name)
        {
            return $"{FieldName} in {name} mora biti drugačen.";
        }
public string Distinct()
        {
            return $"{FieldName} je duplikat.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} se ne sme končati z enim od naslednjih: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} se ne sme začeti z enim od naslednjih: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} mora biti veljaven e-poštni naslov.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} se mora končati z eno od naslednjih vrednosti: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} mora imeti več kot {value} elementov.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} mora imeti več kot {value} znakov.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} mora imeti število elementov enako ali večje od {value}.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} mora imeti število znakov večje ali enako {value}.";
        }
public string In()
        {
            return $"izbran {FieldName} je neveljaven.";
        }
public string Integer()
        {
            return $"{FieldName} mora biti število.";
        }
public string Ip()
        {
            return $"{FieldName} mora biti veljaven IP naslov.";
        }
public string Ipv4()
        {
            return $"{FieldName} mora biti veljaven IPv4 naslov.";
        }
public string Ipv6()
        {
            return $"{FieldName} mora biti veljaven IPv6 naslov.";
        }
public string Json()
        {
            return $"{FieldName} mora biti veljaven JSON tekst.";
        }
public string Lowercase()
        {
            return $"{FieldName} mora biti z malimi črkami.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} mora imeti manj kot {value} elementov.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} mora imeti manj kot {value} znakov.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} mora imeti število elementov manjše ali enako {value}.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} mora imeti število znakov manjše ali enako {value}.";
        }
public string MacAddress()
        {
            return $"{FieldName} mora biti veljaven naslov MAC.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} ne smejo imeti več kot {max} elementov.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} ne sme biti večje od {max}.";
        }
public string MaxString(int max)
        {
            return $"{FieldName} ne sme biti večje {max} znakov.";
        }
public string MinArray(long min)
        {
            return $"{FieldName} mora imeti vsaj {min} elementov.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} mora biti vsaj dolžine {min}.";
        }
public string MinString(int min)
        {
            return $"{FieldName} mora imeti vsaj {min} znakov.";
        }
public string NotIn()
        {
            return $"Izbran {FieldName} je neveljaven.";
        }
public string NotRegex()
        {
            return $"Format {FieldName} je neveljaven.";
        }
public string Numeric()
        {
            return $"{FieldName} mora biti število.";
        }
public string Regex()
        {
            return $"Format polja {FieldName} je neveljaven.";
        }
public string Required()
        {
            return $"Polje {FieldName} je obvezno.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Polje {FieldName} je obvezno, če je {name} enak {value}.";
        }
public string Same(string name)
        {
            return $"Polje {FieldName} in {name} se morata ujemati.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} mora vsebovati {size} elementov.";
        }
public string SizeString(int size)
        {
            return $"{FieldName} mora biti {size} znakov.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} se mora začeti z eno od naslednjih vrednosti: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"{FieldName} mora biti z velikimi črkami.";
        }
public string Url()
        {
            return $"{FieldName} format je neveljaven.";
        }
    }
        }