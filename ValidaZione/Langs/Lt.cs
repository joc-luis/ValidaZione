using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Lt : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"Laukas {FieldName} turi būti priimtas.";
            }
public string ActiveUrl()
        {
            return $"Laukas {FieldName} nėra galiojantis internetinis adresas.";
        }
public string After(string date)
        {
            return $"Lauko {FieldName} reikšmė turi būti po {date} datos.";
        }
public string AfterOrEqual(string date)
        {
            return $"Lauko {FieldName} reikšmė privalo būti data lygi arba vėlesnė negu {date}.";
        }
public string Alpha()
        {
            return $"Laukas {FieldName} gali turėti tik raides.";
        }
public string AlphaDash()
        {
            return $"Laukas {FieldName} gali turėti tik raides, skaičius ir brūkšnelius.";
        }
public string AlphaNum()
        {
            return $"Laukas {FieldName} gali turėti tik raides ir skaičius.";
        }
public string Before(string date)
        {
            return $"Laukas {FieldName} turi būti data prieš {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"Lauko {FieldName} reikšmė privalo būti data lygi arba ankstesnė negu {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"Elementų skaičius lauke {FieldName} turi turėti nuo {min} iki {max}.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"Lauko {FieldName} reikšmė turi būti tarp {min} ir {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"Simbolių skaičius lauke {FieldName} turi būti tarp {min} ir {max}.";
        }
public string Boolean()
        {
            return $"Lauko reikšmė {FieldName} turi būti 'taip' arba 'ne'.";
        }
public string Confirmed()
        {
            return $"Lauko {FieldName} patvirtinimas nesutampa.";
        }
public string Declined()
        {
            return $"Laukas {FieldName} turi būti atmestas.";
        }
public string Different(string name)
        {
            return $"Laukų {FieldName} ir {name} reikšmės turi skirtis.";
        }
public string Distinct()
        {
            return $"Laukas {FieldName} pasikartoja.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"Laukas {FieldName} negali baigtis viena iš šių reikšmių: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"Laukas {FieldName} negali prasidėti viena iš šių reikšmių: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"Lauko {FieldName} reikšmė turi būti galiojantis el. pašto adresas.";
        }
public string EndsWith(List<string> values)
        {
            return $"Laukas {FieldName} turi baigtis vienu iš: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"Laukas {FieldName} turi turėti daugiau nei {value} elementus.";
        }
public string GreaterThanString(int value)
        {
            return $"Lauko {FieldName} reikšmė turi būti didesnė negu {value} simboliai.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"Laukas {FieldName} turi turėti {value} elementus arba daugiau.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"Lauko {FieldName} reikšmė turi būti didesnė arba lygi {value} simboliams.";
        }
public string In()
        {
            return $"Pasirinkta negaliojanti {FieldName} reikšmė.";
        }
public string Integer()
        {
            return $"Lauko {FieldName} reikšmė turi būti sveikasis skaičius.";
        }
public string Ip()
        {
            return $"Lauko {FieldName} reikšmė turi būti galiojantis IP adresas.";
        }
public string Ipv4()
        {
            return $"Lauko {FieldName} reikšmė turi būti galiojantis IPv4 adresas.";
        }
public string Ipv6()
        {
            return $"Lauko {FieldName} reikšmė turi būti galiojantis IPv6 adresas.";
        }
public string Json()
        {
            return $"Lauko {FieldName} reikšmė turi būti JSON tekstas.";
        }
public string Lowercase()
        {
            return $"{FieldName} turi būti mažosios raidės.";
        }
public string LessThanArray(long value)
        {
            return $"Laukas {FieldName} turi turėti mažiau negu {value} elementus.";
        }
public string LessThanString(int value)
        {
            return $"Lauko {FieldName} reikšmė turi būti mažesnė negu {value} simboliai.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"Laukas {FieldName} turi turėti mažiau arba lygiai {value} elementus.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"Lauko {FieldName} reikšmė turi būti mažesnė arba lygi {value} simboliams.";
        }
public string MacAddress()
        {
            return $"Lauko {FieldName} reikšmė turi būti galiojantis MAC adresas.";
        }
public string MaxArray(long max)
        {
            return $"Elementų kiekis lauke {FieldName} negali turėti daugiau nei {max} elementų.";
        }
public string MaxNumeric(string max)
        {
            return $"Lauko {FieldName} reikšmė negali būti didesnė nei {max}.";
        }
public string MaxString(int max)
        {
            return $"Simbolių kiekis lauke {FieldName} reikšmė negali būti didesnė nei {max} simbolių.";
        }
public string MinArray(long min)
        {
            return $"Elementų kiekis lauke {FieldName} turi būti ne mažiau nei {min}.";
        }
public string MinNumeric(string min)
        {
            return $"Lauko {FieldName} reikšmė turi būti ne mažesnė nei {min}.";
        }
public string MinString(int min)
        {
            return $"Simbolių kiekis lauke {FieldName} turi būti ne mažiau nei {min}.";
        }
public string NotIn()
        {
            return $"Pasirinkta negaliojanti reikšmė {FieldName}.";
        }
public string NotRegex()
        {
            return $"Lauko {FieldName} formatas yra neteisingas.";
        }
public string Numeric()
        {
            return $"Lauko {FieldName} reikšmė turi būti skaičius.";
        }
public string Regex()
        {
            return $"Negaliojantis lauko {FieldName} formatas.";
        }
public string Required()
        {
            return $"Privaloma užpildyti lauką {FieldName}.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Privaloma užpildyti lauką {FieldName}, kai {name} yra {value}.";
        }
public string Same(string name)
        {
            return $"Laukai {FieldName} ir {name} turi sutapti.";
        }
public string SizeArray(long size)
        {
            return $"Elementų kiekis lauke {FieldName} turi būti {size}.";
        }
public string SizeString(int size)
        {
            return $"Simbolių skaičius lauke {FieldName} turi būti {size}.";
        }
public string StartsWith(List<string> values)
        {
            return $"Laukas {FieldName} turi prasidėti vienu iš: {String.Join(", ", values)}";
        }
public string Unique()
                {
                    return $"Tokia {FieldName} reikšmė jau pasirinkta.";
                }
public string Uppercase()
        {
            return $"{FieldName} turi būti didžiosios raidės.";
        }
public string Url()
        {
            return $"Negaliojantis lauko {FieldName} formatas.";
        }
    }
        }