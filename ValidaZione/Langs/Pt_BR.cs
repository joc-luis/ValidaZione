using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Pt_BR : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"O campo {FieldName} deve ser aceito.";
            }
public string ActiveUrl()
        {
            return $"O campo {FieldName} deve conter uma URL válida.";
        }
public string After(string date)
        {
            return $"O campo {FieldName} deve conter uma data posterior a {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"O campo {FieldName} deve conter uma data superior ou igual a {date}.";
        }
 public string Alpha()
        {
            return $"O campo {FieldName} deve conter apenas letras.";
        }
public string AlphaDash()
        {
            return $"O campo {FieldName} deve conter apenas letras, números e traços.";
        }
public string AlphaNum()
        {
            return $"O campo {FieldName} deve conter apenas letras e números .";
        }
public string Before(string date)
        {
            return $"O campo {FieldName} deve conter uma data anterior a {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"O campo {FieldName} deve conter uma data inferior ou igual a {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"O campo {FieldName} deve conter de {min} a {max} itens.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"O campo {FieldName} deve conter um número entre {min} e {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"O campo {FieldName} deve conter entre {min} a {max} caracteres.";
        }
public string Boolean()
        {
            return $"O campo {FieldName} deve conter o valor verdadeiro ou falso.";
        }
public string Confirmed()
        {
            return $"A confirmação para o campo {FieldName} não coincide.";
        }
public string Declined()
        {
            return $"O {FieldName} deve ser recusado.";
        }
public string Different(string name)
        {
            return $"Os campos {FieldName} e {name} devem conter valores diferentes.";
        }
public string Distinct()
        {
            return $"O campo {FieldName} contém um valor duplicado.";
        }
public string Email()
        {
            return $"O campo {FieldName} não contém um endereço de email válido.";
        }
public string EndsWith(List<string> values)
        {
            return $"O campo {FieldName} deve terminar com um dos seguintes valores: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"O campo {FieldName} deve ter mais que {value} itens.";
        }
public string GreaterThanString(int value)
        {
            return $"O campo {FieldName} deve ser maior que {value} caracteres.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"O campo {FieldName} deve ter {value} itens ou mais.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"O campo {FieldName} deve ser maior ou igual a {value} caracteres.";
        }
  public string In()
        {
            return $"O campo {FieldName} não contém um valor válido.";
        }
public string Integer()
        {
            return $"O campo {FieldName} deve conter um número inteiro.";
        }
public string Ip()
        {
            return $"O campo {FieldName} deve conter um IP válido.";
        }
 public string Ipv4()
        {
            return $"O campo {FieldName} deve conter um IPv4 válido.";
        }
        public string Ipv6()
        {
            return $"O campo {FieldName} deve conter um IPv6 válido.";
        }
      public string Json()
        {
            return $"O campo {FieldName} deve conter uma string JSON válida.";
        }
        public string Lowercase()
        {
            return $"O {FieldName} deve ser minúsculo.";
        }
        public string LessThanArray(long value)
        {
            return $"O campo {FieldName} deve ter menos que {value} itens.";
        }
    public string LessThanString(int value)
        {
            return $"O campo {FieldName} deve ser menor que {value} caracteres.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"O campo {FieldName} não deve ter mais que {value} itens.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"O campo {FieldName} deve ser menor ou igual a {value} caracteres.";
        }
   public string MacAddress()
        {
            return $"O {FieldName} deve ser um endereço MAC válido.";
        }
      public string MaxArray(long max)
        {
            return $"O campo {FieldName} deve conter no máximo {max} itens.";
        }
      public string MaxNumeric(string max)
        {
            return $"O campo {FieldName} não pode conter um valor superior a {max}.";
        }
        public string MaxString(int max)
        {
            return $"O campo {FieldName} não pode conter mais de {max} caracteres.";
        }
    public string MinArray(long min)
        {
            return $"O campo {FieldName} deve conter no mínimo {min} itens.";
        }
   public string MinNumeric(string min)
        {
            return $"O campo {FieldName} deve conter um número superior ou igual a {min}.";
        }
      public string MinString(int min)
        {
            return $"O campo {FieldName} deve conter no mínimo {min} caracteres.";
        }
      public string NotIn()
        {
            return $"O campo {FieldName} contém um valor inválido.";
        }
       public string NotRegex()
        {
            return $"O formato do valor {FieldName} é inválido.";
        }
      public string Numeric()
        {
            return $"O campo {FieldName} deve conter um valor numérico.";
        }
 public string Regex()
        {
            return $"O formato do valor informado no campo {FieldName} é inválido.";
        }
       public string Required()
        {
            return $"O campo {FieldName} é obrigatório.";
        }
    public string Same(string name)
        {
            return $"Os campos {FieldName} e {name} devem conter valores iguais.";
        }
       public string SizeArray(long size)
        {
            return $"O campo {FieldName} deve conter :size itens.";
        }
    public string SizeString(int size)
        {
            return $"O campo {FieldName} deve conter :size caracteres.";
        }
public string StartsWith(List<string> values)
        {
            return $"O campo {FieldName} deve começar com um dos seguintes valores: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"O {FieldName} deve ser maiúsculo.";
        }
   public string Url()
        {
            return $"O formato da URL informada para o campo {FieldName} é inválido.";
        }
    }
        }