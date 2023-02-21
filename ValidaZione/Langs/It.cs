using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class It : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} deve essere accettato.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} non è un URL valido.";
        }
public string After(string date)
        {
            return $"{FieldName} deve essere una data successiva al {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} deve essere una data successiva o uguale al {date}.";
        }
 public string Alpha()
        {
            return $"{FieldName} può contenere solo lettere.";
        }
public string AlphaDash()
        {
            return $"{FieldName} può contenere solo lettere, numeri e trattini.";
        }
public string AlphaNum()
        {
            return $"{FieldName} può contenere solo lettere e numeri.";
        }
public string Before(string date)
        {
            return $"{FieldName} deve essere una data precedente al {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} deve essere una data precedente o uguale al {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} deve avere tra {min} - {max} elementi.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} deve trovarsi tra {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} deve trovarsi tra {min} - {max} caratteri.";
        }
public string Boolean()
        {
            return $"Il campo {FieldName} deve essere vero o falso.";
        }
public string Confirmed()
        {
            return $"Il campo di conferma per {FieldName} non coincide.";
        }
public string Declined()
        {
            return $"{FieldName} deve essere rifiutato.";
        }
public string Different(string name)
        {
            return $"{FieldName} e {name} devono essere differenti.";
        }
public string Distinct()
        {
            return $"{FieldName} contiene un valore duplicato.";
        }
public string Email()
        {
            return $"{FieldName} non è valido.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} deve finire con uno dei seguenti valori: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} deve contenere più di {value} elementi.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} deve contenere più di {value} caratteri.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} deve contenere un numero di elementi uguale o maggiore di {value}.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} deve contenere un numero di caratteri uguale o maggiore di {value}.";
        }
  public string In()
        {
            return $"{FieldName} selezionato non è valido.";
        }
public string Integer()
        {
            return $"{FieldName} deve essere un numero intero.";
        }
public string Ip()
        {
            return $"{FieldName} deve essere un indirizzo IP valido.";
        }
 public string Ipv4()
        {
            return $"{FieldName} deve essere un indirizzo IPv4 valido.";
        }
        public string Ipv6()
        {
            return $"{FieldName} deve essere un indirizzo IPv6 valido.";
        }
      public string Json()
        {
            return $"{FieldName} deve essere una stringa JSON valida.";
        }
        public string Lowercase()
        {
            return $"{FieldName} deve contenere solo caratteri minuscoli.";
        }
        public string LessThanArray(long value)
        {
            return $"{FieldName} deve contenere meno di {value} elementi.";
        }
    public string LessThanString(int value)
        {
            return $"{FieldName} deve contenere meno di {value} caratteri.";
        }
        public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} deve contenere un numero di elementi minore o uguale a {value}.";
        }
    public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} deve contenere un numero di caratteri minore o uguale a {value}.";
        }
   public string MacAddress()
        {
            return $"Il campo {FieldName} deve essere un indirizzo MAC valido .";
        }
      public string MaxArray(long max)
        {
            return $"{FieldName} non può avere più di {max} elementi.";
        }
      public string MaxNumeric(string max)
        {
            return $"{FieldName} non può essere superiore a {max}.";
        }
        public string MaxString(int max)
        {
            return $"{FieldName} non può contenere più di {max} caratteri.";
        }
    public string MinArray(long min)
        {
            return $"{FieldName} deve avere almeno {min} elementi.";
        }
   public string MinNumeric(string min)
        {
            return $"{FieldName} deve essere almeno {min}.";
        }
      public string MinString(int min)
        {
            return $"{FieldName} deve contenere almeno {min} caratteri.";
        }
      public string NotIn()
        {
            return $"Il valore selezionato per {FieldName} non è valido.";
        }
       public string NotRegex()
        {
            return $"Il formato di {FieldName} non è valido.";
        }
      public string Numeric()
        {
            return $"{FieldName} deve essere un numero.";
        }
 public string Regex()
        {
            return $"Il formato del campo {FieldName} non è valido.";
        }
       public string Required()
        {
            return $"Il campo {FieldName} è richiesto.";
        }
    public string Same(string name)
        {
            return $"{FieldName} e {name} devono coincidere.";
        }
       public string SizeArray(long size)
        {
            return $"{FieldName} deve contenere :size elementi.";
        }
    public string SizeString(int size)
        {
            return $"{FieldName} deve contenere :size caratteri.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} deve iniziare con uno dei seguenti: {String.Join(", ", values)}";
        }
 public string Uppercase()
        {
            return $"{FieldName} deve contenere solo caratteri maiuscoli.";
        }
   public string Url()
        {
            return $"Il formato del campo {FieldName} non è valido.";
        }
    }
        }