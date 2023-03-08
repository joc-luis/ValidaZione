using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Kk : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} қабылдануы керек.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} жарамды URL мекенжайы емес.";
        }
public string After(string date)
        {
            return $"{FieldName} мәні {date} күнінен кейінгі күн болуы керек.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} мәні {date} күнінен кейінгі күн немесе тең болуы керек.";
        }
public string Alpha()
        {
            return $"{FieldName} тек әріптерден тұруы керек.";
        }
public string AlphaDash()
        {
            return $"{FieldName} тек әріптерден, сандардан және сызықшалардан тұруы керек.";
        }
public string AlphaNum()
        {
            return $"{FieldName} тек әріптерден және сандардан тұруы керек.";
        }
public string Before(string date)
        {
            return $"{FieldName} мәні {date} күнінен дейінгі күн болуы керек.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} мәні {date} күнінен дейінгі күн немесе тең болуы керек.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} жиымы {min} және {max} аралығындағы элементтерден тұруы керек.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} мәні {min} және {max} аралығында болуы керек.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} тармағы {min} және {max} аралығындағы таңбалардан тұруы керек.";
        }
public string Boolean()
        {
            return $"{FieldName} жолы шын немесе жалған мән болуы керек.";
        }
public string Confirmed()
        {
            return $"{FieldName} растауы сәйкес емес.";
        }
public string Declined()
        {
            return $"{FieldName}-ден бас тарту керек.";
        }
public string Different(string name)
        {
            return $"{FieldName} және {name} әр түрлі болуы керек.";
        }
public string Distinct()
        {
            return $"{FieldName} жолында қосарланған мән бар.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} келесілердің бірімен аяқталмауы мүмкін: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} келесілердің бірінен басталмауы мүмкін: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} жарамды электрондық пошта мекенжайы болуы керек.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} келесі мәндердің біреуінен аяқталуы керек: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} мәні {value} элементтерден үлкен болуы керек.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} мәні {value} таңбалардан үлкен болуы керек.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} мәні {value} элементтерден үлкен немесе тең болуы керек.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} мәні {value} таңбалардан үлкен немесе тең болуы керек.";
        }
public string In()
        {
            return $"таңдалған {FieldName} жарамсыз.";
        }
public string Integer()
        {
            return $"{FieldName} бүтін сан болуы керек.";
        }
public string Ip()
        {
            return $"{FieldName} жарамды IP мекенжайы болуы керек.";
        }
public string Ipv4()
        {
            return $"{FieldName} жарамды IPv4 мекенжайы болуы керек.";
        }
public string Ipv6()
        {
            return $"{FieldName} жарамды IPv6 мекенжайы болуы керек.";
        }
public string Json()
        {
            return $"{FieldName} жарамды JSON тармағы болуы керек.";
        }
public string Lowercase()
        {
            return $"{FieldName} кіші әріп болуы керек.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} мәні {value} элементтерден кіші болуы керек.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} мәні {value} таңбалардан кіші болуы керек.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} мәні {value} элементтерден кіші немесе тең болуы керек.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} мәні {value} таңбалардан кіші немесе тең болуы керек.";
        }
public string MacAddress()
        {
            return $"{FieldName} жарамды MAC мекенжайы болуы керек.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} жиымының құрамы {max} элементтен аспауы керек.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} мәні {max} мәнінен көп болмауы керек.";
        }
public string MaxString(int max)
        {
            return $"{FieldName} тармағы {max} таңбадан ұзын болмауы керек.";
        }
public string MinArray(long min)
        {
            return $"{FieldName} кемінде {min} элементтен тұруы керек.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} кемінде {min} болуы керек.";
        }
public string MinString(int min)
        {
            return $"{FieldName} кемінде {min} таңбадан тұруы керек.";
        }
public string NotIn()
        {
            return $"таңдалған {FieldName} жарамсыз.";
        }
public string NotRegex()
        {
            return $"таңдалған {FieldName} форматы жарамсыз.";
        }
public string Numeric()
        {
            return $"{FieldName} сан болуы керек.";
        }
public string Regex()
        {
            return $"{FieldName} пішімі жарамсыз.";
        }
public string Required()
        {
            return $"{FieldName} жолы толтырылуы керек.";
        }
public string RequiredIf(string name, string value)
        {
            return $"{FieldName} жолы {name} мәні {value} болған кезде толтырылуы керек.";
        }
public string Same(string name)
        {
            return $"{FieldName} және {name} сәйкес болуы керек.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} жиымы {size} элементтен тұруы керек.";
        }
public string SizeString(int size)
        {
            return $"{FieldName} тармағы {size} таңбадан тұруы керек.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} келесі мәндердің біреуінен басталуы керек: {String.Join(", ", values)}";
        }
public string Unique()
                {
                    return $"{FieldName} бұрын алынған.";
                }
public string Uppercase()
        {
            return $"{FieldName} бас әріп болуы керек.";
        }
public string Url()
        {
            return $"{FieldName} пішімі жарамсыз.";
        }
    }
        }