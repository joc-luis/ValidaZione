using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Sw : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Lazima kipengele kikubaliwe.";
            }
public string ActiveUrl()
        {
            return $"Kipengele sio Chanzo Cha Anuani halali.";
        }
public string After(string date)
        {
            return $"Kipengele lazima kiwe tarehe baada ya {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} inapaswa kuwa tarehe baada au sawa na {date}.";
        }
public string Alpha()
        {
            return $"Kipengele huenda kikawa tu chenye herufi.";
        }
public string AlphaDash()
        {
            return $"Kipengele huenda kikawa tu chenye herufi, na vistari.";
        }
public string AlphaNum()
        {
            return $"Kipengele huenda kikawa tu chenye herufi na nambari.";
        }
public string Before(string date)
        {
            return $"Kipengele lazima kiwe tarehe kabla ya {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} inapaswa kuwa tarehe kabla au sawa na {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Kipengele lazima kiwe na kati ya {min} na {max} cha vifungu.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Kipengele lazima kiwe kati ya {min} na {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Kipengele lazima kiwe kati ya {min} na {max} cha herufi.";
        }
public string Boolean()
        {
            return $"Sehemu ya kipengele lazima iwe kweli au si kweli.";
        }
public string Confirmed()
        {
            return $"Uthibitisho wa kipengele haulingani.";
        }
public string Declined()
        {
            return $"{FieldName} inapaswa kukataliwa.";
        }
public string Different(string name)
        {
            return $"Kipengele na {name} lazima viwe tofauti.";
        }
public string Distinct()
        {
            return $"Sehemu ya kipengele ina thamani rudufu.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} inaweza isiishie na mojawapo ya yafuatayo: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} inaweza isianze na mojawapo ya yafuatayo: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Kipengele lazima kiwe anuani halali ya barua pepe.";
        }
public string EndsWith(List<string> values)
        {
            return $"Ya {FieldName} lazima mwisho na moja ya yafuatayo: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} inapaswa kuwa na vitu zaidi ya {value}.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} inapaswa kuwa kubwa kuliko herufi {value}.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} inapaswa kuwa na vitu {value} au zaidi.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} inapaswa kuwa kubwa kuliko au sawa na herufi {value}.";
        }
public string In()
        {
            return $"Kipengele kilichochaguliwa si halali.";
        }
public string Integer()
        {
            return $"Kipengele lazima kiwe nambari kamili.";
        }
public string Ip()
        {
            return $"Kipengele lazima kiwe anuani halali ya Itifaki ya Intaneti.";
        }
public string Ipv4()
        {
            return $"{FieldName} inapaswa kuwa anwani ya IPv4 sahihi.";
        }
public string Ipv6()
        {
            return $"{FieldName} inapaswa kuwa anwani ya IPv6 sahihi.";
        }
public string Json()
        {
            return $"Kipengele lazima kiwe kidwe halali cha Nukuu ya Java.";
        }
public string Lowercase()
        {
            return $"{FieldName} ni lazima iwe na herufi ndogo..";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} inapaswa kuwa chini ya vitu {value}.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} inapaswa kuwa chini ya herufi {value}.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} haipaswi kuwa na vitu ziadi ya {value}.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} inapaswa kuwa ndogo au sawa na herufi {value}.";
        }
public string MacAddress()
        {
            return $"Kipengele {FieldName} kinapaswa kuwa anwani sahihi ya MAC.";
        }
public string MaxArray(long max)
        {
            return $"Kipengele huenda kisiwe na zaidi ya {max} cha vifungu.";
        }
public string MaxNumeric(string max)
        {
            return $"Kipengele huenda si kikubwa kuliko {max}.";
        }
public string MaxString(int max)
        {
            return $"Kipengele huenda si kikubwa kuliko {max} cha herufi.";
        }
public string MinArray(long min)
        {
            return $"Kipengele lazima kiwe na angalau {min} cha vifungu.";
        }
public string MinNumeric(string min)
        {
            return $"Kipengele lazima kiwe angalau {min}.";
        }
public string MinString(int min)
        {
            return $"Kipengele lazima kiwe angalau {min} cha herufi.";
        }
public string NotIn()
        {
            return $"Kipengele kilichochaguliwa si halali.";
        }
public string NotRegex()
        {
            return $"Muundo wa {FieldName} si sahihi.";
        }
public string Numeric()
        {
            return $"Kipengele lazima kiwe nambari.";
        }
public string Regex()
        {
            return $"Muundo wa kipengele si halali.";
        }
public string Required()
        {
            return $"Sehemu ya kipengele inahitajika.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Sehemu ya kipengele inahitajika wakati {name} ni {value}.";
        }
public string Same(string name)
        {
            return $"Kipengele na {name} lazima vilingane.";
        }
public string SizeArray(long size)
        {
            return $"Kipengele lazima kiwe chenye {size} ya kipimo.";
        }
public string SizeString(int size)
        {
            return $"Kipengele lazima kiwe {size} cha herufi.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} inapaswa kuanza na moja kati ya hizi zifuatazo: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"{FieldName} ni lazima iwe ya herufi kubwa.";
        }
public string Url()
        {
            return $"Muundo wa kipengele si halali.";
        }
    }
        }