using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Hu : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"A(z) {FieldName} el kell legyen fogadva!";
            }
public string ActiveUrl()
        {
            return $"A(z) {FieldName} nem érvényes url!";
        }
public string After(string date)
        {
            return $"A(z) {FieldName} {date} utáni dátum kell, hogy legyen!";
        }
public string AfterOrEqual(string date)
        {
            return $"A(z) {FieldName} nem lehet korábbi dátum, mint {date}!";
        }
public string Alpha()
        {
            return $"A(z) {FieldName} kizárólag betűket tartalmazhat!";
        }
public string AlphaDash()
        {
            return $"A(z) {FieldName} kizárólag betűket, számokat és kötőjeleket tartalmazhat!";
        }
public string AlphaNum()
        {
            return $"A(z) {FieldName} kizárólag betűket és számokat tartalmazhat!";
        }
public string Before(string date)
        {
            return $"A(z) {FieldName} {date} előtti dátum kell, hogy legyen!";
        }
public string BeforeOrEqual(string date)
        {
            return $"A(z) {FieldName} nem lehet későbbi dátum, mint {date}!";
        }
public string BetweenArray(long min, long max)
        {
            return $"A(z) {FieldName} {min} - {max} közötti elemet kell, hogy tartalmazzon!";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"A(z) {FieldName} {min} és {max} közötti szám kell, hogy legyen!";
        }
public string BetweenString(int min, int max)
        {
            return $"A(z) {FieldName} hossza {min} és {max} karakter között kell, hogy legyen!";
        }
public string Boolean()
        {
            return $"A(z) {FieldName} mező csak true vagy false értéket kaphat!";
        }
public string Confirmed()
        {
            return $"A(z) {FieldName} nem egyezik a megerősítéssel.";
        }
public string Declined()
        {
            return $"A {FieldName}-at el kell utasítani.";
        }
public string Different(string name)
        {
            return $"A(z) {FieldName} és {name} értékei különbözőek kell, hogy legyenek!";
        }
public string Distinct()
        {
            return $"A(z) {FieldName} értékének egyedinek kell lennie!";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"A {FieldName} nem végződhet a következők egyikével: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"A {FieldName} nem kezdődhet a következők egyikével: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"A(z) {FieldName} nem érvényes email formátum.";
        }
public string EndsWith(List<string> values)
        {
            return $"A(z) {FieldName} a következővel kell végződjön: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"A(z) {FieldName} több, mint {value} elemet kell, hogy tartalmazzon.";
        }
public string GreaterThanString(int value)
        {
            return $"A(z) {FieldName} hosszabb kell, hogy legyen, mint {value} karakter.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"A(z) {FieldName} legalább {value} elemet kell, hogy tartalmazzon.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"A(z) {FieldName} hossza nem lehet kevesebb, mint {value} karakter.";
        }
public string In()
        {
            return $"A kiválasztott {FieldName} érvénytelen.";
        }
public string Integer()
        {
            return $"A(z) {FieldName} értéke szám kell, hogy legyen!";
        }
public string Ip()
        {
            return $"A(z) {FieldName} érvényes IP cím kell, hogy legyen!";
        }
public string Ipv4()
        {
            return $"A(z) {FieldName} érvényes IPv4 cím kell, hogy legyen!";
        }
public string Ipv6()
        {
            return $"A(z) {FieldName} érvényes IPv6 cím kell, hogy legyen!";
        }
public string Json()
        {
            return $"A(z) {FieldName} érvényes JSON szöveg kell, hogy legyen!";
        }
public string Lowercase()
        {
            return $"A {FieldName}-nak kisbetűnek kell lennie.";
        }
public string LessThanArray(long value)
        {
            return $"A(z) {FieldName} kevesebb, mint {value} elemet kell, hogy tartalmazzon.";
        }
public string LessThanString(int value)
        {
            return $"A(z) {FieldName} rövidebb kell, hogy legyen, mint {value} karakter.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"A(z) {FieldName} legfeljebb {value} elemet kell, hogy tartalmazzon.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"A(z) {FieldName} hossza nem lehet több, mint {value} karakter.";
        }
public string MacAddress()
        {
            return $"A {FieldName}-nak érvényes MAC-címnek kell lennie.";
        }
public string MaxArray(long max)
        {
            return $"A(z) {FieldName} legfeljebb {max} elemet kell, hogy tartalmazzon.";
        }
public string MaxNumeric(string max)
        {
            return $"A(z) {FieldName} értéke nem lehet nagyobb, mint {max}!";
        }
public string MaxString(int max)
        {
            return $"A(z) {FieldName} hossza nem lehet több, mint {max} karakter.";
        }
public string MinArray(long min)
        {
            return $"A(z) {FieldName} legalább {min} elemet kell, hogy tartalmazzon.";
        }
public string MinNumeric(string min)
        {
            return $"A(z) {FieldName} értéke nem lehet kisebb, mint {min}!";
        }
public string MinString(int min)
        {
            return $"A(z) {FieldName} hossza nem lehet kevesebb, mint {min} karakter.";
        }
public string NotIn()
        {
            return $"A(z) {FieldName} értéke érvénytelen.";
        }
public string NotRegex()
        {
            return $"A(z) {FieldName} formátuma érvénytelen.";
        }
public string Numeric()
        {
            return $"A(z) {FieldName} szám kell, hogy legyen!";
        }
public string Regex()
        {
            return $"A(z) {FieldName} formátuma érvénytelen.";
        }
public string Required()
        {
            return $"A(z) {FieldName} megadása kötelező!";
        }
public string RequiredIf(string name, string value)
        {
            return $"A(z) {FieldName} megadása kötelező, ha a(z) {name} értéke {value}!";
        }
public string Same(string name)
        {
            return $"A(z) {FieldName} és {name} mezőknek egyezniük kell!";
        }
public string SizeArray(long size)
        {
            return $"A(z) {FieldName} {size} elemet kell tartalmazzon!";
        }
public string SizeString(int size)
        {
            return $"A(z) {FieldName} hossza {size} karakter kell, hogy legyen!";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} a következővel kell kezdődjön: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"A {FieldName}-nak nagybetűnek kell lennie.";
        }
public string Url()
        {
            return $"A(z) {FieldName} érvénytelen link.";
        }
    }
        }