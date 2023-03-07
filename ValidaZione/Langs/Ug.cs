using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Ug : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} چوقۇم قوشۇلىشىڭىز كېرەك.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} ئىناۋەتلىك توربەت ئادىرىسى ئەمەس.";
        }
public string After(string date)
        {
            return $"{FieldName} چوقۇم {date} دىن كىيىن بۇلىشى كېرەك.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} چوقۇم {date} غا تەڭ ياكى كىيىن بۇلىشى كېرەك.";
        }
public string Alpha()
        {
            return $"{FieldName} پەقەت ھەرىپلەردىن تۈزىلىشى كېرەك.";
        }
public string AlphaDash()
        {
            return $"{FieldName} پەقەت ھەرىپ، سان-سىفىر ۋە يانتۇ سىزىقتىن تۈزەلگەن بۇلىشى كېرەك.";
        }
public string AlphaNum()
        {
            return $"{FieldName} پەقەت ھەرىپ ۋە سان-سىفىرلاردىن تۈزىلىشى كېرەك.";
        }
public string Before(string date)
        {
            return $"{FieldName} چوقۇم {date} دىن بۇرۇن بۇلىشى كېرەك.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} چوقۇم {date} غا تەڭ ياكى بۇرۇن بۇلىشى كېرەك.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} چوقۇم  {min} - {max} بۆلەك ئارلىقىدا بۇلىشى كېرەك.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} چوقۇم {min} - {max} ئارلىقىدا بۇلىشى كېرەك.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} چوقۇم  {min} - {max} خەت ئارلىقىدا بۇلىشى كېرەك.";
        }
public string Boolean()
        {
            return $"{FieldName} چوقۇم بۇل قىممىتى بۇلىشى كېرەك.";
        }
public string Confirmed()
        {
            return $"{FieldName} ئىككى قېتىم كىرگۈزگەن قىممەت ئوخشاش بولمىدى.";
        }
public string Declined()
        {
            return $"{FieldName} نى رەت قىلىش كېرەك.";
        }
public string Different(string name)
        {
            return $"{FieldName} بىلەن {name} چوقۇم ئوخشاش بۇلىشى كېرەك.";
        }
public string Distinct()
        {
            return $"{FieldName} ئاللابۇرۇن مەۋجۈت.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} تۆۋەندىكىلەرنىڭ بىرى بىلەن ئاخىرلاشماسلىقى مۇمكىن: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} تۆۋەندىكىلەرنىڭ بىرىدىن باشلانماسلىقى مۇمكىن: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} ئىناۋەتلىك تورخەت ئادىرىسى ئەمەس.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} چوقۇم تۆۋەندىكىلەرنىڭ بىرى بىلەن ئاخىرلىشىشى كېرەك: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} دە {value} دىن ئارتۇق تۈر بولۇشى كېرەك.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} چوقۇم {value} ھەرپتىن چوڭ بولۇشى كېرەك.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} دە {value} ياكى ئۇنىڭدىن ئارتۇق نەرسە بولۇشى كېرەك.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} چوقۇم {value} ھەرپتىن چوڭ ياكى تەڭ بولۇشى كېرەك.";
        }
public string In()
        {
            return $"تاللانغان قىممەت {FieldName} ئىناۋەتسىز";
        }
public string Integer()
        {
            return $"{FieldName} چوقۇم پۈتۈن سان بۇلىشى كېرەك";
        }
public string Ip()
        {
            return $"{FieldName} چوقۇم ئىناۋەتلىك IP ئادىرىسى بۇلىشى كېرەك.";
        }
public string Ipv4()
        {
            return $"{FieldName} چوقۇم ئىناۋەتلىك IPv4 ئادىرىسى بۇلىشى كېرەك.";
        }
public string Ipv6()
        {
            return $"{FieldName} چوقۇم ئىناۋەتلىك IPv6 ئادىرىسى بۇلىشى كېرەك.";
        }
public string Json()
        {
            return $"{FieldName} چوقۇم ئىناۋەتلىك JSON تىپى بۇلىشى كېرەك.";
        }
public string Lowercase()
        {
            return $"{FieldName} چوقۇم كىچىك ھەرپ بولۇشى كېرەك.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} دە {value} دىن تۆۋەن تۈر بولۇشى كېرەك.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} ھەرپ {value} ھەرپتىن تۆۋەن بولۇشى كېرەك.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} دە {value} دىن ئارتۇق نەرسە بولماسلىقى كېرەك.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} چوقۇم {value} ھەرپتىن تۆۋەن ياكى تەڭ بولۇشى كېرەك.";
        }
public string MacAddress()
        {
            return $"{FieldName} چوقۇم ئىناۋەتلىك MAC ئادرېسى بولۇشى كېرەك.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} ئەڭ كۆپ بولغاندا {max} بۆلەك";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} {max} دىن چوڭ بولماسلىكى كېرەك.";
        }
public string MaxString(int max)
        {
            return $"{FieldName} چوڭ-كىچىكلىكى {max} خەتتىن ئېشىپ كەتمەسلىكى كېرەك.";
        }
public string MinArray(long min)
        {
            return $"{FieldName} ئەڭ ئاز بولغاندا {min} بۆلەك بۇلىشى كېرەك.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} چوقۇم {min} تەڭ ياكى چوڭ بۇلىشى كېرەك.";
        }
public string MinString(int min)
        {
            return $"{FieldName} ئەڭ ئاز بولغاندا {min} خەت بۇلىشى كېرەك.";
        }
public string NotIn()
        {
            return $"تاللانغان قىممەت {FieldName} ئىناۋەتسىز.";
        }
public string NotRegex()
        {
            return $"{FieldName} فورماتى ئىناۋەتسىز.";
        }
public string Numeric()
        {
            return $"{FieldName} چوقۇم سان-سىفىر بۇلىشى كېرەك.";
        }
public string Regex()
        {
            return $"{FieldName} ھۆججەت تىپى ئىناۋەتسىز.";
        }
public string Required()
        {
            return $"{FieldName} قۇرۇق بولسا بولمايدۇ.";
        }
public string RequiredIf(string name, string value)
        {
            return $":Other {value} بولغاندا {FieldName} قۇرۇق بولسا بولمايدۇ.";
        }
public string Same(string name)
        {
            return $"{FieldName} بىلەن {name} چوقۇم ئوخشاش بۇلىشى كېرەك.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} چوقۇم {size} بۆلەك.";
        }
public string SizeString(int size)
        {
            return $"{FieldName} چوقۇم {size} خەت.";
        }
public string StartsWith(List<string> values)
        {
            return $"The {FieldName} must start with one of the following: {String.Join(", ", values)}.";
        }
public string Uppercase()
        {
            return $"{FieldName} چوقۇم چوڭ ھەرپ بولۇشى كېرەك.";
        }
public string Url()
        {
            return $"{FieldName} ھۆججەت تىپى ئىناۋەتسىز.";
        }
    }
        }