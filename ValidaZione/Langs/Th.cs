using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Th : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"ข้อมูล {FieldName} ต้องผ่านการยอมรับก่อน";
            }
public string ActiveUrl()
        {
            return $"ข้อมูล {FieldName} ต้องเป็น URL เท่านั้น";
        }
public string After(string date)
        {
            return $"ข้อมูล {FieldName} ต้องเป็นวันที่หลังจาก {date}";
        }
public string AfterOrEqual(string date)
        {
            return $"ข้อมูล {FieldName} ต้องเป็นวันที่ตั้งแต่วันที่ {date} หรือหลังจากนั้น";
        }
public string Alpha()
        {
            return $"ข้อมูล {FieldName} ต้องเป็นตัวอักษรภาษาอังกฤษเท่านั้น";
        }
public string AlphaDash()
        {
            return $"ข้อมูล {FieldName} ต้องเป็นตัวอักษรภาษาอังกฤษ ตัวเลข และ _ เท่านั้น";
        }
public string AlphaNum()
        {
            return $"ข้อมูล {FieldName} ต้องเป็นตัวอักษรภาษาอังกฤษ ตัวเลข เท่านั้น";
        }
public string Before(string date)
        {
            return $"ข้อมูล {FieldName} ต้องเป็นวันที่ก่อน {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"ข้อมูล {FieldName} ต้องเป็นวันที่ก่อนหรือเท่ากับวันที่ {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"ข้อมูล {FieldName} ต้องมีค่าระหว่าง {min} - {max} ค่า";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"ข้อมูล {FieldName} ต้องอยู่ในช่วงระหว่าง {min} - {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"ข้อมูล {FieldName} ต้องมีความยาวตัวอักษรระหว่าง {min} - {max} ตัวอักษร";
        }
public string Boolean()
        {
            return $"ข้อมูล {FieldName} ต้องเป็นจริงหรือเท็จเท่านั้น";
        }
public string Confirmed()
        {
            return $"ข้อมูล {FieldName} ไม่ตรงกัน";
        }
public string Declined()
        {
            return $"ข้อมูล {FieldName} ต้องถูกปฏิเสธ";
        }
public string Different(string name)
        {
            return $"ข้อมูล {FieldName} และ {name} ต้องไม่เท่ากัน";
        }
public string Distinct()
        {
            return $"ข้อมูล {FieldName} มีค่าที่ซ้ำกัน";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"ข้อมูล {FieldName} ไม่ควรลงท้ายด้วยค่าดังต่อไปนี้: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"ข้อมูล {FieldName} ไม่ควรเริ่มต้นด้วยค่าดังต่อไปนี้: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"ข้อมูล {FieldName} ต้องเป็นอีเมล์";
        }
public string EndsWith(List<string> values)
        {
            return $"ข้อมูล {FieldName} ต้องจบด้วยค่าดังต่อไปนี้: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"ข้อมูล {FieldName} ต้องมีค่ามากกว่า {value}";
        }
public string GreaterThanString(int value)
        {
            return $"ข้อมูล {FieldName} ต้องมีความยาวตัวอักษรมากกว่า {value} ตัวอักษร";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"ข้อมูล {FieldName} ต้องมีค่า {value} หรือมากกว่า";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"ข้อมูล {FieldName} ต้องมีความยาวตัวอักษรมากกว่าหรือเท่ากับ {value} ตัวอักษร";
        }
public string In()
        {
            return $"ข้อมูลที่ถูกเลือกใน {FieldName} ไม่ถูกต้อง";
        }
public string Integer()
        {
            return $"ข้อมูล {FieldName} ต้องเป็นตัวเลข";
        }
public string Ip()
        {
            return $"ข้อมูล {FieldName} ต้องเป็น IP";
        }
public string Ipv4()
        {
            return $"ข้อมูล {FieldName} ต้องตรงตามรูปแบบ IPv4 address.";
        }
public string Ipv6()
        {
            return $"ข้อมูล {FieldName} ต้องตรงตามรูปแบบ IPv6 address.";
        }
public string Json()
        {
            return $"ข้อมูล {FieldName} ต้องเป็นอักขระ JSON ที่สมบูรณ์";
        }
public string Lowercase()
        {
            return $"{FieldName} ต้องเป็นตัวพิมพ์เล็ก";
        }
public string LessThanArray(long value)
        {
            return $"ข้อมูล {FieldName} ต้องมีน้อยกว่า {value} ค่า.";
        }
public string LessThanString(int value)
        {
            return $"ข้อมูล {FieldName} ต้องมีความยาวตัวอักษรน้อยกว่า {value} ตัวอักษร.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"ข้อมูล {FieldName} ต้องมีไม่เกิน {value} ค่า.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"ข้อมูล {FieldName} ต้องมีความยาวตัวอักษรน้อยกว่าหรือเท่ากับ {value} ตัวอักษร.";
        }
public string MacAddress()
        {
            return $"{FieldName} ต้องเป็นที่อยู่ MAC ที่ถูกต้อง";
        }
public string MaxArray(long max)
        {
            return $"ข้อมูล {FieldName} ต้องมีไม่เกิน {max} ค่า";
        }
public string MaxNumeric(string max)
        {
            return $"ข้อมูล {FieldName} ต้องมีค่าไม่เกิน {max}.";
        }
public string MaxString(int max)
        {
            return $"ข้อมูล {FieldName} ต้องมีความยาวตัวอักษรไม่เกิน {max} ตัวอักษร";
        }
public string MinArray(long min)
        {
            return $"ข้อมูล {FieldName} ต้องมีอย่างน้อย {min} ค่า";
        }
public string MinNumeric(string min)
        {
            return $"ข้อมูล {FieldName} ต้องมีค่าอย่างน้อย {min}.";
        }
public string MinString(int min)
        {
            return $"ข้อมูล {FieldName} ต้องมีความยาวตัวอักษรอย่างน้อย {min} ตัวอักษร";
        }
public string NotIn()
        {
            return $"ข้อมูล ที่เลือกจาก {FieldName} ไม่ถูกต้อง";
        }
public string NotRegex()
        {
            return $"ข้อมูล {FieldName} มีรูปแบบไม่ถูกต้อง.";
        }
public string Numeric()
        {
            return $"ข้อมูล {FieldName} ต้องเป็นตัวเลข";
        }
public string Regex()
        {
            return $"ข้อมูล {FieldName} มีรูปแบบไม่ถูกต้อง";
        }
public string Required()
        {
            return $"ข้อมูล {FieldName} จำเป็นต้องกรอก";
        }
public string RequiredIf(string name, string value)
        {
            return $"ข้อมูล {FieldName} จำเป็นต้องกรอกเมื่อ {name} เป็น {value}.";
        }
public string Same(string name)
        {
            return $"ข้อมูล {FieldName} และ {name} ต้องถูกต้อง";
        }
public string SizeArray(long size)
        {
            return $"ข้อมูล {FieldName} ต้องเท่ากับ {size} ค่า";
        }
public string SizeString(int size)
        {
            return $"ข้อมูล {FieldName} ต้องเท่ากับ {size} ตัวอักษร";
        }
public string StartsWith(List<string> values)
        {
            return $"ข้อมูล {FieldName} ต้องเริ่มด้วยค่าใดค่าหนึ่งต่อไปนี้: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"{FieldName} ต้องเป็นตัวพิมพ์ใหญ่";
        }
public string Url()
        {
            return $"ข้อมูล {FieldName} ไม่ถูกต้อง";
        }
    }
        }