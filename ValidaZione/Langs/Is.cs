using System.Collections.Generic;
using ValidaZione.Interfaces;
using System;

namespace ValidaZione.Langs
{
    public class IS : ILang
    {
        public string FieldName { get; set; }

        public string Accepted()
        {
            return $"Reiturinn {FieldName} verður að vera samþykktur.";
        }

        public string ActiveUrl()
        {
            return $"Reiturinn {FieldName} er ekki leyfileg vefslóð.";
        }

        public string After(string date)
        {
            return $"Reiturinn {FieldName} verður að vera dagsetning eftir {date}.";
        }

        public string AfterOrEqual(string date)
        {
            return $"{FieldName} verður að vera dagsetning eftir eða sú sama og {date}.";
        }

        public string Alpha()
        {
            return $"Reiturinn {FieldName} má aðeins innihalda bókstafi.";
        }

        public string AlphaDash()
        {
            return $"Reiturinn {FieldName} má aðeins innihalda bókstafi, tölur og undirstikanir.";
        }

        public string AlphaNum()
        {
            return $"Reiturinn {FieldName} má aðeins innihalda bókstafi og tölur.";
        }

        public string Before(string date)
        {
            return $"Reiturinn {FieldName} verður að vera dagsetning eftir {date}.";
        }

        public string BeforeOrEqual(string date)
        {
            return $"{FieldName} verður að vera dagsetning fyrir eða sú samaog {date}.";
        }

        public string BetweenArray(long min, long max)
        {
            return $"Reiturinn {FieldName} verður að vera á milli {min} - {max} staka.";
        }

        public string BetweenNumeric(string min, string max)
        {
            return $"Reiturinn {FieldName} verður að vera á milli {min} - {max}.";
        }

        public string BetweenString(int min, int max)
        {
            return $"Reiturinn {FieldName} verður að vera á milli {min} - {max} stafa.";
        }

        public string Boolean()
        {
            return $"Reiturinn {FieldName} verður að vera réttur eða rangur.";
        }

        public string Confirmed()
        {
            return $"Staðfesting á reitnum {FieldName} passar ekki.";
        }

        public string Declined()
        {
            return $"{FieldName} verður að hafna.";
        }

        public string Different(string name)
        {
            return $"Reiturinn {FieldName} og {name} verða að vera ólíkir.";
        }

        public string Distinct()
        {
            return $"{FieldName} reiturinn hefur tvítekið gildi.";
        }

        public string Email()
        {
            return $"Reiturinn {FieldName} snið netfangsins er ekki rétt.";
        }

        public string EndsWith(List<string> values)
        {
            return $"Við {FieldName} verður að enda með eftirfarandi: {String.Join(", ", values)}.";
        }

        public string GreaterThanArray(long value)
        {
            return $"{FieldName} verður að hafa fleiri en {value} atriði.";
        }

        public string GreaterThanString(int value)
        {
            return $"{FieldName} verður að vera lengri en {value} stafir.";
        }

        public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} verður að hafa {value} eða fleiri atriði.";
        }

        public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} verður að vera lengri eða jafnlangur og {value} stafir.";
        }

        public string In()
        {
            return $"Reiturinn {FieldName} er ekki réttur.";
        }

        public string Integer()
        {
            return $"Reiturinn {FieldName} verður að vera tala.";
        }

        public string Ip()
        {
            return $"Reiturinn {FieldName} verður að vera lögleg IP-tala.";
        }

        public string Ipv4()
        {
            return $"{FieldName} verður að vera gild IPv4-tala.";
        }

        public string Ipv6()
        {
            return $"{FieldName} verður að vera gild IPv6-tala.";
        }

        public string Json()
        {
            return $"{FieldName} verður að vera gildur JSON-strengur.";
        }

        public string Lowercase()
        {
            return $"{FieldName} verða að vera lágstafir.";
        }

        public string LessThanArray(long value)
        {
            return $"{FieldName} verður að hafa færri en {value} atriði.";
        }

        public string LessThanString(int value)
        {
            return $"{FieldName} verður að vera styttri en {value} stafir.";
        }

        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} má ekki hafa fleiri en {value} atriði.";
        }

        public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} verður að vera styttri eða jafnlangur og {value} stafir.";
        }

        public string MacAddress()
        {
            return $"{FieldName} verður að vera gilt MAC vistfang.";
        }

        public string MaxArray(long max)
        {
            return $"Reiturinn {FieldName} verður að innihalda færri en {max} stök.";
        }

        public string MaxNumeric(string max)
        {
            return $"Reiturinn {FieldName} verður að innihalda færri stafi en {max}.";
        }

        public string MaxString(int max)
        {
            return $"Reiturinn {FieldName} verður að innihalda færri en {max} stafi.";
        }

        public string MinArray(long min)
        {
            return $"Reiturinn {FieldName} verður að vera að lágmarki {min} stök.";
        }

        public string MinNumeric(string min)
        {
            return $"Reiturinn {FieldName} verður að vera að lágmarki {min} tölustafir.";
        }

        public string MinString(int min)
        {
            return $"Reiturinn {FieldName} verður að vera að lágmarki {min} stafir.";
        }

        public string NotIn()
        {
            return $"Reiturinn {FieldName} er ógildur.";
        }

        public string NotRegex()
        {
            return $"{FieldName} sniðið er ógilt.";
        }

        public string Numeric()
        {
            return $"Reiturinn {FieldName} verður að vera tala.";
        }

        public string Regex()
        {
            return $"Reiturinn {FieldName} er ekki á réttu formi.";
        }

        public string Required()
        {
            return $"Reiturinn {FieldName} er nauðsynlegur.";
        }

        public string Same(string name)
        {
            return $"Reiturinn {FieldName} og {name} verða að stemma.";
        }

        public string SizeArray(long size)
        {
            return $"Reiturinn {FieldName} verður að innihalda :size hluti.";
        }

        public string SizeString(int size)
        {
            return $"Reiturinn {FieldName} verður að vera :size stafir.";
        }

        public string StartsWith(List<string> values)
        {
            return $"{FieldName} verður að byrja á einu af eftirfarandi: {String.Join(", ", values)}";
        }

        public string Uppercase()
        {
            return $"{FieldName} verða að vera hástafir.";
        }

        public string Url()
        {
            return $"Reiturinn {FieldName} verður að vera netslóð.";
        }
    }
}