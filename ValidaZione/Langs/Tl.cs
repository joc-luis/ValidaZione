using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Tl : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Ang {FieldName} ay dapat tanggapin.";
            }
public string ActiveUrl()
        {
            return $"Ang {FieldName} ay hindi balidong URL.";
        }
public string After(string date)
        {
            return $"Ang {FieldName} ay dapat petsa pagkatapos ng {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Ang {FieldName} ay dapat na isang petsa pagkatapos o katumbas ng {date}.";
        }
public string Alpha()
        {
            return $"Ang {FieldName} ay maaaring magtaglay ng mga letra lang.";
        }
public string AlphaDash()
        {
            return $"Ang {FieldName} ay maaaring magtaglay ng mga letra, numero at gitling lang.";
        }
public string AlphaNum()
        {
            return $"Ang {FieldName} ay maaaring magtaglay ng mga letra at numero lang.";
        }
public string Before(string date)
        {
            return $"Ang {FieldName} ay dapat petsa bago ang {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Ang {FieldName} ay dapat na isang petsa bago o katumbas ng {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Ang {FieldName} ay dapat nasa pagitan ng {min} at {max} items.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Ang {FieldName} ay dapat nasa pagitan ng {min} at {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Ang {FieldName} ay dapat nasa pagitan ng {min} at {max} characters.";
        }
public string Boolean()
        {
            return $"Ang {FieldName} ng attribute ay dapat tama o mali.";
        }
public string Confirmed()
        {
            return $"Ang {FieldName} ng attribute ay hindi magkatugma.";
        }
public string Declined()
        {
            return $"Dapat tanggihan ang {FieldName}.";
        }
public string Different(string name)
        {
            return $"Ang {FieldName} at {name} pa ay dapat magkaiba.";
        }
public string Distinct()
        {
            return $"Ang {FieldName} ng attribute ay may katulad na balyu.";
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
            return $"Ang {FieldName} ay dapat balidong email address.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} ang dapat magtapos sa isa sa mga sumusunod: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"Ang {FieldName} ay dapat magkaroon ng higit sa {value} mga item.";
        }
public string GreaterThanString(int value)
        {
            return $"Ang {FieldName} ay dapat na higit sa {value} character.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Ang {FieldName} ay dapat magkaroon ng {value} item o higit pa.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Ang {FieldName} ay dapat na mas malaki sa o katumbas ng {value} character.";
        }
public string In()
        {
            return $"Ang piniling {FieldName} ay imbalido.";
        }
public string Integer()
        {
            return $"Ang {FieldName} ay dapat isang integer.";
        }
public string Ip()
        {
            return $"Ang {FieldName} ay dapat isang balidong IP address.";
        }
public string Ipv4()
        {
            return $"Ang {FieldName} ay dapat na isang wastong Ipbagong address.";
        }
public string Ipv6()
        {
            return $"Ang {FieldName} ay dapat na isang balidong Ipbagong address.";
        }
public string Json()
        {
            return $"Ang {FieldName} ay dapat isang balidong JSON string.";
        }
public string Lowercase()
        {
            return $"Dapat lowercase ang {FieldName}.";
        }
public string LessThanArray(long value)
        {
            return $"Ang {FieldName} ay dapat magkaroon ng mas mababa sa {value} na mga item.";
        }
public string LessThanString(int value)
        {
            return $"Dapat mas mababa sa {value} character ang {FieldName}.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"Ang {FieldName} ay hindi dapat magkaroon ng higit sa {value} mga item.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"Ang {FieldName} ay dapat mas mababa sa o katumbas ng {value} character.";
        }
public string MacAddress()
        {
            return $"Ang {FieldName} ay dapat na isang wastong MAC address.";
        }
public string MaxArray(long max)
        {
            return $"Ang {FieldName} ay hindi maaaring higit sa {max} items.";
        }
public string MaxNumeric(string max)
        {
            return $"Ang {FieldName} ay hindi maaaring higit sa  {max}.";
        }
public string MaxString(int max)
        {
            return $"Ang {FieldName} ay hindi maaaring higit sa {max} characters.";
        }
public string MinArray(long min)
        {
            return $"Ang {FieldName} ay dapat di-kukulangin sa {min} items.";
        }
public string MinNumeric(string min)
        {
            return $"Ang {FieldName} ay dapat di-kukulangin sa {min}.";
        }
public string MinString(int min)
        {
            return $"Ang {FieldName} ay dapat di-kukulangin sa {min} characters.";
        }
public string NotIn()
        {
            return $"Ang piniling {FieldName} ay imbalido.";
        }
public string NotRegex()
        {
            return $"Hindi tanggap ang {FieldName} na anyo.";
        }
public string Numeric()
        {
            return $"Ang {FieldName} ay dapat isang numero.";
        }
public string Regex()
        {
            return $"Ang {FieldName} ng attribute ay imbalido.";
        }
public string Required()
        {
            return $"Ang {FieldName} ng attribute ay kailangan.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Ang {FieldName} ng attribute ay kailangan kapag {name} iba ay {value}.";
        }
public string Same(string name)
        {
            return $"Ang {FieldName} at {name} pa ay dapat magtugma.";
        }
public string SizeArray(long size)
        {
            return $"Ang {FieldName} ay dapat magtaglay ng {size} sa items.";
        }
public string SizeString(int size)
        {
            return $"Ang {FieldName} ay dapat {size} sukat sa characters.";
        }
public string StartsWith(List<string> values)
        {
            return $"Ang {FieldName} ay dapat magsimula sa isa sa mga sumusunod: {String.Join(", ", values)}.";
        }
public string Uppercase()
        {
            return $"Ang {FieldName} ay dapat na uppercase.";
        }
public string Url()
        {
            return $"Ang {FieldName} ng attribute ay imbalido.";
        }
    }
        }