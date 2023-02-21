using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Ps : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"باید ومنل شی {FieldName}.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} یو باوري لینک نه دی.";
        }
public string After(string date)
        {
            return $"باید{FieldName} تر نن ورځې نیټې پورې {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} باید وروستی نیټه وي یا د نیټې سره سمون ولري {date}.";
        }
 public string Alpha()
        {
            return $"دا باید شامل نه وي {FieldName} یوازې په حرفو کې.";
        }
public string AlphaDash()
        {
            return $"دا باید شامل نه وي {FieldName} یوازې په حرفو کې، شمیرې او متره.";
        }
public string AlphaNum()
        {
            return $"شمیرې او متره {FieldName} یوازې خطونه او شمیرې.";
        }
public string Before(string date)
        {
            return $"باید{FieldName} د تاریخ پخوا تاریخ وټاکئ {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} دا باید وي د تیر نیټې یا نیټې سره سمون خوري {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"شمیرې او متره {FieldName} د عناصرو په منځ کې {min} او {max}.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"دا باید ارزښت وي {FieldName} ما بين{min} او {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"د متن حروف باید باید وي {FieldName} ما بين{min} او {max}.";
        }
public string Boolean()
        {
            return $"دا باید ارزښت وي {FieldName} او یا هم true یا false .";
        }
public string Confirmed()
        {
            return $"د تایید ساحه د ساحې سره سمون نه لري{FieldName}.";
        }
public string Declined()
        {
            return $"{FieldName} باید رد شي.";
        }
public string Different(string name)
        {
            return $"ساحې باید وي {FieldName} و {name} مختلف.";
        }
public string Distinct()
        {
            return $"د ساحې څخه {FieldName} د نقل ارزښت .";
        }
public string Email()
        {
            return $"دا باید وي {FieldName} یو باوري بریښلیک پته جوړښت.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} باید د لاندې څخه یو سره پای ته ورسیږي: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"شمیرې او متره {FieldName} له زیاتو څخه {value} عناصر/عنصر.";
        }
public string GreaterThanString(int value)
        {
            return $"د متن اوږدوالی باید وي {FieldName} څخه زیات {value} توري/توري.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"شمیرې او متره {FieldName} لږ تر لږه {value} عنصر / عناصر.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"د متن اوږدوالی باید وي {FieldName} لږترلږه {value} توري/توري.";
        }
  public string In()
        {
            return $"{FieldName} غير موجود.";
        }
public string Integer()
        {
            return $"دا باید وي{FieldName} هو عدد صحيح.";
        }
public string Ip()
        {
            return $"دا باید وي{FieldName} عنوان IP ریښتیا.";
        }
 public string Ipv4()
        {
            return $"دا باید وي{FieldName} عنوان IPv4 ریښتیا.";
        }
        public string Ipv6()
        {
            return $"دا باید وي{FieldName} عنوان IPv6 ریښتیا.";
        }
      public string Json()
        {
            return $"دا باید وي{FieldName} د اوریدلو ډول JSON.";
        }
        public string Lowercase()
        {
            return $"{FieldName} باید کوچنی وي.";
        }
        public string LessThanArray(long value)
        {
            return $"شمیرې او متره {FieldName} له کم څخه {value} عناصر/عنصر.";
        }
    public string LessThanString(int value)
        {
            return $"د متن اوږدوالی باید وي {FieldName} له کم څخه {value} توري/توري.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"دا باید شامل نه وي {FieldName} له زیاتو څخه {value} عناصر/عنصر.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"د متن اوږدوالی باید له زیاتوالی نه وي{FieldName} {value} توري/توري.";
        }
   public string MacAddress()
        {
            return $"{FieldName} باید د اعتبار وړ MAC پته وي.";
        }
      public string MaxArray(long max)
        {
            return $"دا باید شامل نه وي {FieldName} له زیاتو څخه {max} عناصر/عنصر.";
        }
      public string MaxNumeric(string max)
        {
            return $"دا باید ارزښت وي {FieldName} نسبت برابر یا کوچنی {max}.";
        }
        public string MaxString(int max)
        {
            return $"د متن اوږدوالی باید له زیاتوالی نه وي{FieldName} {max} توري/توري.";
        }
    public string MinArray(long min)
        {
            return $"شمیرې او متره {FieldName} لږ تر لږه {min} عنصر / عناصر.";
        }
   public string MinNumeric(string min)
        {
            return $"دا باید ارزښت وي {FieldName} مساوی یا زیات {min}.";
        }
      public string MinString(int min)
        {
            return $"د متن اوږدوالی باید وي {FieldName} لږترلږه {min} توري/توري.";
        }
      public string NotIn()
        {
            return $"{FieldName} موجود.";
        }
       public string NotRegex()
        {
            return $"فورمول {FieldName} غلط.";
        }
      public string Numeric()
        {
            return $"باید{FieldName} یو شمېره.";
        }
 public string Regex()
        {
            return $"فورمول {FieldName} .غير صحيح.";
        }
       public string Required()
        {
            return $"{FieldName} اړینه ده.";
        }
    public string Same(string name)
        {
            return $"اړینه ده {FieldName} سره {name}.";
        }
       public string SizeArray(long size)
        {
            return $"شمیرې او متره {FieldName} په :size عنصر/عناصر په سمه توګه.";
        }
    public string SizeString(int size)
        {
            return $"شمیرې او متره متن {FieldName} په :size توري/توري په سمه توګه.";
        }
public string StartsWith(List<string> values)
        {
            return $"دا باید پیل شي {FieldName} د لاندې ارزښتونو څخه یو: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"{FieldName} باید لوی وي.";
        }
   public string Url()
        {
            return $"د لینک بڼه {FieldName} غلط.";
        }
    }
        }