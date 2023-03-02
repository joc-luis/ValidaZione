using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Kn : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"ಈ  {FieldName}  ಒಪ್ಪಿಕೊಳ್ಳಬೇಕು.";
            }
public string ActiveUrl()
        {
            return $"ಈ  {FieldName} ಮಾನ್ಯ URL ಆಗಿಲ್ಲ.";
        }
public string After(string date)
        {
            return $"ಈ  {FieldName} ದಿನಾಂಕವು   {date} ನಂತರದ ದಿನಾಂಕವಾಗಿರಬೇಕು .";
        }
public string AfterOrEqual(string date)
        {
            return $"ಈ  {FieldName} ದಿನಾಂಕವು   {date} ನಂತರದ ಅಥವಾ ಸಮನಾದ ದಿನಾಂಕವಾಗಿರಬೇಕು.";
        }
 public string Alpha()
        {
            return $"ಈ  {FieldName} ಅಕ್ಷರಗಳನ್ನು ಮಾತ್ರ ಹೊಂದಿರಬಹುದು.";
        }
public string AlphaDash()
        {
            return $"ಈ  {FieldName} ಅಕ್ಷರಗಳು, ಸಂಖ್ಯೆಗಳು, ಡ್ಯಾಶ್ಗಳು ಮತ್ತು ಅಂಡರ್ಸ್ಕೋರ್ಗಳನ್ನು ಮಾತ್ರ ಹೊಂದಿರಬಹುದು.";
        }
public string AlphaNum()
        {
            return $"ಈ  {FieldName} ಅಕ್ಷರಗಳು ಮತ್ತು ಸಂಖ್ಯೆಗಳನ್ನು ಮಾತ್ರ ಹೊಂದಿರಬಹುದು.";
        }
public string Before(string date)
        {
            return $"ಈ  {FieldName} ದಿನಾಂಕವು  {date} ಮುಂಚಿನ  ದಿನಾಂಕವಾಗಿರಬೇಕು.";
        }
public string BeforeOrEqual(string date)
        {
            return $"ಈ  {FieldName} ದಿನಾಂಕವು  {date} ಮುಂಚಿನ  ಅಥವಾ ಸಮನಾದ ದಿನಾಂಕವಾಗಿರಬೇಕು.";
        }
public string BetweenArray(long min, long max)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ   {min} ಮತ್ತು {max} ಐಟಂಗಳ ನಡುವೆ ಇರಬೇಕು.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ  {min} ಮತ್ತು {max} ನಡುವೆ ಇರಬೇಕು.";
        }
public string BetweenString(int min, int max)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ  {min} ಮತ್ತು {max} ಅಕ್ಷರಗಳ ನಡುವೆ ಇರಬೇಕು.";
        }
public string Boolean()
        {
            return $"ಈ  {FieldName} ಕ್ಷೇತ್ರವು ನಿಜ ಅಥವಾ ಸುಳ್ಳು ಆಗಿರಬೇಕು.";
        }
public string Confirmed()
        {
            return $"ಈ  {FieldName} ದೃಢೀಕರಣವು ಹೊಂದಿಕೆಯಾಗುವುದಿಲ್ಲ.";
        }
public string Declined()
        {
            return $"{FieldName} ಅನ್ನು ನಿರಾಕರಿಸಬೇಕು.";
        }
public string Different(string name)
        {
            return $"ಈ  {FieldName} ಮತ್ತು {name} ವಿಭಿನ್ನವಾಗಿರಬೇಕು.";
        }
public string Distinct()
        {
            return $"ಈ  {FieldName} ಕ್ಷೇತ್ರವು ನಕಲಿ ಮೌಲ್ಯವನ್ನು ಹೊಂದಿದೆ.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} ಕೆಳಗಿನವುಗಳಲ್ಲಿ ಒಂದರಲ್ಲಿ ಕೊನೆಗೊಳ್ಳದಿರಬಹುದು: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} ಕೆಳಗಿನವುಗಳಲ್ಲಿ ಒಂದರಿಂದ ಪ್ರಾರಂಭವಾಗಬಾರದು: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"ಈ  {FieldName} ಮಾನ್ಯವಾದ ಇಮೇಲ್ ವಿಳಾಸವಾಗಿರಬೇಕು.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} ಕೆಳಗಿನವುಗಳಲ್ಲಿ ಒಂದರಲ್ಲಿ ಕೊನೆಗೊಳ್ಳಬೇಕು: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ  {value} ಐಟಂಗಳಿಗಿಂತ   ಹೆಚ್ಚು ಇರಬೇಕು.";
        }
public string GreaterThanString(int value)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ  {value} ಅಕ್ಷರಗಳಿಗಿಂತ   ಹೆಚ್ಚು ಇರಬೇಕು.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ   {value} ಐಟಂಗಳಿಗಿಂತ  ಹೆಚ್ಚು ಅಥವಾ ಸಮನಾಗಿರಬೇಕು  .";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ   {value} ಅಕ್ಷರಗಳಿಗಿಂತ  ಹೆಚ್ಚು ಅಥವಾ ಸಮನಾಗಿರಬೇಕು.";
        }
  public string In()
        {
            return $"ಈ  ಆಯ್ಕೆಮಾಡಲಾದ {FieldName} ಅಮಾನ್ಯವಾಗಿದೆ.";
        }
public string Integer()
        {
            return $"ಈ  {FieldName} ಒಂದು ಪೂರ್ಣಾಂಕವಾಗಿರಬೇಕು.";
        }
public string Ip()
        {
            return $"ಈ  {FieldName} ಮಾನ್ಯವಾದ IP ವಿಳಾಸವಾಗಿರಬೇಕು.";
        }
 public string Ipv4()
        {
            return $"ಈ  {FieldName} ಮಾನ್ಯವಾದ IPv4 ವಿಳಾಸವಾಗಿರಬೇಕು.";
        }
        public string Ipv6()
        {
            return $"ಈ  {FieldName} ಮಾನ್ಯವಾದ IPv6 ವಿಳಾಸವಾಗಿರಬೇಕು.";
        }
      public string Json()
        {
            return $"ಈ  {FieldName} ಮಾನ್ಯವಾದ JSON ಸ್ಟ್ರಿಂಗ್ ಆಗಿರಬೇಕು .";
        }
        public string Lowercase()
        {
            return $"{FieldName} ಚಿಕ್ಕದಾಗಿರಬೇಕು.";
        }
        public string LessThanArray(long value)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ  {value} ಐಟಂಗಳಿಗಿಂತ ಕಡಿಮೆ ಇರಬೇಕು.";
        }
    public string LessThanString(int value)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ  {value} ಅಕ್ಷರಗಳಿಗಿಂತ ಕಡಿಮೆ ಇರಬೇಕು.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ  {value} ಐಟಂಗಳಿಗಿಂತ  ಕಡಿಮೆ ಅಥವಾ ಸಮನಾಗಿರಬೇಕು .";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ  {value} ಅಕ್ಷರಗಳಿಗಿಂತ  ಕಡಿಮೆ ಅಥವಾ ಸಮನಾಗಿರಬೇಕು.";
        }
   public string MacAddress()
        {
            return $"{FieldName} ಮಾನ್ಯವಾದ MAC ವಿಳಾಸವಾಗಿರಬೇಕು.";
        }
      public string MaxArray(long max)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ  {max} ಐಟಂಗಳಿಗಿಂತ  ಹೆಚ್ಚು ಇರಬಾರದು .";
        }
      public string MaxNumeric(string max)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ  {max} ಗಿಂತ ಹೆಚ್ಚು ಇರಬಾರದು .";
        }
        public string MaxString(int max)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ  {max} ಅಕ್ಷರಗಳಿಗಿಂತ ಹೆಚ್ಚು ಇರಬಾರದು .";
        }
    public string MinArray(long min)
        {
            return $"ಈ  {FieldName} ಕನಿಷ್ಠ {min} ಐಟಂಗಳಿರಬೇಕು.";
        }
   public string MinNumeric(string min)
        {
            return $"ಈ  {FieldName} ಕನಿಷ್ಠ  {min}  ಇರಬೇಕು.";
        }
      public string MinString(int min)
        {
            return $"ಈ  {FieldName} ಕನಿಷ್ಠ {min} ಅಕ್ಷರಗಳಿರಬೇಕು.";
        }
      public string NotIn()
        {
            return $"ಈ  ಆಯ್ಕೆಮಾಡಲಾದ {FieldName} ಅಮಾನ್ಯವಾಗಿದೆ.";
        }
       public string NotRegex()
        {
            return $"ಈ  {FieldName} ಸ್ವರೂಪ ಅಮಾನ್ಯವಾಗಿದೆ.";
        }
      public string Numeric()
        {
            return $"ಈ  {FieldName} must be a number.";
        }
 public string Regex()
        {
            return $"ಈ  {FieldName} ಸ್ವರೂಪ ಅಮಾನ್ಯವಾಗಿದೆ.";
        }
       public string Required()
        {
            return $"ಈ  {FieldName} ಕ್ಷೇತ್ರ ಅಗತ್ಯವಿದೆ.";
        }
    public string Same(string name)
        {
            return $"ಈ  {FieldName} ಮತ್ತು {name} ಹೊಂದಾಣಿಕೆಯಾಗಲೇಬೇಕು.";
        }
       public string SizeArray(long size)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ   {size} ಐಟಂಗಳಿರಲೇಬೇಕು.";
        }
    public string SizeString(int size)
        {
            return $"ಈ  {FieldName} ನಲ್ಲಿ   {size} ಅಕ್ಷರಗಳಿರಲೇಬೇಕು.";
        }
public string StartsWith(List<string> values)
        {
            return $"ಈ  {FieldName} ಕೆಳಗಿನವುಗಳಲ್ಲಿ ಒಂದರಿಂದ  ಪ್ರಾರಂಭಿಸಬೇಕು :  {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"{FieldName} ದೊಡ್ಡಕ್ಷರವಾಗಿರಬೇಕು.";
        }
   public string Url()
        {
            return $"ಈ  {FieldName} ಸ್ವರೂಪವು ಅಮಾನ್ಯವಾಗಿದೆ.";
        }
    }
        }