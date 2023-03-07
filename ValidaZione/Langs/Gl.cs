using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Gl : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"O {FieldName} debe ser aceptado.";
            }
public string ActiveUrl()
        {
            return $"O {FieldName} non é unha URL válida.";
        }
public string After(string date)
        {
            return $"O {FieldName} debe ser unha data despois de {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"O {FieldName} debe ser unha data posterior ou igual a {date}.";
        }
public string Alpha()
        {
            return $"O {FieldName} só debe conter letras.";
        }
public string AlphaDash()
        {
            return $"O {FieldName} só debe conter letras, números, guións e guións baixos.";
        }
public string AlphaNum()
        {
            return $"O {FieldName} só debe conter letras e números.";
        }
public string Before(string date)
        {
            return $"O {FieldName} debe ser unha data anterior a {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"O {FieldName} debe ser unha data anterior ou igual a {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"O {FieldName} debe estar entre {min} e {max} items.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"O {FieldName} debe estar entre {min} e {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"O {FieldName} debe estar entre {min} e {max} caracteres.";
        }
public string Boolean()
        {
            return $"O {FieldName} campo debe ser verdadeiro ou falso.";
        }
public string Confirmed()
        {
            return $"A {FieldName} a confirmación non coincide.";
        }
public string Declined()
        {
            return $"O {FieldName} debe ser rexeitado.";
        }
public string Different(string name)
        {
            return $"O {FieldName} e {name} debe ser diferente.";
        }
public string Distinct()
        {
            return $"O eido {FieldName} ten un valor duplicado.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"O {FieldName} non pode rematar cun dos seguintes: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"O {FieldName} non pode comezar por un dos seguintes: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"O {FieldName} debe ser un enderezo de correo-e válido.";
        }
public string EndsWith(List<string> values)
        {
            return $"O {FieldName} debe rematar cun dos seguintes: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"O {FieldName} debe ter máis de {value} items.";
        }
public string GreaterThanString(int value)
        {
            return $"O {FieldName} debe ser maior que {value} caracteres.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"O {FieldName} debe ter {value} items ou máis.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"O {FieldName} debe ser maior ou igual a {value} caracteres.";
        }
public string In()
        {
            return $"O {FieldName} seleccionado non é válido.";
        }
public string Integer()
        {
            return $"O {FieldName} debe ser un integro.";
        }
public string Ip()
        {
            return $"O {FieldName} debe ser unha dirección IP válida.";
        }
public string Ipv4()
        {
            return $"O {FieldName} debe ser unha dirección IPv4 válida.";
        }
public string Ipv6()
        {
            return $"O {FieldName} debe ser unha dirección IPv6 válida.";
        }
public string Json()
        {
            return $"O {FieldName} debe ser unha cadea JSON válida.";
        }
public string Lowercase()
        {
            return $"O {FieldName} debe estar en minúscula.";
        }
public string LessThanArray(long value)
        {
            return $"O {FieldName} debe ter menos de {value} items.";
        }
public string LessThanString(int value)
        {
            return $"O {FieldName} debe ser inferior a {value} caracteres.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"O {FieldName} non debe ter máis de {value} items.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"O {FieldName} debe ser inferior ou igual a {value} caracteres.";
        }
public string MacAddress()
        {
            return $"O {FieldName} debe ser unha dirección MAC válida.";
        }
public string MaxArray(long max)
        {
            return $"O {FieldName} non debe ter máis de {max} items.";
        }
public string MaxNumeric(string max)
        {
            return $"O {FieldName} non debe ser maior que {max}.";
        }
public string MaxString(int max)
        {
            return $"O {FieldName} non debe ser maior que {max} caracteres.";
        }
public string MinArray(long min)
        {
            return $"O {FieldName} debe ter polo menos {min} items.";
        }
public string MinNumeric(string min)
        {
            return $"O {FieldName} debe ser polo menos {min}.";
        }
public string MinString(int min)
        {
            return $"O {FieldName} deben ser polo menos {min} caracteres.";
        }
public string NotIn()
        {
            return $"O {FieldName} seleccionado non é válido.";
        }
public string NotRegex()
        {
            return $"O formato de {FieldName} non é válido.";
        }
public string Numeric()
        {
            return $"O {FieldName} debe ser un número.";
        }
public string Regex()
        {
            return $"O formato {FieldName} non é válido.";
        }
public string Required()
        {
            return $"O eido {FieldName} é obrigatorio.";
        }
public string RequiredIf(string name, string value)
        {
            return $"O eido {FieldName} é requirido cando {name} é {value}.";
        }
public string Same(string name)
        {
            return $"O {FieldName} e o {name} deben coincidir.";
        }
public string SizeArray(long size)
        {
            return $"O {FieldName} debe conter {size} items.";
        }
public string SizeString(int size)
        {
            return $"O {FieldName} debe ser {size} caracteres.";
        }
public string StartsWith(List<string> values)
        {
            return $"O {FieldName} debe comezar por un dos seguintes: {String.Join(", ", values)}.";
        }
public string Uppercase()
        {
            return $"O {FieldName} debe estar en maiúscula.";
        }
public string Url()
        {
            return $"O {FieldName} debe ser unha URL válida.";
        }
    }
        }