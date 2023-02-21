using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Ur : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} تسلیم کرنا لازمی ہے۔";
            }
public string ActiveUrl()
        {
            return $"{FieldName} قابلِ قبول یو آر ایل نہیں ہے۔";
        }
public string After(string date)
        {
            return $"{FieldName} لازماً {date} کے بعد کی کوئی تاریخ ہو۔";
        }
public string AfterOrEqual(string date)
        {
            return $"اس {FieldName} ہونا ضروری ہے ، ایک تاریخ کے بعد یا اس کے برابر {date}.";
        }
 public string Alpha()
        {
            return $"{FieldName} صرف حروفِ تہجی پر مشتمل ہو سکتا ہے۔";
        }
public string AlphaDash()
        {
            return $"{FieldName} صرف حروفِ تہجی، اعداد، ڈیشِز پر مشتمل ہو سکتا ہے۔";
        }
public string AlphaNum()
        {
            return $"{FieldName} میں صرف حروفِ تہجی و اعداد شامل ہو سکتے ہیں۔";
        }
public string Before(string date)
        {
            return $"{FieldName} لازماً {date} سے پہلے کی کوئی تاریخ ہو۔";
        }
public string BeforeOrEqual(string date)
        {
            return $"اس {FieldName} ہونا ضروری ہے ایک تاریخ سے پہلے یا اس کے برابر {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} لازماً {min} اور {max} آئٹمز کے درمیان ہو۔";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} لازماً {min} اور {max} کے درمیان ہو۔";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} لازماً {min} اور {max} کریکٹرز کے درمیان ہو۔";
        }
public string Boolean()
        {
            return $"{FieldName} لازماً درست یا غلط ہونا چاہیے۔";
        }
public string Confirmed()
        {
            return $"{FieldName} تصدیق سے مطابقت نہیں رکھتا۔";
        }
public string Declined()
        {
            return $"{FieldName} کو مسترد کر دینا چاہیے۔";
        }
public string Different(string name)
        {
            return $"{FieldName} اور {name} لازماً مختلف ہوں۔";
        }
public string Distinct()
        {
            return $"{FieldName} کی دہری ویلیو ہے۔";
        }
public string Email()
        {
            return $"{FieldName} لازماً قابلِ قبول ای میل ہو۔";
        }
public string EndsWith(List<string> values)
        {
            return $"اس {FieldName} ختم کرنا ضروری ہے کے ساتھ مندرجہ ذیل میں سے ایک: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} میں {value} سے زیادہ اشیاء ہونی چاہئیں۔";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} کو {value} حروف سے زیادہ ہونا چاہیے۔";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} میں {value} یا اس سے زیادہ اشیاء ہونی چاہئیں۔";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} کو {value} حروف سے زیادہ یا اس کے برابر ہونا چاہیے۔";
        }
  public string In()
        {
            return $"منتخب {FieldName} قابلِ قبول نہیں ہے۔";
        }
public string Integer()
        {
            return $"{FieldName} لازماً کوئی عدد ہو۔";
        }
public string Ip()
        {
            return $"{FieldName} لازماً قابلِ قبول آئی پی پتہ ہو۔";
        }
 public string Ipv4()
        {
            return $"اس {FieldName} ہونا ضروری ہے ایک درست IPv4 ایڈریس.";
        }
        public string Ipv6()
        {
            return $"اس {FieldName} ہونا ضروری ہے ایک درست IPv6 ایڈریس.";
        }
      public string Json()
        {
            return $"{FieldName} لازماً قابلِ قبول JSON سٹرِنگ ہو۔";
        }
        public string Lowercase()
        {
            return $"{FieldName} کو چھوٹا ہونا چاہیے۔";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} میں {value} سے کم اشیاء ہونی چاہئیں۔";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} {value} حروف سے کم ہونا چاہیے۔";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} میں {value} سے زیادہ اشیاء نہیں ہونی چاہئیں۔";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} کو {value} حروف سے کم یا اس کے برابر ہونا چاہیے۔";
        }
   public string MacAddress()
        {
            return $"{FieldName} ایک درست MAC پتہ ہونا چاہیے۔";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} میں {max} سے زیادہ آئٹمز نہیں ہو سکتیں۔";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} کو {max} سے بڑا نہیں ہونا چاہیے۔";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} کو {max} کریکٹرز سے زیادہ نہیں ہونا چاہیے۔";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} میں لازماً کم از کم {min} آئٹمز ہوں۔";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} لازماً کم از کم {min} ہو۔";
        }
      public string MinString(int min)
        {
            return $"{FieldName} لازماً کم از کم {min} کریکٹرز طویل ہو۔";
        }
      public string NotIn()
        {
            return $"منتخب {FieldName} قابلِ قبول نہیں ہے۔";
        }
       public string NotRegex()
        {
            return $"اس {FieldName} شکل باطل ہے.";
        }
      public string Numeric()
        {
            return $"{FieldName} لازماً کوئی عدد ہو۔";
        }
 public string Regex()
        {
            return $"{FieldName} قابلِ قبول فارمیٹ میں نہیں ہے۔";
        }
       public string Required()
        {
            return $"{FieldName} فیلڈ درکار ہے۔";
        }
    public string Same(string name)
        {
            return $"{FieldName} اور {name} لازماً ایک دوسرے سے مماثل ہوں۔";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} میں لازماً :size آئٹمز شامل ہوں۔";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} لازماً :size کریکٹرز پر مشتمل ہو۔";
        }
public string StartsWith(List<string> values)
        {
            return $"اس {FieldName} کے ساتھ شروع ہونا چاہئے مندرجہ ذیل میں سے ایک: {String.Join(", ", values)}.";
        }
 public string Uppercase()
        {
            return $"{FieldName} کا بڑا ہونا ضروری ہے۔";
        }
   public string Url()
        {
            return $"{FieldName} فارمیٹ قابلِ قبول نہیں ہے۔";
        }
    }
        }