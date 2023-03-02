using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Id : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} harus diterima.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} bukan URL yang valid.";
        }
public string After(string date)
        {
            return $"{FieldName} harus berisi tanggal setelah {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} harus berisi tanggal setelah atau sama dengan {date}.";
        }
 public string Alpha()
        {
            return $"{FieldName} hanya boleh berisi huruf.";
        }
public string AlphaDash()
        {
            return $"{FieldName} hanya boleh berisi huruf, angka, strip, dan garis bawah.";
        }
public string AlphaNum()
        {
            return $"{FieldName} hanya boleh berisi huruf dan angka.";
        }
public string Before(string date)
        {
            return $"{FieldName} harus berisi tanggal sebelum {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} harus berisi tanggal sebelum atau sama dengan {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} harus memiliki {min} sampai {max} anggota.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} harus bernilai antara {min} sampai {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} harus berisi antara {min} sampai {max} karakter.";
        }
public string Boolean()
        {
            return $"{FieldName} harus bernilai true atau false";
        }
public string Confirmed()
        {
            return $"Konfirmasi {FieldName} tidak cocok.";
        }
public string Declined()
        {
            return $"{FieldName} ini harus ditolak.";
        }
public string Different(string name)
        {
            return $"{FieldName} dan {name} harus berbeda.";
        }
public string Distinct()
        {
            return $"{FieldName} memiliki nilai yang duplikat.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} tidak boleh diakhiri dengan salah satu dari berikut ini: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} tidak boleh dimulai dengan salah satu dari berikut ini: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} harus berupa alamat surel yang valid.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} harus diakhiri salah satu dari berikut: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} harus memiliki lebih dari {value} anggota.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} harus berisi lebih besar dari {value} karakter.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} harus terdiri dari {value} anggota atau lebih.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} harus berisi lebih besar dari atau sama dengan {value} karakter.";
        }
  public string In()
        {
            return $"{FieldName} yang dipilih tidak valid.";
        }
public string Integer()
        {
            return $"{FieldName} harus berupa bilangan bulat.";
        }
public string Ip()
        {
            return $"{FieldName} harus berupa alamat IP yang valid.";
        }
 public string Ipv4()
        {
            return $"{FieldName} harus berupa alamat IPv4 yang valid.";
        }
        public string Ipv6()
        {
            return $"{FieldName} harus berupa alamat IPv6 yang valid.";
        }
      public string Json()
        {
            return $"{FieldName} harus berupa JSON string yang valid.";
        }
        public string Lowercase()
        {
            return $"{FieldName} harus berupa huruf kecil.";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} harus memiliki kurang dari {value} anggota.";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} harus berisi kurang dari {value} karakter.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} harus tidak lebih dari {value} anggota.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} harus berisi kurang dari atau sama dengan {value} karakter.";
        }
   public string MacAddress()
        {
            return $"{FieldName} harus berupa alamat MAC yang valid.";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} maksimal terdiri dari {max} anggota.";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} maksimal bernilai {max}.";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} maksimal berisi {max} karakter.";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} minimal terdiri dari {min} anggota.";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} minimal bernilai {min}.";
        }
      public string MinString(int min)
        {
            return $"{FieldName} minimal berisi {min} karakter.";
        }
      public string NotIn()
        {
            return $"{FieldName} yang dipilih tidak valid.";
        }
       public string NotRegex()
        {
            return $"Format {FieldName} tidak valid.";
        }
      public string Numeric()
        {
            return $"{FieldName} harus berupa angka.";
        }
 public string Regex()
        {
            return $"Format {FieldName} tidak valid.";
        }
       public string Required()
        {
            return $"{FieldName} wajib diisi.";
        }
    public string Same(string name)
        {
            return $"{FieldName} dan {name} harus sama.";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} harus mengandung {size} anggota.";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} harus berukuran {size} karakter.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} harus diawali salah satu dari berikut: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"{FieldName} harus berupa huruf kapital.";
        }
   public string Url()
        {
            return $"Format {FieldName} tidak valid.";
        }
    }
        }