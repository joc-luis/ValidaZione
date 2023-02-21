using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Ca : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} ha de ser acceptat.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} no és un URL vàlid.";
        }
public string After(string date)
        {
            return $"{FieldName} ha de ser una data posterior a {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} ha de ser una data posterior o igual a {date}.";
        }
 public string Alpha()
        {
            return $"{FieldName} només pot contenir lletres.";
        }
public string AlphaDash()
        {
            return $"{FieldName} només pot contenir lletres, números i guions.";
        }
public string AlphaNum()
        {
            return $"{FieldName} només pot contenir lletres i números.";
        }
public string Before(string date)
        {
            return $"{FieldName} ha de ser una data anterior a {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} ha de ser una data anterior o igual a {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} ha de tenir entre {min} - {max} ítems.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} ha d'estar entre {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} ha de tenir entre {min} - {max} caràcters.";
        }
public string Boolean()
        {
            return $"El camp {FieldName} ha de ser verdader o fals";
        }
public string Confirmed()
        {
            return $"La confirmació de {FieldName} no coincideix.";
        }
public string Declined()
        {
            return $"Els {FieldName} s'han de rebutjar.";
        }
public string Different(string name)
        {
            return $"{FieldName} i {name} han de ser diferents.";
        }
public string Distinct()
        {
            return $"El camp {FieldName} té un valor duplicat.";
        }
public string Email()
        {
            return $"{FieldName} no és un e-mail vàlid";
        }
public string EndsWith(List<string> values)
        {
            return $"La {FieldName} ha d'acabar amb una de les següents: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"El {FieldName} ha de tenir més de {value} ítems.";
        }
public string GreaterThanString(int value)
        {
            return $"El {FieldName} ha de superar els {value} caràcters.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"El {FieldName} ha de tenir {value} ítems o més.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"El {FieldName} ha de ser igual o superior a {value} caràcters.";
        }
  public string In()
        {
            return $"{FieldName} és invàlid";
        }
public string Integer()
        {
            return $"{FieldName} ha de ser un nombre enter.";
        }
public string Ip()
        {
            return $"{FieldName} ha de ser una adreça IP vàlida.";
        }
 public string Ipv4()
        {
            return $"{FieldName} ha de ser una adreça IPv4 vàlida.";
        }
        public string Ipv6()
        {
            return $"{FieldName} ha de ser una adreça IPv6 vàlida.";
        }
      public string Json()
        {
            return $"El camp {FieldName} ha de ser una cadena JSON vàlida.";
        }
        public string Lowercase()
        {
            return $"El {FieldName} ha d'anar en minúscula.";
        }
        public string LessThanArray(long value)
        {
            return $"El {FieldName} ha de tenir menys de {value} ítems.";
        }
    public string LessThanString(int value)
        {
            return $"El {FieldName} no ha de superar els {value} caràcters.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"El {FieldName} no ha de tenir més de {value} ítems.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"El {FieldName} ha de ser igual o inferior a {value} caràcters.";
        }
   public string MacAddress()
        {
            return $"El {FieldName} ha de ser una adreça MAC vàlida.";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} no pot tenir més de {max} ítems.";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} no pot ser més gran que {max}.";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} no pot ser més gran que {max} caràcters.";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} ha de tenir almenys {min} ítems.";
        }
   public string MinNumeric(string min)
        {
            return $"El tamany de {FieldName} ha de ser d'almenys {min}.";
        }
      public string MinString(int min)
        {
            return $"{FieldName} ha de contenir almenys {min} caràcters.";
        }
      public string NotIn()
        {
            return $"{FieldName} és invàlid.";
        }
       public string NotRegex()
        {
            return $"El format de {FieldName} no és vàlid.";
        }
      public string Numeric()
        {
            return $"{FieldName} ha de ser numèric.";
        }
 public string Regex()
        {
            return $"El format de {FieldName} és invàlid.";
        }
       public string Required()
        {
            return $"El camp {FieldName} és obligatori.";
        }
    public string Same(string name)
        {
            return $"{FieldName} i {name} han de coincidir.";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} ha de contenir :size ítems.";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} ha de contenir :size caràcters.";
        }
public string StartsWith(List<string> values)
        {
            return $"El {FieldName} ha de començar per un dels valors següents: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"El {FieldName} ha d'anar en majúscula.";
        }
   public string Url()
        {
            return $"{FieldName} no és una adreça web vàlida.";
        }
    }
        }