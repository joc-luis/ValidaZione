using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Km : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} ត្រូវតែត្រូវបានទទួលយក។";
            }
public string ActiveUrl()
        {
            return $"{FieldName} មិនមែនជា URL ត្រឹមត្រូវឡើយ។";
        }
public string After(string date)
        {
            return $"{FieldName} ត្រូវតែមានកាលបរិច្ឆេទបន្ទាប់ពី {date}។";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} ត្រូវតែជាកាលបរិច្ឆេទ ក្រោយឬស្មើ {date}។";
        }
 public string Alpha()
        {
            return $"{FieldName} អាចមានអក្សរតែប៉ុណ្ណោះ។";
        }
public string AlphaDash()
        {
            return $"{FieldName} អាចមានតែអក្សរ លេខ និងសហសញ្ញា(-)។";
        }
public string AlphaNum()
        {
            return $"{FieldName} អាចមានតែអក្សរ និងលេខ។";
        }
public string Before(string date)
        {
            return $"{FieldName} ត្រូវតែមានកាលបរិច្ឆេទមុន {date}។";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} ត្រូវតែជាកាលបរិច្ឆេទ មុនឬស្មើ {date}។";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} ត្រូវតែមានចំនួនរវាង {min} និង {max}។";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} ត្រូវតែមានរវាង {min} និង {max}។";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} ត្រូវតែមានរវាង {min} និង {max} តួអក្សរ។";
        }
public string Boolean()
        {
            return $"{FieldName} ត្រូវតែជា ពិត ឬ មិនពិត";
        }
public string Confirmed()
        {
            return $"{FieldName} ការបញ្ជាក់មិនផ្គូរផ្គង។";
        }
public string Declined()
        {
            return $"{FieldName} ត្រូវតែត្រូវបានបដិសេធ។";
        }
public string Different(string name)
        {
            return $"{FieldName} និង {name} ត្រូវតែបញ្ជាក់។";
        }
public string Distinct()
        {
            return $"{FieldName} មានតម្លៃស្ទួន។";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} ប្រហែលជាមិនបញ្ចប់ដោយមួយក្នុងចំណោមដូចខាងក្រោម: {String.Join(", ", values)} ។";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} ប្រហែលជាមិនចាប់ផ្តើមជាមួយមួយក្នុងចំណោមដូចខាងក្រោម: {String.Join(", ", values)} ។";
        }
public string Email()
        {
            return $"{FieldName} ទម្រង់នេះមិនត្រឹមត្រូវ។";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} ត្រូវបញ្ចប់ដោយពាក្យមួយក្នុងចំណោម {String.Join(", ", values)}។";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} ត្រូវមានច្រើនជាង {value}។";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} ត្រូវតែធំជាង {value} តួអក្សរ។";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} ត្រូវមានចំនួន {value} ឬច្រើនជាង។";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} ត្រូវតែធំជាងឬស្មើ {value} តួអក្សរ។";
        }
  public string In()
        {
            return $"ការជ្រើសរើស {FieldName} មិនត្រឹមត្រូវ។";
        }
public string Integer()
        {
            return $"{FieldName} ត្រូវតែជាចំនួនគត់។";
        }
public string Ip()
        {
            return $"{FieldName} ត្រូវតែជា IP address ត្រឹមត្រូវ។";
        }
 public string Ipv4()
        {
            return $"{FieldName} ត្រូវតែជា IPv4 address ត្រឹមត្រូវ។";
        }
        public string Ipv6()
        {
            return $"{FieldName} ត្រូវតែជា IPv6 address ត្រឹមត្រូវ។";
        }
      public string Json()
        {
            return $"{FieldName} ត្រូវតែជា JSON string ត្រឹមត្រូវ។";
        }
        public string Lowercase()
        {
            return $"លេខ {FieldName} ត្រូវតែជាអក្សរតូច។";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} ត្រូវតែមានចំនួនតិចជាង {value}។";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} ត្រូវតែតិចជាង {value} តួអក្សរ។";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} ត្រូវមានចំនួនតិចជាង {value}។";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} ត្រូវតែតិចជាងឬស្មើ {value} តួអក្សរ។";
        }
   public string MacAddress()
        {
            return $"{FieldName} ត្រូវតែជាអាសយដ្ឋាន MAC ត្រឹមត្រូវ។";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} មិនត្រូវច្រើនជាងធាតុនេះ {max}។";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} មិនត្រូវធំជាង {max}។";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} មិនត្រូវធំជាង {max} តួអក្សរ។";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} ត្រូវតែតិចជាងធាតុនេះ {min}។";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} ត្រូវតែតូចជាង {min}។";
        }
      public string MinString(int min)
        {
            return $"{FieldName} ត្រូវតែតូចជាង {min} តួអក្សរ។";
        }
      public string NotIn()
        {
            return $"ការជ្រើសរើស {FieldName} គឺមិនត្រឹមត្រូវ។";
        }
       public string NotRegex()
        {
            return $"{FieldName} ទម្រង់ គឺមិនត្រឹមត្រូវ។";
        }
      public string Numeric()
        {
            return $"{FieldName} ត្រូវតែជាលេខ។";
        }
 public string Regex()
        {
            return $"{FieldName} ទម្រង់មិនត្រឹមត្រូវ។";
        }
       public string Required()
        {
            return $"{FieldName} នេះគឺទាមទារឲ្យមាន។";
        }
    public string Same(string name)
        {
            return $"{FieldName} និង {name} ត្រូវតែដូចគ្នា។";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} ត្រូវតែមានទំហំ {size}។";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} ត្រូវតែ {size} តួអក្សរ។";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} ត្រូវចាប់ផ្តើមដោយ {String.Join(", ", values)} ណាមួយ។";
        }
 public string Uppercase()
        {
            return $"លេខ {FieldName} ត្រូវតែជាអក្សរធំ។";
        }
   public string Url()
        {
            return $"{FieldName} ទម្រង់ត្រឹមត្រូវ។";
        }
    }
        }