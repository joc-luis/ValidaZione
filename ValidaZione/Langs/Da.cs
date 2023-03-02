using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Da : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} skal accepteres.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} er ikke en gyldig URL.";
        }
public string After(string date)
        {
            return $"{FieldName} skal være en dato efter {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} skal være en dato efter eller lig med {date}.";
        }
 public string Alpha()
        {
            return $"{FieldName} må kun bestå af bogstaver.";
        }
public string AlphaDash()
        {
            return $"{FieldName} må kun bestå af bogstaver, tal og bindestreger.";
        }
public string AlphaNum()
        {
            return $"{FieldName} må kun bestå af bogstaver og tal.";
        }
public string Before(string date)
        {
            return $"{FieldName} skal være en dato før {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} skal være en dato før eller lig med {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} skal indeholde mellem {min} og {max} elementer.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} skal være mellem {min} og {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} skal være mellem {min} og {max} tegn.";
        }
public string Boolean()
        {
            return $"{FieldName} skal være sand eller falsk.";
        }
public string Confirmed()
        {
            return $"{FieldName} er ikke det samme som bekræftelsesfeltet.";
        }
public string Declined()
        {
            return $"De {FieldName} skal afvises.";
        }
public string Different(string name)
        {
            return $"{FieldName} og {name} skal være forskellige.";
        }
public string Distinct()
        {
            return $"{FieldName} har en duplikatværdi.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"De {FieldName} slutter muligvis ikke med en af ​​følgende: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"De {FieldName} starter muligvis ikke med en af ​​følgende: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} skal være en gyldig e-mailadresse.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} skal ende med et af følgende: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} skal være mere end {value} elementer.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} skal være mere end {value} tegn.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} skal have {value} elementer eller mere.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} skal være mere end eller lig med {value} tegn.";
        }
  public string In()
        {
            return $"Valgte {FieldName} er ugyldig.";
        }
public string Integer()
        {
            return $"{FieldName} skal være et heltal.";
        }
public string Ip()
        {
            return $"{FieldName} skal være en gyldig IP adresse.";
        }
 public string Ipv4()
        {
            return $"{FieldName} skal være en gyldig IPv4 adresse.";
        }
        public string Ipv6()
        {
            return $"{FieldName} skal være en gyldig IPv6 adresse.";
        }
      public string Json()
        {
            return $"{FieldName} skal være en gyldig JSON streng.";
        }
        public string Lowercase()
        {
            return $"De {FieldName} skal være små bogstaver.";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} skal have mindre end {value} items.";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} skal være mindre end {value} tegn.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} må ikke have mere end {value} elementer.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} skal være mindre eller lig med {value} tegn.";
        }
   public string MacAddress()
        {
            return $"{FieldName} skal være en gyldig MAC-adresse.";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} må ikke indeholde mere end {max} elementer.";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} må ikke være større end {max}.";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} må ikke være mere end {max} tegn.";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} skal indeholde mindst {min} elementer.";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} skal være mindst {min}.";
        }
      public string MinString(int min)
        {
            return $"{FieldName} skal være mindst {min} tegn.";
        }
      public string NotIn()
        {
            return $"Valgte {FieldName} er ugyldig.";
        }
       public string NotRegex()
        {
            return $"Formatet for {FieldName} er ugyldigt.";
        }
      public string Numeric()
        {
            return $"{FieldName} skal være et tal.";
        }
 public string Regex()
        {
            return $"{FieldName} formatet er ugyldigt.";
        }
       public string Required()
        {
            return $"{FieldName} skal udfyldes.";
        }
    public string Same(string name)
        {
            return $"{FieldName} og {name} skal være ens.";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} skal indeholde {size} elementer.";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} skal være {size} tegn lang.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} skal starte med én af følgende: {String.Join(", ", values)}.";
        }
 public string Uppercase()
        {
            return $"De {FieldName} skal være store bogstaver.";
        }
   public string Url()
        {
            return $"{FieldName} formatet er ugyldigt.";
        }
    }
        }