using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Ko : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName}을(를) 동의해야 합니다.";
            }
public string ActiveUrl()
        {
            return $"{FieldName}은(는) 유효한 URL이 아닙니다.";
        }
public string After(string date)
        {
            return $"{FieldName}은(는) {date} 이후 날짜여야 합니다.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName}은(는) {date} 이후 날짜이거나 같은 날짜여야 합니다.";
        }
public string Alpha()
        {
            return $"{FieldName}은(는) 문자만 포함할 수 있습니다.";
        }
public string AlphaDash()
        {
            return $"{FieldName}은(는) 문자, 숫자, 대쉬(-), 밑줄(_)만 포함할 수 있습니다.";
        }
public string AlphaNum()
        {
            return $"{FieldName}은(는) 문자와 숫자만 포함할 수 있습니다.";
        }
public string Before(string date)
        {
            return $"{FieldName}은(는) {date} 이전 날짜여야 합니다.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName}은(는) {date} 이전 날짜이거나 같은 날짜여야 합니다.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName}의 항목 수는 {min}에서 {max} 개의 항목이 있어야 합니다.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName}의 값은 {min}에서 {max} 사이여야 합니다.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName}의 길이는 {min}에서 {max} 문자 사이여야 합니다.";
        }
public string Boolean()
        {
            return $"{FieldName}은(는) true 또는 false 이어야 합니다.";
        }
public string Confirmed()
        {
            return $"{FieldName} 확인 항목이 일치하지 않습니다.";
        }
public string Declined()
        {
            return $"{FieldName}은(는) 거부되어야 합니다.";
        }
public string Different(string name)
        {
            return $"{FieldName}와(과) {name}은(는) 서로 달라야 합니다.";
        }
public string Distinct()
        {
            return $"{FieldName} 필드에 중복된 값이 있습니다.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName}은 다음 중 하나로 끝날 수 없습니다: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName}은 다음 중 하나로 시작할 수 없습니다: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName}은(는) 유효한 이메일 주소여야 합니다.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName}은(는) 다음 중 하나로 끝나야 합니다: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName}의 항목 수는 {value}개 보다 많아야 합니다.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName}의 길이는 {value}보다 길어야 합니다.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName}의 항목 수는 {value}개 보다 같거나 많아야 합니다.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName}의 길이는 {value}보다 같거나 길어야 합니다.";
        }
public string In()
        {
            return $"선택된 {FieldName}은(는) 올바르지 않습니다.";
        }
public string Integer()
        {
            return $"{FieldName}은(는) 정수여야 합니다.";
        }
public string Ip()
        {
            return $"{FieldName}은(는) 유효한 IP 주소여야 합니다.";
        }
public string Ipv4()
        {
            return $"{FieldName}은(는) 유효한 IPv4 주소여야 합니다.";
        }
public string Ipv6()
        {
            return $"{FieldName}은(는) 유효한 IPv6 주소여야 합니다.";
        }
public string Json()
        {
            return $"{FieldName}은(는) JSON 문자열이어야 합니다.";
        }
public string Lowercase()
        {
            return $"{FieldName}은 소문자여야 합니다.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName}의 항목 수는 {value}개 보다 작아야 합니다.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName}의 길이는 {value}보다 짧아야 합니다.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName}의 항목 수는 {value}개 보다 같거나 작아야 합니다.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName}의 길이는 {value}보다 같거나 짧아야 합니다.";
        }
public string MacAddress()
        {
            return $"{FieldName}은(는) 올바른 MAC 주소가 아닙니다.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName}은(는) {max}개보다 많을 수 없습니다.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName}은(는) {max}보다 클 수 없습니다.";
        }
public string MaxString(int max)
        {
            return $"{FieldName}은(는) {max}자보다 클 수 없습니다.";
        }
public string MinArray(long min)
        {
            return $"{FieldName}은(는) 최소한 {min}개의 항목이 있어야 합니다.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName}은(는) 최소한 {min}이어야 합니다.";
        }
public string MinString(int min)
        {
            return $"{FieldName}은(는) 최소한 {min}자이어야 합니다.";
        }
public string NotIn()
        {
            return $"선택된 {FieldName}이(가) 올바르지 않습니다.";
        }
public string NotRegex()
        {
            return $"{FieldName}의 형식이 올바르지 않습니다.";
        }
public string Numeric()
        {
            return $"{FieldName}은(는) 숫자여야 합니다.";
        }
public string Regex()
        {
            return $"{FieldName} 형식이 올바르지 않습니다.";
        }
public string Required()
        {
            return $"{FieldName} 필드는 필수입니다.";
        }
public string RequiredIf(string name, string value)
        {
            return $":Other이(가) {value} 일 때 {FieldName} 필드는 필수입니다.";
        }
public string Same(string name)
        {
            return $"{FieldName}와(과) {name}은(는) 일치해야 합니다.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName}은(는) {size}개의 항목을 포함해야 합니다.";
        }
public string SizeString(int size)
        {
            return $"{FieldName}은(는) {size}자여야 합니다.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName}은(는) {String.Join(", ", values)} 중 하나로 시작해야 합니다.";
        }
public string Uppercase()
        {
            return $"{FieldName}은 대문자여야 합니다.";
        }
public string Url()
        {
            return $"{FieldName}은(는) 형식은 올바르지 않습니다.";
        }
    }
        }