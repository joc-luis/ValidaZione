using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Gu : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} સ્વીકૃત હોવું જોઈએ.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} માન્ય URL નથી.";
        }
public string After(string date)
        {
            return $"{FieldName} પછી તારીખ હોવી જોઈએ :તારીખ.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} પછી તારીખ કે સમાંતર હોવું જોઈએ :તારીખ.";
        }
public string Alpha()
        {
            return $"{FieldName} માત્ર અક્ષરોનો જ સમાવેશ કરી શકે.";
        }
public string AlphaDash()
        {
            return $"{FieldName} માત્ર અક્ષરો, આંકડાઓ, ડેશ અને ની નીચે લીટીનો જ સમાવેશ કરી શકે.";
        }
public string AlphaNum()
        {
            return $"{FieldName} માત્ર અક્ષરો તથા આંકડાઓનો જ સમાવેશ કરી શકે.";
        }
public string Before(string date)
        {
            return $"{FieldName} પહેલાં તારીખ હોવી જોઈએ :તારીખ.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} પહેલાં તારીખ કે સમાંતર હોવું જોઈએ :તારીખ.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} ની વચ્ચે હોવું જોઈએ {min} અને {max} વસ્તુઓ.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} ની વચ્ચે હોવું જોઈએ {min} અને {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} ની વચ્ચે હોવું જોઈએ {min} અને {max} અક્ષરો.";
        }
public string Boolean()
        {
            return $"{FieldName} પ્રવૃત્તિ ક્ષેત્ર ખરું કે ખોટું હોવું જોઈએ.";
        }
public string Confirmed()
        {
            return $"{FieldName} પુષ્ટિકરણ બંધબેસતું નથી.";
        }
public string Declined()
        {
            return $"{FieldName} નકારવા જ જોઈએ.";
        }
public string Different(string name)
        {
            return $"{FieldName} અને {name} અલગ હોવું જોઈએ.";
        }
public string Distinct()
        {
            return $"{FieldName} પ્રવૃત્તિ ક્ષેત્રનું નકલી મૂલ્ય છે.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} નીચેનામાંથી એક સાથે સમાપ્ત થઈ શકે નહીં: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} નીચેનામાંથી એકથી શરૂ ન થઈ શકે: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} માન્ય ઈમેઈલ એડ્રેસ હોવું જોઈએ.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} નીચેમાંથી એક પ્રમાણે પૂરું થતું હોવું જોઈએ {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} ના કરતાં વિશેષ {value} વસ્તુઓ.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} થી વિશેષ હોવું જોઈએ {value} મૂલ્ય અક્ષરો.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} હોવું જોઈએ {value} વસ્તુઓ કે વિશેષ.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} થી વિશેષ અથવા સમાંતર હોવું જોઈએ {value} મૂલ્ય અક્ષરો.";
        }
public string In()
        {
            return $"{FieldName} અમાન્ય છે.";
        }
public string Integer()
        {
            return $"{FieldName} પૂર્ણ સંખ્યા હોવી જોઈએ.";
        }
public string Ip()
        {
            return $"{FieldName} માન્ય IP address હોવું જોઈએ.";
        }
public string Ipv4()
        {
            return $"{FieldName} માન્ય IPv4 address હોવું જોઈએ.";
        }
public string Ipv6()
        {
            return $"{FieldName} માન્ય IPv6 address હોવું જોઈએ.";
        }
public string Json()
        {
            return $"{FieldName} માન્ય JSON શબ્દમાળા હોવી જોઈએ.";
        }
public string Lowercase()
        {
            return $"{FieldName} લોઅરકેસ હોવું આવશ્યક છે.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} ઓછું હોવું જોઈએ {value} વસ્તુઓ.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} ઓછું હોવું જોઈએ {value} અક્ષરો.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} ના કરતા વધુ ન હોવું જોઈએ {value} વસ્તુઓ.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} ઓછું કે સમાંતર હોવું જોઈએ {value} અક્ષરો.";
        }
public string MacAddress()
        {
            return $"{FieldName} એ માન્ય MAC સરનામું હોવું આવશ્યક છે.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} ના કરતાં વધુ ન હોઈ શકે {max} વસ્તુઓ.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} મોટું ન હોઈ શકે {max}.";
        }
public string MaxString(int max)
        {
            return $"{FieldName} મોટું ન હોઈ શકે {max} અક્ષરો.";
        }
public string MinArray(long min)
        {
            return $"{FieldName}  હોવું જ જોઈએ {min} વસ્તુઓ.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} ઓછામાં ઓછું હોવું જોઈએ {min}.";
        }
public string MinString(int min)
        {
            return $"{FieldName} ઓછામાં ઓછું હોવું જોઈએ {min} અક્ષરો.";
        }
public string NotIn()
        {
            return $"પસંદ કરાયેલ {FieldName} અમાન્ય છે.";
        }
public string NotRegex()
        {
            return $"{FieldName} અમાન્ય ગોઠવણ છે.";
        }
public string Numeric()
        {
            return $"{FieldName} આંક હોવો જોઈએ.";
        }
public string Regex()
        {
            return $"{FieldName} અમાન્ય ગોઠવણ છે.";
        }
public string Required()
        {
            return $"{FieldName} પ્રવૃત્તિ ક્ષેત્ર આવશ્યક છે.";
        }
public string RequiredIf(string name, string value)
        {
            return $"{FieldName} પ્રવૃત્તિ ક્ષેત્ર આવશ્યક છે જ્યારે {name} છે {value}.";
        }
public string Same(string name)
        {
            return $"{FieldName} અને {name} બંધબેસતું હોવું જોઈએ.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} સમાવેશ કરતું હોવું જોઈએ : કદ વસ્તુઓ.";
        }
public string SizeString(int size)
        {
            return $"{FieldName} હોવું જોઈએ {size} અક્ષરો.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} નીચેમાંથી કોઈએક વડે શરૂ થતું હોવું જોઈએ {String.Join(", ", values)}.";
        }
public string Unique()
                {
                    return $"{FieldName} પહેલેથી લઈ લેવામાં આવેલ છે.";
                }
public string Uppercase()
        {
            return $"{FieldName} અપરકેસ હોવા જોઈએ.";
        }
public string Url()
        {
            return $"{FieldName} ગોઠવણ અમાન્ય છે.";
        }
    }
        }