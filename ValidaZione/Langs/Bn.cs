using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Bn : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} গ্রহণ করা আবশ্যক।";
            }
public string ActiveUrl()
        {
            return $"এই {FieldName} একটি বৈধ URL নয়।";
        }
public string After(string date)
        {
            return $":Date অবশ্যই {FieldName} এর পরের একটি তারিখ হতে হবে।";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} টি অবশ্যই {date} এর সাথে মিল অথবা এর পরের একটি তারিখ হতে হবে।";
        }
 public string Alpha()
        {
            return $"{FieldName} শুধুমাত্র অক্ষর থাকতে পারে।";
        }
public string AlphaDash()
        {
            return $"{FieldName} শুধুমাত্র অক্ষর, সংখ্যা, এবং ড্যাশ থাকতে পারে।";
        }
public string AlphaNum()
        {
            return $"{FieldName} শুধুমাত্র বর্ণ ও সংখ্যা থাকতে পারে।";
        }
public string Before(string date)
        {
            return $":Date অবশ্যই {FieldName} এর আগের একটি তারিখ হতে হবে।";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} টি অবশ্যই {date} এর সাথে মিল অথবা এর আগের একটি তারিখ হতে হবে।";
        }
public string BetweenArray(long min, long max)
        {
            return $":Min এবং {max} আইটেম {FieldName} মধ্যে হতে হবে।";
        }
public string BetweenNumeric(string min, string max)
        {
            return $":Min এবং {max} {FieldName} মধ্যে হতে হবে।";
        }
public string BetweenString(int min, int max)
        {
            return $":Min এবং {max} অক্ষর {FieldName} মধ্যে হতে হবে।";
        }
public string Boolean()
        {
            return $"{FieldName} স্থানে  সত্য বা মিথ্যা হতে হবে।";
        }
public string Confirmed()
        {
            return $"{FieldName} নিশ্চিতকরণ এর  সাথে মিলছে না।";
        }
public string Declined()
        {
            return $"{FieldName} অবশ্যই প্রত্যাখ্যান করতে হবে।";
        }
public string Different(string name)
        {
            return $"{FieldName} এবং {name} আলাদা হতে হবে।";
        }
public string Distinct()
        {
            return $"{FieldName} এর স্থানে একটি নকল মান আছে।";
        }
public string Email()
        {
            return $"{FieldName} একটি বৈধ ইমেইল ঠিকানা হতে হবে।";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} নিম্নলিখিত এক সঙ্গে শেষ করতে হবে: {String.Join(", ", values)}।";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} এ অবশ্যই {value} আইটেমের থেকে বেশি থাকতে হবে।";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} অবশ্যই {value} অক্ষরের চেয়ে বড় হতে হবে।";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName}-এর অবশ্যই {value} আইটেম বা তার বেশি থাকতে হবে।";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} অবশ্যই {value} অক্ষরের চেয়ে বড় বা সমান হতে হবে।";
        }
  public string In()
        {
            return $"নির্বাচিত {FieldName} টি অবৈধ।";
        }
public string Integer()
        {
            return $"{FieldName} একটি পূর্ণসংখ্যা হতে হবে।";
        }
public string Ip()
        {
            return $"{FieldName} একটি বৈধ  IP address হতে হবে।";
        }
 public string Ipv4()
        {
            return $"{FieldName} টি একটি বৈধ IPv4 address হতে হবে।";
        }
        public string Ipv6()
        {
            return $"{FieldName} টি একটি বৈধ IPv6 address হতে হবে।";
        }
      public string Json()
        {
            return $"{FieldName} একটি বৈধ JSON স্ট্রিং হতে হবে।";
        }
        public string Lowercase()
        {
            return $"{FieldName} অবশ্যই ছোট হাতের হতে হবে।";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} এর থেকে কম {value} আইটেম থাকতে হবে।";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} অবশ্যই {value} অক্ষরের চেয়ে কম হতে হবে।";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} এ অবশ্যই {value} আইটেমের বেশি থাকা উচিত নয়৷";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} অবশ্যই {value} অক্ষরের চেয়ে কম বা সমান হতে হবে।";
        }
   public string MacAddress()
        {
            return $"{FieldName} একটি বৈধ MAC ঠিকানা হতে হবে।";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} এর মান {max} টি উপাদানের চেয়ে বড় হতে পারেনা।";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} এর মান {max} এর চেয়ে বড় হতে পারেনা।";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} এর মান {max} অক্ষর এর চেয়ে বড় হতে পারেনা।";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} অবশ্যই {min} উপাদানের চেয়ে ছোট হতে হবে।";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} অবশ্যই {min} এর চেয়ে ছোট হতে হবে।";
        }
      public string MinString(int min)
        {
            return $"{FieldName} অবশ্যই {min} অক্ষর এর চেয়ে ছোট হতে হবে।";
        }
      public string NotIn()
        {
            return $"নির্বাচিত {FieldName} অবৈধ।";
        }
       public string NotRegex()
        {
            return $"{FieldName} বিন্যাস অবৈধ।";
        }
      public string Numeric()
        {
            return $"{FieldName} একটি সংখ্যা হতে হবে।";
        }
 public string Regex()
        {
            return $"{FieldName} বিন্যাস অবৈধ।";
        }
       public string Required()
        {
            return $"{FieldName} স্থানটি পূরণ করা বাধ্যতামূলক।";
        }
    public string Same(string name)
        {
            return $"{FieldName} এবং {name} অবশ্যই মিলতে হবে।";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} অবশ্যই :size আইটেম হতে হবে।";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} অবশ্যই :size অক্ষর হতে হবে।";
        }
public string StartsWith(List<string> values)
        {
            return $"এই {FieldName} নিম্নলিখিত এক সঙ্গে শুরু হবে: {String.Join(", ", values)}।";
        }
 public string Uppercase()
        {
            return $"এই {FieldName} অবশ্যই বড় হাতের হতে হবে।";
        }
   public string Url()
        {
            return $"এই {FieldName} একটি বৈধ URL হতে হবে।";
        }
    }
        }