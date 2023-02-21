using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Ka : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} უნდა იყოს მონიშნული.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} არ არის სწორი ბმული.";
        }
public string After(string date)
        {
            return $"{FieldName} უნდა იყოს თარიღი {date}-ის შემდეგ.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} უნდა იყოს თარიღი {date}-ის შემდეგ ან მისი ტოლი.";
        }
 public string Alpha()
        {
            return $"{FieldName} უნდა შეიცავდეს მხოლოდ ასოებს.";
        }
public string AlphaDash()
        {
            return $"{FieldName} უნდა შეიცავდეს მხოლოდ ასოებს, რიცხვებს, ტირეებს და ქვეტირეებს.";
        }
public string AlphaNum()
        {
            return $"{FieldName} უნდა შეიცავდეს მხოლოდ ასოებს და რიცხვებს.";
        }
public string Before(string date)
        {
            return $"{FieldName} უნდა იყოს თარიღი {date}-მდე.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} უნდა იყოს თარიღი {date}-მდე ან მისი ტოლი.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName}-ის რაოდენობა უნდა იყოს {min}-დან {max}-მდე.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} უნდა იყოს {min}-სა და {max}-ს შორის.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} უნდა იყოს {min}-სა და {max} სიმბოლოს შორის.";
        }
public string Boolean()
        {
            return $"{FieldName} ველი უნდა იყოს true ან false.";
        }
public string Confirmed()
        {
            return $"{FieldName}-ის დადასტურება არ ემთხვევა.";
        }
public string Declined()
        {
            return $"{FieldName} უნდა უარი თქვას.";
        }
public string Different(string name)
        {
            return $"{FieldName} და {name} არ უნდა ემთხვეოდეს ერთმანეთს.";
        }
public string Distinct()
        {
            return $"{FieldName}-ის ველს აქვს დუბლირებული მნიშვნელობა.";
        }
public string Email()
        {
            return $"{FieldName} უნდა იყოს სწორი ელ.ფოსტა.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} უნდა ბოლოვდებოდეს შემდეგიდან ერთ-ერთით: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} უნდა შეიცავდეს {value} ელემენტზე მეტს.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} უნდა შეიცავდეს {value} სიმბოლოზე მეტს.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} უნდა შეიცავდეს მინიმუმ {value} ელემენტს.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} უნდა შეიცავდეს მინიმუმ {value} სიმბოლოს.";
        }
  public string In()
        {
            return $"არჩეული {FieldName} არასწორია.";
        }
public string Integer()
        {
            return $"{FieldName} უნდა იყოს მთელი რიცხვი.";
        }
public string Ip()
        {
            return $"{FieldName} უნდა იყოს ვალიდური IP მისამართი.";
        }
 public string Ipv4()
        {
            return $"{FieldName} უნდა იყოს ვალიდური IPv4 მისამართი.";
        }
        public string Ipv6()
        {
            return $"{FieldName} უნდა იყოს ვალიდური IPv6 მისამართი.";
        }
      public string Json()
        {
            return $"{FieldName} უნდა იყოს სწორი JSON ტიპის.";
        }
        public string Lowercase()
        {
            return $"{FieldName} უნდა იყოს პატარა.";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} უნდა შეიცავდეს {value} ელემენტზე ნაკლებს.";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} უნდა შეიცავდეს {value} სიმბოლოზე ნაკლებს.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} უნდა შეიცავდეს მაქსიმუმ {value} ელემენტს.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} უნდა შეიცავდეს მაქსიმუმ {value} სიმბოლოს.";
        }
   public string MacAddress()
        {
            return $"{FieldName} უნდა იყოს სწორი MAC მისამართი.";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName}-ს არ უნდა ჰქონდეს {max} ელემენტზე მეტი.";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} არ უნდა აღემატებოდეს {max}-ს.";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} არ უნდა აღემატებოდეს {max} სიმბოლოს.";
        }
    public string MinArray(long min)
        {
            return $"{FieldName}-ს უნდა ჰქონდეს მინიმუმ {min} ელემენტი.";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} უნდა იყოს მინიმუმ {min}.";
        }
      public string MinString(int min)
        {
            return $"{FieldName} უნდა შეიცავდეს მინიმუმ {min} სიმბოლოს.";
        }
      public string NotIn()
        {
            return $"არჩეული {FieldName} არასწორია.";
        }
       public string NotRegex()
        {
            return $"{FieldName}-ის ფორმატი არასწორია.";
        }
      public string Numeric()
        {
            return $"{FieldName} უნდა იყოს რიცხვი.";
        }
 public string Regex()
        {
            return $"{FieldName}-ის ფორმატი არასწორია.";
        }
       public string Required()
        {
            return $"{FieldName}-ის ველი აუცილებელია.";
        }
    public string Same(string name)
        {
            return $"{FieldName} და {name} უნდა ემთხვეოდეს ერთმანეთს.";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} უნდა შეიცავდეს :size ელემენტს.";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} უნდა შედგებოდეს :size სიმბოლოსგან.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} უნდა იწყებოდეს შემდეგიდან ერთ-ერთით: {String.Join(", ", values)}.";
        }
 public string Uppercase()
        {
            return $"{FieldName} უნდა იყოს დიდი.";
        }
   public string Url()
        {
            return $"{FieldName}-ის ფორმატი არასწორია.";
        }
    }
        }