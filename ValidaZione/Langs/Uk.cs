using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Uk : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Ви повинні прийняти {FieldName}.";
            }
public string ActiveUrl()
        {
            return $"Поле {FieldName} не є правильним URL.";
        }
public string After(string date)
        {
            return $"Поле {FieldName} має містити дату не раніше {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Поле {FieldName} має містити дату не раніше, або дорівнюватися {date}.";
        }
public string Alpha()
        {
            return $"Поле {FieldName} має містити лише літери.";
        }
public string AlphaDash()
        {
            return $"Поле {FieldName} має містити лише літери, цифри, тире та підкреслення.";
        }
public string AlphaNum()
        {
            return $"Поле {FieldName} має містити лише літери та цифри.";
        }
public string Before(string date)
        {
            return $"Поле {FieldName} має містити дату не пізніше {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Поле {FieldName} має містити дату не пізніше, або дорівнюватися {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Поле {FieldName} має містити від {min} до {max} елементів.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Поле {FieldName} має бути між {min} та {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Текст у полі {FieldName} має бути не менше {min} та не більше {max} символів.";
        }
public string Boolean()
        {
            return $"Поле {FieldName} повинне містити логічний тип.";
        }
public string Confirmed()
        {
            return $"Поле {FieldName} не збігається з підтвердженням.";
        }
public string Declined()
        {
            return $"Поле {FieldName} має бути відхилено.";
        }
public string Different(string name)
        {
            return $"Поля {FieldName} та {name} повинні бути різними.";
        }
public string Distinct()
        {
            return $"Поле {FieldName} містить значення, яке дублюється.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"Поле {FieldName} не може закінчуватися одним із таких: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"Поле {FieldName} не може починатися з одного з наступного: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Поле {FieldName} повинне містити коректну електронну адресу.";
        }
public string EndsWith(List<string> values)
        {
            return $"Поле {FieldName} має закінчуватися одним з наступних значень: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"Поле {FieldName} має містити більше ніж {value} елементів.";
        }
public string GreaterThanString(int value)
        {
            return $"Поле {FieldName} має бути більше ніж {value} символів.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Поле {FieldName} має містити {value} чи більше елементів.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Поле {FieldName} має дорівнювати чи бути більше ніж {value} символів.";
        }
public string In()
        {
            return $"Вибране для {FieldName} значення не коректне.";
        }
public string Integer()
        {
            return $"Поле {FieldName} має містити ціле число.";
        }
public string Ip()
        {
            return $"Поле {FieldName} має містити IP адресу.";
        }
public string Ipv4()
        {
            return $"Поле {FieldName} має містити IPv4 адресу.";
        }
public string Ipv6()
        {
            return $"Поле {FieldName} має містити IPv6 адресу.";
        }
public string Json()
        {
            return $"Дані поля {FieldName} мають бути у форматі JSON.";
        }
public string Lowercase()
        {
            return $"Поле {FieldName} має бути рядком у нижньому регістрі";
        }
public string LessThanArray(long value)
        {
            return $"Поле {FieldName} має містити менше ніж {value} items.";
        }
public string LessThanString(int value)
        {
            return $"Поле {FieldName} має бути менше ніж {value} символів.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"Поле {FieldName} має містити не більше ніж {value} елементів.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"Поле {FieldName} має дорівнювати чи бути менше ніж {value} символів.";
        }
public string MacAddress()
        {
            return $"Поле {FieldName} має містити MAC адресу.";
        }
public string MaxArray(long max)
        {
            return $"Поле {FieldName} повинне містити не більше {max} елементів.";
        }
public string MaxNumeric(string max)
        {
            return $"Поле {FieldName} має бути не більше {max}.";
        }
public string MaxString(int max)
        {
            return $"Текст в полі {FieldName} повинен мати довжину не більшу за {max}.";
        }
public string MinArray(long min)
        {
            return $"Поле {FieldName} повинне містити не менше {min} елементів.";
        }
public string MinNumeric(string min)
        {
            return $"Поле {FieldName} повинне бути не менше {min}.";
        }
public string MinString(int min)
        {
            return $"Текст у полі {FieldName} повинен містити не менше {min} символів.";
        }
public string NotIn()
        {
            return $"Вибране для {FieldName} значення не коректне.";
        }
public string NotRegex()
        {
            return $"Формат поля {FieldName} не вірний.";
        }
public string Numeric()
        {
            return $"Поле {FieldName} повинно містити число.";
        }
public string Regex()
        {
            return $"Поле {FieldName} має хибний формат.";
        }
public string Required()
        {
            return $"Поле {FieldName} є обов'язковим для заповнення.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Поле {FieldName} є обов'язковим для заповнення, коли {name} є рівним {value}.";
        }
public string Same(string name)
        {
            return $"Поля {FieldName} та {name} мають збігатися.";
        }
public string SizeArray(long size)
        {
            return $"Поле {FieldName} повинне містити {size} елементів.";
        }
public string SizeString(int size)
        {
            return $"Текст у полі {FieldName} повинен містити {size} символів.";
        }
public string StartsWith(List<string> values)
        {
            return $"Поле {FieldName} повинне починатися з одного з наступних значень: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"Поле {FieldName} має бути рядком у верхньому регістрі.";
        }
public string Url()
        {
            return $"Формат поля {FieldName} хибний.";
        }
    }
        }