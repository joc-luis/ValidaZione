using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Lv : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} ir jābūt pieņemtam.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} ir ar nederīgu saiti.";
        }
public string After(string date)
        {
            return $"{FieldName} ir jābūt ar datumu pēc {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} ir jābūt ar datumu pēc vai vienādu ar {date}.";
        }
public string Alpha()
        {
            return $"{FieldName} var saturēt tikai burtus.";
        }
public string AlphaDash()
        {
            return $"{FieldName} var saturēt tikai burtus, numurus un atstarpes.";
        }
public string AlphaNum()
        {
            return $"{FieldName} var tikai saturēt burtus un numurus.";
        }
public string Before(string date)
        {
            return $"{FieldName} ir jābūt ar datumu pirms {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} ir jābūt ar datumu pirms vai vienādu ar {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} jābūt no {min} līdz {max} vienībām.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} jābūt starp {min} un {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} jābūt no {min} līdz {max} zīmēm.";
        }
public string Boolean()
        {
            return $"{FieldName} lauciņam jābūt patiesam vai nepatiesam.";
        }
public string Confirmed()
        {
            return $"{FieldName} apstiprinājums neatbilst.";
        }
public string Declined()
        {
            return $"{FieldName} ir jānoraida.";
        }
public string Different(string name)
        {
            return $"{FieldName} un {name} ir jābūt atšķirīgiem.";
        }
public string Distinct()
        {
            return $"{FieldName} laukam ir dublikāts.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} nedrīkst beigties ar kādu no šiem: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} nedrīkst sākties ar kādu no šiem: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} ir jābūt derīgai e-pasta adresei.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} jābeidzas ar vienu no šiem: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} jābūt vairāk nekā {value} vienībām.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} jāpārsniedz {value} rakstzīmes.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} jābūt {value} vai vairāk vienībām.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} garumam jābūt lielākam vai vienādam ar {value} rakstzīmēm.";
        }
public string In()
        {
            return $"Izvēlētais {FieldName} ir nederīgs.";
        }
public string Integer()
        {
            return $"{FieldName} ir jābūt skaitlim.";
        }
public string Ip()
        {
            return $"{FieldName} jābūt derīgai IP adresei.";
        }
public string Ipv4()
        {
            return $"{FieldName} jābūt derīgai IPv4 adresei.";
        }
public string Ipv6()
        {
            return $"{FieldName} jābūt derīgai IPv6 adresei.";
        }
public string Json()
        {
            return $"{FieldName} jābūt derīgai JSON virknei.";
        }
public string Lowercase()
        {
            return $"{FieldName} ir jābūt mazajiem burtiem.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} jābūt mazāk nekā {value} vienībām.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} nedrīkst pārsniegt {value} rakstzīmes.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} nedrīkst būt vairāk par {value} vienībām.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} nedrīkst pārsniegt {value} rakstzīmes.";
        }
public string MacAddress()
        {
            return $"{FieldName} ir jābūt derīgai MAC adresei.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} nedrīkst pārsniegt {max} vienības.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} nedrīkst pārsniegt {max}.";
        }
public string MaxString(int max)
        {
            return $"{FieldName} nedrīkst pārsniegt {max} rakstzīmes.";
        }
public string MinArray(long min)
        {
            return $"{FieldName} jāsatur vismaz {min} vienības.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} jābūt vismaz {min}.";
        }
public string MinString(int min)
        {
            return $"{FieldName} jābūt vismaz {min} rakstzīmēm.";
        }
public string NotIn()
        {
            return $"izvēlētais {FieldName} ir nederīgs.";
        }
public string NotRegex()
        {
            return $"{FieldName} formāts ir nederīgs.";
        }
public string Numeric()
        {
            return $"{FieldName} jābūt skaitlim.";
        }
public string Regex()
        {
            return $"{FieldName} formāts ir nederīgs.";
        }
public string Required()
        {
            return $"{FieldName} lauks ir obligāts.";
        }
public string RequiredIf(string name, string value)
        {
            return $"{FieldName} lauks ir obligāts, ja {name} ir value.";
        }
public string Same(string name)
        {
            return $"{FieldName} un {name} ir jāsakrīt.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} jāsatur {size} vienības.";
        }
public string SizeString(int size)
        {
            return $"{FieldName} jābūt {size} rakstzīmēm.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} jāsākas ar kādu no šiem: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"{FieldName} ir jābūt lielajiem burtiem.";
        }
public string Url()
        {
            return $"{FieldName} formāts ir nederīgs.";
        }
    }
        }