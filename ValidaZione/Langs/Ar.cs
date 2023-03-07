using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Ar : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"يجب قبول {FieldName}.";
            }
public string ActiveUrl()
        {
            return $"حقل {FieldName} لا يُمثّل رابطًا صحيحًا.";
        }
public string After(string date)
        {
            return $"يجب على حقل {FieldName} أن يكون تاريخًا لاحقًا للتاريخ {date}.";
        }
public string AfterOrEqual(string date)
        {
            return $"حقل {FieldName} يجب أن يكون تاريخاً لاحقاً أو مطابقاً للتاريخ {date}.";
        }
public string Alpha()
        {
            return $"يجب أن لا يحتوي حقل {FieldName} سوى على حروف.";
        }
public string AlphaDash()
        {
            return $"يجب أن لا يحتوي حقل {FieldName} سوى على حروف، أرقام ومطّات.";
        }
public string AlphaNum()
        {
            return $"يجب أن يحتوي حقل {FieldName} على حروفٍ وأرقامٍ فقط.";
        }
public string Before(string date)
        {
            return $"يجب على حقل {FieldName} أن يكون تاريخًا سابقًا للتاريخ {date}.";
        }
public string BeforeOrEqual(string date)
        {
            return $"حقل {FieldName} يجب أن يكون تاريخا سابقا أو مطابقا للتاريخ {date}.";
        }
public string BetweenArray(long min, long max)
        {
            return $"يجب أن يحتوي حقل {FieldName} على عدد من العناصر بين {min} و {max}.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"يجب أن تكون قيمة حقل {FieldName} بين {min} و {max}.";
        }
public string BetweenString(int min, int max)
        {
            return $"يجب أن يكون عدد حروف نّص حقل {FieldName} بين {min} و {max}.";
        }
public string Boolean()
        {
            return $"يجب أن تكون قيمة حقل {FieldName} إما true أو false .";
        }
public string Confirmed()
        {
            return $"حقل التأكيد غير مُطابق للحقل {FieldName}.";
        }
public string Declined()
        {
            return $"يجب رفض {FieldName}.";
        }
public string Different(string name)
        {
            return $"يجب أن يكون الحقلان {FieldName} و {name} مُختلفين.";
        }
public string Distinct()
        {
            return $"للحقل {FieldName} قيمة مُكرّرة.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"الحقل {FieldName} يجب ألّا ينتهي بأحد القيم التالية: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"الحقل {FieldName} يجب ألّا يبدأ بأحد القيم التالية: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"يجب أن يكون حقل {FieldName} عنوان بريد إلكتروني صحيح البُنية.";
        }
public string EndsWith(List<string> values)
        {
            return $"يجب أن ينتهي حقل {FieldName} بأحد القيم التالية: {String.Join(", ", values)}";
        }
public string GreaterThanArray(long value)
        {
            return $"يجب أن يحتوي حقل {FieldName} على أكثر من {value} عناصر/عنصر.";
        }
public string GreaterThanString(int value)
        {
            return $"يجب أن يكون طول نّص حقل {FieldName} أكثر من {value} حروفٍ/حرفًا.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"يجب أن يحتوي حقل {FieldName} على الأقل على {value} عُنصرًا/عناصر.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"يجب أن يكون طول نص حقل {FieldName} على الأقل {value} حروفٍ/حرفًا.";
        }
public string In()
        {
            return $"حقل {FieldName} غير موجود.";
        }
public string Integer()
        {
            return $"يجب أن يكون حقل {FieldName} عددًا صحيحًا.";
        }
public string Ip()
        {
            return $"يجب أن يكون حقل {FieldName} عنوان IP صحيحًا.";
        }
public string Ipv4()
        {
            return $"يجب أن يكون حقل {FieldName} عنوان IPv4 صحيحًا.";
        }
public string Ipv6()
        {
            return $"يجب أن يكون حقل {FieldName} عنوان IPv6 صحيحًا.";
        }
public string Json()
        {
            return $"يجب أن يكون حقل {FieldName} نصًا من نوع JSON.";
        }
public string Lowercase()
        {
            return $"يجب أن يحتوي الحقل {FieldName} على حروف صغيرة.";
        }
public string LessThanArray(long value)
        {
            return $"يجب أن يحتوي حقل {FieldName} على أقل من {value} عناصر/عنصر.";
        }
public string LessThanString(int value)
        {
            return $"يجب أن يكون طول نّص حقل {FieldName} أقل من {value} حروفٍ/حرفًا.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"يجب أن لا يحتوي حقل {FieldName} على أكثر من {value} عناصر/عنصر.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"يجب أن لا يتجاوز طول نّص حقل {FieldName} {value} حروفٍ/حرفًا.";
        }
public string MacAddress()
        {
            return $"الحقل {FieldName} يجب أن يكون عنوان MAC صالحاً.";
        }
public string MaxArray(long max)
        {
            return $"يجب أن لا يحتوي حقل {FieldName} على أكثر من {max} عناصر/عنصر.";
        }
public string MaxNumeric(string max)
        {
            return $"يجب أن تكون قيمة حقل {FieldName} مساوية أو أصغر من {max}.";
        }
public string MaxString(int max)
        {
            return $"يجب أن لا يتجاوز طول نّص حقل {FieldName} {max} حروفٍ/حرفًا.";
        }
public string MinArray(long min)
        {
            return $"يجب أن يحتوي حقل {FieldName} على الأقل على {min} عُنصرًا/عناصر.";
        }
public string MinNumeric(string min)
        {
            return $"يجب أن تكون قيمة حقل {FieldName} مساوية أو أكبر من {min}.";
        }
public string MinString(int min)
        {
            return $"يجب أن يكون طول نص حقل {FieldName} على الأقل {min} حروفٍ/حرفًا.";
        }
public string NotIn()
        {
            return $"عنصر الحقل {FieldName} غير صحيح.";
        }
public string NotRegex()
        {
            return $"صيغة حقل {FieldName} غير صحيحة.";
        }
public string Numeric()
        {
            return $"يجب على حقل {FieldName} أن يكون رقمًا.";
        }
public string Regex()
        {
            return $"صيغة حقل {FieldName} غير صحيحة.";
        }
public string Required()
        {
            return $"حقل {FieldName} مطلوب.";
        }
public string RequiredIf(string name, string value)
        {
            return $"حقل {FieldName} مطلوب في حال ما إذا كان {name} يساوي {value}.";
        }
public string Same(string name)
        {
            return $"يجب أن يتطابق حقل {FieldName} مع {name}.";
        }
public string SizeArray(long size)
        {
            return $"يجب أن يحتوي حقل {FieldName} على {size} عنصرٍ/عناصر بالضبط.";
        }
public string SizeString(int size)
        {
            return $"يجب أن يحتوي نص حقل {FieldName} على {size} حروفٍ/حرفًا بالضبط.";
        }
public string StartsWith(List<string> values)
        {
            return $"يجب أن يبدأ حقل {FieldName} بأحد القيم التالية: {String.Join(", ", values)}";
        }
public string Uppercase()
        {
            return $"يجب أن يحتوي الحقل {FieldName} على حروف كبيرة.";
        }
public string Url()
        {
            return $"صيغة رابط حقل {FieldName} غير صحيحة.";
        }
    }
        }