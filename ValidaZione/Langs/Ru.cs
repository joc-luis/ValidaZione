using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Ru : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Вы должны принять {FieldName}.";
            }
public string ActiveUrl()
        {
            return $"Значение поля {FieldName} должно быть действительным URL адресом.";
        }
public string After(string date)
        {
            return $"Значение поля {FieldName} должно быть датой после {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Значение поля {FieldName} должно быть датой после или равной {date}.";
        }
public string Alpha()
        {
            return $"Значение поля {FieldName} может содержать только буквы.";
        }
public string AlphaDash()
        {
            return $"Значение поля {FieldName} может содержать только буквы, цифры, дефис и нижнее подчеркивание.";
        }
public string AlphaNum()
        {
            return $"Значение поля {FieldName} может содержать только буквы и цифры.";
        }
public string Before(string date)
        {
            return $"Значение поля {FieldName} должно быть датой до {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Значение поля {FieldName} должно быть датой до или равной {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Количество элементов в поле {FieldName} должно быть между {min} и {max}.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Значение поля {FieldName} должно быть между {min} и {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Количество символов в поле {FieldName} должно быть между {min} и {max}.";
        }
public string Boolean()
        {
            return $"Значение поля {FieldName} должно быть логического типа.";
        }
public string Confirmed()
        {
            return $"Значение поля {FieldName} не совпадает с подтверждаемым.";
        }
public string Declined()
        {
            return $"Поле {FieldName} должно быть отклонено.";
        }
public string Different(string name)
        {
            return $"Значения полей {FieldName} и {name} должны различаться.";
        }
public string Distinct()
        {
            return $"Значения поля {FieldName} не должны повторяться.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"Значение поля {FieldName} не должно заканчиваться одним из следующих: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"Значение поля {FieldName} не должно начинаться с одного из следующих: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Значение поля {FieldName} должно быть действительным электронным адресом.";
        }
public string EndsWith(List<string> values)
        {
            return $"Значение поля {FieldName} должно заканчиваться одним из следующих: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"Количество элементов в поле {FieldName} должно быть больше {value}.";
        }
public string GreaterThanString(int value)
        {
            return $"Количество символов в поле {FieldName} должно быть больше {value}.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Количество элементов в поле {FieldName} должно быть {value} или больше.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Количество символов в поле {FieldName} должно быть {value} или больше.";
        }
public string In()
        {
            return $"Значение поля {FieldName} некорректно.";
        }
public string Integer()
        {
            return $"Значение поля {FieldName} должно быть целым числом.";
        }
public string Ip()
        {
            return $"Значение поля {FieldName} должно быть действительным IP-адресом.";
        }
public string Ipv4()
        {
            return $"Значение поля {FieldName} должно быть действительным IPv4-адресом.";
        }
public string Ipv6()
        {
            return $"Значение поля {FieldName} должно быть действительным IPv6-адресом.";
        }
public string Json()
        {
            return $"Значение поля {FieldName} должно быть JSON строкой.";
        }
public string Lowercase()
        {
            return $"Значение поля {FieldName} должно быть в нижнем регистре.";
        }
public string LessThanArray(long value)
        {
            return $"Количество элементов в поле {FieldName} должно быть меньше {value}.";
        }
public string LessThanString(int value)
        {
            return $"Количество символов в поле {FieldName} должно быть меньше {value}.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"Количество элементов в поле {FieldName} должно быть {value} или меньше.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"Количество символов в поле {FieldName} должно быть {value} или меньше.";
        }
public string MacAddress()
        {
            return $"Значение поля {FieldName} должно быть корректным MAC-адресом.";
        }
public string MaxArray(long max)
        {
            return $"Количество элементов в поле {FieldName} не может превышать {max}.";
        }
public string MaxNumeric(string max)
        {
            return $"Значение поля {FieldName} не может быть больше {max}.";
        }
public string MaxString(int max)
        {
            return $"Количество символов в значении поля {FieldName} не может превышать {max}.";
        }
public string MinArray(long min)
        {
            return $"Количество элементов в поле {FieldName} должно быть не меньше {min}.";
        }
public string MinNumeric(string min)
        {
            return $"Значение поля {FieldName} должно быть не меньше {min}.";
        }
public string MinString(int min)
        {
            return $"Количество символов в поле {FieldName} должно быть не меньше {min}.";
        }
public string NotIn()
        {
            return $"Значение поля {FieldName} некорректно.";
        }
public string NotRegex()
        {
            return $"Значение поля {FieldName} имеет некорректный формат.";
        }
public string Numeric()
        {
            return $"Значение поля {FieldName} должно быть числом.";
        }
public string Regex()
        {
            return $"Значение поля {FieldName} имеет некорректный формат.";
        }
public string Required()
        {
            return $"Поле {FieldName} обязательно.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Поле {FieldName} обязательно для заполнения, когда {name} равно {value}.";
        }
public string Same(string name)
        {
            return $"Значения полей {FieldName} и {name} должны совпадать.";
        }
public string SizeArray(long size)
        {
            return $"Количество элементов в поле {FieldName} должно быть равным {size}.";
        }
public string SizeString(int size)
        {
            return $"Количество символов в поле {FieldName} должно быть равным {size}.";
        }
public string StartsWith(List<string> values)
        {
            return $"Поле {FieldName} должно начинаться с одного из следующих значений: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"Значение поля {FieldName} должно быть в верхнем регистре.";
        }
public string Url()
        {
            return $"Значение поля {FieldName} имеет ошибочный формат URL.";
        }
    }
        }