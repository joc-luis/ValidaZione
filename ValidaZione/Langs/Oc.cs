using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Oc : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Lo camp {FieldName} deu èsser acceptat.";
            }
public string ActiveUrl()
        {
            return $"Lo camp {FieldName} es pas una URL valida.";
        }
public string After(string date)
        {
            return $"Lo camp {FieldName} deu èsser una data posteriora a {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Lo camp {FieldName} deu èsser una data posteriora o egala a {date}.";
        }
public string Alpha()
        {
            return $"Lo camp {FieldName} a de conténer solament de letras.";
        }
public string AlphaDash()
        {
            return $"Lo camp {FieldName} a de conténer solament de letras, nombres e de tirets.";
        }
public string AlphaNum()
        {
            return $"Lo camp {FieldName} a de conténer solament de letras e nombres.";
        }
public string Before(string date)
        {
            return $"Lo camp {FieldName} deu èsser una data anteriora a {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Lo camp {FieldName} deu èsser una data anteriora o egala a {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Lo tablèu {FieldName} deu aver entre {min} e {max} elements.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"La valor de {FieldName} deu èsser entre {min} e {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Lo tèxt {FieldName} deu conténer entre {min} e {max} caractèrs.";
        }
public string Boolean()
        {
            return $"Lo camp {FieldName} deu èsser true o false.";
        }
public string Confirmed()
        {
            return $"Lo camp de confirmacion {FieldName} correspond pas.";
        }
public string Declined()
        {
            return $"The {FieldName} must be declined.";
        }
public string Different(string name)
        {
            return $"Los camps {FieldName} e {name} devon èsser diferents.";
        }
public string Distinct()
        {
            return $"Lo camp {FieldName} a un doblon.";
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
            return $"{FieldName} deu èsser una adreça de corrièl valida.";
        }
public string EndsWith(List<string> values)
        {
            return $"Lo camp {FieldName} deu acabar per una de las valors seguentas : {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"Lo tablèu {FieldName} deu conténer mai de {value} elements.";
        }
public string GreaterThanString(int value)
        {
            return $"Lo tèxt {FieldName} deu conténer mai de {value} caractèrs.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Lo tablèu {FieldName} deu conténer almens {value} elements.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Lo tèxt {FieldName} deu conténer almens {value} caractèrs.";
        }
public string In()
        {
            return $"Lo camp {FieldName} selecionnat es invalid.";
        }
public string Integer()
        {
            return $"Lo camp {FieldName} deu èsser un nombre entièr.";
        }
public string Ip()
        {
            return $"Lo camp {FieldName} deu èsser una adreça IP valida.";
        }
public string Ipv4()
        {
            return $"Lo camp {FieldName} deu èsser una adreça IPv4 valida.";
        }
public string Ipv6()
        {
            return $"Lo camp {FieldName} deu èsser una adreça IPv6 valida.";
        }
public string Json()
        {
            return $"Lo camp {FieldName} deu èsser una cadena JSON valida.";
        }
public string Lowercase()
        {
            return $"The {FieldName} must be lowercase.";
        }
public string LessThanArray(long value)
        {
            return $"Lo tablèu {FieldName} deu conténer almens {value} elements.";
        }
public string LessThanString(int value)
        {
            return $"Lo tèxt {FieldName} deu conténer almens {value} caractèrs.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"Lo tablèu {FieldName} deu conténer al pus mai {value} elements.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"Lo tèxt {FieldName} deu conténer al pus mai {value} caractèrs.";
        }
public string MacAddress()
        {
            return $"The {FieldName} must be a valid MAC address.";
        }
public string MaxArray(long max)
        {
            return $"Lo tablèu {FieldName} deu pas conténer mai de {max} elements.";
        }
public string MaxNumeric(string max)
        {
            return $"La valor de {FieldName} deu pas èsser superiora a {max}.";
        }
public string MaxString(int max)
        {
            return $"Lo tèxt {FieldName} deu èsser superior a {max} caractèrs.";
        }
public string MinArray(long min)
        {
            return $"Lo tablèu {FieldName} deu conténer almens {min} elements.";
        }
public string MinNumeric(string min)
        {
            return $"La valor de {FieldName} deu fa almens {min} o mai.";
        }
public string MinString(int min)
        {
            return $"Lo tèxt {FieldName} deu fa almens {min} caractèrs.";
        }
public string NotIn()
        {
            return $"Lo camp {FieldName} seleccionat es invalid.";
        }
public string NotRegex()
        {
            return $"Lo format {FieldName} es invalid.";
        }
public string Numeric()
        {
            return $"Lo camp {FieldName} deu èsser un nombre.";
        }
public string Regex()
        {
            return $"Lo format {FieldName} es invalid.";
        }
public string Required()
        {
            return $"Lo camp {FieldName} es obligatòri.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Lo camp {FieldName} es obligatòri quand {name} es {value}.";
        }
public string Same(string name)
        {
            return $"Los camps {FieldName} e {name} devon correspondre.";
        }
public string SizeArray(long size)
        {
            return $"Lo tablèu {FieldName} deu conténer {size} elements.";
        }
public string SizeString(int size)
        {
            return $"Lo tèxt {FieldName} deu fa {size} caractèrs.";
        }
public string StartsWith(List<string> values)
        {
            return $"Lo camp {FieldName} deu començar amb una de las valors seguentas : {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"The {FieldName} must be uppercase.";
        }
public string Url()
        {
            return $"Lo format de {FieldName} es invalid.";
        }
    }
        }