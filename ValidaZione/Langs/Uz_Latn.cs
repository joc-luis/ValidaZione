using System.Collections.Generic;
        using ValidaZione.Interfaces;
        using System;

        namespace ValidaZione.Langs
        {
            public class Uz_Latn : ILang
            { public string FieldName { get; set; } 
public string Accepted()
            {
                return $"{FieldName} ni qabul qilishingiz kerak.";
            }
public string ActiveUrl()
        {
            return $"{FieldName} ga noto‘g‘ri URL kiritildi.";
        }
public string After(string date)
        {
            return $"{FieldName} da sana {date} dan keyin bo‘lishi kerak.";
        }
public string AfterOrEqual(string date)
        {
            return $"{FieldName} da sana {date} ga teng yoki undan keyin bo‘lishi kerak.";
        }
public string Alpha()
        {
            return $"{FieldName} faqat harflarni qabul qilishi mumkin.";
        }
public string AlphaDash()
        {
            return $"{FieldName} faqat harflar, sonlar va chiziqchalarni qabul qilishi mumkin.";
        }
public string AlphaNum()
        {
            return $"{FieldName} faqat harflar va sonlarni qabul qilishi mumkin.";
        }
public string Before(string date)
        {
            return $"{FieldName} da sana {date} gacha bo‘lishi kerak.";
        }
public string BeforeOrEqual(string date)
        {
            return $"{FieldName} da sana {date} ga teng yoki undan oldin bo‘lishi kerak.";
        }
public string BetweenArray(long min, long max)
        {
            return $"{FieldName} dagi elementlar soni {min} va {max} orasida bo‘lishi kerak.";
        }
public string BetweenNumeric(string min, string max)
        {
            return $"{FieldName} ning qiymati {min} va {max} orasida bo‘lishi kerak.";
        }
public string BetweenString(int min, int max)
        {
            return $"{FieldName} dagi belgilar soni {min} va {max} orasida bo‘lishi kerak.";
        }
public string Boolean()
        {
            return $"{FieldName} maydoni faqat mantiqiy qiymatni qabul qiladi.";
        }
public string Confirmed()
        {
            return $"{FieldName} tasdiqlangani bilan mos kelmadi.";
        }
public string Declined()
        {
            return $"The {FieldName} must be declined.";
        }
public string Different(string name)
        {
            return $"{FieldName} va {name} maydonlari farqli bo‘lishi kerak.";
        }
public string Distinct()
        {
            return $"{FieldName} maydoni takrorlanuvchi qiymatlardan iborat.";
        }
public string DoesNotEndWith(List<string> values)
        {
            return $"The {FieldName} may not end with one of the following: {String.Join(", ", values)}.";
        }
public string DoesNotStartWith(List<string> values)
        {
            return $"The {FieldName} may not start with one of the following: {String.Join(", ", values)}.";
        }
public string Email()
        {
            return $"{FieldName} haqiqiy elektron pochta manzili bo‘lishi kerak.";
        }
public string EndsWith(List<string> values)
        {
            return $"{FieldName} quyidagi qiymatlarning biri bilan tugashi kerak: {String.Join(", ", values)}.";
        }
public string GreaterThanArray(long value)
        {
            return $"{FieldName} dagi elementlar soni {value} dan katta bo‘lishi kerak.";
        }
public string GreaterThanString(int value)
        {
            return $"{FieldName} dagi belgilar soni {value} dan katta bo‘lishi kerak.";
        }
public string GreaterThanOrEqualArray(long value)
        {
            return $"{FieldName} dagi elementlar soni {value} dan katta yoki teng bo‘lishi kerak.";
        }
public string GreaterThanOrEqualString(int value)
        {
            return $"{FieldName} dagi belgilar soni {value} dan katta yoki teng bo‘lishi kerak.";
        }
public string In()
        {
            return $"{FieldName} uchun tanlangan qiymat xato.";
        }
public string Integer()
        {
            return $"{FieldName} butun son bo‘lishi kerak.";
        }
public string Ip()
        {
            return $"{FieldName} haqiqiy IP manzil bo‘lishi kerak.";
        }
public string Ipv4()
        {
            return $"{FieldName} haqiqiy IPv4 manzil bo‘lishi kerak.";
        }
public string Ipv6()
        {
            return $"{FieldName} haqiqiy IPv6 manzil bo‘lishi kerak.";
        }
public string Json()
        {
            return $"{FieldName} JSON qatori bo‘lishi kerak.";
        }
public string Lowercase()
        {
            return $"The {FieldName} must be lowercase.";
        }
public string LessThanArray(long value)
        {
            return $"{FieldName} dagi elementlar soni {value} dan kichik bo‘lishi kerak.";
        }
public string LessThanString(int value)
        {
            return $"{FieldName} dagi belgilar soni {value} dan kichik bo‘lishi kerak.";
        }
public string LessThanOrEqualArray(long value)
        {
            return $"{FieldName} dagi elementlar soni {value} dan kichik yoki teng bo‘lishi kerak.";
        }
public string LessThanOrEqualString(int value)
        {
            return $"{FieldName} dagi belgilar soni {value} dan kichik yoki teng bo‘lishi kerak.";
        }
public string MacAddress()
        {
            return $"The {FieldName} must be a valid MAC address.";
        }
public string MaxArray(long max)
        {
            return $"{FieldName} ning elementlar soni {max} tadan oshmasligi kerak.";
        }
public string MaxNumeric(string max)
        {
            return $"{FieldName} ning qiymati {max} dan oshmasligi kerak.";
        }
public string MaxString(int max)
        {
            return $"{FieldName} ning belgilar soni {max} tadan oshmasligi kerak.";
        }
public string MinArray(long min)
        {
            return $"{FieldName} dagi elementlar soni {min} tadan kam bo‘lmasligi kerak.";
        }
public string MinNumeric(string min)
        {
            return $"{FieldName} ning qiymati {min} dan kam bo‘lmasligi kerak.";
        }
public string MinString(int min)
        {
            return $"{FieldName} dagi belgilar soni {min} tadan kam bo‘lmasligi kerak.";
        }
public string NotIn()
        {
            return $"{FieldName} uchun tanlangan qiymat xato.";
        }
public string NotRegex()
        {
            return $"{FieldName} uchun tanlangan format xato.";
        }
public string Numeric()
        {
            return $"{FieldName} son bo‘lishi kerak.";
        }
public string Regex()
        {
            return $"{FieldName} maydoni xato formatda.";
        }
public string Required()
        {
            return $"{FieldName} maydoni to‘ldirilishi shart.";
        }
public string RequiredIf(string name, string value)
        {
            return $":Other maydoni {value} ga teng bo‘lsa, {FieldName} maydoni to‘ldirilishi shart.";
        }
public string Same(string name)
        {
            return $"{FieldName} ning qiymati {name} bilan bir xil bo‘lishi kerak.";
        }
public string SizeArray(long size)
        {
            return $"{FieldName} dagi elementlar soni {size} ga teng bo‘lishi kerak.";
        }
public string SizeString(int size)
        {
            return $"{FieldName} dagi belgilar soni {size} ga teng bo‘lishi kerak.";
        }
public string StartsWith(List<string> values)
        {
            return $"{FieldName} quyidagi qiymatlardan biri bilan boshlanishi kerak: {String.Join(", ", values)}.";
        }
public string Uppercase()
        {
            return $"The {FieldName} must be uppercase.";
        }
public string Url()
        {
            return $"{FieldName} noto‘g‘ri formatga ega.";
        }
    }
        }