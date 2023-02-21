using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Sq : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} duhet të pranohet.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} nuk është adresë e saktë.";
        }
public string After(string date)
        {
            return $"{FieldName} duhet të jetë datë pas {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} duhet të jetë datë e barabartë ose pas {date}.";
        }
 public string Alpha()
        {
            return $"{FieldName} mund të përmbajë vetëm shkronja.";
        }
public string AlphaDash()
        {
            return $"{FieldName} mund të përmbajë vetëm shkronja, numra, dhe viza.";
        }
public string AlphaNum()
        {
            return $"{FieldName} mund të përmbajë vetëm shkronja dhe numra.";
        }
public string Before(string date)
        {
            return $"{FieldName} duhet të jetë datë para {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} duhet të jetë datë e barabartë ose para {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} duhet të ketë ndërmjet {min} - {max} elementëve.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} duhet të jetë ndërmjet {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} duhet të ketë ndërmjet {min} - {max} karaktereve.";
        }
public string Boolean()
        {
            return $"Fusha {FieldName} duhet të jetë e vërtetë ose e gabuar";
        }
public string Confirmed()
        {
            return $"{FieldName} konfirmimi nuk përputhet.";
        }
public string Declined()
        {
            return $"{FieldName} duhet të refuzohen.";
        }
public string Different(string name)
        {
            return $"{FieldName} dhe {name} duhet të jenë të ndryshme.";
        }
public string Distinct()
        {
            return $"{FieldName} ka një vlerë të përsëritur.";
        }
public string Email()
        {
            return $"{FieldName} formati është i pasaktë.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} duhet të përfundojë me një nga vlerat: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} duhet të ketë më shumë se {value} elemente.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} duhet të ketë më shumë se {value} karaktere.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} duhet të ketë {value} ose më shumë elemente.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} duhet të ketë {value} ose më shumë karaktere.";
        }
  public string In()
        {
            return $"{FieldName} përzgjedhur është i/e pasaktë.";
        }
public string Integer()
        {
            return $"{FieldName} duhet të jetë numër i plotë.";
        }
public string Ip()
        {
            return $"{FieldName} duhet të jetë një IP adresë.";
        }
 public string Ipv4()
        {
            return $"{FieldName} duhet të jetë një IPv4 adresë.";
        }
        public string Ipv6()
        {
            return $"{FieldName} duhet të jetë një IPv6 adresë.";
        }
      public string Json()
        {
            return $"{FieldName} duhet të ketë përmbajtje të vlefshme JSON.";
        }
        public string Lowercase()
        {
            return $"{FieldName} duhet të jetë me shkronja të vogla.";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} duhet të ketë më pak se {value} elemente.";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} duhet të ketë më pak se {value} karaktere.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} duhet të ketë {value} ose më pak karaktere.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} duhet të ketë {value} ose më pak karaktere.";
        }
   public string MacAddress()
        {
            return $"{FieldName} duhet të jetë një adresë MAC e vlefshme.";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} nuk mund të ketë më tepër se {max} elemente.";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} nuk mund të jetë më tepër se {max}.";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} nuk mund të ketë më tepër se {max} karaktere.";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} nuk mund të ketë më pak se {min} elemente.";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} nuk mund të jetë më pak se {min}.";
        }
      public string MinString(int min)
        {
            return $"{FieldName} nuk mund të ketë më pak se {min} karaktere.";
        }
      public string NotIn()
        {
            return $"{FieldName} përzgjedhur është i/e pasaktë.";
        }
       public string NotRegex()
        {
            return $"Formati i {FieldName} është i pasaktë.";
        }
      public string Numeric()
        {
            return $"{FieldName} duhet të jetë një numër.";
        }
 public string Regex()
        {
            return $"Formati i {FieldName} është i pasaktë.";
        }
       public string Required()
        {
            return $"Fusha {FieldName} është e kërkuar.";
        }
    public string Same(string name)
        {
            return $"{FieldName} dhe {name} duhet të përputhen.";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} duhet të ketë :size elemente.";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} duhet të ketë :size karaktere.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} duhet të fillojë me njërën nga vlerat: {String.Join(", ", values)}.";
        }
 public string Uppercase()
        {
            return $"{FieldName} duhet të jetë e madhe.";
        }
   public string Url()
        {
            return $"Formati i {FieldName} është i pasaktë.";
        }
    }
        }