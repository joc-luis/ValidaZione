using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Zh_CN : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"您必须接受 {FieldName}。";
            }
public string ActiveUrl()
        {
            return $"{FieldName} 不是一个有效的网址。";
        }
public string After(string date)
        {
            return $"{FieldName} 必须要晚于 {date}。";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} 必须要等于 {date} 或更晚。";
        }
public string Alpha()
        {
            return $"{FieldName} 只能由字母组成。";
        }
public string AlphaDash()
        {
            return $"{FieldName} 只能由字母、数字、短划线(-)和下划线(_)组成。";
        }
public string AlphaNum()
        {
            return $"{FieldName} 只能由字母和数字组成。";
        }
public string Before(string date)
        {
            return $"{FieldName} 必须要早于 {date}。";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} 必须要等于 {date} 或更早。";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} 必须只有 {min} - {max} 个单元。";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} 必须介于 {min} - {max} 之间。";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} 必须介于 {min} - {max} 个字符之间。";
        }
public string Boolean()
        {
            return $"{FieldName} 必须为布尔值。";
        }
public string Confirmed()
        {
            return $"{FieldName} 两次输入不一致。";
        }
public string Declined()
        {
            return $"{FieldName} 必须是拒绝的。";
        }
public string Different(string name)
        {
            return $"{FieldName} 和 {name} 必须不同。";
        }
public string Distinct()
        {
            return $"{FieldName} 已经存在。";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} 不能以以下之一结尾: {String.Join(", ", values)}。";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} 不能以下列之一开头: {String.Join(", ", values)}。";
        }
public string Email()
        {
            return $"{FieldName} 不是一个合法的邮箱。";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} 必须以 {String.Join(", ", values)} 为结尾。";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} 必须多于 {value} 个元素。";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} 必须多于 {value} 个字符。";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} 必须多于或等于 {value} 个元素。";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} 必须多于或等于 {value} 个字符。";
        }
public string In()
        {
            return $"已选的属性 {FieldName} 无效。";
        }
public string Integer()
        {
            return $"{FieldName} 必须是整数。";
        }
public string Ip()
        {
            return $"{FieldName} 必须是有效的 IP 地址。";
        }
public string Ipv4()
        {
            return $"{FieldName} 必须是有效的 IPv4 地址。";
        }
public string Ipv6()
        {
            return $"{FieldName} 必须是有效的 IPv6 地址。";
        }
public string Json()
        {
            return $"{FieldName} 必须是正确的 JSON 格式。";
        }
public string Lowercase()
        {
            return $"{FieldName} 必须小写。";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} 必须少于 {value} 个元素。";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} 必须少于 {value} 个字符。";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} 必须少于或等于 {value} 个元素。";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} 必须少于或等于 {value} 个字符。";
        }
public string MacAddress()
        {
            return $"{FieldName} 必须是一个有效的 MAC 地址。";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} 最多只有 {max} 个单元。";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} 不能大于 {max}。";
        }
public string MaxString(int max)
        {
            return $"{FieldName} 不能大于 {max} 个字符。";
        }
public string MinArray(long min)
        {
            return $"{FieldName} 至少有 {min} 个单元。";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} 必须大于等于 {min}。";
        }
public string MinString(int min)
        {
            return $"{FieldName} 至少为 {min} 个字符。";
        }
public string NotIn()
        {
            return $"已选的属性 {FieldName} 非法。";
        }
public string NotRegex()
        {
            return $"{FieldName} 的格式错误。";
        }
public string Numeric()
        {
            return $"{FieldName} 必须是一个数字。";
        }
public string Regex()
        {
            return $"{FieldName} 格式不正确。";
        }
public string Required()
        {
            return $"{FieldName} 不能为空。";
        }
public string RequiredIf(string name, string value)
        {
            return $"当 {name} 为 {value} 时 {FieldName} 不能为空。";
        }
public string Same(string name)
        {
            return $"{FieldName} 和 {name} 必须相同。";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} 必须为 {size} 个单元。";
        }
public string SizeString(int size)
        {
            return $"{FieldName} 必须是 {size} 个字符。";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} 必须以 {String.Join(", ", values)} 为开头。";
        }
public string Unique()
                {
                    return $"{FieldName} 已经存在。";
                }
public string Uppercase()
        {
            return $"{FieldName} 必须大写";
        }
public string Url()
        {
            return $"{FieldName} 格式不正确。";
        }
    }
        }