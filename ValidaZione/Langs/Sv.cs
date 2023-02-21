using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Sv : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} måste accepteras.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} är inte en giltig webbadress.";
        }
public string After(string date)
        {
            return $"{FieldName} måste vara ett datum efter {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} måste vara ett datum senare eller samma dag som {date}.";
        }
 public string Alpha()
        {
            return $"{FieldName} får endast innehålla bokstäver.";
        }
public string AlphaDash()
        {
            return $"{FieldName} får endast innehålla bokstäver, siffror och bindestreck.";
        }
public string AlphaNum()
        {
            return $"{FieldName} får endast innehålla bokstäver och siffror.";
        }
public string Before(string date)
        {
            return $"{FieldName} måste vara ett datum innan {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} måste vara ett datum före eller samma dag som {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} måste innehålla mellan {min} - {max} objekt.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} måste vara en siffra mellan {min} och {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} måste innehålla {min} till {max} tecken.";
        }
public string Boolean()
        {
            return $"{FieldName} måste vara sant eller falskt.";
        }
public string Confirmed()
        {
            return $"{FieldName} bekräftelsen matchar inte.";
        }
public string Declined()
        {
            return $"{FieldName} måste vara avaktiverat.";
        }
public string Different(string name)
        {
            return $"{FieldName} och {name} får inte vara lika.";
        }
public string Distinct()
        {
            return $"{FieldName} innehåller fler än en repetition av samma element.";
        }
public string Email()
        {
            return $"{FieldName} måste innehålla en korrekt e-postadress.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} måste sluta med en av följande: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} måste innehålla fler än {value} objekt.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} måste vara längre än {value} tecken.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} måste innehålla lika många eller fler än {value} objekt.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} måste vara lika med eller längre än {value} tecken.";
        }
  public string In()
        {
            return $"{FieldName} är ogiltigt.";
        }
public string Integer()
        {
            return $"{FieldName} måste vara en siffra.";
        }
public string Ip()
        {
            return $"{FieldName} måste vara en giltig IP-adress.";
        }
 public string Ipv4()
        {
            return $"{FieldName} måste vara en giltig IPv4-adress.";
        }
        public string Ipv6()
        {
            return $"{FieldName} måste vara en giltig IPv6-adress.";
        }
      public string Json()
        {
            return $"{FieldName} måste vara en giltig JSON-sträng.";
        }
        public string Lowercase()
        {
            return $"{FieldName} måste vara i små bokstäver.";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} måste innehålla färre än {value} objekt.";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} måste vara kortare än {value} tecken.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} måste innehålla lika många eller färre än {value} objekt.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} måste vara lika med eller kortare än {value} tecken.";
        }
   public string MacAddress()
        {
            return $"{FieldName} måste vara en giltig MAC adress.";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} får inte innehålla mer än {max} objekt.";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} får inte vara större än {max}.";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} får max innehålla {max} tecken.";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} måste innehålla minst {min} objekt.";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} måste vara större än {min}.";
        }
      public string MinString(int min)
        {
            return $"{FieldName} måste innehålla minst {min} tecken.";
        }
      public string NotIn()
        {
            return $"{FieldName} är ogiltigt.";
        }
       public string NotRegex()
        {
            return $"Formatet för {FieldName} är ogiltigt.";
        }
      public string Numeric()
        {
            return $"{FieldName} måste vara en siffra.";
        }
 public string Regex()
        {
            return $"{FieldName} har ogiltigt format.";
        }
       public string Required()
        {
            return $"{FieldName} är obligatoriskt.";
        }
    public string Same(string name)
        {
            return $"{FieldName} och {name} måste vara lika.";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} måste innehålla :size objekt.";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} måste innehålla :size tecken.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} måste börja med en av följande: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"{FieldName} måste vara versaler.";
        }
   public string Url()
        {
            return $"{FieldName} har ett ogiltigt format.";
        }
    }
        }