using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Uz_Cyrl : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} ни қабул қилишингиз керак.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} га нотўғри URL киритилди.";
        }
public string After(string date)
        {
            return $"{FieldName} да сана {date} дан кейин бўлиши керак.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} да сана {date} га тенг ёки ундан кейин бўлиши керак.";
        }
public string Alpha()
        {
            return $"{FieldName} фақат ҳарфларни қабул қилиши мумкин.";
        }
public string AlphaDash()
        {
            return $"{FieldName} фақат ҳарфлар, сонлар ва чизиқчаларни қабул қилиши мумкин.";
        }
public string AlphaNum()
        {
            return $"{FieldName} фақат ҳарфлар ва сонларни қабул қилиши мумкин.";
        }
public string Before(string date)
        {
            return $"{FieldName} да сана {date} гача бўлиши керак.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} да сана {date} га тенг ёки ундан олдин бўлиши керак.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} даги элементлар сони {min} ва {max} орасида бўлиши керак.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} нинг қиймати {min} ва {max} орасида бўлиши керак.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} даги белгилар сони {min} ва {max} орасида бўлиши керак.";
        }
public string Boolean()
        {
            return $"{FieldName} майдони фақат мантиқий қийматни қабул қилади.";
        }
public string Confirmed()
        {
            return $"{FieldName} тасдиқлангани билан мос келмади.";
        }
public string Declined()
        {
            return $"{FieldName} rad etilishi kerak.";
        }
public string Different(string name)
        {
            return $"{FieldName} ва {name} майдонлари фарқли бўлиши керак.";
        }
public string Distinct()
        {
            return $"{FieldName} майдони такрорланувчи қийматлардан иборат.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} soni quyidagilardan biri bilan tugamasligi mumkin: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} quyidagidan biri bilan boshlanmasligi mumkin: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} ҳақиқий электрон почта манзили бўлиши керак.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} қуйидаги қийматларнинг бири билан тугаши керак: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} даги элементлар сони {value} дан катта бўлиши керак.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} даги белгилар сони {value} дан катта бўлиши керак.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} даги элементлар сони {value} дан катта ёки тенг бўлиши керак.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} даги белгилар сони {value} дан катта ёки тенг бўлиши керак.";
        }
public string In()
        {
            return $"{FieldName} учун танланган қиймат хато.";
        }
public string Integer()
        {
            return $"{FieldName} бутун сон бўлиши керак.";
        }
public string Ip()
        {
            return $"{FieldName} ҳақиқий IP манзил бўлиши керак.";
        }
public string Ipv4()
        {
            return $"{FieldName} ҳақиқий IPv4 манзил бўлиши керак.";
        }
public string Ipv6()
        {
            return $"{FieldName} ҳақиқий IPv6 манзил бўлиши керак.";
        }
public string Json()
        {
            return $"{FieldName} JSON қатори бўлиши керак.";
        }
public string Lowercase()
        {
            return $"{FieldName} kichik harf bo'lishi kerak.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} даги элементлар сони {value} дан кичик бўлиши керак.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} даги белгилар сони {value} дан кичик бўлиши керак.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} даги элементлар сони {value} дан кичик ёки тенг бўлиши керак.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} даги белгилар сони {value} дан кичик ёки тенг бўлиши керак.";
        }
public string MacAddress()
        {
            return $"{FieldName} haqiqiy MAC manzili bo'lishi kerak.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} нинг элементлар сони {max} тадан ошмаслиги керак.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} нинг қиймати {max} дан ошмаслиги керак.";
        }
public string MaxString(int max)
        {
            return $"{FieldName} нинг белгилар сони {max} тадан ошмаслиги керак.";
        }
public string MinArray(long min)
        {
            return $"{FieldName} даги элементлар сони {min} тадан кам бўлмаслиги керак.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} нинг қиймати {min} дан кам бўлмаслиги керак.";
        }
public string MinString(int min)
        {
            return $"{FieldName} даги белгилар сони {min} тадан кам бўлмаслиги керак.";
        }
public string NotIn()
        {
            return $"{FieldName} учун танланган қиймат хато.";
        }
public string NotRegex()
        {
            return $"{FieldName} учун танланган формат хато.";
        }
public string Numeric()
        {
            return $"{FieldName} майдони сон бўлиши керак.";
        }
public string Regex()
        {
            return $"{FieldName} майдони хато форматда.";
        }
public string Required()
        {
            return $"{FieldName} майдони тўлдирилиши шарт.";
        }
public string RequiredIf(string name, string value)
        {
            return $":Other майдони {value} га тенг бўлса, {FieldName} майдони тўлдирилиши шарт.";
        }
public string Same(string name)
        {
            return $"{FieldName} нинг қиймати {name} билан бир хил бўлиши керак.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} даги элементлар сони {size} га тенг бўлиши керак.";
        }
public string SizeString(int size)
        {
            return $"{FieldName} даги белгилар сони {size} га тенг бўлиши керак.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} қуйидаги қийматлардан бири билан бошланиши керак: {String.Join(", ", values)}.";
        }
public string Uppercase()
        {
            return $"{FieldName} katta harf bo'lishi kerak.";
        }
public string Url()
        {
            return $"{FieldName} нотўғри форматга эга.";
        }
    }
        }