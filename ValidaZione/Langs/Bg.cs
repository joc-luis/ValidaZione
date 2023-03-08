using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Bg : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Трябва да приемете {FieldName}.";
            }
public string ActiveUrl()
        {
            return $"Полето {FieldName} не е валиден URL адрес.";
        }
public string After(string date)
        {
            return $"Полето {FieldName} трябва да бъде дата след {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Полето {FieldName} трябва да бъде дата след или равна на {date}.";
        }
public string Alpha()
        {
            return $"Полето {FieldName} трябва да съдържа само букви.";
        }
public string AlphaDash()
        {
            return $"Полето {FieldName} трябва да съдържа само букви, цифри, долна черта и тире.";
        }
public string AlphaNum()
        {
            return $"Полето {FieldName} трябва да съдържа само букви и цифри.";
        }
public string Before(string date)
        {
            return $"Полето {FieldName} трябва да бъде дата преди {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Полето {FieldName} трябва да бъде дата преди или равна на {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Полето {FieldName} трябва да има между {min} - {max} елемента.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Полето {FieldName} трябва да бъде между {min} и {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Полето {FieldName} трябва да бъде между {min} и {max} знака.";
        }
public string Boolean()
        {
            return $"Полето {FieldName} трябва да съдържа Да или Не";
        }
public string Confirmed()
        {
            return $"Полето {FieldName} не е потвърдено.";
        }
public string Declined()
        {
            return $"{FieldName}-те трябва да бъдат отхвърлени.";
        }
public string Different(string name)
        {
            return $"Полетата {FieldName} и {name} трябва да са различни.";
        }
public string Distinct()
        {
            return $"Данните в полето {FieldName} се дублират.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName}-те може да не завършват с едно от следните: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName}-те може да не започват с едно от следните: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Полето {FieldName} е в невалиден формат.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} трябва да завършва с една от следните стойности: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} трябва да разполага с повече от {value} елемента.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} трябва да бъде по-голяма от {value} знака.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} трябва да разполага с {value} елемента или повече.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} трябва да бъде по-голяма от или равна на {value} знака.";
        }
public string In()
        {
            return $"Избраното поле {FieldName} е невалидно.";
        }
public string Integer()
        {
            return $"Полето {FieldName} трябва да бъде цяло число.";
        }
public string Ip()
        {
            return $"Полето {FieldName} трябва да бъде IP адрес.";
        }
public string Ipv4()
        {
            return $"Полето {FieldName} трябва да бъде IPv4 адрес.";
        }
public string Ipv6()
        {
            return $"Полето {FieldName} трябва да бъде IPv6 адрес.";
        }
public string Json()
        {
            return $"Полето {FieldName} трябва да бъде JSON низ.";
        }
public string Lowercase()
        {
            return $"{FieldName} трябва да са малки букви.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} трябва да разполага с по-малко от {value} елемента.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} трябва да бъде по-малка от {value} знака.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} не трябва да разполага с повече от {value} елемента.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} трябва да бъде по-малка от или равна на {value} знака.";
        }
public string MacAddress()
        {
            return $"{FieldName} трябва да е валиден MAC адрес.";
        }
public string MaxArray(long max)
        {
            return $"Полето {FieldName} трябва да има по-малко от {max} елемента.";
        }
public string MaxNumeric(string max)
        {
            return $"Полето {FieldName} трябва да бъде по-малко от {max}.";
        }
public string MaxString(int max)
        {
            return $"Полето {FieldName} трябва да бъде по-малко от {max} знака.";
        }
public string MinArray(long min)
        {
            return $"Полето {FieldName} трябва има минимум {min} елемента.";
        }
public string MinNumeric(string min)
        {
            return $"Полето {FieldName} трябва да бъде минимум {min}.";
        }
public string MinString(int min)
        {
            return $"Полето {FieldName} трябва да бъде минимум {min} знака.";
        }
public string NotIn()
        {
            return $"Избраното поле {FieldName} е невалидно.";
        }
public string NotRegex()
        {
            return $"Форматът на {FieldName} е невалиден.";
        }
public string Numeric()
        {
            return $"Полето {FieldName} трябва да бъде число.";
        }
public string Regex()
        {
            return $"Полето {FieldName} е в невалиден формат.";
        }
public string Required()
        {
            return $"Полето {FieldName} е задължително.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Полето {FieldName} се изисква, когато {name} е {value}.";
        }
public string Same(string name)
        {
            return $"Полетата {FieldName} и {name} трябва да съвпадат.";
        }
public string SizeArray(long size)
        {
            return $"Полето {FieldName} трябва да има {size} елемента.";
        }
public string SizeString(int size)
        {
            return $"Полето {FieldName} трябва да бъде {size} знака.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} трябва да започва с едно от следните: {String.Join(", ", values)}.";
        }
public string Unique()
                {
                    return $"Полето {FieldName} вече съществува.";
                }
public string Uppercase()
        {
            return $"{FieldName} трябва да са главни букви.";
        }
public string Url()
        {
            return $"Полето {FieldName} е в невалиден формат.";
        }
    }
        }