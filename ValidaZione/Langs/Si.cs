using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Si : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"මෙම {FieldName} වලංගු විය යුතුය.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} වලංගු නැති URL එකකි.";
        }
public string After(string date)
        {
            return $"මෙම {FieldName}, {date} දිනයට පසු දිනයක් විය යුතුය.";
        }
public string AfterOrEqual(string date)
        {
            return $"මෙම {FieldName}, {date} දිනයම හෝ ඊට පසු දිනයක් විය යුතුය.";
        }
 public string Alpha()
        {
            return $"මෙම {FieldName} ට අඩංගු විය හැක්කේ අකුරු පමණි.";
        }
public string AlphaDash()
        {
            return $"මෙම {FieldName} ට අඩංගු විය හැක්කේ අකුරු, ඉලක්කම්, කෙටිඉර හා යටිඉර පමණි.";
        }
public string AlphaNum()
        {
            return $"මෙම {FieldName} ට අඩංගු විය හැක්කේ අකුරු හා ඉලක්කම් පමණි.";
        }
public string Before(string date)
        {
            return $"මෙම {FieldName}, {date} දිනයට පෙර දිනයක් විය යුතුය.";
        }
public string BeforeOrEqual(string date)
        {
            return $"මෙම {FieldName}, {date} දිනයම හෝ ඊට පෙර දිනයක් විය යුතුය.";
        }
public string BetweenArray(long min, long max)
        {
            return $"මෙම අන්තර්ගතය {min} ත් {max} ත් අතර විය යුතුය.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"මෙම සංක්‍යාව {min} ත් {max} ත් අතර විය යුතුය.";
        }
public string BetweenString(int min, int max)
        {
            return $"මෙම වචනය අකුරු {min} ත් {max} ත් අතර විය යුතුය.";
        }
public string Boolean()
        {
            return $"මෙම {FieldName} ය සත්‍ය හෝ අසත්‍ය අගයක් විය යුතුය.";
        }
public string Confirmed()
        {
            return $"මෙම {FieldName} තහවුරු කිරීම නොගැලපේ.";
        }
public string Declined()
        {
            return $"{FieldName} ප්‍රතික්ෂේප කළ යුතුය.";
        }
public string Different(string name)
        {
            return $"මෙම {FieldName} එක හා {name} එකිනෙකට වෙනස් විය යුතුය.";
        }
public string Distinct()
        {
            return $"මේ {FieldName} හි එකම අගයේ අනු පිටපත් ඇත.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} පහත සඳහන් එකකින් අවසන් නොවිය හැක: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} පහත සඳහන් එකකින් ආරම්භ නොවිය හැක: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"මෙම {FieldName} එක වලංගු විද්‍යුත් ලිපිනයක් විය යුතුය.";
        }
public string EndsWith(List<string> values)
        {
            return $"මෙම {FieldName} එක {String.Join(", ", values)} මගින් අවසාන විය යුතුය.";
        }
public string GreaterThanArray(long value)
        {
            return $"මෙම {FieldName} එක {value} ට වඩා වැඩි අයිතම ගණනක් විය යුතුය.";
        }
public string GreaterThanString(int value)
        {
            return $"මෙම {FieldName} එක {value} ට වඩා වැඩි අකුරු ගණනක් විය යුතුය.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"මෙම {FieldName} එක අයිතම {value} ට වඩා වැඩි හෝ සමාන විය යුතුයි.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"මෙම {FieldName} එක අකුරු {value} ට වඩා වැඩි හෝ සමාන විය යුතුයි.";
        }
  public string In()
        {
            return $"මෙම තෝරා ඇති {FieldName} වලංගු නැත.";
        }
public string Integer()
        {
            return $"මෙම {FieldName} පූර්ණ සංඛ්යාවක් විය යුතුය.";
        }
public string Ip()
        {
            return $"මෙම {FieldName} වලංගු IP ලිපිනයක් විය යුතුය.";
        }
 public string Ipv4()
        {
            return $"මෙම {FieldName} වලංගු IPv4 ලිපිනය විය යුතුය.";
        }
        public string Ipv6()
        {
            return $"මෙම {FieldName} වලංගු IPv6 ලිපිනය විය යුතුය.";
        }
      public string Json()
        {
            return $"මෙම {FieldName} වලංගු JSON පේළියක් විය යුතුය.";
        }
        public string Lowercase()
        {
            return $"{FieldName} කුඩා අකුරු විය යුතුය.";
        }
        public string LessThanArray(long value)
        {
            return $"මෙම {FieldName} එක {value} ට වඩා අඩු අයිතම ගණනක් විය යුතුය.";
        }
    public string LessThanString(int value)
        {
            return $"මෙම {FieldName} එක {value} ට වඩා අඩු අකුරු ගණනක් විය යුතුය.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"මෙම {FieldName} එක අයිතම {value} ට වඩා අඩු හෝ සමාන විය යුතුයි.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"මෙම {FieldName} එක අකුරු {value} ට වඩා අඩු හෝ සමාන විය යුතුයි.";
        }
   public string MacAddress()
        {
            return $"{FieldName} වලංගු MAC ලිපිනයක් විය යුතුය.";
        }
      public string MaxArray(long max)
        {
            return $"මෙම {FieldName} එක {max} ට වඩා වැඩි නොවිය යුතුයි.";
        }
      public string MaxNumeric(string max)
        {
            return $"මෙම {FieldName} එක අකුරු {max} ට වඩා වැඩි නොවිය යුතුයි.";
        }
        public string MaxString(int max)
        {
            return $"මෙම {FieldName} එක අයිතම {max} ට වඩා වැඩි නොවිය යුතුයි.";
        }
    public string MinArray(long min)
        {
            return $"මෙම {FieldName} එක {min} ට වඩා අඩු නොවිය යුතුයි.";
        }
   public string MinNumeric(string min)
        {
            return $"මෙම {FieldName} එක අකුරු {min} ට වඩා අඩු නොවිය යුතුයි.";
        }
      public string MinString(int min)
        {
            return $"මෙම {FieldName} එක අයිතම {min} ට වඩා අඩු නොවිය යුතුයි.";
        }
      public string NotIn()
        {
            return $"මෙම තෝරා ඇත {FieldName} වලංගු නැත.";
        }
       public string NotRegex()
        {
            return $"මෙම {FieldName} ආකෘතිය වලංගු නැත.";
        }
      public string Numeric()
        {
            return $"මෙම {FieldName} අංකයක් විය යුතුය.";
        }
 public string Regex()
        {
            return $"මෙම {FieldName} ආකෘතිය වලංගු නැත.";
        }
       public string Required()
        {
            return $"මෙම {FieldName} ක්ෂේත්‍රයේ අවශ්‍යයි.";
        }
    public string Same(string name)
        {
            return $"මෙම {FieldName} සහ {name} ගැලපිය යුතුයි.";
        }
       public string SizeArray(long size)
        {
            return $"මෙම {FieldName} යේ අයිතම {size} ක් තිබිය යුතුය.";
        }
    public string SizeString(int size)
        {
            return $"මෙම {FieldName} ය අකුරු {size} විය යුතුය.";
        }
public string StartsWith(List<string> values)
        {
            return $"මෙම {FieldName} පහත සඳහන් එකක් සමඟ ආරම්භ කළ යුතුය: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"{FieldName} විශාල අකුරු විය යුතුය.";
        }
   public string Url()
        {
            return $"මෙම {FieldName} ආකෘතිය වලංගු නැත.";
        }
    }
        }