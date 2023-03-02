using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Az : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} qəbul edilməlidir.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} düzgün URL deyil.";
        }
public string After(string date)
        {
            return $"{FieldName} {date} tarixindən sonrakı tarix olmalıdır.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} {date} tarixindən sonrakı və ya eyni tarixdə olmalıdır.";
        }
 public string Alpha()
        {
            return $"{FieldName} yalnız hərflərdən ibarət olmalıdır.";
        }
public string AlphaDash()
        {
            return $"{FieldName} yalnız hərflərdən, rəqəmlərdən, tire və alt xətlərdən ibarət olmalıdır.";
        }
public string AlphaNum()
        {
            return $"{FieldName} yalnız hərflərdən və rəqəmlərdən ibarət olmalıdır.";
        }
public string Before(string date)
        {
            return $"{FieldName} {date} tarixindən əvvəlki tarix olmalıdır.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} {date} tarixindən əvvəlki və ya ona bərabər olan bir tarix olmalıdır.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} elementlərinin sayı {min} ilə {max} arasında olmalıdır.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} {min} ilə {max} arasında olmalıdır.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} {min} ilə {max} simvol arasında olmalıdır.";
        }
public string Boolean()
        {
            return $"{FieldName} sahəsi doğru (true) və ya yalan (false) olmalıdır.";
        }
public string Confirmed()
        {
            return $"{FieldName} sahəsinin dəyəri təsdiqlənənlə uyğun gəlmir.";
        }
public string Declined()
        {
            return $"{FieldName} rədd edilməlidir.";
        }
public string Different(string name)
        {
            return $"{FieldName} və {name} fərqli olmalıdır.";
        }
public string Distinct()
        {
            return $"{FieldName} sahəsinin dəyərləri təkrarlanmamalıdır.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} aşağıdakılardan biri ilə bitməyə bilər: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName}  aşağıdakılardan biri ilə başlaya bilməz: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} düzgün e-poçt ünvanı olmalıdır.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} sahəsi göstərilən dəyərlərdən biri ilə bitməlidir: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} sahəsinin dəyəri {value} elementdən çox olmalıdır.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} sahəsinin dəyəri {value} simvoldan çox olmalıdır.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} {value} və ya daha çox elementdən ibarət olmalıdır.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} {value} və ya daha çox simvoldan ibarət olmalıdır.";
        }
  public string In()
        {
            return $"Seçilmiş {FieldName} yanlışdır.";
        }
public string Integer()
        {
            return $"{FieldName} tam ədəd olmalıdır.";
        }
public string Ip()
        {
            return $"{FieldName} düzgün IP ünvanı olmalıdır.";
        }
 public string Ipv4()
        {
            return $"{FieldName} düzgün IPv4 ünvanı olmalıdır.";
        }
        public string Ipv6()
        {
            return $"{FieldName} düzgün IPv6 ünvanı olmalıdır.";
        }
      public string Json()
        {
            return $"{FieldName} düzgün JSON sətri olmalıdır.";
        }
        public string Lowercase()
        {
            return $"{FieldName} kiçik hərf olmalıdır.";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} sahəsinin dəyəri {value} elementdən az olmalıdır.";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} sahəsinin dəyəri {value} simvoldan az olmalıdır.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} {value} və ya daha az elementdən ibarət olmalıdır.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} {value} və ya daha az simvoldan ibarət olmalıdır.";
        }
   public string MacAddress()
        {
            return $"{FieldName} düzgün MAC ünvanı olmalıdır.";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} ən çoxu {max} elementdən ibarət ola bilər.";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} dəyəri {max} sayından böyük ola bilməz.";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} ən çoxu {max} simvoldan ibarət ola bilər.";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} ən azı {min} elementdən ibarət olmalıdır.";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} {min} sayından kiçik ola bilməz.";
        }
      public string MinString(int min)
        {
            return $"{FieldName} ən azı {min} simvoldan ibarət olmalıdır.";
        }
      public string NotIn()
        {
            return $"Seçilmiş {FieldName} yanlışdır.";
        }
       public string NotRegex()
        {
            return $"{FieldName} sahəsinin formatı yanlışdır.";
        }
      public string Numeric()
        {
            return $"{FieldName} sahəsinin dəyəri rəqəm olmalıdır.";
        }
 public string Regex()
        {
            return $"{FieldName} sahəsinin formatı yanlışdır.";
        }
       public string Required()
        {
            return $"{FieldName} mütləq qeyd edilməlidir.";
        }
    public string Same(string name)
        {
            return $"{FieldName} ilə {name} sahəsinin dəyərləri üst-üstə düşməlidir.";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} sahəsi {size} elementdən ibarət olmalıdır.";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} {size} simvoldan ibarət olmalıdır.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} göstərilən dəyərlərdən biri ilə başlamalıdır: {String.Join(", ", values)}.";
        }
 public string Uppercase()
        {
            return $"{FieldName} böyük hərf olmalıdır.";
        }
   public string Url()
        {
            return $"{FieldName} düzgün URL olmalıdır.";
        }
    }
        }