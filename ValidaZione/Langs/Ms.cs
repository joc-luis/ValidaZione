using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Ms : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} mesti diterima pakai.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} bukan URL yang sah.";
        }
public string After(string date)
        {
            return $"{FieldName} mesti tarikh selepas {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} mesti tarikh selepas atau sama dengan {date}.";
        }
 public string Alpha()
        {
            return $"{FieldName} hanya boleh mengandungi huruf.";
        }
public string AlphaDash()
        {
            return $"{FieldName} boleh mengandungi huruf, nombor, dan sengkang.";
        }
public string AlphaNum()
        {
            return $"{FieldName} boleh mengandungi huruf dan nombor.";
        }
public string Before(string date)
        {
            return $"{FieldName} mesti tarikh sebelum {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} mesti tarikh sebelum atau sama dengan {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} mesti mengandungi antara {min} dan {max} perkara.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} mesti mengandungi antara {min} dan {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} mesti mengandungi antara {min} dan {max} aksara.";
        }
public string Boolean()
        {
            return $"{FieldName} mesti benar atau salah.";
        }
public string Confirmed()
        {
            return $"{FieldName} pengesahan yang tidak sepadan.";
        }
public string Declined()
        {
            return $"{FieldName} mesti ditolak.";
        }
public string Different(string name)
        {
            return $"{FieldName} dan {name} mesti berlainan.";
        }
public string Distinct()
        {
            return $"{FieldName} adalah nilai yang berulang";
        }
public string Email()
        {
            return $"{FieldName} tidak sah.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} mesti berakhir dengan salah satu dari: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} mesti mengandungi lebih daripada {value} perkara.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} mesti melebihi {value} aksara.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} mesti mengandungi {value} perkara atau lebih.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} mesti melebihi atau bersamaan {value} aksara.";
        }
  public string In()
        {
            return $"{FieldName} tidak sah.";
        }
public string Integer()
        {
            return $"{FieldName} mesti integer.";
        }
public string Ip()
        {
            return $"{FieldName} mesti alamat IP yang sah.";
        }
 public string Ipv4()
        {
            return $"{FieldName} mesti alamat IPv4 yang sah.";
        }
        public string Ipv6()
        {
            return $"{FieldName} mesti alamat IPv6 yang sah";
        }
      public string Json()
        {
            return $"{FieldName} mesti JSON yang sah.";
        }
        public string Lowercase()
        {
            return $"{FieldName} mestilah huruf kecil.";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} mesti mengandungi kurang daripada {value} perkara.";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} mesti kurang daripada {value} aksara.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} mesti mengandungi kurang daripada atau bersamaan dengan {value} perkara.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} mesti kurang daripada atau bersamaan dengan {value} aksara.";
        }
   public string MacAddress()
        {
            return $"{FieldName} mestilah alamat MAC yang sah.";
        }
      public string MaxArray(long max)
        {
            return $"Jumlah {FieldName} mesti tidak melebihi {max} perkara.";
        }
      public string MaxNumeric(string max)
        {
            return $"Jumlah {FieldName} mesti tidak melebihi {max}.";
        }
        public string MaxString(int max)
        {
            return $"Jumlah {FieldName} mesti tidak melebihi {max} aksara.";
        }
    public string MinArray(long min)
        {
            return $"Jumlah {FieldName} mesti sekurang-kurangnya {min} perkara.";
        }
   public string MinNumeric(string min)
        {
            return $"Jumlah {FieldName} mesti sekurang-kurangnya {min}.";
        }
      public string MinString(int min)
        {
            return $"Jumlah {FieldName} mesti sekurang-kurangnya {min} aksara.";
        }
      public string NotIn()
        {
            return $"{FieldName} tidak sah.";
        }
       public string NotRegex()
        {
            return $"Format {FieldName} adalah tidak sah.";
        }
      public string Numeric()
        {
            return $"{FieldName} mesti nombor.";
        }
 public string Regex()
        {
            return $"Format {FieldName} tidak sah.";
        }
       public string Required()
        {
            return $"Ruangan {FieldName} diperlukan.";
        }
    public string Same(string name)
        {
            return $"Ruangan {FieldName} dan {name} mesti sepadan.";
        }
       public string SizeArray(long size)
        {
            return $"Saiz {FieldName} mesti mengandungi :size perkara.";
        }
    public string SizeString(int size)
        {
            return $"Saiz {FieldName} mesti :size aksara.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} mesti bermula dengan salah satu dari: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"{FieldName} mestilah huruf besar.";
        }
   public string Url()
        {
            return $"{FieldName} format tidak sah.";
        }
    }
        }