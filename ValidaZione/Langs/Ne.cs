using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Ne : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} स्वीकार गरिएको हुनुपर्छ।";
            }
public string ActiveUrl()
        {
            return $"{FieldName} URL अमान्य छ।";
        }
public string After(string date)
        {
            return $"{FieldName} को मिति {date} भन्दा पछि हुनुपर्छ।";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} मिति पछाडि वा बराबर मिति हुनुपर्दछ।";
        }
 public string Alpha()
        {
            return $"{FieldName} मा अक्षरहरु मात्र हुनसक्छ।";
        }
public string AlphaDash()
        {
            return $"{FieldName} मा अक्षर, संख्या र ड्यासहरू मात्र हुनसक्छ।";
        }
public string AlphaNum()
        {
            return $"{FieldName} मा अक्षर र संख्याहरू मात्र हुनसक्छ।";
        }
public string Before(string date)
        {
            return $"{FieldName} को मिति {date} भन्दा अघि हुनुपर्छ।";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} मिति भन्दा अघि वा बराबर {date} हुनुपर्दछ।";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} आइटमको संख्या {min} र {max} को बिचमा हुनुपर्छ।";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} {min} र {max}को बिचमा हुनुपर्छ।";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} {min} र {max} वर्णको बिचमा हुनुपर्छ।";
        }
public string Boolean()
        {
            return $"{FieldName} ठिक अथवा बेठिक हुनुपर्छ।";
        }
public string Confirmed()
        {
            return $"{FieldName} दाेहाेर्याइएकाे मिलेन।";
        }
public string Declined()
        {
            return $"{FieldName} लाई अस्वीकार गर्नुपर्छ।";
        }
public string Different(string name)
        {
            return $"{FieldName} र {name} फरक हुनुपर्छ।";
        }
public string Distinct()
        {
            return $"{FieldName} फिल्ड फिल्डको नक्कल मान छ";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} निम्न मध्ये एक संग समाप्त नहुन सक्छ: {String.Join(", ", values)}।";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} निम्न मध्ये एकबाट सुरु नहुन सक्छ: {String.Join(", ", values)}।";
        }
public string Email()
        {
            return $"{FieldName} को इमेल ठेगाना मिलेन।";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} निम्न मध्ये एकको साथ विशेषता अन्त हुनुपर्दछ {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} {value} आईटमहरू भन्दा बढि हुनुपर्दछ।";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} {value} क्यारेक्टर भन्दा बढि हुनुपर्दछ।";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} {value} आईटमहरू भन्दा बढि हुनुपर्दछ।";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} {value} क्यारेक्टर भन्दा बढि हुनुपर्दछ।";
        }
  public string In()
        {
            return $"छानिएको {FieldName} अमान्य छ।";
        }
public string Integer()
        {
            return $"{FieldName} पूर्ण संख्या हुनुपर्छ।";
        }
public string Ip()
        {
            return $"{FieldName} मा दिइएको मान्य IP ठेगाना हुनुपर्छ।";
        }
 public string Ipv4()
        {
            return $"{FieldName} एक मान्य IPv4 ठेगाना हुनुपर्दछ.";
        }
        public string Ipv6()
        {
            return $"{FieldName} एक मान्य IPv6 ठेगाना हुनुपर्दछ.";
        }
      public string Json()
        {
            return $"{FieldName} मा दिइएको मान्य JSON स्ट्रिङ्ग हुनुपर्छ।";
        }
        public string Lowercase()
        {
            return $"{FieldName} लोअरकेस हुनुपर्छ।";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} {value} आईटमहरू भन्दा बढि हुनुपर्दछ।";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} {value} क्यारेक्टर भन्दा बढि हुनुपर्दछ।";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} {value} आईटमहरू भन्दा बढि हुनुपर्दछ।";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} {value} क्यारेक्टर भन्दा बढि हुनुपर्दछ।";
        }
   public string MacAddress()
        {
            return $"{FieldName} मान्य MAC ठेगाना हुनुपर्छ।";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} मा {max} आईटमहरू भन्दा बढि हुनुपर्दछ।";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} {max} भन्दा बढि हुनुपर्दछ।";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} {max} क्यारेक्टर भन्दा बढि हुनुपर्दछ।";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} मा कम्तिमा {min} आइटम हुनुपर्छ।";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} कम्तिमा {min} हुनुपर्छ।";
        }
      public string MinString(int min)
        {
            return $"{FieldName} कम्तिमा {min} वर्णको हुनुपर्छ।";
        }
      public string NotIn()
        {
            return $"छानिएको {FieldName} अमान्य छ।";
        }
       public string NotRegex()
        {
            return $"{FieldName} ढाँचा अवैध छ.";
        }
      public string Numeric()
        {
            return $"{FieldName} संख्या हुनुपर्छ।";
        }
 public string Regex()
        {
            return $"{FieldName} को ढाँचा मिलेन।";
        }
       public string Required()
        {
            return $"{FieldName} दिइएको हुनुपर्छ।";
        }
    public string Same(string name)
        {
            return $"{FieldName} र {name} मिल्नुपर्छ।";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} {size}मा आइटम हुनुपर्छ।";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} {size} वर्णको हुनुपर्छ।.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} निम्न मध्ये एकसँग सुरू हुनुपर्दछ {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"१०० अपरकेस हुनुपर्छ।";
        }
   public string Url()
        {
            return $"{FieldName} को ढांचा मिलेन।";
        }
    }
        }