using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class De_CH : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} muss akzeptiert werden.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} ist keine gültige Internet-Adresse.";
        }
public string After(string date)
        {
            return $"{FieldName} muss ein Datum nach dem {date} sein.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} muss ein Datum nach dem {date} oder gleich dem {date} sein.";
        }
 public string Alpha()
        {
            return $"{FieldName} darf nur aus Buchstaben bestehen.";
        }
public string AlphaDash()
        {
            return $"{FieldName} darf nur aus Buchstaben, Zahlen, Binde- und Unterstrichen bestehen.";
        }
public string AlphaNum()
        {
            return $"{FieldName} darf nur aus Buchstaben und Zahlen bestehen.";
        }
public string Before(string date)
        {
            return $"{FieldName} muss ein Datum vor dem {date} sein.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} muss ein Datum vor dem {date} oder gleich dem {date} sein.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} muss zwischen {min} & {max} Elemente haben.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} muss zwischen {min} & {max} liegen.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} muss zwischen {min} & {max} Zeichen lang sein.";
        }
public string Boolean()
        {
            return $"{FieldName} muss entweder 'true' oder 'false' sein.";
        }
public string Confirmed()
        {
            return $"{FieldName} stimmt nicht mit der Bestätigung überein.";
        }
public string Declined()
        {
            return $"Die {FieldName} muss abgelehnt werden.";
        }
public string Different(string name)
        {
            return $"{FieldName} und {name} müssen sich unterscheiden.";
        }
public string Distinct()
        {
            return $"{FieldName} beinhaltet einen bereits vorhandenen Wert.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"Die {FieldName} darf nicht mit einer der folgenden Zahlen enden: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"Die {FieldName} darf nicht mit einem der folgenden Werte beginnen: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} muss eine gültige E-Mail-Adresse sein.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} muss eine der folgenden Endungen aufweisen: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} muss mindestens {value} Elemente haben.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} muss mindestens {value} Zeichen lang sein.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} muss grösser oder gleich {value} Elemente haben.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} muss grösser oder gleich {value} Zeichen lang sein.";
        }
  public string In()
        {
            return $"Der gewählte Wert für {FieldName} ist ungültig.";
        }
public string Integer()
        {
            return $"{FieldName} muss eine ganze Zahl sein.";
        }
public string Ip()
        {
            return $"{FieldName} muss eine gültige IP-Adresse sein.";
        }
 public string Ipv4()
        {
            return $"{FieldName} muss eine gültige IPv4-Adresse sein.";
        }
        public string Ipv6()
        {
            return $"{FieldName} muss eine gültige IPv6-Adresse sein.";
        }
      public string Json()
        {
            return $"{FieldName} muss ein gültiger JSON-String sein.";
        }
        public string Lowercase()
        {
            return $"Die {FieldName} muss klein geschrieben werden.";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} muss kleiner {value} Elemente haben.";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} muss kleiner {value} Zeichen lang sein.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} muss kleiner oder gleich {value} Elemente haben.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} muss kleiner oder gleich {value} Zeichen lang sein.";
        }
   public string MacAddress()
        {
            return $"Die {FieldName} muss eine gültige MAC-Adresse sein.";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} darf nicht mehr als {max} Elemente haben.";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} darf maximal {max} sein.";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} darf maximal {max} Zeichen haben.";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} muss mindestens {min} Elemente haben.";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} muss mindestens {min} sein.";
        }
      public string MinString(int min)
        {
            return $"{FieldName} muss mindestens {min} Zeichen lang sein.";
        }
      public string NotIn()
        {
            return $"Der gewählte Wert für {FieldName} ist ungültig.";
        }
       public string NotRegex()
        {
            return $"{FieldName} hat ein ungültiges Format.";
        }
      public string Numeric()
        {
            return $"{FieldName} muss eine Zahl sein.";
        }
 public string Regex()
        {
            return $"{FieldName} Format ist ungültig.";
        }
       public string Required()
        {
            return $"{FieldName} muss ausgefüllt sein.";
        }
    public string Same(string name)
        {
            return $"{FieldName} und {name} müssen übereinstimmen.";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} muss genau {size} Elemente haben.";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} muss {size} Zeichen lang sein.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} muss einen der folgenden Anfänge aufweisen: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"Die {FieldName} muss in Großbuchstaben geschrieben werden.";
        }
   public string Url()
        {
            return $"{FieldName} muss eine URL sein.";
        }
    }
        }