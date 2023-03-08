using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Tr : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} kabul edilmelidir.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} geçerli bir URL olmalıdır.";
        }
public string After(string date)
        {
            return $"{FieldName} mutlaka {date} tarihinden sonra olmalıdır.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} mutlaka {date} tarihinden sonra veya aynı tarihte olmalıdır.";
        }
public string Alpha()
        {
            return $"{FieldName} sadece harflerden oluşmalıdır.";
        }
public string AlphaDash()
        {
            return $"{FieldName} sadece harflerden, rakamlardan ve tirelerden oluşmalıdır.";
        }
public string AlphaNum()
        {
            return $"{FieldName} sadece harflerden ve rakamlardan oluşmalıdır.";
        }
public string Before(string date)
        {
            return $"{FieldName} mutlaka {date} tarihinden önce olmalıdır.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} mutlaka {date} tarihinden önce veya aynı tarihte olmalıdır.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} mutlaka {min} - {max} arasında öge içermelidir.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} mutlaka {min} - {max} arasında olmalıdır.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} mutlaka {min} - {max} karakter arasında olmalıdır.";
        }
public string Boolean()
        {
            return $"{FieldName} sadece doğru veya yanlış olmalıdır.";
        }
public string Confirmed()
        {
            return $"{FieldName} tekrarı eşleşmiyor.";
        }
public string Declined()
        {
            return $"{FieldName} kabul edilmemektedir.";
        }
public string Different(string name)
        {
            return $"{FieldName} ile {name} mutlaka birbirinden farklı olmalıdır.";
        }
public string Distinct()
        {
            return $"{FieldName} alanı yinelenen bir değere sahip.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} aşağıdakilerden biriyle bitemez: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} aşağıdakilerden biriyle başlamayabilir: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} mutlaka geçerli bir e-posta adresi olmalıdır.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} sadece şu değerlerden biriyle bitebilir: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} mutlaka {value} sayısından daha fazla öge içermelidir.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} mutlaka {value} karakterden uzun olmalıdır.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} mutlaka {value} veya daha fazla öge içermelidir.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} mutlaka {value} karakterden uzun veya eşit olmalıdır.";
        }
public string In()
        {
            return $"Seçili {FieldName} geçersiz.";
        }
public string Integer()
        {
            return $"{FieldName} mutlaka bir tam sayı olmalıdır.";
        }
public string Ip()
        {
            return $"{FieldName} mutlaka geçerli bir IP adresi olmalıdır.";
        }
public string Ipv4()
        {
            return $"{FieldName} mutlaka geçerli bir IPv4 adresi olmalıdır.";
        }
public string Ipv6()
        {
            return $"{FieldName} mutlaka geçerli bir IPv6 adresi olmalıdır.";
        }
public string Json()
        {
            return $"{FieldName} mutlaka geçerli bir JSON içeriği olmalıdır.";
        }
public string Lowercase()
        {
            return $"{FieldName} küçük harf olmalıdır.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} mutlaka {value} sayısından daha az öge içermelidir.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} mutlaka {value} karakterden kısa olmalıdır.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} mutlaka {value} veya daha az öge içermelidir.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} mutlaka {value} karakterden kısa veya eşit olmalıdır.";
        }
public string MacAddress()
        {
            return $"{FieldName} geçerli bir MAC adresi olmalıdır.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} en fazla {max} öge içerebilir.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} en fazla {max} olabilir.";
        }
public string MaxString(int max)
        {
            return $"{FieldName} en fazla {max} karakter olabilir.";
        }
public string MinArray(long min)
        {
            return $"{FieldName} en az {min} öge içerebilir.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} en az {min} olabilir.";
        }
public string MinString(int min)
        {
            return $"{FieldName} en az {min} karakter olabilir.";
        }
public string NotIn()
        {
            return $"Seçili {FieldName} geçersiz.";
        }
public string NotRegex()
        {
            return $"{FieldName} biçimi geçersiz.";
        }
public string Numeric()
        {
            return $"{FieldName} mutlaka bir sayı olmalıdır.";
        }
public string Regex()
        {
            return $"{FieldName} biçimi geçersiz.";
        }
public string Required()
        {
            return $"{FieldName} mutlaka gereklidir.";
        }
public string RequiredIf(string name, string value)
        {
            return $"{FieldName} {name} {value} değerine sahip olduğunda mutlaka gereklidir.";
        }
public string Same(string name)
        {
            return $"{FieldName} ile {name} aynı olmalıdır.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} mutlaka {size} ögeye sahip olmalıdır.";
        }
public string SizeString(int size)
        {
            return $"{FieldName} mutlaka {size} karakterli olmalıdır.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} sadece şu değerlerden biriyle başlayabilir: {String.Join(", ", values)}.";
        }
public string Unique()
                {
                    return $"{FieldName} zaten alınmış.";
                }
public string Uppercase()
        {
            return $"{FieldName} büyük harf olmalıdır.";
        }
public string Url()
        {
            return $"{FieldName} biçimi geçersiz.";
        }
    }
        }