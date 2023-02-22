using System;
using System.Collections.Generic;

namespace ValidaZione.Interfaces
{
    
    /// <summary>
    /// Interface for messages language
    /// </summary>
    public interface ILang
    {
        
        /// <summary>
        /// Name of the field
        /// </summary>
        string FieldName { get; set; }
        
        /// <summary>
        /// Error message for Accepted rule.
        /// </summary>
        /// <returns></returns>
        string Accepted();
        
        /// <summary>
        /// Set the error message for ActiveUrl rule.
        /// </summary>
        /// <returns></returns>
        string ActiveUrl();
        
        /// <summary>
        /// Set the error message for After rule.
        /// <param name="date">Value to compare</param>
        /// </summary>
        /// <returns></returns>
        string After(String date);
        
        /// <summary>
        /// Set the error message for AfterOrEqual rule.
        /// </summary>
        /// <param name="date">
        /// Value to compare
        /// </param>
        /// <returns></returns>
        string AfterOrEqual(String date);
        
        /// <summary>
        /// Set the error message for Alpha rule.
        /// </summary>
        /// <returns></returns>
        string Alpha();
        
        /// <summary>
        /// Set the error message for AlphaDash rule.
        /// </summary>
        /// <returns></returns>
        string AlphaDash();
        
        /// <summary>
        /// Set the error message for AlphaNum rule.
        /// </summary>
        /// <returns></returns>
        string AlphaNum();
        
        /// <summary>
        /// Set the error message for Before rule.
        /// <param name="date">Value to compare</param>
        /// </summary>
        /// <returns></returns>
        string Before(String date);
        
        /// <summary>
        /// Set the error message for BeforeOrEqual rule.
        /// <param name="date">Value to compare.</param>
        /// </summary>
        /// <returns></returns>
        string BeforeOrEqual(String date);
        
        /// <summary>
        /// Set the error message for BetweenNumeric rule.
        /// <param name="min">Min value allowed.</param>
        /// <param name="max">Max value allowed.</param>
        /// </summary>
        /// <returns></returns>
        string BetweenNumeric(String min, String max);
        
        /// <summary>
        /// Set the error message for BetweenString rule.
        /// <param name="min">Min value allowed.</param>
        /// <param name="max">Max value allowed.</param>
        /// </summary>
        /// <returns></returns>
        string BetweenString(int min, int max);
        
        /// <summary>
        /// Set the error message for BetweenArray rule.
        /// <param name="min">Min value allowed.</param>
        /// <param name="max">Max value allowed.</param>
        /// </summary>
        /// <returns></returns>
        string BetweenArray(long min, long max);
        
        /// <summary>
        /// Set the error message for Boolean rule.
        /// </summary>
        /// <returns></returns>
        string Boolean();
        
        /// <summary>
        /// Set the error message for Confirmed rule.
        /// </summary>
        /// <returns></returns>
        string Confirmed();
        
        /// <summary>
        /// Set the error message for Declined rule.
        /// </summary>
        /// <returns></returns>
        string Declined();
        
        /// <summary>
        /// Set the error message for Different rule.
        /// <param name="name">Name of the field.</param>
        /// </summary>
        /// <returns></returns>
        string Different(string name);
        
        /// <summary>
        /// Set the error message for Distinct rule.
        /// </summary>
        /// <returns></returns>
        string Distinct();
        
        /// <summary>
        /// Set the error message for Email rule.
        /// </summary>
        /// <returns></returns>
        string Email();
        
        /// <summary>
        /// Set the error message for EndsWith rule.
        /// <param name="values">List of allowed values.</param>
        /// </summary>
        /// <returns></returns>
        string EndsWith(List<String> values);
        
        /// <summary>
        /// Set the error message for GreaterThaArray rule.
        /// <param name="value">Min size allowed.</param>
        /// </summary>
        /// <returns></returns>
        string GreaterThanArray(long value);
        
        /// <summary>
        /// Set the error message for GreaterThanString rule.
        /// <param name="value">Min size allowed.</param>
        /// </summary>
        /// <returns></returns>
        string GreaterThanString(int value);
        
        /// <summary>
        /// Set the error message for GreaterThanOrEqualArray rule.
        /// <param name="value">Min size allowed.</param>
        /// </summary>
        /// <returns></returns>
        string GreaterThanOrEqualArray(long value);
        
        /// <summary>
        /// Set the error message for GreaterThanOrEqualString rule.
        /// <param name="value">Min size allowed.</param>
        /// </summary>
        /// <returns></returns>
        string GreaterThanOrEqualString(int value);
        
        /// <summary>
        /// Set the error message for In rule.
        /// </summary>
        /// <returns></returns>
        string In();
        
        /// <summary>
        /// Set the error message for Integer rule.
        /// </summary>
        /// <returns></returns>
        string Integer();
        
        /// <summary>
        /// Set the error message for Ip rule.
        /// </summary>
        /// <returns></returns>
        string Ip();
        
        /// <summary>
        /// Set the error message for Ipv4 rule.
        /// </summary>
        /// <returns></returns>
        string Ipv4();
        
        /// <summary>
        /// Set the error message for Ipv6 rule.
        /// </summary>
        /// <returns></returns>
        string Ipv6();
        
        /// <summary>
        /// Set the error message for Json rule.
        /// </summary>
        /// <returns></returns>
        string Json();
        
        /// <summary>
        /// Set the error message for Lowercase rule.
        /// </summary>
        /// <returns></returns>
        string Lowercase();
        
        /// <summary>
        /// Set the error message for LessThanArray rule.
        /// <param name="value">Max size allowed.</param>
        /// </summary>
        /// <returns></returns>
        string LessThanArray(long value);
        
        /// <summary>
        /// Set the error message for LessThanString rule.
        /// <param name="value">Max size allowed.</param>
        /// </summary>
        /// <returns></returns>
        string LessThanString(int value);
        
        /// <summary>
        /// Set the error message for LessThanOrEqualArray rule.
        /// <param name="value">Max size allowed.</param>
        /// </summary>
        /// <returns></returns>
        string LessThanOrEqualArray(long value);
        
        /// <summary>
        /// Set the error message for LessThanOrEqualString rule.
        /// <param name="value">Max size allowed.</param>
        /// </summary>
        /// <returns></returns>
        string LessThanOrEqualString(int value);
        
        /// <summary>
        /// Set the error message for MacAddress rule.
        /// </summary>
        /// <returns></returns>
        string MacAddress();
        
        /// <summary>
        /// Set the error message for MaxArray rule.
        /// <param name="max">Max size allowed.</param>
        /// </summary>
        /// <returns></returns>
        string MaxArray(long max);
        
        /// <summary>
        /// Set the error message for MaxNumeric rule.
        /// <param name="max">Max value allowed.</param>
        /// </summary>
        /// <returns></returns>
        string MaxNumeric(string max);
        
        /// <summary>
        /// Set the error message for MaxString rule.
        /// <param name="max">Max size allowed.</param>
        /// </summary>
        /// <returns></returns>
        string MaxString(int max);
        
        /// <summary>
        /// Set the error message for MinArray rule.
        /// <param name="min">Min size allowed.</param>
        /// </summary>
        /// <returns></returns>
        string MinArray(long  min);
        
        /// <summary>
        /// Set the error message for MinNumeric rule.
        /// <param name="min">Min size allowed.</param>
        /// </summary>
        /// <returns></returns>
        string MinNumeric(string min);
        
        /// <summary>
        /// Set the error message for MinString rule.
        /// <param name="min">Min value allowed.</param>
        /// </summary>
        /// <returns></returns>
        string MinString(int min);
        
        /// <summary>
        /// Set the error message for NotIn rule.
        /// </summary>
        /// <returns></returns>
        string NotIn();
        
        /// <summary>
        /// Set the error message for NotRegex rule.
        /// </summary>
        /// <returns></returns>
        string NotRegex();
        
        /// <summary>
        /// Set the error message for Numeric rule.
        /// </summary>
        /// <returns></returns>
        string Numeric();
        
        /// <summary>
        /// Set the error message for Regex rule.
        /// </summary>
        /// <returns></returns>
        string Regex();
        
        /// <summary>
        /// Set the error message for Required rule.
        /// </summary>
        /// <returns></returns>
        string Required();
        
        /// <summary>
        /// Set the error message for Same rule.
        /// <param name="name">Name of the field.</param>
        /// </summary>
        /// <returns></returns>
        string Same(string name);
        
        /// <summary>
        /// Set the error message for SizeArray rule.
        /// <param name="size">Size allowed.</param>
        /// </summary>
        /// <returns></returns>
        string SizeArray(long size);
        
        /// <summary>
        /// Set the error message for SizeString rule.
        /// <param name="size">Size allowed.</param>
        /// </summary>
        /// <returns></returns>
        string SizeString(int size);
        
        /// <summary>
        /// Set the error message for StartsWith rule.
        /// <param name="values">List of values allowed.</param>
        /// </summary>
        /// <returns></returns>
        string StartsWith(List<String> values);
        
        /// <summary>
        /// Set the error message for Uppercase rule.
        /// </summary>
        /// <returns></returns>
        string Uppercase();
        
        /// <summary>
        /// Set the error message for Url rule.
        /// </summary>
        /// <returns></returns>
        string Url();

    }
}