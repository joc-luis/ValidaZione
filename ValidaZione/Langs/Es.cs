using System;
using System.Collections.Generic;
using ValidaZione.Interfaces;

namespace ValidaZione.Langs
{
    public class Es : ILang
    {
        public string FieldName { get; set; }

        public string Accepted()
        {
            return $"El campo {FieldName} debe ser aceptado.";
        }

        public string ActiveUrl()
        {
            return $"El campo {FieldName} debe ser una URL válida.";
        }

        public string After(string date)
        {
            return $"El campo {FieldName} debe ser una fecha posterior a {date}.";
        }

        public string AfterOrEqual(string date)
        {
            return $"El campo {FieldName} debe ser una fecha posterior o igual a {date}.";
        }

        public string Alpha()
        {
            return $"El campo {FieldName} sólo debe contener letras.";
        }

        public string AlphaDash()
        {
            return $"El campo {FieldName} sólo debe contener letras, números, guiones y guiones bajos.";
        }

        public string AlphaNum()
        {
            return $"El campo {FieldName} sólo debe contener letras y números.";
        }

        public string Before(string date)
        {
            return $"El campo {FieldName} debe ser una fecha anterior a {date}.";
        }

        public string BeforeOrEqual(string date)
        {
            return $"El campo {FieldName} debe ser una fecha anterior o igual a {date}.";
        }

        public string BetweenNumeric(string min, string max)
        {
            return $"El campo {FieldName} tiene que estar entre {min} - {max}.";
        }

        public string BetweenString(int min, int max)
        {
            return $"El campo {FieldName} tiene que tener entre {min} - {max} caracteres.";
        }

        public string BetweenArray(long min, long max)
        {
            return $"El campo {FieldName} tiene que tener entre {min} - {max} elementos.";
        }

        public string Boolean()
        {
            return $"El campo {FieldName} debe tener un valor verdadero o falso.";
        }

        public string Confirmed()
        {
            return $"La confirmación de {FieldName} no coincide.";
        }

        public string Declined()
        {
            return $"El campo {FieldName} debe ser rechazado.";
        }

        public string Different(string name)
        {
            return $"El campo {FieldName} y {name} deben ser diferentes.";
        }

        public string Distinct()
        {
            return $"El campo {FieldName} contiene un valor duplicado.";
        }

        public string Email()
        {
            return $"El campo {FieldName} no es un correo válido.";
        }

        public string EndsWith(List<string> values)
        {
            return $"El campo {FieldName} debe finalizar con uno de los siguientes valores: {String.Join(", ", values)}";
        }

        public string GreaterThanArray(long value)
        {
            return $"El campo {FieldName} debe tener más de {value} elementos.";
        }

        public string GreaterThanString(int value)
        {
            return $"El campo {FieldName} debe tener más de {value} caracteres.";
        }

        public string GreaterThanOrEqualArray(long value)
        {
            return $"El campo {FieldName} debe tener como mínimo {value} elementos.";
        }

        public string GreaterThanOrEqualString(int value)
        {
            return $"El campo {FieldName} debe tener como mínimo {value} caracteres.";
        }

        public string In()
        {
            return $"The {FieldName} seleccionado no es válido.";
        }

        public string Integer()
        {
            return $"El campo {FieldName} debe ser un número entero.";
        }

        public string Ip()
        {
            return $"El campo {FieldName} debe ser una dirección IP válida.";
        }

        public string Ipv4()
        {
            return $"El campo {FieldName} debe ser una dirección IPv4 válida.";
        }

        public string Ipv6()
        {
            return $"El campo {FieldName} debe ser una dirección IPv6 válida.";
        }

        public string Json()
        {
            return $"El campo {FieldName} debe ser una cadena JSON válida.";
        }

        public string Lowercase()
        {
            return $"El campo {FieldName} debe estar en minúscula.";
        }

        public string LessThanArray(long value)
        {
            return $"El campo {FieldName} debe tener menos de {value} elementos.";
        }

        public string LessThanString(int value)
        {
            return $"El campo {FieldName} debe tener menos de {value} caracteres.";
        }

        public string LessThanOrEqualArray(long value)
        {
            return $"El campo {FieldName} debe tener como máximo {value} elementos.";
        }

        public string LessThanOrEqualString(int value)
        {
            return $"El campo {FieldName} debe tener como máximo {value} caracteres.";
        }

        public string MacAddress()
        {
            return $"El campo {FieldName} debe ser una dirección MAC válida.";
        }

        public string MaxArray(long max)
        {
            return $"El campo {FieldName} no debe tener más de {max} elementos.";
        }

        public string MaxNumeric(string max)
        {
            return $"El campo {FieldName} no debe ser mayor que {max}.";
        }

        public string MaxString(int max)
        {
            return $"El campo {FieldName} no debe ser mayor que {max} caracteres.";
        }

        public string MinArray(long min)
        {
            return $"El campo {FieldName} debe tener al menos {min} elementos.";
        }

        public string MinNumeric(string min)
        {
            return $"El tamaño de {FieldName} debe ser de al menos {min}.";
        }

        public string MinString(int min)
        {
            return $"El campo {FieldName} debe contener al menos {min} caracteres.";
        }

        public string NotIn()
        {
            return $"El {FieldName} seleccionado no es válido.";
        }

        public string NotRegex()
        {
            return $"El formato del campo {FieldName} no es válido.";
        }

        public string Numeric()
        {
            return $"El campo {FieldName} debe ser numérico.";
        }

        public string Regex()
        {
            return $"El formato del campo {FieldName} no es válido.";
        }

        public string Required()
        {
            return $"El campo {FieldName} es obligatorio.";
        }

        public string Same(string name)
        {
            return $"Los campos {FieldName} y {name} deben coincidir.";
        }

        public string SizeArray(long size)
        {
            return $"El campo {FieldName} debe contener {size} elementos.";
        }

        public string SizeString(int size)
        {
            return $"El campo {FieldName} debe contener {size} caracteres.";
        }

        public string StartsWith(List<string> values)
        {
            return $"El campo {FieldName} debe comenzar con uno de los siguientes valores: {String.Join(", ", values)}";
        }

        public string Uppercase()
        {
            return $"El campo {FieldName} debe estar en mayúscula.";
        }

        public string Url()
        {
            return $"El campo {FieldName} debe ser una URL válida.";
        }
    }
}