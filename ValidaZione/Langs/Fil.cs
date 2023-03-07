using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Fil : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Dapat na tanggapin ang {FieldName}.";
            }
public string ActiveUrl()
        {
            return $"Hindi valid na URL ang {FieldName}.";
        }
public string After(string date)
        {
            return $"Ang {FieldName} ay dapat na isang petsa pagkatapos ng {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Ang {FieldName} ay dapat na isang petsa na pagkatapos o katumbas ng {date}.";
        }
public string Alpha()
        {
            return $"Mga titik lang dapat ang nilalaman ng {FieldName}.";
        }
public string AlphaDash()
        {
            return $"Mag titik, numero, gitlling at underscore lang dapat ang nilalaman ng {FieldName}.";
        }
public string AlphaNum()
        {
            return $"Mag titik, numero, gitlling at underscore lang dapat ang nilalaman ng {FieldName}.";
        }
public string Before(string date)
        {
            return $"Ang {FieldName} ay dapat na isang petsa bago ang {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Ang {FieldName} ay dapat na isang petsa bago ang o katumbas ng {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Ang {FieldName} ay dapat na nasa pagitan ng {min} at {max} (na) item.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Ang {FieldName} ay dapat na nasa pagitan ng {min} at {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Ang {FieldName} ay dapat na nasa pagitan ng {min} at {max} (na) character.";
        }
public string Boolean()
        {
            return $"Dapat na true o false ang field na {FieldName}.";
        }
public string Confirmed()
        {
            return $"Hindi tumutugma ang pagkumpirma ng {FieldName}.";
        }
public string Declined()
        {
            return $"Dapat tanggihan ang {FieldName}.";
        }
public string Different(string name)
        {
            return $"Dapat na magkaiba ang {FieldName} at {name}.";
        }
public string Distinct()
        {
            return $"May duplicate na value ang field na {FieldName}.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"Ang {FieldName} ay maaaring hindi magtapos sa isa sa mga sumusunod: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"Ang {FieldName} ay maaaring hindi magsimula sa isa sa mga sumusunod: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Dapat na valid na email address ang {FieldName}.";
        }
public string EndsWith(List<string> values)
        {
            return $"Ang {FieldName} ay dapat magtapos sa isa sa mga sumusunod: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"Ang {FieldName} ay dapat na mayroong mahigit sa {value} (na) item.";
        }
public string GreaterThanString(int value)
        {
            return $"Ang {FieldName} ay dapat na mas marami sa {value} (na) character.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Ang {FieldName} ay dapat na mayroong {value} (na) item o higit pa.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Ang {FieldName} ay dapat na mas marami sa o katumbas ng {value} (na) character.";
        }
public string In()
        {
            return $"Hindi valid ang piniling {FieldName}.";
        }
public string Integer()
        {
            return $"Dapat na isang integer ang {FieldName}.";
        }
public string Ip()
        {
            return $"Dapat na valid na IP address ang {FieldName}.";
        }
public string Ipv4()
        {
            return $"Dapat na valid na IPv4 address ang {FieldName}.";
        }
public string Ipv6()
        {
            return $"Dapat na IPv6 address ang {FieldName}.";
        }
public string Json()
        {
            return $"Dapat na valid na JSON string ang {FieldName}.";
        }
public string Lowercase()
        {
            return $"Dapat lowercase ang {FieldName}.";
        }
public string LessThanArray(long value)
        {
            return $"Ang {FieldName} ay dapat na may mas bababa sa {value} (na) item.";
        }
public string LessThanString(int value)
        {
            return $"Ang {FieldName} ay dapat na mas mababa sa {value} (na) character.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"Hindi dapat magkaroon ang {FieldName} ng higit sa {value} (na) item.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"Ang {FieldName} ay dapat na mas mababa sa o katumbas ng {value} (na) character.";
        }
public string MacAddress()
        {
            return $"Ang {FieldName} ay dapat na isang wastong MAC address.";
        }
public string MaxArray(long max)
        {
            return $"Hindi dapat magkaroon ang {FieldName} ng mahigit sa {max} (na) item.";
        }
public string MaxNumeric(string max)
        {
            return $"Ang {FieldName} ay hindi dapat mas malaki sa {max}.";
        }
public string MaxString(int max)
        {
            return $"Ang {FieldName} ay hindi dapat mas malaki sa {max} (na) character.";
        }
public string MinArray(long min)
        {
            return $"Ang {FieldName} ay dapat na may hindi bababa sa {min} (na) item.";
        }
public string MinNumeric(string min)
        {
            return $"Ang {FieldName} ay dapat na hindi bababa sa {min}.";
        }
public string MinString(int min)
        {
            return $"Ang {FieldName} ay dapat na hindi bababa sa {min} (na) character.";
        }
public string NotIn()
        {
            return $"Hindi valid ang piniling {FieldName}.";
        }
public string NotRegex()
        {
            return $"Hindi valid ang format na {FieldName}.";
        }
public string Numeric()
        {
            return $"Dapat na numero ang {FieldName}.";
        }
public string Regex()
        {
            return $"Hindi valid ang format na {FieldName}.";
        }
public string Required()
        {
            return $"Kinakailangan ang field na {FieldName}.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Kinakailangan ang field na {FieldName} kapag ang {name} ay {value}.";
        }
public string Same(string name)
        {
            return $"Dapat na magtugma ang {FieldName} at {name}.";
        }
public string SizeArray(long size)
        {
            return $"Dapat na maglaman ang {FieldName} ng {size} (na) item.";
        }
public string SizeString(int size)
        {
            return $"Ang {FieldName} ay dapat na {size} (na) character.";
        }
public string StartsWith(List<string> values)
        {
            return $"Dapat na magsimula ang {FieldName} sa isa sa sumusunod: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"Ang {FieldName} ay dapat na uppercase.";
        }
public string Url()
        {
            return $"Hindi valid ang format na {FieldName}.";
        }
    }
        }