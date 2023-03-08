using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Zh_HK : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"必須接受 {FieldName}。";
            }
public string ActiveUrl()
        {
            return $"{FieldName} 並非一個有效的網址。";
        }
public string After(string date)
        {
            return $"{FieldName} 必須要晚於 {date}。";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} 必須要等於 {date} 或更晚。";
        }
public string Alpha()
        {
            return $"{FieldName} 只能以字母組成。";
        }
public string AlphaDash()
        {
            return $"{FieldName} 只能以字母、數字、連接線(-)及底線(_)組成。";
        }
public string AlphaNum()
        {
            return $"{FieldName} 只能以字母及數字組成。";
        }
public string Before(string date)
        {
            return $"{FieldName} 必須要早於 {date}。";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} 必須要等於 {date} 或更早。";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName}: 必須有 {min} 至 {max} 個項目。";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} 必須介乎 {min} 至 {max} 之間。";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} 必須介乎 {min} 至 {max} 個字符之間。";
        }
public string Boolean()
        {
            return $"{FieldName} 必須是布爾值。";
        }
public string Confirmed()
        {
            return $"{FieldName} 確認欄位的輸入並不相符。";
        }
public string Declined()
        {
            return $"{FieldName} 必須被拒絕。";
        }
public string Different(string name)
        {
            return $"{FieldName} 與 {name} 必須不同。";
        }
public string Distinct()
        {
            return $"{FieldName} 已經存在。";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} 不能以下列之一结尾：{String.Join(", ", values)}。";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} 不能以下列之一开头：{String.Join(", ", values)}。";
        }
public string Email()
        {
            return $"{FieldName} 必須是有效的電郵地址。";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} 結尾必須包含下列之一：{String.Join(", ", values)}。";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} 必須多於 {value} 個項目。";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} 必須多於 {value} 個字符。";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} 必須多於或等於 {value} 個項目。";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} 必須多於或等於 {value} 個字符。";
        }
public string In()
        {
            return $"所揀選的 {FieldName} 選項無效。";
        }
public string Integer()
        {
            return $"{FieldName} 必須是一個整數。";
        }
public string Ip()
        {
            return $"{FieldName} 必須是一個有效的 IP 地址。";
        }
public string Ipv4()
        {
            return $"{FieldName} 必須是一個有效的 IPv4 地址。";
        }
public string Ipv6()
        {
            return $"{FieldName} 必須是一個有效的 IPv6 地址。";
        }
public string Json()
        {
            return $"{FieldName} 必須是正確的 JSON 格式。";
        }
public string Lowercase()
        {
            return $"{FieldName} 必须小写。";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} 必須少於 {value} 個項目。";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} 必須少於 {value} 個字符。";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} 必須少於或等於 {value} 個項目。";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} 必須少於或等於 {value} 個字符。";
        }
public string MacAddress()
        {
            return $"{FieldName} 必須是一個有效的 MAC 地址。";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} 不能多於 {max} 個項目。";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} 不能大於 {max}。";
        }
public string MaxString(int max)
        {
            return $"{FieldName} 不能多於 {max} 個字符。";
        }
public string MinArray(long min)
        {
            return $"{FieldName} 不能小於 {min} 個項目。";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} 不能小於 {min}。";
        }
public string MinString(int min)
        {
            return $"{FieldName} 不能小於 {min} 個字符。";
        }
public string NotIn()
        {
            return $"所揀選的 {FieldName} 選項無效。";
        }
public string NotRegex()
        {
            return $"{FieldName} 的格式錯誤。";
        }
public string Numeric()
        {
            return $"{FieldName} 必須為一個數字。";
        }
public string Regex()
        {
            return $"{FieldName} 的格式錯誤。";
        }
public string Required()
        {
            return $"{FieldName} 不能留空。";
        }
public string RequiredIf(string name, string value)
        {
            return $"當 {name} 是 {value} 時 {FieldName} 不能留空。";
        }
public string Same(string name)
        {
            return $"{FieldName} 與 {name} 必須相同。";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} 必須是 {size} 個單元。";
        }
public string SizeString(int size)
        {
            return $"{FieldName} 必須是 {size} 個字符。";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} 開頭必須包含下列之一：{String.Join(", ", values)}。";
        }
public string Unique()
                {
                    return $"{FieldName} 已經存在。";
                }
public string Uppercase()
        {
            return $"{FieldName} 必须大写。";
        }
public string Url()
        {
            return $"{FieldName} 的格式錯誤。";
        }
    }
        }