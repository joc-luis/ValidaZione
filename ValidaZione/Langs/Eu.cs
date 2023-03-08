using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Eu : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} onartu beharra dago.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} ez da baliozko URL bat.";
        }
public string After(string date)
        {
            return $"{FieldName} {date} osteko data izan behar da.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} {date} osteko data edo data bera izan behar da.";
        }
public string Alpha()
        {
            return $"{FieldName} hizkiak besterik ezin ditu izan.";
        }
public string AlphaDash()
        {
            return $"{FieldName} hizkiak, zenbakiak eta marrak besterik ezin ditu izan.";
        }
public string AlphaNum()
        {
            return $"{FieldName} hizkiak eta zenbakiak besterik ezin ditu izan.";
        }
public string Before(string date)
        {
            return $"{FieldName} {date} aurreko data izan behar da.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} {date} aurreko data edo data bera izan behar da.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName}-(e)k {min} eta {max} arteko elementu kopurua izan behar du.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} {min} eta {max} artean egon behar da.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName}-(e)k {min} eta {max} karaktere artean izan behar ditu.";
        }
public string Boolean()
        {
            return $"{FieldName}-(r)en balioa egia edo gezurra izan behar da.";
        }
public string Confirmed()
        {
            return $"{FieldName}-(r)en berrespena ez dator bat.";
        }
public string Declined()
        {
            return $"{FieldName}ak baztertu egin behar dira.";
        }
public string Different(string name)
        {
            return $"{FieldName} eta {name} ezberdinak izan behar dira.";
        }
public string Distinct()
        {
            return $"{FieldName}-(e)k bikoiztutako balioa dauka.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName}ekoa ezingo da honako hauetako batekin amaitu: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName}ekoa ezingo da honako hauetako batekin hasi: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} baliozko helbide elektronikoa izan behar da.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName}-(e)k ondorengo balioetako batekin amaitu behar du: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName}-(e)k {value} elementu baino gehiago izan behar ditu.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName}-(e)k {value} karaktere baino gehiago izan behar ditu.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName}-(e)k {value} elementu edo gehiago izan behar ditu.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName}-(e)k {value} karaktere edo gehiago izan behar ditu.";
        }
public string In()
        {
            return $"{FieldName} baliogabea da.";
        }
public string Integer()
        {
            return $"{FieldName} zenbaki osoa izan behar da.";
        }
public string Ip()
        {
            return $"{FieldName} baliozko IP helbidea izan behar da.";
        }
public string Ipv4()
        {
            return $"{FieldName} baliozko IPv4 helbidea izan behar da.";
        }
public string Ipv6()
        {
            return $"{FieldName} baliozko IPv6 helbidea izan behar da.";
        }
public string Json()
        {
            return $"{FieldName} baliozko JSON karaktere-katea izan behar da.";
        }
public string Lowercase()
        {
            return $"{FieldName}ak minuskula izan behar du.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName}-(e)k {value} elementu baino gutxiago izan behar ditu.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName}-(e)k {value} karaktere baino gutxiago izan behar ditu.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName}-(e)k {value} elementu edo gutxiago izan behar ditu.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName}-(e)k {value} karaktere edo gutxiago izan behar ditu.";
        }
public string MacAddress()
        {
            return $"{FieldName}ak baliozko MAC helbidea izan behar du.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName}-(e)k ezin du {max} elementu baino gehiago eduki.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} ezin da {max} baino handiagoa izan.";
        }
public string MaxString(int max)
        {
            return $"{FieldName}-(e)k ezin du {max} karaktere baino gehiago eduki.";
        }
public string MinArray(long min)
        {
            return $"{FieldName}-(e)k gutxienez {min} elementu izan behar ditu.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName}-(e)k gutxienez {min}-(e)ko tamaina izan behar du.";
        }
public string MinString(int min)
        {
            return $"{FieldName}-(e)k gutxienez {min} karaktere izan behar ditu.";
        }
public string NotIn()
        {
            return $"{FieldName} baliogabea da.";
        }
public string NotRegex()
        {
            return $"{FieldName} formatua baliogabea da.";
        }
public string Numeric()
        {
            return $"{FieldName} zenbakizkoa izan behar da.";
        }
public string Regex()
        {
            return $"{FieldName} baliogabea da.";
        }
public string Required()
        {
            return $"{FieldName} derrigorrezkoa da.";
        }
public string RequiredIf(string name, string value)
        {
            return $"{FieldName} derrigorrezkoa da {name} {value} denean.";
        }
public string Same(string name)
        {
            return $"{FieldName} eta {name} bat etorri behar dira.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName}-(e)k {size} elementu izan behar ditu.";
        }
public string SizeString(int size)
        {
            return $"{FieldName}-(e)k {size} karaktere izan behar ditu.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName}-(e)k ondorengo balioetako batekin hasi behar du {String.Join(", ", values)}";
        }
public string Unique()
                {
                    return $"{FieldName} jadanik erregistratua izan da.";
                }
public string Uppercase()
        {
            return $"{FieldName}ak maiuskulak izan behar ditu.";
        }
public string Url()
        {
            return $"{FieldName}-(r)en formatua baliogabea da.";
        }
    }
        }