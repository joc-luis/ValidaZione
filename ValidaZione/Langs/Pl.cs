using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Pl : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Pole {FieldName} musi zostać zaakceptowane.";
            }
public string ActiveUrl()
        {
            return $"Pole {FieldName} jest nieprawidłowym adresem URL.";
        }
public string After(string date)
        {
            return $"Pole {FieldName} musi być datą późniejszą od {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Pole {FieldName} musi być datą nie wcześniejszą niż {date}.";
        }
public string Alpha()
        {
            return $"Pole {FieldName} może zawierać jedynie litery.";
        }
public string AlphaDash()
        {
            return $"Pole {FieldName} może zawierać jedynie litery, cyfry i myślniki.";
        }
public string AlphaNum()
        {
            return $"Pole {FieldName} może zawierać jedynie litery i cyfry.";
        }
public string Before(string date)
        {
            return $"Pole {FieldName} musi być datą wcześniejszą od {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Pole {FieldName} musi być datą nie późniejszą niż {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Pole {FieldName} musi składać się z {min} - {max} elementów.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Pole {FieldName} musi zawierać się w granicach {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Pole {FieldName} musi zawierać się w granicach {min} - {max} znaków.";
        }
public string Boolean()
        {
            return $"Pole {FieldName} musi mieć wartość logiczną prawda albo fałsz.";
        }
public string Confirmed()
        {
            return $"Potwierdzenie pola {FieldName} nie zgadza się.";
        }
public string Declined()
        {
            return $"Pole {FieldName} musi zostać odrzucony.";
        }
public string Different(string name)
        {
            return $"Pole {FieldName} oraz {name} muszą się różnić.";
        }
public string Distinct()
        {
            return $"Pole {FieldName} ma zduplikowane wartości.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"Pole {FieldName} nie może kończyć się jednym z następujących wartości: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"Pole {FieldName} nie może zaczynać się od jednego z następujących wartości: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Pole {FieldName} nie jest poprawnym adresem e-mail.";
        }
public string EndsWith(List<string> values)
        {
            return $"Pole {FieldName} musi kończyć się jedną z następujących wartości: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"Pole {FieldName} musi mieć więcej niż {value} elementów.";
        }
public string GreaterThanString(int value)
        {
            return $"Pole {FieldName} musi być dłuższe niż {value} znaków.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Pole {FieldName} musi mieć {value} lub więcej elementów.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Pole {FieldName} musi być dłuższe lub równe {value} znaków.";
        }
public string In()
        {
            return $"Zaznaczony element {FieldName} jest nieprawidłowy.";
        }
public string Integer()
        {
            return $"Pole {FieldName} musi być liczbą całkowitą.";
        }
public string Ip()
        {
            return $"Pole {FieldName} musi być prawidłowym adresem IP.";
        }
public string Ipv4()
        {
            return $"Pole {FieldName} musi być prawidłowym adresem IPv4.";
        }
public string Ipv6()
        {
            return $"Pole {FieldName} musi być prawidłowym adresem IPv6.";
        }
public string Json()
        {
            return $"Pole {FieldName} musi być poprawnym ciągiem znaków JSON.";
        }
public string Lowercase()
        {
            return $"{FieldName} musi być pisany małymi literami.";
        }
public string LessThanArray(long value)
        {
            return $"Pole {FieldName} musi mieć mniej niż {value} elementów.";
        }
public string LessThanString(int value)
        {
            return $"Pole {FieldName} musi być krótsze niż {value} znaków.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"Pole {FieldName} musi mieć {value} lub mniej elementów.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"Pole {FieldName} musi być krótsze lub równe {value} znaków.";
        }
public string MacAddress()
        {
            return $"Pole {FieldName} musi być prawidłowym adresem MAC.";
        }
public string MaxArray(long max)
        {
            return $"Pole {FieldName} nie może mieć więcej niż {max} elementów.";
        }
public string MaxNumeric(string max)
        {
            return $"Pole {FieldName} nie może być większe niż {max}.";
        }
public string MaxString(int max)
        {
            return $"Pole {FieldName} nie może być dłuższe niż {max} znaków.";
        }
public string MinArray(long min)
        {
            return $"Pole {FieldName} musi mieć przynajmniej {min} elementów.";
        }
public string MinNumeric(string min)
        {
            return $"Pole {FieldName} musi być nie mniejsze od {min}.";
        }
public string MinString(int min)
        {
            return $"Pole {FieldName} musi mieć przynajmniej {min} znaków.";
        }
public string NotIn()
        {
            return $"Zaznaczony {FieldName} jest nieprawidłowy.";
        }
public string NotRegex()
        {
            return $"Format pola {FieldName} jest nieprawidłowy.";
        }
public string Numeric()
        {
            return $"Pole {FieldName} musi być liczbą.";
        }
public string Regex()
        {
            return $"Format pola {FieldName} jest nieprawidłowy.";
        }
public string Required()
        {
            return $"Pole {FieldName} jest wymagane.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Pole {FieldName} jest wymagane gdy {name} ma wartość {value}.";
        }
public string Same(string name)
        {
            return $"Pole {FieldName} i {name} muszą być takie same.";
        }
public string SizeArray(long size)
        {
            return $"Pole {FieldName} musi zawierać {size} elementów.";
        }
public string SizeString(int size)
        {
            return $"Pole {FieldName} musi mieć {size} znaków.";
        }
public string StartsWith(List<string> values)
        {
            return $"Pole {FieldName} musi zaczynać się jedną z następujących wartości: {String.Join(", ", values)}.";
        }
public string Uppercase()
        {
            return $"{FieldName} musi być pisany wielkimi literami.";
        }
public string Url()
        {
            return $"Format pola {FieldName} jest nieprawidłowy.";
        }
    }
        }