using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class El : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Το πεδίο {FieldName} πρέπει να γίνει αποδεκτό.";
            }
public string ActiveUrl()
        {
            return $"Το πεδίο {FieldName} δεν είναι αποδεκτή διεύθυνση URL.";
        }
public string After(string date)
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι μία ημερομηνία μετά από {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι μία ημερομηνία ίδια ή μετά από {date}.";
        }
public string Alpha()
        {
            return $"Το πεδίο {FieldName} μπορεί να περιέχει μόνο γράμματα.";
        }
public string AlphaDash()
        {
            return $"Το πεδίο {FieldName} μπορεί να περιέχει μόνο γράμματα, αριθμούς, και παύλες.";
        }
public string AlphaNum()
        {
            return $"Το πεδίο {FieldName} μπορεί να περιέχει μόνο γράμματα και αριθμούς.";
        }
public string Before(string date)
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι μία ημερομηνία πριν από {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι μία ημερομηνία ίδια ή πριν από {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Το πεδίο {FieldName} πρέπει να έχει μεταξύ {min} - {max} αντικείμενα.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι μεταξύ {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι μεταξύ {min} - {max} χαρακτήρες.";
        }
public string Boolean()
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι true ή false.";
        }
public string Confirmed()
        {
            return $"Η επιβεβαίωση του {FieldName} δεν ταιριάζει.";
        }
public string Declined()
        {
            return $"Τα {FieldName} πρέπει να απορριφθούν.";
        }
public string Different(string name)
        {
            return $"Το πεδίο {FieldName} και {name} πρέπει να είναι διαφορετικά.";
        }
public string Distinct()
        {
            return $"Το πεδίο {FieldName} περιέχει δύο φορές την ίδια τιμή.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"Το {FieldName} δεν μπορεί να τελειώνει με ένα από τα ακόλουθα: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"Το {FieldName} δεν μπορεί να ξεκινά με ένα από τα ακόλουθα: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι μία έγκυρη διεύθυνση email.";
        }
public string EndsWith(List<string> values)
        {
            return $"Το πεδίο {FieldName} πρέπει να τελειώνει με ένα από τα παρακάτω: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"To πεδίο {FieldName} πρέπει να έχει περισσότερα από {value} αντικείμενα.";
        }
public string GreaterThanString(int value)
        {
            return $"To πεδίο {FieldName} πρέπει να είναι μεγαλύτερο από {value} χαρακτήρες.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"To πεδίο {FieldName} πρέπει να έχει {value} αντικείμενα ή περισσότερα.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"To πεδίο {FieldName} πρέπει να είναι μεγαλύτερο ή ίσο από {value} χαρακτήρες.";
        }
public string In()
        {
            return $"Το επιλεγμένο {FieldName} δεν είναι έγκυρο.";
        }
public string Integer()
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι ακέραιος.";
        }
public string Ip()
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι μία έγκυρη διεύθυνση IP.";
        }
public string Ipv4()
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι μία έγκυρη διεύθυνση IPv4.";
        }
public string Ipv6()
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι μία έγκυρη διεύθυνση IPv6.";
        }
public string Json()
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι μία έγκυρη συμβολοσειρά JSON.";
        }
public string Lowercase()
        {
            return $"Το {FieldName} πρέπει να είναι πεζό.";
        }
public string LessThanArray(long value)
        {
            return $"To πεδίο {FieldName} πρέπει να έχει λιγότερα από {value} αντικείμενα.";
        }
public string LessThanString(int value)
        {
            return $"To πεδίο {FieldName} πρέπει να είναι μικρότερo από {value} χαρακτήρες.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"To πεδίο {FieldName} δεν πρέπει να υπερβαίνει τα {value} αντικείμενα.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"To πεδίο {FieldName} πρέπει να είναι μικρότερo ή ίσο από  {value} χαρακτήρες.";
        }
public string MacAddress()
        {
            return $"Το {FieldName} πρέπει να είναι έγκυρη διεύθυνση MAC.";
        }
public string MaxArray(long max)
        {
            return $"Το πεδίο {FieldName} δεν μπορεί να έχει περισσότερα από {max} αντικείμενα.";
        }
public string MaxNumeric(string max)
        {
            return $"Το πεδίο {FieldName} δεν μπορεί να είναι μεγαλύτερο από {max}.";
        }
public string MaxString(int max)
        {
            return $"Το πεδίο {FieldName} δεν μπορεί να έχει περισσότερους από {max} χαρακτήρες.";
        }
public string MinArray(long min)
        {
            return $"Το πεδίο {FieldName} πρέπει να έχει τουλάχιστον {min} αντικείμενα.";
        }
public string MinNumeric(string min)
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι τουλάχιστον {min}.";
        }
public string MinString(int min)
        {
            return $"Το πεδίο {FieldName} πρέπει να έχει τουλάχιστον {min} χαρακτήρες.";
        }
public string NotIn()
        {
            return $"Το επιλεγμένο {FieldName} δεν είναι αποδεκτό.";
        }
public string NotRegex()
        {
            return $"Η μορφή του πεδίου {FieldName} δεν είναι αποδεκτή.";
        }
public string Numeric()
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι αριθμός.";
        }
public string Regex()
        {
            return $"Η μορφή του πεδίου {FieldName} δεν είναι αποδεκτή.";
        }
public string Required()
        {
            return $"Το πεδίο {FieldName} είναι απαραίτητο.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Το πεδίο {FieldName} είναι απαραίτητο όταν το πεδίο {name} είναι {value}.";
        }
public string Same(string name)
        {
            return $"Τα πεδία {FieldName} και {name} πρέπει να είναι ίδια.";
        }
public string SizeArray(long size)
        {
            return $"Το πεδίο {FieldName} πρέπει να περιέχει {size} αντικείμενα.";
        }
public string SizeString(int size)
        {
            return $"Το πεδίο {FieldName} πρέπει να είναι {size} χαρακτήρες.";
        }
public string StartsWith(List<string> values)
        {
            return $"Το στοιχείο {FieldName} πρέπει να ξεκινά με ένα από τα παρακάτω: {String.Join(", ", values)}";
        }
public string Unique()
                {
                    return $"Το πεδίο {FieldName} έχει ήδη εκχωρηθεί.";
                }
public string Uppercase()
        {
            return $"Το {FieldName} πρέπει να είναι κεφαλαίο.";
        }
public string Url()
        {
            return $"Το πεδίο {FieldName} δεν είναι έγκυρη διεύθυνση URL.";
        }
    }
        }