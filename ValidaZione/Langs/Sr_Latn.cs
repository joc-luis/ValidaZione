using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Sr_Latn : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Polje {FieldName} mora biti prihvaćeno.";
            }
public string ActiveUrl()
        {
            return $"Polje {FieldName} nije validan URL.";
        }
public string After(string date)
        {
            return $"Polje {FieldName} mora biti datum posle {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Polje {FieldName} mora da bude {date} ili kasniji datum.";
        }
 public string Alpha()
        {
            return $"Polje {FieldName} može sadržati samo slova.";
        }
public string AlphaDash()
        {
            return $"Polje {FieldName} može sadržati samo slova, brojeve i povlake.";
        }
public string AlphaNum()
        {
            return $"Polje {FieldName} može sadržati samo slova i brojeve.";
        }
public string Before(string date)
        {
            return $"Polje {FieldName} mora biti datum pre {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} mora da bude {date} ili raniji datum.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Polje {FieldName} mora biti između {min} - {max} stavki.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Polje {FieldName} mora biti između {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Polje {FieldName} mora biti između {min} - {max} karaktera.";
        }
public string Boolean()
        {
            return $"Polje {FieldName} mora biti tačno ili netačno";
        }
public string Confirmed()
        {
            return $"Potvrda polja {FieldName} se ne poklapa.";
        }
public string Declined()
        {
            return $"The {FieldName} must be declined.";
        }
public string Different(string name)
        {
            return $"Polja {FieldName} i {name} moraju biti različita.";
        }
public string Distinct()
        {
            return $"Polje {FieldName} ima dupliranu vrednost.";
        }
public string Email()
        {
            return $"Format polja {FieldName} nije validan.";
        }
public string EndsWith(List<string> values)
        {
            return $"Polje {FieldName} mora da se završi sa nečim od sledećeg: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"Polje {FieldName} mora da sadrži više od {value} stavke.";
        }
public string GreaterThanString(int value)
        {
            return $"Polje {FieldName} mora da sadrži više od {value} znakova.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Polje {FieldName} mora da sadrži {value} stavki ili više.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Polje {FieldName} mora da sadrži {value} ili više znakova.";
        }
  public string In()
        {
            return $"Polje Odabrano polje {FieldName} nije validno.";
        }
public string Integer()
        {
            return $"Polje {FieldName} mora biti broj.";
        }
public string Ip()
        {
            return $"Polje {FieldName} mora biti validna IP adresa.";
        }
 public string Ipv4()
        {
            return $"Polje {FieldName} mora da bude važeća IPv4 adresa.";
        }
        public string Ipv6()
        {
            return $"Polje {FieldName} mora da bude važeća IPv6 adresa.";
        }
      public string Json()
        {
            return $"Polje {FieldName} mora da bude važeća JSON niska.";
        }
        public string Lowercase()
        {
            return $"The {FieldName} must be lowercase.";
        }
        public string LessThanArray(long value)
        {
            return $"Polje {FieldName} mora da sadrži manje od {value} stavki.";
        }
    public string LessThanString(int value)
        {
            return $"Polje {FieldName} mora da sadrži manje od {value} znakova.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"Polje {FieldName} ne sme da sadrži više od {value} stavki.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"Polje {FieldName} mora da sadrži {value} ili manje znakova.";
        }
   public string MacAddress()
        {
            return $"The {FieldName} must be a valid MAC address.";
        }
      public string MaxArray(long max)
        {
            return $"Polje {FieldName} ne smije da image više od {max} stavki.";
        }
      public string MaxNumeric(string max)
        {
            return $"Polje {FieldName} mora biti manje od {max}.";
        }
        public string MaxString(int max)
        {
            return $"Polje {FieldName} mora sadržati manje od {max} karaktera.";
        }
    public string MinArray(long min)
        {
            return $"Polje {FieldName} mora sadrzati najmanje {min} stavku.";
        }
   public string MinNumeric(string min)
        {
            return $"Polje {FieldName} mora biti najmanje {min}.";
        }
      public string MinString(int min)
        {
            return $"Polje {FieldName} mora sadržati najmanje {min} karaktera.";
        }
      public string NotIn()
        {
            return $"Odabrani element polja {FieldName} nije validan.";
        }
       public string NotRegex()
        {
            return $"Format {FieldName} je nevažeći.";
        }
      public string Numeric()
        {
            return $"Polje {FieldName} mora biti broj.";
        }
 public string Regex()
        {
            return $"Format polja {FieldName} nije validan.";
        }
       public string Required()
        {
            return $"Polje {FieldName} je obavezno.";
        }
    public string Same(string name)
        {
            return $"Polja {FieldName} i {name} se moraju poklapati.";
        }
       public string SizeArray(long size)
        {
            return $"Polje {FieldName} mora sadržati :size stavki.";
        }
    public string SizeString(int size)
        {
            return $"Polje {FieldName} mora biti :size karaktera.";
        }
public string StartsWith(List<string> values)
        {
            return $"Polje {FieldName} mora da počne sa: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"The {FieldName} must be uppercase.";
        }
   public string Url()
        {
            return $"Format polja {FieldName} ne važi.";
        }
    }
        }