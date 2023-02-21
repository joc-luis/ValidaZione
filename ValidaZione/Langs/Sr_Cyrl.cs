using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Sr_Cyrl : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Поље {FieldName} мора бити прихваћено.";
            }
public string ActiveUrl()
        {
            return $"Поље {FieldName} није валидан УРЛ.";
        }
public string After(string date)
        {
            return $"Поље {FieldName} мора бити датум после {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Поље {FieldName} мора да буде {date} или каснији датум.";
        }
 public string Alpha()
        {
            return $"Поље {FieldName} може садржати само слова.";
        }
public string AlphaDash()
        {
            return $"Поље {FieldName} може садржати само слова, бројеве и повлаке.";
        }
public string AlphaNum()
        {
            return $"Поље {FieldName} може садржати само слова и бројеве.";
        }
public string Before(string date)
        {
            return $"Поље {FieldName} мора бити датум пре {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} мора да буде {date} или ранији датум.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Поље {FieldName} мора бити између {min} - {max} ставки.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Поље {FieldName} мора бити између {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Поље {FieldName} мора бити између {min} - {max} карактера.";
        }
public string Boolean()
        {
            return $"Поље {FieldName} мора бити тачно или нетачно";
        }
public string Confirmed()
        {
            return $"Потврда поља {FieldName} се не поклапа.";
        }
public string Declined()
        {
            return $"{FieldName} се мора одбити.";
        }
public string Different(string name)
        {
            return $"Поља {FieldName} и {name} морају бити различита.";
        }
public string Distinct()
        {
            return $"Поље {FieldName} има дуплирану вредност.";
        }
public string Email()
        {
            return $"Формат поља {FieldName} није валидан.";
        }
public string EndsWith(List<string> values)
        {
            return $"Поље {FieldName} мора да се заврши са нечим од следећег: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"Поље {FieldName} мора да садржи више од {value} ставке.";
        }
public string GreaterThanString(int value)
        {
            return $"Поље {FieldName} мора да садржи више од {value} знакова.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Поље {FieldName} мора да садржи {value} ставки или више.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Поље {FieldName} мора да садржи {value} или више знакова.";
        }
  public string In()
        {
            return $"Поље Одабрано поље {FieldName} није валидно.";
        }
public string Integer()
        {
            return $"Поље {FieldName} мора бити број.";
        }
public string Ip()
        {
            return $"Поље {FieldName} мора бити валидна ИП адреса.";
        }
 public string Ipv4()
        {
            return $"Поље {FieldName} мора да буде важећа ИПв4 адреса.";
        }
        public string Ipv6()
        {
            return $"Поље {FieldName} мора да буде важећа ИПв6 адреса.";
        }
      public string Json()
        {
            return $"Поље {FieldName} мора да буде важећа ЈСОН формат.";
        }
        public string Lowercase()
        {
            return $"{FieldName} мора бити малим словима.";
        }
        public string LessThanArray(long value)
        {
            return $"Поље {FieldName} мора да садржи мање од {value} ставки.";
        }
    public string LessThanString(int value)
        {
            return $"Поље {FieldName} мора да садржи мање од {value} знакова.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"Поље {FieldName} не сме да садржи више од {value} ставки.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"Поље {FieldName} мора да садржи {value} или мање знакова.";
        }
   public string MacAddress()
        {
            return $"{FieldName} мора бити важећа МАЦ адреса.";
        }
      public string MaxArray(long max)
        {
            return $"Поље {FieldName} не смије да имаге више од {max} ставки.";
        }
      public string MaxNumeric(string max)
        {
            return $"Поље {FieldName} мора бити мање од {max}.";
        }
        public string MaxString(int max)
        {
            return $"Поље {FieldName} мора садржати мање од {max} карактера.";
        }
    public string MinArray(long min)
        {
            return $"Поље {FieldName} мора садрзати најмање {min} ставку.";
        }
   public string MinNumeric(string min)
        {
            return $"Поље {FieldName} мора бити најмање {min}.";
        }
      public string MinString(int min)
        {
            return $"Поље {FieldName} мора садржати најмање {min} карактера.";
        }
      public string NotIn()
        {
            return $"Одабрани елемент поља {FieldName} није валидан.";
        }
       public string NotRegex()
        {
            return $"Формат {FieldName} је неважећи.";
        }
      public string Numeric()
        {
            return $"Поље {FieldName} мора бити број.";
        }
 public string Regex()
        {
            return $"Формат поља {FieldName} није валидан.";
        }
       public string Required()
        {
            return $"Поље {FieldName} је обавезно.";
        }
    public string Same(string name)
        {
            return $"Поља {FieldName} и {name} се морају поклапати.";
        }
       public string SizeArray(long size)
        {
            return $"Поље {FieldName} мора садржати :size ставки.";
        }
    public string SizeString(int size)
        {
            return $"Поље {FieldName} мора бити :size карактера.";
        }
public string StartsWith(List<string> values)
        {
            return $"Поље {FieldName} мора да почне са: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"{FieldName} мора бити великим словима.";
        }
   public string Url()
        {
            return $"Формат поља {FieldName} не важи.";
        }
    }
        }