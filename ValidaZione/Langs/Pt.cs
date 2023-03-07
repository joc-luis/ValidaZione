using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Pt : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"O campo {FieldName} deverá ser aceite.";
            }
public string ActiveUrl()
        {
            return $"O campo {FieldName} não contém um URL válido.";
        }
public string After(string date)
        {
            return $"O campo {FieldName} deverá conter uma data posterior a {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"O campo {FieldName} deverá conter uma data posterior ou igual a {date}.";
        }
public string Alpha()
        {
            return $"O campo {FieldName} deverá conter apenas letras.";
        }
public string AlphaDash()
        {
            return $"O campo {FieldName} deverá conter apenas letras, números e traços.";
        }
public string AlphaNum()
        {
            return $"O campo {FieldName} deverá conter apenas letras e números .";
        }
public string Before(string date)
        {
            return $"O campo {FieldName} deverá conter uma data anterior a {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"O Campo {FieldName} deverá conter uma data anterior ou igual a {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"O campo {FieldName} deverá conter entre {min} - {max} elementos.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"O campo {FieldName} deverá ter um valor entre {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"O campo {FieldName} deverá conter entre {min} - {max} caracteres.";
        }
public string Boolean()
        {
            return $"O campo {FieldName} deverá conter o valor verdadeiro ou falso.";
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
            return $"Os campos {FieldName} e {name} deverão conter valores diferentes.";
        }
public string Distinct()
        {
            return $"O campo {FieldName} contém um valor duplicado.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"O campo {FieldName} não pode terminar com um dos seguintes: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"O campo {FieldName} não pode começar com um dos seguintes: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"O campo {FieldName} não contém um endereço de e-mail válido.";
        }
public string EndsWith(List<string> values)
        {
            return $"O campo {FieldName} deverá terminar com : {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"O campo {FieldName} tem de ter mais de {value} itens.";
        }
public string GreaterThanString(int value)
        {
            return $"O campo {FieldName} tem de ter mais de {value} caracteres.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"O campo {FieldName} tem de ter {value} itens ou mais.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"O campo {FieldName} tem de ter {value} caracteres ou mais.";
        }
public string In()
        {
            return $"O campo {FieldName} não contém um valor válido.";
        }
public string Integer()
        {
            return $"O campo {FieldName} deverá conter um número inteiro.";
        }
public string Ip()
        {
            return $"O campo {FieldName} deverá conter um IP válido.";
        }
public string Ipv4()
        {
            return $"O campo {FieldName} deverá conter um IPv4 válido.";
        }
public string Ipv6()
        {
            return $"O campo {FieldName} deverá conter um IPv6 válido.";
        }
public string Json()
        {
            return $"O campo {FieldName} deverá conter um texto JSON válido.";
        }
public string Lowercase()
        {
            return $"O campo {FieldName} deve ser em minúsculas.";
        }
public string LessThanArray(long value)
        {
            return $"O campo {FieldName} tem de ter menos de {value} itens.";
        }
public string LessThanString(int value)
        {
            return $"O campo {FieldName} tem de ter menos de {value} caracteres.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"O campo {FieldName} não pode ter mais de {value} itens.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"O campo {FieldName} tem de ter {value} caracteres ou menos.";
        }
public string MacAddress()
        {
            return $"O {FieldName} deve ser um endereço MAC válido.";
        }
public string MaxArray(long max)
        {
            return $"O campo {FieldName} não deverá conter mais de {max} elementos.";
        }
public string MaxNumeric(string max)
        {
            return $"O campo {FieldName} não deverá conter um valor superior a {max}.";
        }
public string MaxString(int max)
        {
            return $"O campo {FieldName} não deverá conter mais de {max} caracteres.";
        }
public string MinArray(long min)
        {
            return $"O campo {FieldName} deverá conter no mínimo {min} elementos.";
        }
public string MinNumeric(string min)
        {
            return $"O campo {FieldName} deverá ter um valor superior ou igual a {min}.";
        }
public string MinString(int min)
        {
            return $"O campo {FieldName} deverá conter no mínimo {min} caracteres.";
        }
public string NotIn()
        {
            return $"O campo {FieldName} contém um valor inválido.";
        }
public string NotRegex()
        {
            return $"O formato de {FieldName} não é válido";
        }
public string Numeric()
        {
            return $"O campo {FieldName} deverá conter um valor numérico.";
        }
public string Regex()
        {
            return $"O formato do valor para o campo {FieldName} é inválido.";
        }
public string Required()
        {
            return $"É obrigatória a indicação de um valor para o campo {FieldName}.";
        }
public string RequiredIf(string name, string value)
        {
            return $"É obrigatória a indicação de um valor para o campo {FieldName} quando o valor do campo {name} é igual a {value}.";
        }
public string Same(string name)
        {
            return $"Os campos {FieldName} e {name} deverão conter valores iguais.";
        }
public string SizeArray(long size)
        {
            return $"O campo {FieldName} deverá conter {size} elementos.";
        }
public string SizeString(int size)
        {
            return $"O campo {FieldName} deverá conter {size} caracteres.";
        }
public string StartsWith(List<string> values)
        {
            return $"O campo {FieldName} tem de começar com um dos valores seguintes: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"O campo {FieldName} deve ser em maiúsculas.";
        }
public string Url()
        {
            return $"O formato do URL indicado para o campo {FieldName} é inválido.";
        }
    }
        }