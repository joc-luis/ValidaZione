using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Cy : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Rhaid derbyn {FieldName}.";
            }
public string ActiveUrl()
        {
            return $"Nid yw {FieldName} yn URL dilys.";
        }
public string After(string date)
        {
            return $"Rhaid i {FieldName} fod yn ddyddiad sydd ar ôl {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Y {FieldName} rhaid iddo fod yn ddyddiad ar ôl neu yn hafal i {date}.";
        }
 public string Alpha()
        {
            return $"Dim ond llythrennau'n unig gall {FieldName} gynnwys.";
        }
public string AlphaDash()
        {
            return $"Dim ond llythrennau, rhifau a dash yn unig gall {FieldName} gynnwys.";
        }
public string AlphaNum()
        {
            return $"Dim ond llythrennau a rhifau yn unig gall {FieldName} gynnwys.";
        }
public string Before(string date)
        {
            return $"Rhaid i {FieldName} fod yn ddyddiad sydd cyn {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Y {FieldName} rhaid iddo fod yn ddyddiad cyn neu yn hafal i {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Rhaid i {FieldName} fod rhwng {min} a {max} eitem.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Rhaid i {FieldName} fod rhwng {min} a {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Rhaid i {FieldName} fod rhwng {min} a {max} nodyn.";
        }
public string Boolean()
        {
            return $"Rhaid i'r maes {FieldName} fod yn wir neu gau.";
        }
public string Confirmed()
        {
            return $"Nid yw'r cadarnhad {FieldName} yn gyfwerth.";
        }
public string Declined()
        {
            return $"Rhaid gwrthod y {FieldName}.";
        }
public string Different(string name)
        {
            return $"Rhaid i {FieldName} a {name} fod yn wahanol.";
        }
public string Distinct()
        {
            return $"Y {FieldName} maes wedi dyblyg gwerth.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"Efallai na fydd y {FieldName} yn gorffen gydag un o’r canlynol: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"Efallai na fydd y {FieldName} yn dechrau gydag un o’r canlynol: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Rhaid i {FieldName} fod yn gyfeiriad ebost dilys.";
        }
public string EndsWith(List<string> values)
        {
            return $"Y {FieldName} rhaid i ben gydag un o'r canlynol: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"Rhaid i'r {FieldName} fod â mwy na {value} o eitemau.";
        }
public string GreaterThanString(int value)
        {
            return $"Rhaid i'r {FieldName} fod yn fwy na {value} nod.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Rhaid i'r {FieldName} fod â {value} o eitemau neu fwy.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Rhaid i'r {FieldName} fod yn fwy na neu'n hafal i {value} nod.";
        }
  public string In()
        {
            return $"Nid yw {FieldName} yn ddilys.";
        }
public string Integer()
        {
            return $"Rhaid i {FieldName} fod yn integer.";
        }
public string Ip()
        {
            return $"Rhaid i {FieldName} fod yn gyfeiriad IP dilys.";
        }
 public string Ipv4()
        {
            return $"Y {FieldName} rhaid iddo fod yn ddilys ar IPv4 cyfeiriad.";
        }
        public string Ipv6()
        {
            return $"Y {FieldName} rhaid iddo fod yn ddilys cyfeiriad IPv6.";
        }
      public string Json()
        {
            return $"Y {FieldName} rhaid iddo fod yn ddilys JSON llinyn.";
        }
        public string Lowercase()
        {
            return $"Rhaid i'r {FieldName} fod yn llythrennau bach.";
        }
        public string LessThanArray(long value)
        {
            return $"Rhaid i'r {FieldName} fod â llai na {value} o eitemau.";
        }
    public string LessThanString(int value)
        {
            return $"Rhaid i'r {FieldName} fod yn llai na {value} nod.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"Ni ddylai'r {FieldName} fod â mwy na {value} o eitemau.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"Rhaid i'r {FieldName} fod yn llai na neu'n hafal i {value} nod.";
        }
   public string MacAddress()
        {
            return $"Rhaid i'r {FieldName} fod yn gyfeiriad MAC dilys.";
        }
      public string MaxArray(long max)
        {
            return $"Ni chai {FieldName} fod yn fwy na {max} eitem.";
        }
      public string MaxNumeric(string max)
        {
            return $"Ni chai {FieldName} fod yn fwy na {max}.";
        }
        public string MaxString(int max)
        {
            return $"Ni chai {FieldName} fod yn fwy na {max} nodyn.";
        }
    public string MinArray(long min)
        {
            return $"Rhaid i {FieldName} fod o leiaf {min} eitem.";
        }
   public string MinNumeric(string min)
        {
            return $"Rhaid i {FieldName} fod o leiaf {min}.";
        }
      public string MinString(int min)
        {
            return $"Rhaid i {FieldName} fod o leiaf {min} nodyn.";
        }
      public string NotIn()
        {
            return $"Nid yw {FieldName} yn ddilys.";
        }
       public string NotRegex()
        {
            return $"Y {FieldName} fformat annilys.";
        }
      public string Numeric()
        {
            return $"Rhaid i {FieldName} fod yn rif.";
        }
 public string Regex()
        {
            return $"Nid yw fformat {FieldName} yn ddilys.";
        }
       public string Required()
        {
            return $"Rhaid cynnwys {FieldName}.";
        }
    public string Same(string name)
        {
            return $"Rhaid i {FieldName} a {name} fod yn gyfwerth.";
        }
       public string SizeArray(long size)
        {
            return $"Rhaid i {FieldName} fod yn {size} eitem.";
        }
    public string SizeString(int size)
        {
            return $"Rhaid i {FieldName} fod yn {size} nodyn.";
        }
public string StartsWith(List<string> values)
        {
            return $"Y {FieldName} rhaid dechrau gydag un o'r canlynol: {String.Join(", ", values)}.";
        }
 public string Uppercase()
        {
            return $"Rhaid i'r {FieldName} fod yn briflythrennau.";
        }
   public string Url()
        {
            return $"Nid yw fformat {FieldName} yn ddilys.";
        }
    }
        }