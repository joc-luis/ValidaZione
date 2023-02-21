using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class He : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"שדה {FieldName} חייב להיות מסומן.";
            }
public string ActiveUrl()
        {
            return $"שדה {FieldName} הוא לא כתובת אתר תקנית.";
        }
public string After(string date)
        {
            return $"שדה {FieldName} חייב להיות תאריך אחרי {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"שדה {FieldName} חייב להיות תאריך מאוחר או שווה ל {date}.";
        }
 public string Alpha()
        {
            return $"שדה {FieldName} יכול להכיל אותיות בלבד.";
        }
public string AlphaDash()
        {
            return $"שדה {FieldName} יכול להכיל אותיות, מספרים ומקפים בלבד.";
        }
public string AlphaNum()
        {
            return $"שדה {FieldName} יכול להכיל אותיות ומספרים בלבד.";
        }
public string Before(string date)
        {
            return $"שדה {FieldName} חייב להיות תאריך לפני {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"שדה {FieldName} חייב להיות תאריך מוקדם או שווה ל {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"שדה {FieldName} חייב להיות בין {min} ל-{max} פריטים.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"שדה {FieldName} חייב להיות בין {min} ל-{max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"שדה {FieldName} חייב להיות בין {min} ל-{max} תווים.";
        }
public string Boolean()
        {
            return $"שדה {FieldName} חייב להיות אמת או שקר.";
        }
public string Confirmed()
        {
            return $"שדה האישור של {FieldName} לא תואם.";
        }
public string Declined()
        {
            return $"יש לדחות את ה-{FieldName}.";
        }
public string Different(string name)
        {
            return $"שדה {FieldName} ושדה {name} חייבים להיות שונים.";
        }
public string Distinct()
        {
            return $"שדה {FieldName} קיים ערך כפול.";
        }
public string Email()
        {
            return $"שדה {FieldName} חייב להיות כתובת אימייל תקנית.";
        }
public string EndsWith(List<string> values)
        {
            return $"שדה {FieldName} חייב להסתיים באחד מהבאים: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"על ה {FieldName} לכלול יותר מ- {value} פריטים.";
        }
public string GreaterThanString(int value)
        {
            return $"על ה {FieldName} להיות גדול יותר מ- {value} תווים.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"ה {FieldName} חייב לכלול {value} פריטים או יותר.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"על ה {FieldName} להיות גדול יותר או שווה ל- {value} תווים.";
        }
  public string In()
        {
            return $"בחירת ה-{FieldName} אינה תקפה.";
        }
public string Integer()
        {
            return $"שדה {FieldName} חייב להיות מספר שלם.";
        }
public string Ip()
        {
            return $"שדה {FieldName} חייב להיות כתובת IP תקנית.";
        }
 public string Ipv4()
        {
            return $"שדה {FieldName} חייב להיות כתובת IPv4 תקנית.";
        }
        public string Ipv6()
        {
            return $"שדה {FieldName} חייב להיות כתובת IPv6 תקנית.";
        }
      public string Json()
        {
            return $"שדה {FieldName} חייב להיות מחרוזת JSON תקנית.";
        }
        public string Lowercase()
        {
            return $"ה-{FieldName} חייב להיות באותיות קטנות.";
        }
        public string LessThanArray(long value)
        {
            return $"על ה {FieldName} לכלול פחות מ- {value} פריטים.";
        }
    public string LessThanString(int value)
        {
            return $"על ה {FieldName} להכיל פחות מ- {value} תווים.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"ה {FieldName} לא יכול לכלול יותר מאשר {value} פריטים.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"על ה {FieldName} להכיל {value} תווים או פחות.";
        }
   public string MacAddress()
        {
            return $"ה-{FieldName} חייבת להיות כתובת MAC חוקית.";
        }
      public string MaxArray(long max)
        {
            return $"שדה {FieldName} לא יכול להכיל יותר מ-{max} פריטים.";
        }
      public string MaxNumeric(string max)
        {
            return $"שדה {FieldName} אינו יכול להיות גדול מ-{max}.";
        }
        public string MaxString(int max)
        {
            return $"שדה {FieldName} לא יכול להיות גדול מ-{max} characters.";
        }
    public string MinArray(long min)
        {
            return $"שדה {FieldName} חייב להיות לפחות {min} פריטים.";
        }
   public string MinNumeric(string min)
        {
            return $"שדה {FieldName} חייב להיות לפחות {min}.";
        }
      public string MinString(int min)
        {
            return $"שדה {FieldName} חייב להיות לפחות {min} תווים.";
        }
      public string NotIn()
        {
            return $"בחירת ה-{FieldName} אינה תקפה.";
        }
       public string NotRegex()
        {
            return $"הפורמט של {FieldName} איננו חוקי.";
        }
      public string Numeric()
        {
            return $"שדה {FieldName} חייב להיות מספר.";
        }
 public string Regex()
        {
            return $"שדה {FieldName} בעל פורמט שאינו תקין.";
        }
       public string Required()
        {
            return $"שדה {FieldName} הוא חובה.";
        }
    public string Same(string name)
        {
            return $"שדה {FieldName} ו-{name} חייבים להיות זהים.";
        }
       public string SizeArray(long size)
        {
            return $"שדה {FieldName} חייב להכיל :size פריטים.";
        }
    public string SizeString(int size)
        {
            return $"שדה {FieldName} חייב להיות :size תווים.";
        }
public string StartsWith(List<string> values)
        {
            return $"ה {FieldName} חייב להתחיל עם אחד מהבאים: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"ה-{FieldName} חייב להיות רישיות.";
        }
   public string Url()
        {
            return $"שדה {FieldName} בעל פורמט שאינו תקין.";
        }
    }
        }