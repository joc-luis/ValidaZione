using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Ja : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName}を承認してください。";
            }
public string ActiveUrl()
        {
            return $"{FieldName}は、有効なURLではありません。";
        }
public string After(string date)
        {
            return $"{FieldName}には、{date}より後の日付を指定してください。";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName}には、{date}以降の日付を指定してください。";
        }
 public string Alpha()
        {
            return $"{FieldName}には、アルファベッドのみ使用できます。";
        }
public string AlphaDash()
        {
            return $"{FieldName}には、英数字('A-Z','a-z','0-9')とハイフンと下線('-','_')が使用できます。";
        }
public string AlphaNum()
        {
            return $"{FieldName}には、英数字('A-Z','a-z','0-9')が使用できます。";
        }
public string Before(string date)
        {
            return $"{FieldName}には、{date}より前の日付を指定してください。";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName}には、{date}以前の日付を指定してください。";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName}の項目は、{min}個から{max}個にしてください。";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName}には、{min}から、{max}までの数字を指定してください。";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName}は、{min}文字から{max}文字にしてください。";
        }
public string Boolean()
        {
            return $"{FieldName}には、'true'か'false'を指定してください。";
        }
public string Confirmed()
        {
            return $"{FieldName}と{FieldName}確認が一致しません。";
        }
public string Declined()
        {
            return $"{FieldName}を拒否する必要があります。";
        }
public string Different(string name)
        {
            return $"{FieldName}と{name}には、異なるものを指定してください。";
        }
public string Distinct()
        {
            return $"{FieldName}の値が重複しています。";
        }
public string Email()
        {
            return $"{FieldName}は、有効なメールアドレス形式で指定してください。";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName}は、次のうちのいずれかで終わらなければいけません。: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName}の項目数は、{value}個より多くなければいけません。";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName}は、{value}文字より大きくなければいけません";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName}の項目数は、{value}個以上でなければいけません。";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName}は、{value}文字以上でなければいけません。";
        }
  public string In()
        {
            return $"選択された{FieldName}は、有効ではありません。";
        }
public string Integer()
        {
            return $"{FieldName}には、整数を指定してください。";
        }
public string Ip()
        {
            return $"{FieldName}には、有効なIPアドレスを指定してください。";
        }
 public string Ipv4()
        {
            return $"{FieldName}はIPv4アドレスを指定してください。";
        }
        public string Ipv6()
        {
            return $"{FieldName}はIPv6アドレスを指定してください。";
        }
      public string Json()
        {
            return $"{FieldName}には、有効なJSON文字列を指定してください。";
        }
        public string Lowercase()
        {
            return $"{FieldName}は、小文字で入力してください。";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName}の項目数は、{value}個より少なくなければいけません。";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName}は、{value}文字より小さくなければいけません。";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName}の項目数は、{value}個以下でなければいけません。";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName}は、{value}文字以下でなければいけません。";
        }
   public string MacAddress()
        {
            return $"{FieldName}は有効なMACアドレスである必要があります。";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName}の項目数は、{max}個以下でなければいけません。";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName}は、{max}以下の数字でなければいけません。";
        }
        public string MaxString(int max)
        {
            return $"{FieldName}の文字数は、{max}文字以下でなければいけません。";
        }
    public string MinArray(long min)
        {
            return $"{FieldName}の項目数は、{min}個以上にしてください。";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName}には、{min}以上の数字を指定してください。";
        }
      public string MinString(int min)
        {
            return $"{FieldName}の文字数は、{min}文字以上でなければいけません。";
        }
      public string NotIn()
        {
            return $"選択された{FieldName}は、有効ではありません。";
        }
       public string NotRegex()
        {
            return $"{FieldName}の形式が正しくありません。";
        }
      public string Numeric()
        {
            return $"{FieldName}には、数字を指定してください。";
        }
 public string Regex()
        {
            return $"{FieldName}には、正しい形式を指定してください。";
        }
       public string Required()
        {
            return $"{FieldName}は必須項目です。";
        }
    public string Same(string name)
        {
            return $"{FieldName}と{name}が一致しません。";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName}の項目数は、:size個にしてください。";
        }
    public string SizeString(int size)
        {
            return $"{FieldName}の文字数は、:size文字にしてください。";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName}は、次のいずれかで始まる必要があります。{String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"{FieldName}は、大文字で入力してください。";
        }
   public string Url()
        {
            return $"{FieldName}は、有効なURL形式で指定してください。";
        }
    }
        }