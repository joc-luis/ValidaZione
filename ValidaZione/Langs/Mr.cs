using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Mr : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} ला स्वीकार केला गेला पाहिजे.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} हा एक बरोबर URL नाही आहे.";
        }
public string After(string date)
        {
            return $"{FieldName}, {date} नंतरची एक तारीख पाहिजे.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName}, {date} हि किंवा त्या नंतरची एक तारीख पाहिजे.";
        }
 public string Alpha()
        {
            return $"{FieldName} मध्ये फक्त अक्षरे वैध आहेत.";
        }
public string AlphaDash()
        {
            return $"{FieldName} मध्ये फक्त अक्षरे, संख्या आणि डॅश वैध आहेत.";
        }
public string AlphaNum()
        {
            return $"{FieldName} मध्ये फक्त अक्षरे आणि संख्या वैध आहेत.";
        }
public string Before(string date)
        {
            return $"{FieldName}, {date} आधीची एक तारीख पाहिजे.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName}, {date} हि किंवा त्या आधीची एक तारीख पाहिजे.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName}, {min} किंवा {max} संख्या यामध्ये असावी.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName}, {min} किंवा {max} यामध्ये असावी.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName}, {min} किंवा {max} शब्द यामध्ये असावी.";
        }
public string Boolean()
        {
            return $"{FieldName} फील्ड योग्य किंवा चुकीचे असावे.";
        }
public string Confirmed()
        {
            return $"{FieldName} पुष्टीकरण जुळत नाही.";
        }
public string Declined()
        {
            return $"{FieldName} नाकारणे आवश्यक आहे.";
        }
public string Different(string name)
        {
            return $"{FieldName} आणि {name} वेगळे असावे.";
        }
public string Distinct()
        {
            return $"{FieldName} वेगवेगळे असावेत.";
        }
public string Email()
        {
            return $"{FieldName} एक वैध ईमेल पत्ता असणे आवश्यक आहे.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} खालील एक समाप्त करणे आवश्यक आहे: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName}, {value} संख्या पेक्षा जास्त असावी.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName}, {value} characters पेक्षा जास्त असावी.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName}, {value} संख्या पेक्षा मोठे किंवा समान असणे आवश्यक आहे.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName}, {value} शब्दांपेक्षा मोठे किंवा समान असणे आवश्यक आहे.";
        }
  public string In()
        {
            return $"{FieldName} अमान्य आहे.";
        }
public string Integer()
        {
            return $"{FieldName} एक पूर्णांक असणे आवश्यक आहे.";
        }
public string Ip()
        {
            return $"{FieldName} एक वैध IP address असावा.";
        }
 public string Ipv4()
        {
            return $"{FieldName} एक वैध IPv4 address असावा.";
        }
        public string Ipv6()
        {
            return $"{FieldName} एक वैध IPv6 address असावा.";
        }
      public string Json()
        {
            return $"{FieldName} एक वैध JSON स्ट्रिंग असावा.";
        }
        public string Lowercase()
        {
            return $"{FieldName} लोअरकेस असणे आवश्यक आहे.";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName}, {value} संख्या पेक्षा कमी असावी.";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName}, {value} वर्णांपेक्षा पेक्षा कमी असावी.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName}, {value} संख्या पेक्षा कमी किंवा समान असणे आवश्यक आहे.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName}, {value} शब्दांपेक्षा कमी किंवा समान असणे आवश्यक आहे.";
        }
   public string MacAddress()
        {
            return $"{FieldName} हा वैध MAC पत्ता असणे आवश्यक आहे.";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName}, {max} संख्या पेक्षा कमी असणे आवश्यक आहे.";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName}, {max} पेक्षा कमी असणे आवश्यक आहे.";
        }
        public string MaxString(int max)
        {
            return $"{FieldName}, {max} शब्दांपेक्षा कमी असणे आवश्यक आहे.";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} कमीत कमी {min} आइटम असावी.";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} कमीत कमी {min} असावी.";
        }
      public string MinString(int min)
        {
            return $"{FieldName} कमीत कमी {min} शब्द असावी.";
        }
      public string NotIn()
        {
            return $"घेतलेला {FieldName} वैध नाही.";
        }
       public string NotRegex()
        {
            return $"{FieldName} प्रारूप वैध नाही.";
        }
      public string Numeric()
        {
            return $"{FieldName} एक संख्या असावी.";
        }
 public string Regex()
        {
            return $"{FieldName} फॉर्मेट वैध नाही.";
        }
       public string Required()
        {
            return $"{FieldName} फील्ड आवश्यक आहे.";
        }
    public string Same(string name)
        {
            return $"{FieldName} आणि {name} सामान असावेत.";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} में :size आइटम असावी.";
        }
    public string SizeString(int size)
        {
            return $"{FieldName}, :size शब्द असावी.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} खालीलपैकी कोणत्याही अक्षराने सुरूवात करावी: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"{FieldName} अप्परकेस असणे आवश्यक आहे.";
        }
   public string Url()
        {
            return $"{FieldName} फॉर्मेट अमान्य आहे.";
        }
    }
        }