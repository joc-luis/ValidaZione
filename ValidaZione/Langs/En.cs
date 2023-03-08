using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class En : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"The {FieldName} must be accepted.";
            }
public string ActiveUrl()
        {
            return $"The {FieldName} is not a valid URL.";
        }
public string After(string date)
        {
            return $"The {FieldName} must be a date after {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"The {FieldName} must be a date after or equal to {date}.";
        }
public string Alpha()
        {
            return $"The {FieldName} may only contain letters.";
        }
public string AlphaDash()
        {
            return $"The {FieldName} may only contain letters, numbers, and dashes.";
        }
public string AlphaNum()
        {
            return $"The {FieldName} may only contain letters and numbers.";
        }
public string Before(string date)
        {
            return $"The {FieldName} must be a date before {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"The {FieldName} must be a date before or equal to {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"The {FieldName} must have between {min} and {max} items.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"The {FieldName} must be between {min} and {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"The {FieldName} must be between {min} and {max} characters.";
        }
public string Boolean()
        {
            return $"The {FieldName} field must be true or false.";
        }
public string Confirmed()
        {
            return $"The {FieldName} confirmation does not match.";
        }
public string Declined()
        {
            return $"The {FieldName} must be declined.";
        }
public string Different(string name)
        {
            return $"The {FieldName} and {name} must be different.";
        }
public string Distinct()
        {
            return $"The {FieldName} field has a duplicate value.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"The {FieldName} may not end with one of the following: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"The {FieldName} may not start with one of the following: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"The {FieldName} must be a valid email address.";
        }
public string EndsWith(List<string> values)
        {
            return $"The {FieldName} must end with one of the following: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"The {FieldName} must have more than {value} items.";
        }
public string GreaterThanString(int value)
        {
            return $"The {FieldName} must be greater than {value} characters.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"The {FieldName} must have {value} items or more.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"The {FieldName} must be greater than or equal {value} characters.";
        }
public string In()
        {
            return $"The selected {FieldName} is invalid.";
        }
public string Integer()
        {
            return $"The {FieldName} must be an integer.";
        }
public string Ip()
        {
            return $"The {FieldName} must be a valid IP address.";
        }
public string Ipv4()
        {
            return $"The {FieldName} must be a valid IPv4 address.";
        }
public string Ipv6()
        {
            return $"The {FieldName} must be a valid IPv6 address.";
        }
public string Json()
        {
            return $"The {FieldName} must be a valid JSON string.";
        }
public string Lowercase()
        {
            return $"The {FieldName} must be lowercase.";
        }
public string LessThanArray(long value)
        {
            return $"The {FieldName} must have less than {value} items.";
        }
public string LessThanString(int value)
        {
            return $"The {FieldName} must be less than {value} characters.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"The {FieldName} must not have more than {value} items.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"The {FieldName} must be less than or equal {value} characters.";
        }
public string MacAddress()
        {
            return $"The {FieldName} must be a valid MAC address.";
        }
public string MaxArray(long max)
        {
            return $"The {FieldName} may not have more than {max} items.";
        }
public string MaxNumeric(string max)
        {
            return $"The {FieldName} may not be greater than {max}.";
        }
public string MaxString(int max)
        {
            return $"The {FieldName} may not be greater than {max} characters.";
        }
public string MinArray(long min)
        {
            return $"The {FieldName} must have at least {min} items.";
        }
public string MinNumeric(string min)
        {
            return $"The {FieldName} must be at least {min}.";
        }
public string MinString(int min)
        {
            return $"The {FieldName} must be at least {min} characters.";
        }
public string NotIn()
        {
            return $"The selected {FieldName} is invalid.";
        }
public string NotRegex()
        {
            return $"The {FieldName} format is invalid.";
        }
public string Numeric()
        {
            return $"The {FieldName} must be a number.";
        }
public string Regex()
        {
            return $"The {FieldName} format is invalid.";
        }
public string Required()
        {
            return $"The {FieldName} field is required.";
        }
public string RequiredIf(string name, string value)
        {
            return $"The {FieldName} field is required when {name} is {value}.";
        }
public string Same(string name)
        {
            return $"The {FieldName} and {name} must match.";
        }
public string SizeArray(long size)
        {
            return $"The {FieldName} must contain {size} items.";
        }
public string SizeString(int size)
        {
            return $"The {FieldName} must be {size} characters.";
        }
public string StartsWith(List<string> values)
        {
            return $"The {FieldName} must start with one of the following: {String.Join(", ", values)}";
        }
public string Unique()
                {
                    return $"The {FieldName} has already been taken.";
                }
public string Uppercase()
        {
            return $"The {FieldName} must be uppercase.";
        }
public string Url()
        {
            return $"The {FieldName} format is invalid.";
        }
    }
        }