using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Sc : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} depet èssere atzetadu.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} no est un'URL bàlidu.";
        }
public string After(string date)
        {
            return $"{FieldName} depet èssere una data chi benit a pustis de {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"The {FieldName} must be a date after or equal to {date}.";
        }
 public string Alpha()
        {
            return $"{FieldName} podet cuntènnere isceti lìteras.";
        }
public string AlphaDash()
        {
            return $"{FieldName} podet cuntènnere isceti lìteras, nùmeros e tratigheddos.";
        }
public string AlphaNum()
        {
            return $"{FieldName} podet cuntènnere isceti lìteras e nùmeros.";
        }
public string Before(string date)
        {
            return $"{FieldName} depet èssere una data chi benit prima de {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"The {FieldName} must be a date before or equal to {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} depet èssere intre {min} - {max} elementos.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} depet èssere intre {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} depet èssere intre {min} - {max} caràteres.";
        }
public string Boolean()
        {
            return $"The {FieldName} field must be true or false";
        }
public string Confirmed()
        {
            return $"Su campu de cunfirma pro {FieldName} non torrat.";
        }
public string Declined()
        {
            return $"The {FieldName} must be declined.";
        }
public string Different(string name)
        {
            return $"{FieldName} e {name} depent èssere diferentes.";
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
            return $"{FieldName} no est bàlidu.";
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
            return $"{FieldName} seberadu no est bàlidu.";
        }
public string Integer()
        {
            return $"{FieldName} depet èssere intreu.";
        }
public string Ip()
        {
            return $"{FieldName} depet èssere un'indiritzu IP bàlidu.";
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
            return $"{FieldName} non podet tènnere prus de {max} elementos.";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} depet èssere prus piticu de {max}.";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} non podet cuntènnere prus de {max} caràteres.";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} depet tènnere a su mancu {min} elementos.";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} depet bàlere a su mancu {min}.";
        }
      public string MinString(int min)
        {
            return $"{FieldName} depet cuntènnere a su mancu {min} caràteres.";
        }
      public string NotIn()
        {
            return $"Su balore seberadu pro {FieldName} no est bàlidu.";
        }
       public string NotRegex()
        {
            return $"The {FieldName} format is invalid.";
        }
      public string Numeric()
        {
            return $"{FieldName} depet èssere unu nùmeru.";
        }
 public string Regex()
        {
            return $"Su formadu de su campu {FieldName} no est bàlidu.";
        }
       public string Required()
        {
            return $"{FieldName} est pedidu.";
        }
    public string Same(string name)
        {
            return $"{FieldName} e {name} depent èssere uguales.";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} depet cuntènnere {size} elementos.";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} depet cuntènnere {size} caràteres.";
        }
public string StartsWith(List<string> values)
        {
            return $"The {FieldName} must start with one of the following: {String.Join(", ", values)}.";
        }
 public string Uppercase()
        {
            return $"The {FieldName} must be uppercase.";
        }
   public string Url()
        {
            return $"{FieldName} depet èssere un'URL.";
        }
    }
        }