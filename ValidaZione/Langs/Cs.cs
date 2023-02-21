using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Cs : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} musí být přijat.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} není platnou URL adresou.";
        }
public string After(string date)
        {
            return $"{FieldName} musí být datum po {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} musí být datum {date} nebo pozdější.";
        }
 public string Alpha()
        {
            return $"{FieldName} může obsahovat pouze písmena.";
        }
public string AlphaDash()
        {
            return $"{FieldName} může obsahovat pouze písmena, číslice, pomlčky a podtržítka. České znaky (á, é, í, ó, ú, ů, ž, š, č, ř, ď, ť, ň) nejsou podporovány.";
        }
public string AlphaNum()
        {
            return $"{FieldName} může obsahovat pouze písmena a číslice.";
        }
public string Before(string date)
        {
            return $"{FieldName} musí být datum před {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Datum {FieldName} musí být před nebo rovno {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} musí obsahovat nejméně {min} a nesmí obsahovat více než {max} prvků.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} musí být hodnota mezi {min} a {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} musí být delší než {min} a kratší než {max} znaků.";
        }
public string Boolean()
        {
            return $"{FieldName} musí být true nebo false";
        }
public string Confirmed()
        {
            return $"{FieldName} nesouhlasí.";
        }
public string Declined()
        {
            return $"{FieldName} musí být odmítnuto.";
        }
public string Different(string name)
        {
            return $"{FieldName} a {name} se musí lišit.";
        }
public string Distinct()
        {
            return $"{FieldName} má duplicitní hodnotu.";
        }
public string Email()
        {
            return $"{FieldName} není platný formát.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} musí končit jednou z následujících hodnot: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"Pole {FieldName} musí mít více prvků než {value}.";
        }
public string GreaterThanString(int value)
        {
            return $"Počet znaků {FieldName} musí být větší {value}.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Pole {FieldName} musí mít {value} prvků nebo více.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Počet znaků {FieldName} musí být větší nebo rovno {value}.";
        }
  public string In()
        {
            return $"Zvolená hodnota pro {FieldName} je neplatná.";
        }
public string Integer()
        {
            return $"{FieldName} musí být celé číslo.";
        }
public string Ip()
        {
            return $"{FieldName} musí být platnou IP adresou.";
        }
 public string Ipv4()
        {
            return $"{FieldName} musí být platná IPv4 adresa.";
        }
        public string Ipv6()
        {
            return $"{FieldName} musí být platná IPv6 adresa.";
        }
      public string Json()
        {
            return $"{FieldName} musí být platný JSON řetězec.";
        }
        public string Lowercase()
        {
            return $"{FieldName} musí být malá písmena.";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} by měl obsahovat méně než {value} položek.";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} musí obsahovat méně než {value} znaků.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} by měl obsahovat maximálně {value} položek.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} nesmí být delší než {value} znaků.";
        }
   public string MacAddress()
        {
            return $"{FieldName} musí být platná adresa MAC.";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} nemůže obsahovat více než {max} prvků.";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} nemůže být větší než {max}.";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} nemůže být delší než {max} znaků.";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} musí obsahovat více než {min} prvků.";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} musí být větší než {min}.";
        }
      public string MinString(int min)
        {
            return $"{FieldName} musí být delší než {min} znaků.";
        }
      public string NotIn()
        {
            return $"Zvolená hodnota pro {FieldName} je neplatná.";
        }
       public string NotRegex()
        {
            return $"{FieldName} musí být regulární výraz.";
        }
      public string Numeric()
        {
            return $"{FieldName} musí být číslo.";
        }
 public string Regex()
        {
            return $"{FieldName} nemá správný formát.";
        }
       public string Required()
        {
            return $"{FieldName} musí být vyplněno.";
        }
    public string Same(string name)
        {
            return $"{FieldName} a {name} se musí shodovat.";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} musí obsahovat právě :size prvků.";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} musí být přesně :size znaků dlouhý.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} musí začínat jednou z následujících hodnot: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"{FieldName} musí být velká písmena.";
        }
   public string Url()
        {
            return $"Formát {FieldName} je neplatný.";
        }
    }
        }