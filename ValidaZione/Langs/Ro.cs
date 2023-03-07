using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Ro : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Câmpul {FieldName} trebuie să fie acceptat.";
            }
public string ActiveUrl()
        {
            return $"Câmpul {FieldName} nu este un URL valid.";
        }
public string After(string date)
        {
            return $"Câmpul {FieldName} trebuie să fie o dată după {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Câmpul {FieldName} trebuie să fie o dată ulterioară sau egală cu {date}.";
        }
public string Alpha()
        {
            return $"Câmpul {FieldName} poate conține doar litere.";
        }
public string AlphaDash()
        {
            return $"Câmpul {FieldName} poate conține doar litere, numere și cratime.";
        }
public string AlphaNum()
        {
            return $"Câmpul {FieldName} poate conține doar litere și numere.";
        }
public string Before(string date)
        {
            return $"Câmpul {FieldName} trebuie să fie o dată înainte de {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Câmpul {FieldName} trebuie să fie o dată înainte sau egală cu {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Câmpul {FieldName} trebuie să aibă între {min} și {max} elemente.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Câmpul {FieldName} trebuie să fie între {min} și {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Câmpul {FieldName} trebuie să fie între {min} și {max} caractere.";
        }
public string Boolean()
        {
            return $"Câmpul {FieldName} trebuie să fie adevărat sau fals.";
        }
public string Confirmed()
        {
            return $"Confirmarea {FieldName} nu se potrivește.";
        }
public string Declined()
        {
            return $"Câmpul {FieldName} trebuie să fie declinat.";
        }
public string Different(string name)
        {
            return $"Câmpurile {FieldName} și {name} trebuie să fie diferite.";
        }
public string Distinct()
        {
            return $"Câmpul {FieldName} are o valoare duplicat.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} nu se poate termina cu una dintre următoarele valori: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} trebuie să nu înceapă cu una dintre următoarele valori: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Câmpul {FieldName} trebuie să fie o adresă de e-mail validă.";
        }
public string EndsWith(List<string> values)
        {
            return $"Câmpul {FieldName} trebuie să se încheie cu una din următoarele valori: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"Câmpul {FieldName} trebuie să aibă mai multe de {value} elemente.";
        }
public string GreaterThanString(int value)
        {
            return $"Câmpul {FieldName} trebuie să fie mai mare de {value} caractere.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Câmpul {FieldName} trebuie să aibă {value} elemente sau mai multe.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Câmpul {FieldName} trebuie să fie mai mare sau egal cu {value} caractere.";
        }
public string In()
        {
            return $"Câmpul {FieldName} selectat nu este valid.";
        }
public string Integer()
        {
            return $"Câmpul {FieldName} trebuie să fie un număr întreg.";
        }
public string Ip()
        {
            return $"Câmpul {FieldName} trebuie să fie o adresă IP validă.";
        }
public string Ipv4()
        {
            return $"Câmpul {FieldName} trebuie să fie o adresă IPv4 validă.";
        }
public string Ipv6()
        {
            return $"Câmpul {FieldName} trebuie să fie o adresă IPv6 validă.";
        }
public string Json()
        {
            return $"Câmpul {FieldName} trebuie să fie un string JSON valid.";
        }
public string Lowercase()
        {
            return $"{FieldName} trebuie să fie format doar din litere mici.";
        }
public string LessThanArray(long value)
        {
            return $"Câmpul {FieldName} trebuie să aibă mai puțin de {value} elemente.";
        }
public string LessThanString(int value)
        {
            return $"Câmpul {FieldName} trebuie să fie mai mic de {value} caractere.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"Câmpul {FieldName} trebuie să aibă {value} elemente sau mai puține.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"Câmpul {FieldName} trebuie să fie mai mic sau egal cu {value} caractere.";
        }
public string MacAddress()
        {
            return $"Câmpul {FieldName} trebuie să fie o adresă MAC validă.";
        }
public string MaxArray(long max)
        {
            return $"Câmpul {FieldName} nu poate avea mai mult de {max} elemente.";
        }
public string MaxNumeric(string max)
        {
            return $"Câmpul {FieldName} nu poate fi mai mare de {max}.";
        }
public string MaxString(int max)
        {
            return $"Câmpul {FieldName} nu poate avea mai mult de {max} caractere.";
        }
public string MinArray(long min)
        {
            return $"Câmpul {FieldName} trebuie să aibă cel puțin {min} elemente.";
        }
public string MinNumeric(string min)
        {
            return $"Câmpul {FieldName} nu poate fi mai mic de {min}.";
        }
public string MinString(int min)
        {
            return $"Câmpul {FieldName} trebuie să aibă cel puțin {min} caractere.";
        }
public string NotIn()
        {
            return $"Câmpul {FieldName} selectat nu este valid.";
        }
public string NotRegex()
        {
            return $"Câmpul {FieldName} nu are un format valid.";
        }
public string Numeric()
        {
            return $"Câmpul {FieldName} trebuie să fie un număr.";
        }
public string Regex()
        {
            return $"Câmpul {FieldName} nu are un format valid.";
        }
public string Required()
        {
            return $"Câmpul {FieldName} este obligatoriu.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Câmpul {FieldName} este necesar când {name} este {value}.";
        }
public string Same(string name)
        {
            return $"Câmpurile {FieldName} și {name} trebuie să fie identice.";
        }
public string SizeArray(long size)
        {
            return $"Câmpul {FieldName} trebuie să aibă {size} elemente.";
        }
public string SizeString(int size)
        {
            return $"Câmpul {FieldName} trebuie să aibă {size} caractere.";
        }
public string StartsWith(List<string> values)
        {
            return $"Câmpul {FieldName} trebuie să înceapă cu una din următoarele valori: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"{FieldName} trebuie să fie majuscule.";
        }
public string Url()
        {
            return $"Câmpul {FieldName} nu este un URL valid.";
        }
    }
        }