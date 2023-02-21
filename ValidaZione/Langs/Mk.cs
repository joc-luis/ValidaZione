using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Mk : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Полето {FieldName} мора да биде прифатено.";
            }
public string ActiveUrl()
        {
            return $"Полето {FieldName} не е валиден URL.";
        }
public string After(string date)
        {
            return $"Полето {FieldName} мора да биде датум после {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Полето {FieldName} мора да биде датум кој е после или еднаков на {date}.";
        }
 public string Alpha()
        {
            return $"Полето {FieldName} може да содржи само букви.";
        }
public string AlphaDash()
        {
            return $"Полето {FieldName} може да содржи само букви, броеви, долна црта и тире.";
        }
public string AlphaNum()
        {
            return $"Полето {FieldName} може да содржи само букви и броеви.";
        }
public string Before(string date)
        {
            return $"Полето {FieldName} мора да биде датум пред {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Полето {FieldName} мора да биде датум пред или еднаков на {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Полето {FieldName} мора да има помеѓу {min} - {max} елементи.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Полето {FieldName} мора да биде број помеѓу {min} и {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Полето {FieldName} мора да биде текст со должина помеѓу {min} и {max} карактери.";
        }
public string Boolean()
        {
            return $"Полето {FieldName} мора да има вредност вистинито (true) или невистинито (false).";
        }
public string Confirmed()
        {
            return $"Полето {FieldName} не е потврдено.";
        }
public string Declined()
        {
            return $"{FieldName}-те мора да се одбијат.";
        }
public string Different(string name)
        {
            return $"Полињата {FieldName} и {name} треба да се различни.";
        }
public string Distinct()
        {
            return $"Полето {FieldName} има вредност која е дупликат.";
        }
public string Email()
        {
            return $"Полето {FieldName} не е во валиден формат.";
        }
public string EndsWith(List<string> values)
        {
            return $"Полето {FieldName} мора да завршува со една од следните вредности: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"Полето {FieldName} мора да има повеке од {value} елементи.";
        }
public string GreaterThanString(int value)
        {
            return $"Полето {FieldName} мора да биде текст со повеќе од {value} карактери.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Полето {FieldName} мора да има {value} елементи или повеќе.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Полето {FieldName} мора да биде текст со повеќе или еднаков на {value} број на карактери.";
        }
  public string In()
        {
            return $"Избраното поле {FieldName} е невалидно.";
        }
public string Integer()
        {
            return $"Полето {FieldName} мора да биде цел број.";
        }
public string Ip()
        {
            return $"Полето {FieldName} мора да биде валидна IP адреса.";
        }
 public string Ipv4()
        {
            return $"Полето {FieldName} мора да биде валидна IPv4 адреса.";
        }
        public string Ipv6()
        {
            return $"Полето {FieldName} мора да биде валидна IPv6 адреса.";
        }
      public string Json()
        {
            return $"Полето {FieldName} мора да биде валиден JSON објект.";
        }
        public string Lowercase()
        {
            return $"{FieldName}-ката мора да биде мала.";
        }
        public string LessThanArray(long value)
        {
            return $"Полето {FieldName} мора да има помалку од {value} елементи.";
        }
    public string LessThanString(int value)
        {
            return $"Полето {FieldName} мора да биде текст помал од {value} број на карактери.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"Полето {FieldName} мора да има {value} елементи или помалку.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"Полето {FieldName} мора да биде текст со помалку или еднаков на {value} број на карактери.";
        }
   public string MacAddress()
        {
            return $"{FieldName} мора да биде валидна MAC адреса.";
        }
      public string MaxArray(long max)
        {
            return $"Полето {FieldName} не може да има повеќе од {max} елементи.";
        }
      public string MaxNumeric(string max)
        {
            return $"Полето {FieldName} мора да биде број не поголем од {max}.";
        }
        public string MaxString(int max)
        {
            return $"Полето {FieldName} мора да има не повеќе од {max} карактери.";
        }
    public string MinArray(long min)
        {
            return $"Полето {FieldName} мора да има минимум {min} елементи.";
        }
   public string MinNumeric(string min)
        {
            return $"Полето {FieldName} мора да биде број не помал од {min}.";
        }
      public string MinString(int min)
        {
            return $"Полето {FieldName} мора да има не помалку од {min} карактери.";
        }
      public string NotIn()
        {
            return $"Избраното поле {FieldName} е невалидно.";
        }
       public string NotRegex()
        {
            return $"Полето {FieldName} има невалиден формат.";
        }
      public string Numeric()
        {
            return $"Полето {FieldName} мора да биде број.";
        }
 public string Regex()
        {
            return $"Полето {FieldName} има невалиден формат.";
        }
       public string Required()
        {
            return $"Полето {FieldName} е задолжително.";
        }
    public string Same(string name)
        {
            return $"Полињата {FieldName} и {name} треба да совпаѓаат.";
        }
       public string SizeArray(long size)
        {
            return $"Полето {FieldName} мора да биде низа со :size број на елементи.";
        }
    public string SizeString(int size)
        {
            return $"Полето {FieldName} мора да биде текст со должина од :size број на карактери.";
        }
public string StartsWith(List<string> values)
        {
            return $"Полето {FieldName} мора да започнува со една од следните вредности: {String.Join(", ", values)}.";
        }
 public string Uppercase()
        {
            return $"{FieldName}-ката мора да биде голема.";
        }
   public string Url()
        {
            return $"Полето {FieldName} не е во валиден формат.";
        }
    }
        }