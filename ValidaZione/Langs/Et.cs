using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Et : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} tuleb aktsepteerida.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} ei ole kehtiv URL.";
        }
public string After(string date)
        {
            return $"{FieldName} peab olema kuupäev pärast {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} peab olema kuupäev pärast või samastuma {date}.";
        }
public string Alpha()
        {
            return $"{FieldName} võib sisaldada vaid tähemärke.";
        }
public string AlphaDash()
        {
            return $"{FieldName} võib sisaldada vaid tähti, numbreid ja kriipse.";
        }
public string AlphaNum()
        {
            return $"{FieldName} võib sisaldada vaid tähti ja numbreid.";
        }
public string Before(string date)
        {
            return $"{FieldName} peab olema kuupäev enne {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} peab olema kuupäev enne või samastuma {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} peab olema {min} ja {max} kirje vahel.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} peab olema {min} ja {max} vahel.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} peab olema {min} ja {max} tähemärgi vahel.";
        }
public string Boolean()
        {
            return $"{FieldName} väli peab olema tõene või väär.";
        }
public string Confirmed()
        {
            return $"{FieldName} kinnitus ei vasta.";
        }
public string Declined()
        {
            return $"{FieldName} tuleb tagasi lükata.";
        }
public string Different(string name)
        {
            return $"{FieldName} ja {name} peavad olema erinevad.";
        }
public string Distinct()
        {
            return $"{FieldName} väljal on topeltväärtus.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} ei tohi lõppeda ühega järgmistest: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} ei pruugi alata ühega järgmistest: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} peab olema kehtiv e-posti aadress.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} peab lõppema ühega järgmistest: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} peab sisaldama rohkem kui {value} üksust";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} peab sisaldama rohkem kui {value} tähemärki";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} peab sisaldama vähemalt {value} üksust";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} peab sisaldama rohkem kui {value} tähemärki või sama palju";
        }
public string In()
        {
            return $"Valitud {FieldName} on vigane.";
        }
public string Integer()
        {
            return $"{FieldName} peab olema täisarv.";
        }
public string Ip()
        {
            return $"{FieldName} peab olema kehtiv IP aadress.";
        }
public string Ipv4()
        {
            return $"{FieldName} peab olema kehtiv IPv4 aadress.";
        }
public string Ipv6()
        {
            return $"{FieldName} peab olema kehtiv IPv6 aadress.";
        }
public string Json()
        {
            return $"{FieldName} peab olema kehtiv JSON string.";
        }
public string Lowercase()
        {
            return $"{FieldName} peab olema väiketäht.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} peab sisaldama vähem kui {value} üksust";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} ei tohi ületada {value} tähemärki";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} ei tohi sisaldada rohkem kui {value} üksust";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} peab sisaldama vähem või sama palju {value} tähemärke";
        }
public string MacAddress()
        {
            return $"{FieldName} peab olema kehtiv MAC-aadress.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} ei tohi sisaldada rohkem kui {max} kirjet.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} ei tohi olla suurem kui {max}.";
        }
public string MaxString(int max)
        {
            return $"{FieldName} ei tohi olla suurem kui {max} tähemärki.";
        }
public string MinArray(long min)
        {
            return $"{FieldName} peab olema vähemalt {min} kirjet.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} peab olema vähemalt {min}.";
        }
public string MinString(int min)
        {
            return $"{FieldName} peab olema vähemalt {min} tähemärki.";
        }
public string NotIn()
        {
            return $"Valitud {FieldName} on vigane.";
        }
public string NotRegex()
        {
            return $"{FieldName} vorming on vale";
        }
public string Numeric()
        {
            return $"{FieldName} peab olema number.";
        }
public string Regex()
        {
            return $"{FieldName} vorming on vigane.";
        }
public string Required()
        {
            return $"{FieldName} väli on nõutud.";
        }
public string RequiredIf(string name, string value)
        {
            return $"{FieldName} väli on nõutud, kui {name} on {value}.";
        }
public string Same(string name)
        {
            return $"{FieldName} ja {name} peavad sobima.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} peab sisaldama {size} kirjet.";
        }
public string SizeString(int size)
        {
            return $"{FieldName} peab olema {size} tähemärki.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} peab algama ühega järgmistest: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"{FieldName} peab olema suurtäht.";
        }
public string Url()
        {
            return $"{FieldName} vorming on vigane.";
        }
    }
        }