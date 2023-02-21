using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Be : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Вы павінны прыняць {FieldName}.";
            }
public string ActiveUrl()
        {
            return $"Поле {FieldName} утрымлівае несапраўдны URL.";
        }
public string After(string date)
        {
            return $"У полі {FieldName} павінна быць дата пасля {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} павінна быць датай пасля або роўнай {date}.";
        }
 public string Alpha()
        {
            return $"Поле {FieldName} можа мець толькі літары.";
        }
public string AlphaDash()
        {
            return $"Поле {FieldName} можа мець толькі літары, лічбы і злучок.";
        }
public string AlphaNum()
        {
            return $"Поле {FieldName} можа мець толькі літары і лічбы.";
        }
public string Before(string date)
        {
            return $"У полі {FieldName} павінна быць дата да {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} павінна быць датай да або роўнай {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Колькасць элементаў у поле {FieldName} павінна быць паміж {min} і {max}.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Поле {FieldName} павінна быць паміж {min} і {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Колькасць сiмвалаў у поле {FieldName} павінна быць паміж {min} і {max}.";
        }
public string Boolean()
        {
            return $"Поле {FieldName} павінна мець значэнне лагічнага тыпу.";
        }
public string Confirmed()
        {
            return $"Поле {FieldName} не супадае з пацвярджэннем.";
        }
public string Declined()
        {
            return $"{FieldName} трэба адхіліць.";
        }
public string Different(string name)
        {
            return $"Палі {FieldName} і {name} павінны адрознівацца.";
        }
public string Distinct()
        {
            return $"Поле {FieldName} мае паўтаральнае значэнне.";
        }
public string Email()
        {
            return $"Поле {FieldName} павінна быць сапраўдным электронным адрасам.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} павінен заканчвацца адным з наступных: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"У {FieldName} павінна быць больш за {value} прадметаў.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} павінна быць больш за {value} сімвалаў.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"У {FieldName} павінна быць {value} прадметаў і больш.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} павінна быць больш або роўна {value} сімвалам.";
        }
  public string In()
        {
            return $"Выбранае значэнне для {FieldName} памылкова.";
        }
public string Integer()
        {
            return $"Поле {FieldName} павінна быць цэлым лікам.";
        }
public string Ip()
        {
            return $"Поле {FieldName} дпавінна быць сапраўдным IP-адрасам.";
        }
 public string Ipv4()
        {
            return $"{FieldName} павінен быць сапраўдным IPv4-адрасам.";
        }
        public string Ipv6()
        {
            return $"{FieldName} павінен быць сапраўдным IPv6-адрасам.";
        }
      public string Json()
        {
            return $"Поле {FieldName} павінна быць JSON радком.";
        }
        public string Lowercase()
        {
            return $"{FieldName} павінны быць малымі.";
        }
        public string LessThanArray(long value)
        {
            return $"У {FieldName} павінна быць менш за {value} элементаў.";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} павінна быць менш за {value} сімвалаў.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"У {FieldName} не павінна быць больш за {value} элементаў.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} павінна быць менш або роўна {value} сімвалам.";
        }
   public string MacAddress()
        {
            return $"{FieldName} павінен быць сапраўдным MAC-адрасам.";
        }
      public string MaxArray(long max)
        {
            return $"Колькасць элементаў у поле {FieldName} не можа перавышаць {max}.";
        }
      public string MaxNumeric(string max)
        {
            return $"Поле {FieldName} не можа быць больш {max}.";
        }
        public string MaxString(int max)
        {
            return $"Колькасць сiмвалаў у поле {FieldName} не можа перавышаць {max}.";
        }
    public string MinArray(long min)
        {
            return $"Колькасць элементаў у поле {FieldName} павінна быць не менш {min}.";
        }
   public string MinNumeric(string min)
        {
            return $"Поле {FieldName} павінна быць не менш {min}.";
        }
      public string MinString(int min)
        {
            return $"Колькасць сiмвалаў у поле {FieldName} павінна быць не менш {min}.";
        }
      public string NotIn()
        {
            return $"Выбранае значэнне для {FieldName} памылкова.";
        }
       public string NotRegex()
        {
            return $"Фармат {FieldName} недапушчальны.";
        }
      public string Numeric()
        {
            return $"Поле {FieldName} павінна быць лікам.";
        }
 public string Regex()
        {
            return $"Поле {FieldName} мае памылковы фармат.";
        }
       public string Required()
        {
            return $"Поле {FieldName} абавязкова для запаўнення.";
        }
    public string Same(string name)
        {
            return $"Значэнне {FieldName} павінна супадаць з {name}.";
        }
       public string SizeArray(long size)
        {
            return $"Колькасць элементаў у поле {FieldName} павінна быць :size.";
        }
    public string SizeString(int size)
        {
            return $"Колькасць сiмвалаў у поле {FieldName} павінна быць :size.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} павінен пачынацца з аднаго з наступных значэнняў: {String.Join(", ", values)}.";
        }
 public string Uppercase()
        {
            return $"{FieldName} павінны быць вялікімі.";
        }
   public string Url()
        {
            return $"Поле {FieldName} мае памылковы фармат.";
        }
    }
        }