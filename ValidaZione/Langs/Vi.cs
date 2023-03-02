using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Vi : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Trường {FieldName} phải được chấp nhận.";
            }
public string ActiveUrl()
        {
            return $"Trường {FieldName} không phải là một URL hợp lệ.";
        }
public string After(string date)
        {
            return $"Trường {FieldName} phải là một ngày sau ngày {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Trường {FieldName} phải là thời gian bắt đầu sau hoặc đúng bằng {date}.";
        }
 public string Alpha()
        {
            return $"Trường {FieldName} chỉ có thể chứa các chữ cái.";
        }
public string AlphaDash()
        {
            return $"Trường {FieldName} chỉ có thể chứa chữ cái, số và dấu gạch ngang.";
        }
public string AlphaNum()
        {
            return $"Trường {FieldName} chỉ có thể chứa chữ cái và số.";
        }
public string Before(string date)
        {
            return $"Trường {FieldName} phải là một ngày trước ngày {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Trường {FieldName} phải là thời gian bắt đầu trước hoặc đúng bằng {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Trường {FieldName} phải có từ {min} - {max} phần tử.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Trường {FieldName} phải nằm trong khoảng {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Trường {FieldName} phải từ {min} - {max} kí tự.";
        }
public string Boolean()
        {
            return $"Trường {FieldName} phải là true hoặc false.";
        }
public string Confirmed()
        {
            return $"Giá trị xác nhận trong trường {FieldName} không khớp.";
        }
public string Declined()
        {
            return $"Trường {FieldName} phải bị từ chối.";
        }
public string Different(string name)
        {
            return $"Trường {FieldName} và {name} phải khác nhau.";
        }
public string Distinct()
        {
            return $"Trường {FieldName} có giá trị trùng lặp.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"Trường {FieldName} không được kết thúc bằng một trong những điều kiện sau: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"Trường {FieldName} không được bắt đầu bằng một trong những điều sau: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Trường {FieldName} phải là một địa chỉ email hợp lệ.";
        }
public string EndsWith(List<string> values)
        {
            return $"Trường {FieldName} phải kết thúc bằng một trong những giá trị sau: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"Mảng {FieldName} phải có nhiều hơn {value} phần tử.";
        }
public string GreaterThanString(int value)
        {
            return $"Độ dài trường {FieldName} phải nhiều hơn {value} kí tự.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Mảng {FieldName} phải có ít nhất {value} phần tử.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Độ dài trường {FieldName} phải lớn hơn hoặc bằng {value} kí tự.";
        }
  public string In()
        {
            return $"Giá trị đã chọn trong trường {FieldName} không hợp lệ.";
        }
public string Integer()
        {
            return $"Trường {FieldName} phải là một số nguyên.";
        }
public string Ip()
        {
            return $"Trường {FieldName} phải là một địa chỉ IP.";
        }
 public string Ipv4()
        {
            return $"Trường {FieldName} phải là một địa chỉ IPv4.";
        }
        public string Ipv6()
        {
            return $"Trường {FieldName} phải là một địa chỉ IPv6.";
        }
      public string Json()
        {
            return $"Trường {FieldName} phải là một chuỗi JSON.";
        }
        public string Lowercase()
        {
            return $"Trường {FieldName} phải là chữ thường.";
        }
        public string LessThanArray(long value)
        {
            return $"Mảng {FieldName} phải có ít hơn {value} phần tử.";
        }
    public string LessThanString(int value)
        {
            return $"Độ dài trường {FieldName} phải nhỏ hơn {value} kí tự.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"Mảng {FieldName} không được có nhiều hơn {value} phần tử.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"Độ dài trường {FieldName} phải nhỏ hơn hoặc bằng {value} kí tự.";
        }
   public string MacAddress()
        {
            return $"Trường {FieldName} phải là một địa chỉ MAC hợp lệ.";
        }
      public string MaxArray(long max)
        {
            return $"Trường {FieldName} không được lớn hơn {max} phần tử.";
        }
      public string MaxNumeric(string max)
        {
            return $"Trường {FieldName} không được lớn hơn {max}.";
        }
        public string MaxString(int max)
        {
            return $"Trường {FieldName} không được lớn hơn {max} kí tự.";
        }
    public string MinArray(long min)
        {
            return $"Trường {FieldName} phải có tối thiểu {min} phần tử.";
        }
   public string MinNumeric(string min)
        {
            return $"Trường {FieldName} phải tối thiểu là {min}.";
        }
      public string MinString(int min)
        {
            return $"Trường {FieldName} phải có tối thiểu {min} kí tự.";
        }
      public string NotIn()
        {
            return $"Giá trị đã chọn trong trường {FieldName} không hợp lệ.";
        }
       public string NotRegex()
        {
            return $"Trường {FieldName} có định dạng không hợp lệ.";
        }
      public string Numeric()
        {
            return $"Trường {FieldName} phải là một số.";
        }
 public string Regex()
        {
            return $"Trường {FieldName} có định dạng không hợp lệ.";
        }
       public string Required()
        {
            return $"Trường {FieldName} không được bỏ trống.";
        }
    public string Same(string name)
        {
            return $"Trường {FieldName} và {name} phải giống nhau.";
        }
       public string SizeArray(long size)
        {
            return $"Trường {FieldName} phải chứa {size} phần tử.";
        }
    public string SizeString(int size)
        {
            return $"Trường {FieldName} phải chứa {size} kí tự.";
        }
public string StartsWith(List<string> values)
        {
            return $"Trường {FieldName} phải được bắt đầu bằng một trong những giá trị sau: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"Trường {FieldName} phải là chữ in hoa.";
        }
   public string Url()
        {
            return $"Trường {FieldName} không giống với định dạng một URL.";
        }
    }
        }