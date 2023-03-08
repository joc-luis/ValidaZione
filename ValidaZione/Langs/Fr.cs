using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Fr : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Le champ {FieldName} doit être accepté.";
            }
public string ActiveUrl()
        {
            return $"Le champ {FieldName} n'est pas une URL valide.";
        }
public string After(string date)
        {
            return $"Le champ {FieldName} doit être une date postérieure au {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"Le champ {FieldName} doit être une date postérieure ou égale au {date}.";
        }
public string Alpha()
        {
            return $"Le champ {FieldName} doit contenir uniquement des lettres.";
        }
public string AlphaDash()
        {
            return $"Le champ {FieldName} doit contenir uniquement des lettres, des chiffres et des tirets.";
        }
public string AlphaNum()
        {
            return $"Le champ {FieldName} doit contenir uniquement des chiffres et des lettres.";
        }
public string Before(string date)
        {
            return $"Le champ {FieldName} doit être une date antérieure au {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Le champ {FieldName} doit être une date antérieure ou égale au {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Le tableau {FieldName} doit contenir entre {min} et {max} éléments.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"La valeur de {FieldName} doit être comprise entre {min} et {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Le texte {FieldName} doit contenir entre {min} et {max} caractères.";
        }
public string Boolean()
        {
            return $"Le champ {FieldName} doit être vrai ou faux.";
        }
public string Confirmed()
        {
            return $"Le champ de confirmation {FieldName} ne correspond pas.";
        }
public string Declined()
        {
            return $"Le champ {FieldName} doit être décliné.";
        }
public string Different(string name)
        {
            return $"Les champs {FieldName} et {name} doivent être différents.";
        }
public string Distinct()
        {
            return $"Le champ {FieldName} a une valeur en double.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"Le champ {FieldName} ne doit pas finir avec une des valeurs suivantes : {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"Le champ {FieldName} ne doit pas commencer avec une des valeurs suivantes : {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Le champ {FieldName} doit être une adresse e-mail valide.";
        }
public string EndsWith(List<string> values)
        {
            return $"Le champ {FieldName} doit se terminer par une des valeurs suivantes : {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"Le tableau {FieldName} doit contenir plus de {value} éléments.";
        }
public string GreaterThanString(int value)
        {
            return $"Le texte {FieldName} doit contenir plus de {value} caractères.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Le tableau {FieldName} doit contenir au moins {value} éléments.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Le texte {FieldName} doit contenir au moins {value} caractères.";
        }
public string In()
        {
            return $"Le champ {FieldName} est invalide.";
        }
public string Integer()
        {
            return $"Le champ {FieldName} doit être un entier.";
        }
public string Ip()
        {
            return $"Le champ {FieldName} doit être une adresse IP valide.";
        }
public string Ipv4()
        {
            return $"Le champ {FieldName} doit être une adresse IPv4 valide.";
        }
public string Ipv6()
        {
            return $"Le champ {FieldName} doit être une adresse IPv6 valide.";
        }
public string Json()
        {
            return $"Le champ {FieldName} doit être un document JSON valide.";
        }
public string Lowercase()
        {
            return $"Le champ {FieldName} doit être en minuscules.";
        }
public string LessThanArray(long value)
        {
            return $"Le tableau {FieldName} doit contenir moins de {value} éléments.";
        }
public string LessThanString(int value)
        {
            return $"Le texte {FieldName} doit contenir moins de {value} caractères.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"Le tableau {FieldName} doit contenir au plus {value} éléments.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"Le texte {FieldName} doit contenir au plus {value} caractères.";
        }
public string MacAddress()
        {
            return $"Le champ {FieldName} doit être une adresse MAC valide.";
        }
public string MaxArray(long max)
        {
            return $"Le tableau {FieldName} ne peut pas contenir plus que {max} éléments.";
        }
public string MaxNumeric(string max)
        {
            return $"La valeur de {FieldName} ne peut pas être supérieure à {max}.";
        }
public string MaxString(int max)
        {
            return $"Le texte de {FieldName} ne peut pas contenir plus de {max} caractères.";
        }
public string MinArray(long min)
        {
            return $"Le tableau {FieldName} doit contenir au moins {min} éléments.";
        }
public string MinNumeric(string min)
        {
            return $"La valeur de {FieldName} doit être supérieure ou égale à {min}.";
        }
public string MinString(int min)
        {
            return $"Le texte de {FieldName} doit contenir au moins {min} caractères.";
        }
public string NotIn()
        {
            return $"Le champ {FieldName} sélectionné n'est pas valide.";
        }
public string NotRegex()
        {
            return $"Le format du champ {FieldName} n'est pas valide.";
        }
public string Numeric()
        {
            return $"Le champ {FieldName} doit contenir un nombre.";
        }
public string Regex()
        {
            return $"Le format du champ {FieldName} est invalide.";
        }
public string Required()
        {
            return $"Le champ {FieldName} est obligatoire.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Le champ {FieldName} est obligatoire quand la valeur de {name} est {value}.";
        }
public string Same(string name)
        {
            return $"Les champs {FieldName} et {name} doivent être identiques.";
        }
public string SizeArray(long size)
        {
            return $"Le tableau {FieldName} doit contenir {size} éléments.";
        }
public string SizeString(int size)
        {
            return $"Le texte de {FieldName} doit contenir {size} caractères.";
        }
public string StartsWith(List<string> values)
        {
            return $"Le champ {FieldName} doit commencer avec une des valeurs suivantes : {String.Join(", ", values)}";
        }
public string Unique()
                {
                    return $"La valeur du champ {FieldName} est déjà utilisée.";
                }
public string Uppercase()
        {
            return $"Le champ {FieldName} doit être en majuscules.";
        }
public string Url()
        {
            return $"Le format de l'URL de {FieldName} n'est pas valide.";
        }
    }
        }