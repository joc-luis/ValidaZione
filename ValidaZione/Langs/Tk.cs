using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Tk : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} kabul edilmelidir.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} dogry URL bolmalydyr.";
        }
public string After(string date)
        {
            return $"{FieldName} şundan has köne sene bolmalydyr {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName}-den soň bir sene bolmaly ýa-da {date}-e deň bolmaly.";
        }
public string Alpha()
        {
            return $"{FieldName} dine harplardan durmalydyr.";
        }
public string AlphaDash()
        {
            return $"{FieldName} dine harplardan, sanlardan we tirelerden durmalydyr.";
        }
public string AlphaNum()
        {
            return $"{FieldName} dine harplardan we sanlardan durmalydyr.";
        }
public string Before(string date)
        {
            return $"{FieldName} şundan has irki sene bolmalydyr {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName}-den öň bir sene bolmaly ýa-da {date}-e deň bolmaly.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} {min} - {max} arasynda madda eýe bolmalydyr.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} {min} - {max} arasynda bolmalydyr.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} {min} - {max} harplar arasynda bolmalydyr.";
        }
public string Boolean()
        {
            return $"{FieldName} diňe dogry ýada ýalňyş bolmalydyr.";
        }
public string Confirmed()
        {
            return $"{FieldName} tassyklamasy deň däl.";
        }
public string Declined()
        {
            return $"{FieldName}-den ýüz öwürmeli.";
        }
public string Different(string name)
        {
            return $"{FieldName} bilen {name} birbirinden tapawutly bolmalydyr.";
        }
public string Distinct()
        {
            return $"{FieldName} meýdanyň dublikat bahasy bar.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} aşakdakylaryň biri bilen gutarman biler: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} aşakdakylardan biri bilen başlamazlygy mümkin: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} formaty ýalňyş.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} aşakdakylaryň biri bilen gutarmaly: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName}-de {value}-den gowrak zat bolmaly.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} simwoldan uly bolmaly.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName}-de {value} element ýa-da ondan köp zat bolmaly.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} {value} simwoldan uly ýa-da deň bolmaly.";
        }
public string In()
        {
            return $"{FieldName} mukdary ýalňyş.";
        }
public string Integer()
        {
            return $"{FieldName} san bolmalydyr.";
        }
public string Ip()
        {
            return $"{FieldName} dogry IP adres bolmalydyr.";
        }
public string Ipv4()
        {
            return $"{FieldName} dogry IPv4 salgy bolmaly.";
        }
public string Ipv6()
        {
            return $"{FieldName} dogry IPv6 salgy bolmaly.";
        }
public string Json()
        {
            return $"{FieldName} dogry JSON setiri bolmaly.";
        }
public string Lowercase()
        {
            return $"{FieldName} kiçi harp bolmaly";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName}-de {value}-den az zat bolmaly.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} simwoldan {value} simwoldan az bolmaly.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName}-de {value}-den köp zat bolmaly däldir.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} {value} simwoldan az ýa-da deň bolmaly.";
        }
public string MacAddress()
        {
            return $"{FieldName} dogry MAC salgysy bolmaly.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} iň az {max} maddadan ybarat bolmalydyr.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} {max} den kiçi bolmalydyr.";
        }
public string MaxString(int max)
        {
            return $"{FieldName} {max} harpdan kiçi bolmalydyr.";
        }
public string MinArray(long min)
        {
            return $"{FieldName} iň az {min} harpdan bolmalydyr.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} mukdary {min} dan köp bolmalydyr.";
        }
public string MinString(int min)
        {
            return $"{FieldName} mukdary {min} harpdan köp bolmalydyr.";
        }
public string NotIn()
        {
            return $"Saýlanan {FieldName} geçersiz.";
        }
public string NotRegex()
        {
            return $"{FieldName} format nädogry.";
        }
public string Numeric()
        {
            return $"{FieldName} san bolmalydyr.";
        }
public string Regex()
        {
            return $"{FieldName} formaty ýalňyş.";
        }
public string Required()
        {
            return $"{FieldName} meýdany zerur.";
        }
public string RequiredIf(string name, string value)
        {
            return $"{FieldName} meýdany, {name} {value} hümmetine eýe bolanynda zerurdyr.";
        }
public string Same(string name)
        {
            return $"{FieldName} bilen {name} deň bolmalydyr.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} {size} madda eýe bolmalydyr.";
        }
public string SizeString(int size)
        {
            return $"{FieldName} {size} harp bolmalydyr.";
        }
public string StartsWith(List<string> values)
        {
            return $"The {FieldName} must start with one of the following: {String.Join(", ", values)}.";
        }
public string Uppercase()
        {
            return $"{FieldName} baş harp bolmaly.";
        }
public string Url()
        {
            return $"{FieldName} formaty ýalňyş.";
        }
    }
        }