using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Tg : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Қиммати {FieldName} бояд қабул карда шавад.";
            }
public string ActiveUrl()
        {
            return $"Қиммати {FieldName} дорои URL-и нодуруст мебошад.";
        }
public string After(string date)
        {
            return $"Қиммати {FieldName} бояд санаи баъд аз {date} бошад.";
        }
public string AfterOrEqual(string date)
        {
            return $"Қиммати {FieldName} бояд санаи баъд ё баробари {date} бошад.";
        }
public string Alpha()
        {
            return $"Қиммати {FieldName} метавонад танҳо дорои ҳарфҳои алифо бошад.";
        }
public string AlphaDash()
        {
            return $"Қиммати {FieldName} метавонад танҳо дорои ҳарфҳои алифо, ададҳо ва хати тире бошад.";
        }
public string AlphaNum()
        {
            return $"Қиммати {FieldName} метавонад танҳо дорои ҳарфҳои алифо ва ададҳо бошад";
        }
public string Before(string date)
        {
            return $"Қиммати {FieldName} бояд санаи қабл аз {date} бошад.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Қиммати {FieldName} бояд санаи қабл ё баробари {date} бошад.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Миқдори элементҳо дар {FieldName} бояд байни {min} ва {max} бошад.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Қиммати {FieldName} бояд байни {min} ва {max} бошад.";
        }
public string BetweenString(int min, int max)
        {
            return $"Миқдори аломатҳо дар {FieldName} бояд байни {min} ва {max} бошад.";
        }
public string Boolean()
        {
            return $"Қиммати {FieldName} бояд логикӣ дошта бошад.";
        }
public string Confirmed()
        {
            return $"Қиммати {FieldName} бо қиммати тасдиқотӣ мувофиқат надорад.";
        }
public string Declined()
        {
            return $"{FieldName} бояд рад карда шавад.";
        }
public string Different(string name)
        {
            return $"Қимматҳои {FieldName} ва {name} бояд аз ҳам фарқ кунанд.";
        }
public string Distinct()
        {
            return $"{FieldName} дорои қиммати такроршаванда мебошад.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} метавонад бо яке аз зерин хотима наёбад: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} метавонад бо яке аз инҳо оғоз нашавад: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Қиммати {FieldName} бояд суроғаи электронии дуруст бошад.";
        }
public string EndsWith(List<string> values)
        {
            return $"Рақами {FieldName} бояд заканчиваться яке аз зерин: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} бояд зиёда аз {value} адад дошта бошад.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} бояд аз {value} аломат зиёд бошад.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} бояд {value} адад ё бештар дошта бошад.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} бояд аз {value} аломат зиёд ё баробар бошад.";
        }
public string In()
        {
            return $"Қиммати интихобкардаи {FieldName} нодуруст мебошад.";
        }
public string Integer()
        {
            return $"Қиммати {FieldName} бояд адади бутун бошад.";
        }
public string Ip()
        {
            return $"Қиммати {FieldName} бояд суроғаи дурусти IP бошад.";
        }
public string Ipv4()
        {
            return $"{FieldName} бояд дархост эътибор дорад IPv4-суроғаи.";
        }
public string Ipv6()
        {
            return $"{FieldName} бояд дархост эътибор дорад IPv6-суроғаи.";
        }
public string Json()
        {
            return $"Қиммати {FieldName} бояд сатри дурусти JSON бошад.";
        }
public string Lowercase()
        {
            return $"{FieldName} бояд хурд бошад.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} бояд камтар аз {value} адад дошта бошад.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} бояд камтар аз {value} аломат бошад.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} набояд аз {value} адад зиёд бошад.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} бояд камтар аз {value} аломат бошад.";
        }
public string MacAddress()
        {
            return $"{FieldName} бояд суроғаи дурусти MAC бошад.";
        }
public string MaxArray(long max)
        {
            return $"Миқдори элементҳо дар {FieldName} бояд на зиёда аз {max} бошад.";
        }
public string MaxNumeric(string max)
        {
            return $"Қиммати {FieldName} набояд аз {max} зиёд бошад.";
        }
public string MaxString(int max)
        {
            return $"Миқдори аломатҳо дар {FieldName} бояд на зиёда аз {max} бошад.";
        }
public string MinArray(long min)
        {
            return $"Миқдори элементҳо дар {FieldName} бояд на кам аз {min} бошад.";
        }
public string MinNumeric(string min)
        {
            return $"Қиммати {FieldName} набояд аз {min} хурд бошад.";
        }
public string MinString(int min)
        {
            return $"Миқдори аломатҳо дар {FieldName} бояд на кам аз {min} бошад.";
        }
public string NotIn()
        {
            return $"Қиммати интихобкардаи {FieldName} нодуруст мебошад.";
        }
public string NotRegex()
        {
            return $"Формати {FieldName} недопустим.";
        }
public string Numeric()
        {
            return $"Қиммати {FieldName} бояд адад бошад.";
        }
public string Regex()
        {
            return $"Формати {FieldName} нодуруст мебошад.";
        }
public string Required()
        {
            return $"{FieldName} бояд дорои қиммат бошад.";
        }
public string RequiredIf(string name, string value)
        {
            return $"{FieldName} бояд дорои қиммат бошад агар {name} ба {value} баробар бошад.";
        }
public string Same(string name)
        {
            return $"Қиммати {FieldName} ва {name} бояд баробар бошанд.";
        }
public string SizeArray(long size)
        {
            return $"Миқдори элементҳо дар {FieldName} бояд {size} бошад.";
        }
public string SizeString(int size)
        {
            return $"Миқдори аломатҳо дар {FieldName} бояд {size} бошад.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} бояд оғоз бо яке аз арзишҳои зерин: {String.Join(", ", values)}.";
        }
public string Uppercase()
        {
            return $"{FieldName} бояд ҳарфи калон бошад.";
        }
public string Url()
        {
            return $"Формати {FieldName} нодуруст мебошад.";
        }
    }
        }