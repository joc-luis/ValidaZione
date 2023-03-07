using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Mn : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} баталсан байх шаардлагатай.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} талбарт зөв URL хаяг оруулна уу.";
        }
public string After(string date)
        {
            return $"{FieldName} талбарт {date}-с хойш огноо оруулна уу.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} талбарт {date} эсвэл түүнээс хойш огноо оруулна уу.";
        }
public string Alpha()
        {
            return $"{FieldName} талбарт латин үсэг оруулна уу.";
        }
public string AlphaDash()
        {
            return $"{FieldName} талбарт латин үсэг, тоо болон зураас оруулах боломжтой.";
        }
public string AlphaNum()
        {
            return $"{FieldName} талбарт латин үсэг болон тоо оруулах боломжтой.";
        }
public string Before(string date)
        {
            return $"{FieldName} талбарт {date}-с өмнөх огноо оруулна уу.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} талбарт {date} эсвэл түүнээс өмнөх огноо оруулна уу.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} массивт {min}-{max} элемэнт байх шаардлагатай.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} талбарт {min}-{max} хооронд тоо оруулна уу.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} талбарт {min}-{max} урттай текст оруулна уу.";
        }
public string Boolean()
        {
            return $"{FieldName} талбарын утга үнэн эсвэл худал байх шаардлагатай.";
        }
public string Confirmed()
        {
            return $"{FieldName} талбарын баталагажуулалт тохирохгүй байна.";
        }
public string Declined()
        {
            return $"{FieldName}-аас татгалзах ёстой.";
        }
public string Different(string name)
        {
            return $"{FieldName} талбарт {name} -с өөр утга оруулах шаардлагатай.";
        }
public string Distinct()
        {
            return $"{FieldName} талбарт ялгаатай утга оруулах шаардлагатай.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"{FieldName} нь дараахын аль нэгээр төгсөхгүй байж болно: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"{FieldName} нь дараахын аль нэгээр нь эхэлж болохгүй: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} талбарт зөв и-мэйл хаяг оруулах шаардлагатай.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} дараах аль нэгийг нь дуусгах естой: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} нь {value} гаруй зүйлтэй байх ёстой.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} нь {value} тэмдэгтээс их байх ёстой.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} нь {value} ба түүнээс дээш зүйлтэй байх ёстой.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} нь {value} тэмдэгтээс их буюу тэнцүү байх ёстой.";
        }
public string In()
        {
            return $"Сонгогдсон {FieldName} буруу байна.";
        }
public string Integer()
        {
            return $"{FieldName} талбарт бүхэл тоо оруулах шаардлагатай.";
        }
public string Ip()
        {
            return $"{FieldName} талбарт зөв IP хаяг оруулах шаардлагатай.";
        }
public string Ipv4()
        {
            return $"{FieldName} нь хүчинтэй ЦТ 4-р хаяг байх естой.";
        }
public string Ipv6()
        {
            return $"{FieldName} нь хүчин төгөлдөр Атв6 хаяг байх естой.";
        }
public string Json()
        {
            return $"{FieldName} талбарт зөв JSON тэмдэгт мөр оруулах шаардлагатай.";
        }
public string Lowercase()
        {
            return $"{FieldName} нь жижиг үсгээр бичигдсэн байх ёстой.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} нь {value}-аас бага зүйлтэй байх ёстой.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} нь {value} тэмдэгтээс бага байх ёстой.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName}-д ​​{value}-аас илүү зүйл байх ёсгүй.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} нь {value} тэмдэгтээс бага буюу тэнцүү байх ёстой.";
        }
public string MacAddress()
        {
            return $"{FieldName} нь хүчинтэй MAC хаяг байх ёстой.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} талбарт хамгийн ихдээ {max} элемэнт оруулах боломжтой.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} талбарт {max} буюу түүнээс бага утга оруулна уу.";
        }
public string MaxString(int max)
        {
            return $"{FieldName} талбарт {max}-с бага урттай текст оруулна уу.";
        }
public string MinArray(long min)
        {
            return $"{FieldName} талбарт хамгийн багадаа {min} элемэнт оруулах боломжтой.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} талбарт {min} буюу түүнээс их тоо оруулна уу.";
        }
public string MinString(int min)
        {
            return $"{FieldName} талбарт {min} буюу түүнээс их үсэг бүхий текст оруулна уу.";
        }
public string NotIn()
        {
            return $"Буруу {FieldName} сонгогдсон байна.";
        }
public string NotRegex()
        {
            return $"{FieldName} хэлбэр нь хүчин төгөлдөр бус байна.";
        }
public string Numeric()
        {
            return $"{FieldName} талбарт тоон утга оруулна уу.";
        }
public string Regex()
        {
            return $"{FieldName} талбарт оруулсан утга буруу байна.";
        }
public string Required()
        {
            return $"{FieldName} талбар шаардлагатай.";
        }
public string RequiredIf(string name, string value)
        {
            return $"Хэрэв {name} {value} бол {FieldName} табларт утга оруулах шаардлагатай.";
        }
public string Same(string name)
        {
            return $"{FieldName} болон {name} тохирох естой.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} {size} элемэнттэй байх шаардлагатай.";
        }
public string SizeString(int size)
        {
            return $"{FieldName} {size} тэмдэгтийн урттай байх шаардлагатай.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} дараах аль нэг нь эхлэх естой: {String.Join(", ", values)}.";
        }
public string Uppercase()
        {
            return $"{FieldName} нь том үсгээр бичигдсэн байх ёстой.";
        }
public string Url()
        {
            return $"{FieldName} зөв url хаяг оруулна уу.";
        }
    }
        }