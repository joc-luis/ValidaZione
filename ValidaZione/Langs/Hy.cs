using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Hy : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} դաշտը պետք է ընդունվի։";
            }
public string ActiveUrl()
        {
            return $"{FieldName} դաշտը վավեր URL չէ։";
        }
public string After(string date)
        {
            return $"{FieldName} դաշտի ամսաթիվը պետք է լինի {date}-ից հետո։";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} դաշտի ամսաթիվը պետք է լինի {date} կամ դրանից հետո։";
        }
public string Alpha()
        {
            return $"{FieldName} դաշտը պետք է պարունակի միայն տառեր։";
        }
public string AlphaDash()
        {
            return $"{FieldName} դաշտը պետք է պարունակի միայն տառեր, թվեր, գծիկներ և ընդգծումներ։";
        }
public string AlphaNum()
        {
            return $"{FieldName} դաշտը պետք է պարունակի միայն տառեր և թվեր։";
        }
public string Before(string date)
        {
            return $"{FieldName} դաշտի ամսաթիվը պետք է լինի {date}-ից առաջ։";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} դաշտի ամսաթիվը պետք է լինի {date} կամ դրանից առաջ։";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} դաշտում էլեմենտների քանակը պետք է լինի {min}-ի և {max}-ի միջև։";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} դաշտը պետք է լինի {min} և {max} թվերի միջև։";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} դաշտը պետք է ունենա {min}-ից {max} նիշ։";
        }
public string Boolean()
        {
            return $"{FieldName} դաշտի արժեքը պետք է լինի ճշմարիտ կամ կեղծ։";
        }
public string Confirmed()
        {
            return $"{FieldName} դաշտը չի համապատասխանում հաստատմանը։";
        }
public string Declined()
        {
            return $"{FieldName}-ը պետք է մերժվի:";
        }
public string Different(string name)
        {
            return $"{FieldName} և {name} դաշտերը պետք է լինեն տարբեր։";
        }
public string Distinct()
        {
            return $"{FieldName} դաշտը ունի կրկնվող արժեք։";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName}-ը չի կարող ավարտվել հետևյալներից որևէ մեկով. {String.Join(", ", values)}:";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName}-ը չի կարող սկսվել հետևյալներից որևէ մեկով՝ {String.Join(", ", values)}։";
        }
public string Email()
        {
            return $"{FieldName} դաշտը պետք է լինի վավերական Էլ․ հասցե։";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} դաշտը պետք է ավարտվի հետևյալ արժեքներից մեկով․ {String.Join(", ", values)}։";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} դաշտում էլեմենտների քանակը պետք է լինի {value}-ից մեծ։";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} դաշտի նիշերի քանակը պետք է գերազանցի {value}-ը։";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} դաշտում էլեմենտների քանակը պետք է մեծ կամ հավասար լինի {value}-ից։";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} դաշտի նիշերի քանակը պետք է մեծ կամ հավասար լինի {value}-ից։";
        }
public string In()
        {
            return $"{FieldName} դաշտի ընտրված արժեքն անվավեր է։";
        }
public string Integer()
        {
            return $"{FieldName} դաշտը պետք է լինի ամբողջ թիվ։";
        }
public string Ip()
        {
            return $"{FieldName} դաշտը պետք է լինի վավեր IP հասցե.";
        }
public string Ipv4()
        {
            return $"{FieldName} դաշտը պետք է լինի վավեր IPv4 հասցե։";
        }
public string Ipv6()
        {
            return $"{FieldName} դաշտը պետք է լինի վավեր IPv6 հասցե։";
        }
public string Json()
        {
            return $"{FieldName} դաշտը պետք է լինի վավեր JSON տեքստ։";
        }
public string Lowercase()
        {
            return $"{FieldName}-ը պետք է լինի փոքրատառ:";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} դաշտում էլեմենտների քանակը պետք է փոքր լինի {value}-ից։";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} դաշտը պետք է ունենա {value}-ից պակաս նիշեր։";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} դաշտում էլեմենտների քանակը պետք է փոքր կամ հավասար լինի {value}-ից։";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} դաշտի նիշերի քանակը պետք է փոքր կամ հավասար լինի {value}-ից։";
        }
public string MacAddress()
        {
            return $"{FieldName}-ը պետք է լինի վավեր MAC հասցե:";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} դաշտում էլեմենտների քանակը չպետք է գերազանցի {max}-ը։";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} դաշտը չի կարող լինել {max}-ից մեծ։";
        }
public string MaxString(int max)
        {
            return $"{FieldName} դաշտի նիշերի քանակը չի կարող լինել {max}-ց մեծ։";
        }
public string MinArray(long min)
        {
            return $"{FieldName} դաշտում էլեմենտների քանակը պետք է լինի առնվազն {min}։";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} դաշտը պետք է լինի առնվազն {min}։";
        }
public string MinString(int min)
        {
            return $"{FieldName} դաշտի նիշերի քանակը պետք է լինի առնվազն {min}։";
        }
public string NotIn()
        {
            return $"{FieldName} դաշտի ընտրված արժեքն անվավեր է։";
        }
public string NotRegex()
        {
            return $"{FieldName} դաշտի ձևաչափը սխալ է։";
        }
public string Numeric()
        {
            return $"{FieldName} դաշտը պետք է լինի թիվ։";
        }
public string Regex()
        {
            return $"{FieldName} դաշտի ձևաչափը սխալ է։";
        }
public string Required()
        {
            return $"{FieldName} դաշտը պարտադիր է։";
        }
public string RequiredIf(string name, string value)
        {
            return $"{FieldName} դաշտը պարտադիր է երբ {name}-ը հավասար է {value}։";
        }
public string Same(string name)
        {
            return $"{FieldName} և {name} դաշտերը պետք է համընկնեն։";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} դաշտը պետք է պարունակի {size} էլեմենտ։";
        }
public string SizeString(int size)
        {
            return $"{FieldName} դաշտը պետք է ունենա {size} նիշ։";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} դաշտը պետք է սկսվի հետևյալ արժեքներից մեկով․ {String.Join(", ", values)}։";
        }
public string Unique()
                {
                    return $"{FieldName}-ի տվյալ արժեքն արդեն գոյություն ունի։";
                }
public string Uppercase()
        {
            return $"{FieldName}-ը պետք է լինի մեծատառ:";
        }
public string Url()
        {
            return $"{FieldName} դաշտի ձևաչափը սխալ է։";
        }
    }
        }