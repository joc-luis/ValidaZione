using System;
using System.Collections.Generic;

namespace ValidaZione.Interfaces
{
    public interface ILang
    {
        string FieldName { get; set; }
        string Accepted();
        string ActiveUrl();
        string After(String date);
        string AfterOrEqual(String date);
        string Alpha();
        string AlphaDash();
        string AlphaNum();
        string Before(String date);
        string BeforeOrEqual(String date);
        string BetweenNumeric(String min, String max);
        string BetweenString(int min, int max);
        string BetweenArray(long min, long max);
        string Boolean();
        string Confirmed();
        string Declined();
        string Different(string name);
        string Distinct();
        string Email();
        string EndsWith(List<String> values);
        string GreaterThanArray(long value);
        string GreaterThanString(int value);
        string GreaterThanOrEqualArray(long value);
        string GreaterThanOrEqualString(int value);
        string In();
        string Integer();
        string Ip();
        string Ipv4();
        string Ipv6();
        string Json();
        string Lowercase();
        string LessThanArray(long value);
        string LessThanString(int value);
        string LessThanOrEqualArray(long value);
        string LessThanOrEqualString(int value);
        string MacAddress();
        string MaxArray(long max);
        string MaxNumeric(string max);
        string MaxString(int max);
        string MinArray(long  min);
        string MinNumeric(string min);
        string MinString(int min);
        string NotIn();
        string NotRegex();
        string Numeric();
        string Regex();
        string Required();
        string Same(string name);
        string SizeArray(long size);
        string SizeString(int size);
        string StartsWith(List<String> values);
        string Uppercase();
        string Url();

    }
}