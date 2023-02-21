using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Nn : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} må aksepterast.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} er ikkje ein gyldig URL.";
        }
public string After(string date)
        {
            return $"{FieldName} må vere ein dato etter {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} må vere ein dato etter eller lik {date}.";
        }
 public string Alpha()
        {
            return $"{FieldName} må berre vere av bokstavar.";
        }
public string AlphaDash()
        {
            return $"{FieldName} må berre vere av bokstavar, tal og bindestrekar.";
        }
public string AlphaNum()
        {
            return $"{FieldName} må berre vere av bokstavar og tal.";
        }
public string Before(string date)
        {
            return $"{FieldName} må vere ein dato før {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} må vere ein dato før eller lik {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} må ha mellom {min} - {max} element.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} skal vere mellom {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} skal vere mellom {min} - {max} teikn.";
        }
public string Boolean()
        {
            return $"{FieldName} må vere sann eller usann.";
        }
public string Confirmed()
        {
            return $"{FieldName} er ikkje likt feltet for stadfesting.";
        }
public string Declined()
        {
            return $"De {FieldName} må avvises.";
        }
public string Different(string name)
        {
            return $"{FieldName} og {name} skal vere ulike.";
        }
public string Distinct()
        {
            return $"{FieldName} har ein duplikatverdi.";
        }
public string Email()
        {
            return $"{FieldName} format er ugyldig.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} må slutte på ein av følgande: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} må vere minst {value} element.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} må vere lengre enn {value} teikn.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} må ha {value} element eller meir.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} må vere lengre enn eller lik {value} teikn.";
        }
  public string In()
        {
            return $"Det valde {FieldName} er ugyldig.";
        }
public string Integer()
        {
            return $"{FieldName} skal vere eit heiltal.";
        }
public string Ip()
        {
            return $"{FieldName} skal vere ei gyldig IP-adresse.";
        }
 public string Ipv4()
        {
            return $"{FieldName} skal vere ei gyldig IPv4-adresse.";
        }
        public string Ipv6()
        {
            return $"{FieldName} skal vere ei gyldig IPv6-adresse.";
        }
      public string Json()
        {
            return $"{FieldName} må vere på JSON-format.";
        }
        public string Lowercase()
        {
            return $"{FieldName} må være små bokstaver.";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} må ha færre enn {value} element.";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} må vere kortare enn {value} teikn.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} må ikkje ha fleire enn {value} element.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} må vere kortare enn eller lik {value} teikn.";
        }
   public string MacAddress()
        {
            return $"{FieldName} må være en gyldig MAC-adresse.";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} skal ikkje ha fleire enn {max} element.";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} skal vere mindre enn {max}.";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} skal vere kortare enn {max} teikn.";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} må vere minst {min} element.";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} skal vere større enn {min}.";
        }
      public string MinString(int min)
        {
            return $"{FieldName} skal vere lengre enn {min} teikn.";
        }
      public string NotIn()
        {
            return $"Den valgte {FieldName} er ugyldig.";
        }
       public string NotRegex()
        {
            return $"Formatet på {FieldName} er ugyldig.";
        }
      public string Numeric()
        {
            return $"{FieldName} skal vere eit tal.";
        }
 public string Regex()
        {
            return $"Formatet på {FieldName} er ugyldig.";
        }
       public string Required()
        {
            return $"{FieldName} må fyllast ut.";
        }
    public string Same(string name)
        {
            return $"{FieldName} og {name} må vere like.";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} må innehalde :size element.";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} må vere :size teikn lang.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} må starte med ein av følgande: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"{FieldName} må være store bokstaver.";
        }
   public string Url()
        {
            return $"Formatet på {FieldName} er ugyldig.";
        }
    }
        }