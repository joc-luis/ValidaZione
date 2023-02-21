using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Fa : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} باید پذیرفته شده باشد.";
            }
public string ActiveUrl()
        {
            return $"آدرس {FieldName} معتبر نیست.";
        }
public string After(string date)
        {
            return $"{FieldName} باید تاریخی بعد از {date} باشد.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} باید تاریخی بعد از {date}، یا مطابق با آن باشد.";
        }
 public string Alpha()
        {
            return $"{FieldName} باید فقط حروف الفبا باشد.";
        }
public string AlphaDash()
        {
            return $"{FieldName} باید فقط حروف الفبا، اعداد، خط تیره و زیرخط باشد.";
        }
public string AlphaNum()
        {
            return $"{FieldName} باید فقط حروف الفبا و اعداد باشد.";
        }
public string Before(string date)
        {
            return $"{FieldName} باید تاریخی قبل از {date} باشد.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} باید تاریخی قبل از {date}، یا مطابق با آن باشد.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} باید بین {min} و {max} آیتم باشد.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} باید بین {min} و {max} باشد.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} باید بین {min} و {max} کاراکتر باشد.";
        }
public string Boolean()
        {
            return $"فیلد {FieldName} فقط می‌تواند true و یا false باشد.";
        }
public string Confirmed()
        {
            return $"{FieldName} با فیلد تکرار مطابقت ندارد.";
        }
public string Declined()
        {
            return $"{FieldName} باید رد شده باشد.";
        }
public string Different(string name)
        {
            return $"{FieldName} و {name} باید از یکدیگر متفاوت باشند.";
        }
public string Distinct()
        {
            return $"فیلد {FieldName} مقدار تکراری دارد.";
        }
public string Email()
        {
            return $"{FieldName} باید یک ایمیل معتبر باشد.";
        }
public string EndsWith(List<string> values)
        {
            return $"فیلد {FieldName} باید با یکی از مقادیر زیر خاتمه یابد: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} باید بیشتر از {value} آیتم داشته باشد.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} باید بیشتر از {value} کاراکتر داشته باشد.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} باید بیشتر یا مساوی {value} آیتم داشته باشد.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} باید بیشتر یا مساوی {value} کاراکتر داشته باشد.";
        }
  public string In()
        {
            return $"{FieldName} انتخاب شده، معتبر نیست.";
        }
public string Integer()
        {
            return $"{FieldName} باید عدد صحیح باشد.";
        }
public string Ip()
        {
            return $"{FieldName} باید آدرس IP معتبر باشد.";
        }
 public string Ipv4()
        {
            return $"{FieldName} باید یک آدرس معتبر از نوع IPv4 باشد.";
        }
        public string Ipv6()
        {
            return $"{FieldName} باید یک آدرس معتبر از نوع IPv6 باشد.";
        }
      public string Json()
        {
            return $"فیلد {FieldName} باید یک رشته از نوع JSON باشد.";
        }
        public string Lowercase()
        {
            return $"فیلد {FieldName} باید با حروف کوچک باشد.";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} باید کمتر از {value} آیتم داشته باشد.";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} باید کمتر از {value} کاراکتر داشته باشد.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} باید کمتر یا مساوی {value} آیتم داشته باشد.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} باید کمتر یا مساوی {value} کاراکتر داشته باشد.";
        }
   public string MacAddress()
        {
            return $"{FieldName} باید یک مک آدرس صحیح باشد.";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} نباید بیشتر از {max} آیتم داشته باشد.";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} نباید بزرگتر از {max} باشد.";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} نباید بیشتر از {max} کاراکتر داشته باشد.";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} نباید کمتر از {min} آیتم داشته باشد.";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} نباید کوچکتر از {min} باشد.";
        }
      public string MinString(int min)
        {
            return $"{FieldName} نباید کمتر از {min} کاراکتر داشته باشد.";
        }
      public string NotIn()
        {
            return $"{FieldName} انتخاب شده، معتبر نیست.";
        }
       public string NotRegex()
        {
            return $"فرمت {FieldName} معتبر نیست.";
        }
      public string Numeric()
        {
            return $"{FieldName} باید عدد یا رشته‌ای از اعداد باشد.";
        }
 public string Regex()
        {
            return $"فرمت {FieldName} معتبر نیست.";
        }
       public string Required()
        {
            return $"فیلد {FieldName} الزامی است.";
        }
    public string Same(string name)
        {
            return $"{FieldName} و {name} باید همانند هم باشند.";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} باید شامل :size آیتم باشد.";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} باید برابر با :size کاراکتر باشد.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} باید با یکی از این ها شروع شود: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"فیلد {FieldName} باید با حروف بزرگ باشد.";
        }
   public string Url()
        {
            return $"{FieldName} معتبر نمی‌باشد.";
        }
    }
        }