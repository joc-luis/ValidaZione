using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Sr_Latn_ME : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Morate prihvatiti {FieldName} polje.";
            }
public string ActiveUrl()
        {
            return $"Polje {FieldName} nije link.";
        }
public string After(string date)
        {
            return $"Polje {FieldName} mora da bude poslije {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Polje {FieldName} mora da bude {date} ili kasniji datum.";
        }
 public string Alpha()
        {
            return $"Polje {FieldName} mora da sadrži samo slova.";
        }
public string AlphaDash()
        {
            return $"Polje {FieldName} može da sadrži samo slova, brojeve i povlake.";
        }
public string AlphaNum()
        {
            return $"Polje {FieldName} može da sadrži samo slova i brojeve.";
        }
public string Before(string date)
        {
            return $"Polje {FieldName} mora da bude datum prije {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Polje {FieldName} mora da bude {date} ili raniji datum.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Niz {FieldName} mora da ima najmanje {min}, a najviše {max} stavki.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Vrijednost {FieldName} mora da bude između {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Rečenica polja {FieldName} mora da ima najmanje {min} a najviše {max} znakova.";
        }
public string Boolean()
        {
            return $"Polje {FieldName} mora da bude tačno ili netačno.";
        }
public string Confirmed()
        {
            return $"Potvrda za polje {FieldName} se ne poklapa.";
        }
public string Declined()
        {
            return $"The {FieldName} must be declined.";
        }
public string Different(string name)
        {
            return $"Polje {FieldName} mora da ima različitu vrijednost od {name}.";
        }
public string Distinct()
        {
            return $"Polje {FieldName} nema jedinstvenu vrijednost.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"The {FieldName} may not end with one of the following: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"The {FieldName} may not start with one of the following: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Polje {FieldName} mora biti ispravna E-mail adresa.";
        }
public string EndsWith(List<string> values)
        {
            return $"Polje {FieldName} mora da se završi sa: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"Niz {FieldName} mora da sadrži više od {value} stavki.";
        }
public string GreaterThanString(int value)
        {
            return $"Polje {FieldName} mora da sadrži više od {value} znakova.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Niz {FieldName} mora da sadrži najmanje {value} stavki.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Polje {FieldName} mora da sadrži najmanje {value} znakova.";
        }
  public string In()
        {
            return $"Polje {FieldName} ne sadrži neku od predloženih vrijednosti.";
        }
public string Integer()
        {
            return $"Vrijednost polja {FieldName} mora da bude broj.";
        }
public string Ip()
        {
            return $"Polje {FieldName} mora da bude ispravna IP adresa.";
        }
 public string Ipv4()
        {
            return $"Polje {FieldName} mora da bude ispravna IPv4 adresa.";
        }
        public string Ipv6()
        {
            return $"Polje {FieldName} mora da bude ispravna IPv6 adresa.";
        }
      public string Json()
        {
            return $"Polje {FieldName} mora da bude u JSON formatu.";
        }
        public string Lowercase()
        {
            return $"The {FieldName} must be lowercase.";
        }
        public string LessThanArray(long value)
        {
            return $"Niz {FieldName} mora da sadrži manje od {value} stavki.";
        }
    public string LessThanString(int value)
        {
            return $"Polje {FieldName} mora da sadrži manje od {value} znakova.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"Niz {FieldName} mora da sadrži najviše {value} stavki.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"Polje {FieldName} mora da sadrži najviše {value} znakova.";
        }
   public string MacAddress()
        {
            return $"The {FieldName} must be a valid MAC address.";
        }
      public string MaxArray(long max)
        {
            return $"Niz {FieldName} mora da sadrži najviše {max} stavki.";
        }
      public string MaxNumeric(string max)
        {
            return $"Polje {FieldName} može da bude najviše {max}.";
        }
        public string MaxString(int max)
        {
            return $"Polje {FieldName} mora da sadrži najviše {max} znakova.";
        }
    public string MinArray(long min)
        {
            return $"Niz {FieldName} mora da sadrži najmanje {min} stavki.";
        }
   public string MinNumeric(string min)
        {
            return $"Polje {FieldName} može da bude najmanje {min}.";
        }
      public string MinString(int min)
        {
            return $"Polje {FieldName} mora da sadrži najmanje {min} znakova.";
        }
      public string NotIn()
        {
            return $"Polje {FieldName} sadrži neku od nedozvoljenih vrijednosti.";
        }
       public string NotRegex()
        {
            return $"Format polja {FieldName} nije ispravan.";
        }
      public string Numeric()
        {
            return $"Polje {FieldName} mora da bude broj.";
        }
 public string Regex()
        {
            return $"Format polja {FieldName} nije ispravan.";
        }
       public string Required()
        {
            return $"Morate da popunite polje {FieldName}.";
        }
    public string Same(string name)
        {
            return $"Polje {FieldName} ovog polja se mora poklopiti sa jednim od sledećeg: {name}.";
        }
       public string SizeArray(long size)
        {
            return $"Niz {FieldName} mora da sadrži tačno {size} stavki.";
        }
    public string SizeString(int size)
        {
            return $"Polje {FieldName} mora da sadrži tačno {size} znakova.";
        }
public string StartsWith(List<string> values)
        {
            return $"Polje {FieldName} mora da počne sa: {String.Join(", ", values)}.";
        }
 public string Uppercase()
        {
            return $"The {FieldName} must be uppercase.";
        }
   public string Url()
        {
            return $"Polje {FieldName} nije link.";
        }
    }
        }