using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Hi : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} को स्वीकार किया जाना चाहिए ।";
            }
public string ActiveUrl()
        {
            return $"{FieldName} एक मान्य URL नहीं है ।";
        }
public string After(string date)
        {
            return $"{FieldName}, {date} के बाद की एक तारीख होनी चाहिए ।";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName}, {date} के बाद या उसके बराबर की तारीख होनी चाहिए ।";
        }
 public string Alpha()
        {
            return $"{FieldName} में केवल अक्षर हो सकते हैं ।";
        }
public string AlphaDash()
        {
            return $"{FieldName} में केवल अक्षर, संख्या, और डैश हो सकते हैं ।";
        }
public string AlphaNum()
        {
            return $"{FieldName} में केवल अक्षर और संख्याएं हो सकती हैं ।";
        }
public string Before(string date)
        {
            return $"{FieldName}, {date} से पहले की एक तारीख होनी चाहिए ।";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName}, {date} इससे पहले या उसके बराबर की तारीख होनी चाहिए ।";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName}, {min} और {max} आइटमों के बीच होनी चाहिए ।";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName}, {min} और {max} के बीच होना चाहिए ।";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName}, {min} और {max} वर्णों के बीच होना चाहिए ।";
        }
public string Boolean()
        {
            return $"{FieldName} फील्ड सही या गलत होना चाहिए ।";
        }
public string Confirmed()
        {
            return $"{FieldName} पुष्टिकरण मेल नहीं खा रहा है।";
        }
public string Declined()
        {
            return $"{FieldName} को ज़रूर अस्वीकार किया जाना चाहिए ।";
        }
public string Different(string name)
        {
            return $"{FieldName} और {name} अलग होना चाहिए ।";
        }
public string Distinct()
        {
            return $"{FieldName} फील्ड का एक डुप्लिकेट मान होता है ।";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} निम्नलिखित में से किसी एक के साथ समाप्त नहीं हो सकता है: {String.Join(", ", values)} ।";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} निम्नलिखित में से किसी एक के साथ शुरू नहीं हो सकता है: {String.Join(", ", values)} ।";
        }
public string Email()
        {
            return $"{FieldName} एक मान्य ईमेल पता होना चाहिए ।";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} को निम्नलिखित में से एक के साथ समाप्त होना चाहिए: {String.Join(", ", values)} ।";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName}, {value} मद से अधिक होना चाहिए ।";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName}, {value} characters से अधिक होना चाहिए ।";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} में {value} आइटम या अधिक होना चाहिए ।";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} को {value} वर्णों से अधिक या उसके बराबर होना चाहिए।";
        }
  public string In()
        {
            return $"चुना गया {FieldName} अमान्य है ।";
        }
public string Integer()
        {
            return $"{FieldName} एक पूर्णांक होना चाहिए ।";
        }
public string Ip()
        {
            return $"{FieldName} एक मान्य IP address होना चाहिए ।";
        }
 public string Ipv4()
        {
            return $"{FieldName} एक वैध IPv4 address होना चाहिए ।";
        }
        public string Ipv6()
        {
            return $"{FieldName} एक वैध IPv6 address होना चाहिए ।";
        }
      public string Json()
        {
            return $"{FieldName} एक मान्य JSON स्ट्रिंग होना चाहिए ।";
        }
        public string Lowercase()
        {
            return $"{FieldName} लोअरकेस होना चाहिए।";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} में {value} आइटम से कम होना चाहिए ।";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} {value} अक्षरों से कम होना चाहिए ।";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} {value} आइटम से अधिक नहीं होना चाहिए ।";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} को {value} वर्णों से कम या उसके बराबर होना चाहिए।";
        }
   public string MacAddress()
        {
            return $"{FieldName} एक मान्य MAC address होना चाहिए ।";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName}, {max} आइटमों से अधिक नहीं हो सकता है ।";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName}, {max} से बड़ा नहीं हो सकता है ।";
        }
        public string MaxString(int max)
        {
            return $"{FieldName}, {max} वर्णों से बड़ा नहीं हो सकता है ।";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} कम से कम {min} आइटम होना चाहिए ।";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} कम से कम {min} होना चाहिए ।";
        }
      public string MinString(int min)
        {
            return $"{FieldName} कम से कम {min} वर्ण होना चाहिए ।";
        }
      public string NotIn()
        {
            return $"चुना गया {FieldName} अमान्य है ।";
        }
       public string NotRegex()
        {
            return $"{FieldName} प्रारूप अमान्य है ।";
        }
      public string Numeric()
        {
            return $"{FieldName} एक संख्या होनी चाहिए ।";
        }
 public string Regex()
        {
            return $"{FieldName} फॉर्मेट अमान्य है ।";
        }
       public string Required()
        {
            return $"{FieldName} फील्ड आवश्यक होता है ।";
        }
    public string Same(string name)
        {
            return $"{FieldName} और {name} मेल खाना चाहिए ।";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} में {size} आइटम होने चाहिए ।";
        }
    public string SizeString(int size)
        {
            return $"{FieldName}, {size} वर्ण होना चाहिए ।";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} निम्नलिखित में से किसी एक से शुरू करना चाहिए: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"{FieldName} अपरकेस होना चाहिए।";
        }
   public string Url()
        {
            return $"{FieldName} फॉर्मेट अमान्य है ।";
        }
    }
        }