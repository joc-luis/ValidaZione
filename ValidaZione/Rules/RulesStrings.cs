﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using Newtonsoft.Json.Linq;
using ValidaZione.Interfaces;
using ValidaZione.Objects;

namespace ValidaZione.Rules
{
    /// <summary>
    /// Rules for string values.
    /// </summary>
    public class RulesStrings : IRule
    {
        private ILang _lang;
        private String FieldName { get; set; }
        private String? Value { get; set; }
        private Field Field { get; set; }
        private bool Null { get; set; } = false;


        /// <summary>
        /// Prepare the field and value for the validations.
        /// </summary>
        /// <param name="lang">
        /// Language of errors messages. <see cref="ILang"/>, <see cref="Language"/>
        /// </param>
        /// <param name="fieldName">
        /// Name of the field.
        /// </param>
        /// <param name="value">
        /// Value of the field.
        /// </param>
        public RulesStrings(ILang lang, string fieldName, string? value)
        {
            _lang = lang;
            _lang.FieldName = fieldName;
            Field = new Field(fieldName);
            this.FieldName = fieldName;
            this.Value = value;
        }

        private void AddError(string error)
        {
            Field.Errors.Add(error);
        }

        /// <summary>
        /// Get errors from the validation
        /// </summary>
        /// <returns>
        /// Field and errors.
        /// </returns>
        public Field ErrorsByField()
        {
            return Field;
        }

        /// <summary>
        /// The field under validation must be "yes", "on", 1, or true.
        /// This is useful for validating "Terms of Service" acceptance or similar fields.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Accepted()
        {
            string[] allowed = new[] { "yes", "on", "true", "1" };
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.Accepted());
                }

                return this;
            }

            if (allowed.All(a => a != Value))
            {
                this.AddError(_lang.Accepted());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must have a valid and avaible URL.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings ActiveUrl()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.ActiveUrl());
                }

                return this;
            }

            try
            {
                if (!Uri.IsWellFormedUriString(this.Value, UriKind.RelativeOrAbsolute))
                {
                    AddError(_lang.Url());
                    return this;
                }

                WebRequest? request = WebRequest.Create(this.Value) as HttpWebRequest;
                request.Method = "HEAD";
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                    {
                        AddError(_lang.ActiveUrl());
                    }
                }
            }
            catch (Exception e)
            {
                AddError(_lang.ActiveUrl());
            }

            return this;
        }


        /// <summary>
        /// The field under validation must be entirely Unicode alphabetic characters.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Alpha()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.Alpha());
                }

                return this;
            }

            if (!this.Value.All(Char.IsLetter))
            {
                this.AddError(_lang.Alpha());
            }

            return this;
        }


        /// <summary>
        /// The field under validation must be entirely Unicode alpha-numeric characters.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings AlphaDash()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.AlphaDash());
                }

                return this;
            }

            if (!this.Value.All(c => (c >= 48 && c <= 57) 
                                     || Char.IsLetter(c)
                                     || (c == 45 || c == 95)))
            {
                this.AddError(_lang.AlphaDash());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be entirely Unicode alpha-numeric characters.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings AlphaNum()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.AlphaNum());
                }

                return this;
            }

            if (!this.Value.All(c => Char.IsNumber(c) || Char.IsLetter(c)))
            {
                this.AddError(_lang.AlphaNum());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must have a size between the given min and max 
        /// </summary>
        /// <param name="min">
        /// Min size
        /// </param>
        /// <param name="max">
        /// Max size
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Between(int min, int max)
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.BetweenString(min, max));
                }

                return this;
            }

            if (this.Value.Length < min || max < this.Value.Length)
            {
                this.AddError(_lang.BetweenString(min, max));
            }

            return this;
        }


        /// <summary>
        /// The field under validation must be able to be cast as a boolean.
        /// Accepted input are true, false, "1", and "0"
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Boolean()
        {
            string[] allowed = new[] { "true", "false", "0", "1" };

            if (this.Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.Boolean());
                }

                return this;
            }


            if (allowed.All(a => a != Value))
            {
                this.AddError(_lang.Boolean());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be a value equal to the given value.
        /// </summary>
        /// <param name="value">
        /// Value to confirmed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Confirmed(string value)
        {
            if (Value != value)
            {
                this.AddError(_lang.Confirmed());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be "no", "off", 0, or false.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Declined()
        {
            string[] allowed = new[] { "false", "no", "off", "0" };
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.Declined());
                }

                return this;
            }


            if (allowed.All(a => a != Value))
            {
                this.AddError(_lang.Declined());
            }

            return this;
        }


        /// <summary>
        /// The field under validation must have a different value than field
        /// </summary>
        /// <param name="name">
        /// Name of the field.
        /// </param>
        /// <param name="value">
        /// Value of the field.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Different(String name, String value)
        {
            if (this.Value == value)
            {
                this.AddError(_lang.Different(name));
            }

            return this;
        }
        
        
        /// <summary>
        /// The field under validation must not end with one of the given values.
        /// </summary>
        /// <param name="values">Not allowed values.</param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings DoesNotEndWith(List<String> values)
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.DoesNotEndWith(values));
                }

                return this;
            }


            if (values.Any(v => this.Value.EndsWith(v)))
            {
                AddError(_lang.DoesNotEndWith(values));
            }

            return this;
        }
        
        
        /// <summary>
        /// The field under validation must not end with one of the given values.
        /// </summary>
        /// <param name="values">Not allowed values.</param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings DoesNotEndWith(String[] values)
        {
            return DoesNotEndWith(values.ToList());
        }
        
        /// <summary>
        /// The field under validation must not end with one of the given values.
        /// </summary>
        /// <param name="values">Not allowed values.</param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings DoesNotEndWith(IEnumerable<String> values)
        {
            return DoesNotEndWith(values.ToList());
        }

        
        
        /// <summary>
        /// The field under validation must not start with one of the given values.
        /// </summary>
        /// <param name="values">Not allowed values.</param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings DoesNotStartWith(List<String> values)
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.DoesNotStartWith(values));
                }

                return this;
            }


            if (values.Any(v => this.Value.StartsWith(v)))
            {
                AddError(_lang.DoesNotStartWith(values));
            }

            return this;
        }
        
        /// <summary>
        /// The field under validation must not start with one of the given values.
        /// </summary>
        /// <param name="values">Not allowed values.</param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings DoesNotStartWith(String[] values)
        {
            return DoesNotStartWith(values.ToList());
        }
        
        /// <summary>
        /// The field under validation must not start with one of the given values.
        /// </summary>
        /// <param name="values">Not allowed values.</param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings DoesNotStartWith(IEnumerable<String> values)
        {
            return DoesNotStartWith(values.ToList());
        }


        /// <summary>
        /// The field under validation must be formatted as an email address.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Email()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.Email());
                }

                return this;
            }

            try
            {
                MailAddress mailAddress = new MailAddress(this.Value);
            }
            catch (Exception e)
            {
                this.AddError(_lang.Email());
            }

            return this;
        }


        /// <summary>
        /// The field under validation must end with one of the given values.
        /// </summary>
        /// <param name="values">
        /// Values allowed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings EndsWith(List<String> values)
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.EndsWith(values));
                }

                return this;
            }


            if (!values.Any(v => this.Value.EndsWith(v)))
            {
                AddError(_lang.EndsWith(values));
            }

            return this;
        }


        /// <summary>
        /// The field under validation must end with one of the given values.
        /// </summary>
        /// <param name="values">
        /// Values allowed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings EndsWith(String[] values)
        {
            return EndsWith(values.ToList());
        }
        
        /// <summary>
        /// The field under validation must end with one of the given values.
        /// </summary>
        /// <param name="values">
        /// Values allowed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings EndsWith(IEnumerable<String> values)
        {
            return EndsWith(values.ToList());
        }


        /// <summary>
        /// The field under validation must be greater than the given field.
        /// </summary>
        /// <param name="value">
        /// Value to compare. If is null the length be 0.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings GreaterThan(string value)
        {
            int length = String.IsNullOrEmpty(value) ? 0 : value.Length;
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.GreaterThanString(length));
                }

                return this;
            }

            if (length >= Value.Length)
            {
                AddError(_lang.GreaterThanString(length));
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be greater than or equal to the given field.
        /// </summary>
        /// <param name="value">
        /// Value to compare. If is null the length be 0.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings GreaterThanOrEqual(string value)
        {
            int length = String.IsNullOrEmpty(value) ? 0 : value.Length;

            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.GreaterThanOrEqualString(length));
                }

                return this;
            }

            if (length > Value.Length)
            {
                AddError(_lang.GreaterThanOrEqualString(length));
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be included in the given list of values.
        /// </summary>
        /// <param name="values">
        /// List of the allowed values.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings In(List<String> values)
        {
            if (values.All(v => this.Value != v))
            {
                AddError(_lang.In());
            }

            return this;
        }


        /// <summary>
        /// The field under validation must be included in the given array of values.
        /// </summary>
        /// <param name="values">
        /// Array of the allowed values.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings In(String[] values)
        {
            return In(values.ToList());
        }
        
        /// <summary>
        /// The field under validation must be included in the given array of values.
        /// </summary>
        /// <param name="values">
        /// Array of the allowed values.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings In(IEnumerable<String> values)
        {
            return In(values.ToList());
        }

        /// <summary>
        /// The field under validation must be an integer.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Integer()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.Integer());
                }

                return this;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(Value, "(^[\\-][0-9]+$)|(^[0-9]+$)"))
            {
                this.AddError(_lang.Integer());
            }

            return this;
        }


        /// <summary>
        /// The field under validation must be an IP address IPv4 or IPv6.
        /// The validation use IPAddress.Parse <see cref="IPAddress"/>
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Ip()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.Ip());
                }

                return this;
            }

            try
            {
                var ip = IPAddress.Parse(this.Value);

                if (ip.AddressFamily != AddressFamily.InterNetwork
                    && ip.AddressFamily != AddressFamily.InterNetworkV6)
                {
                    AddError(_lang.Ip());
                }
            }
            catch (Exception)
            {
                AddError(_lang.Ip());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be an IPv4 address.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Ipv4()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.Ipv4());
                }

                return this;
            }

            try
            {
                IPAddress ip = IPAddress.Parse(this.Value);

                if (ip.AddressFamily != AddressFamily.InterNetwork)
                {
                    this.AddError(_lang.Ipv4());
                }
            }
            catch (Exception)
            {
                this.AddError(_lang.Ipv4());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be an IPv6 address.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Ipv6()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.Ipv6());
                }

                return this;
            }

            try
            {
                IPAddress ip = IPAddress.Parse(this.Value);

                if (ip.AddressFamily != AddressFamily.InterNetworkV6)
                {
                    AddError(_lang.Ipv6());
                }
            }
            catch (Exception)
            {
                AddError(_lang.Ipv6());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be a valid JSON string.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Json()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.Json());
                }

                return this;
            }

            try
            {
                JObject.Parse(this.Value);
            }
            catch (Exception e)
            {
                AddError(_lang.Json());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be lowercase.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Lowercase()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.Lowercase());
                }

                return this;
            }

            if (!this.Value.All(Char.IsLower))
            {
                AddError(_lang.Lowercase());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be less than the given field
        /// </summary>
        /// <param name="value">
        /// Value to comapre. If the value is null the lenght be 0.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings LessThan(string value)
        {
            int length = String.IsNullOrEmpty(value) ? 0 : value.Length;

            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.LessThanString(length));
                }

                return this;
            }

            if (length <= Value.Length)
            {
                AddError(_lang.LessThanString(length));
            }

            return this;
        }


        /// <summary>
        /// The field under validation must be less than or equal to the given field
        /// </summary>
        /// <param name="value">
        /// Value to comapre. If the value is null the length be 0.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings LessThanOrEqual(string value)
        {
            int length = String.IsNullOrEmpty(value) ? 0 : value.Length;
            
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.LessThanOrEqualString(value.Length));
                }

                return this;
            }

            if (this.Value.Length > length)
            {
                AddError(_lang.LessThanOrEqualString(length));
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be a MAC address.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings MacAddress()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.MacAddress());
                }

                return this;
            }

            String mac = this.Value.Replace(" ", "")
                .Replace(":", "")
                .Replace("-", "");

            Regex regex = new Regex("^[a-fA-F0-9]{12}$");


            if (!regex.IsMatch(mac))
            {
                this.AddError(_lang.MacAddress());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be less than or equal to a maximum value
        /// </summary>
        /// <param name="max">
        /// Max length allowed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Max(int max)
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.MaxString(max));
                }

                return this;
            }

            if (this.Value.Length > max)
            {
                AddError(_lang.MaxString(max));
            }

            return this;
        }

        /// <summary>
        /// The field under validation must have a minimum value
        /// </summary>
        /// <param name="min">
        ///  Min length allowed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Min(int min)
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.MinString(min));
                }

                return this;
            }

            if (this.Value.Length < min)
            {
                AddError(_lang.MinString(min));
            }

            return this;
        }

        /// <summary>
        /// The field under validation must not be included in the given list of values
        /// </summary>
        /// <param name="values">
        /// List of values not allowed
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings NotIn(List<String> values)
        {
            if (values.Any(v => this.Value == v))
            {
                AddError(_lang.NotIn());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must not be included in the given array of values
        /// </summary>
        /// <param name="values">
        /// Array of values not allowed
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings NotIn(String[] values)
        {
            return NotIn(values.ToList());
        }
        
        /// <summary>
        /// The field under validation must not be included in the given array of values
        /// </summary>
        /// <param name="values">
        /// Array of values not allowed
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings NotIn(IEnumerable<String> values)
        {
            return NotIn(values.ToList());
        }

        /// <summary>
        /// The field under validation must not match the given regular expression.
        /// </summary>
        /// <param name="pattern">
        /// Not allowed pattern
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings NotRegex(String pattern)
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.NotRegex());
                }

                return this;
            }

            Regex regex = new Regex(pattern);


            if (regex.IsMatch(this.Value))
            {
                AddError(_lang.NotRegex());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must not match the given regular expression.
        /// </summary>
        /// <param name="regex">
        /// Regular expression
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings NotRegex(Regex regex)
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.NotRegex());
                }

                return this;
            }


            if (regex.IsMatch(this.Value))
            {
                AddError(_lang.NotRegex());
            }

            return this;
        }

        /// <summary>
        /// The field under validation may be null.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Nullable()
        {
            this.Null = true;

            return this;
        }


        /// <summary>
        /// The field under validation must be numeric.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Numeric()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.Numeric());
                }

                return this;
            }

            try
            {
                Convert.ToDouble(this.Value);
            }
            catch (Exception e)
            {
                AddError(_lang.Numeric());
            }

            return this;
        }


        /// <summary>
        /// The field under validation must match the given regular expression.
        /// </summary>
        /// <param name="pattern">
        /// Allowed pattern
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Regex(String pattern)
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.Regex());
                }

                return this;
            }

            Regex regex = new Regex(pattern);


            if (!regex.IsMatch(this.Value))
            {
                AddError(_lang.Regex());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must match the given regular expression.
        /// </summary>
        /// <param name="regex">
        /// Regular expression
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Regex(Regex regex)
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.Regex());
                }

                return this;
            }

            if (!regex.IsMatch(this.Value))
            {
                AddError(_lang.Regex());
            }

            return this;
        }


        /// <summary>
        /// The field under validation must be present in the input data and not empty.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Required()
        {
            this.Null = false;

            if (string.IsNullOrEmpty(this.Value))
            {
                AddError(_lang.Required());
            }

            return this;
        }


        /// <summary>
        /// The field under validation must be present and not empty if the another field is equal to any value
        /// </summary>
        /// <param name="name">Name of the field</param>
        /// <param name="value">Value of the field</param>
        /// <param name="equalValue">Value to compare.</param>
        /// <returns></returns>
        public RulesStrings RequiredIf(string name, string value, string equalValue)
        {
            if (string.IsNullOrEmpty(Value) && value == equalValue)
            {
                AddError(_lang.RequiredIf(name, value));
            }

            return this;
        }


        /// <summary>
        /// The given field must match the field under validation.
        /// </summary>
        /// <param name="name">
        /// Name of the field.
        /// </param>
        /// <param name="value">
        /// Value of the field.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Same(String name, String value)
        {
            if (this.Value != value)
            {
                AddError(_lang.Same(name));
            }

            return this;
        }


        /// <summary>
        /// The field under validation must have a size matching the given value
        /// </summary>
        /// <param name="size">
        /// Length allowed
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Size(int size)
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.SizeString(size));
                }

                return this;
            }

            if (this.Value.Length != size)
            {
                AddError(_lang.SizeString(size));
            }

            return this;
        }


        /// <summary>
        /// The field under validation must start with one of the given values.
        /// </summary>
        /// <param name="values">
        /// Allowed values.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings StartsWith(List<String> values)
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.StartsWith(values));
                }

                return this;
            }

            if (values.All(v => !this.Value.StartsWith(v)))
            {
                AddError(_lang.StartsWith(values));
            }

            return this;
        }


        /// <summary>
        /// The field under validation must start with one of the given values.
        /// </summary>
        /// <param name="values">
        /// Allowed values.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings StartsWith(String[] values)
        {
            return StartsWith(values.ToList());
        }
        
        
        /// <summary>
        /// The field under validation must start with one of the given values.
        /// </summary>
        /// <param name="values">
        /// Allowed values.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings StartsWith(IEnumerable<String> values)
        {
            return StartsWith(values.ToList());
        }
        
        /// <summary>
        /// The field under validation must not exist within the given list.
        /// </summary>
        /// <param name="values">
        /// List of values not allowed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Unique(List<String> values)
        {
            if (values.Any(v => this.Value == v))
            {
                AddError(_lang.Unique());
            }

            return this;
        }
        
        /// <summary>
        /// The field under validation must not exist within the given array.
        /// </summary>
        /// <param name="values">
        /// Array of values not allowed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Unique(String[] values)
        {
            return Unique(values.ToList());
        }
        
        /// <summary>
        /// The field under validation must not exist within the given array.
        /// </summary>
        /// <param name="values">
        /// Array of values not allowed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Unique(IEnumerable<String> values)
        {
            return Unique(values.ToList());
        }

        /// <summary>
        /// The field under validation must be uppercase.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Uppercase()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.Uppercase());
                }

                return this;
            }

            if (!this.Value.All(Char.IsUpper))
            {
                AddError(_lang.Uppercase());
            }

            return this;
        }


        /// <summary>
        /// The field under validation must be a valid URL.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Url()
        {
            if (this.Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.Url());
                }

                return this;
            }

            if (!Uri.IsWellFormedUriString(this.Value, UriKind.RelativeOrAbsolute))
            {
                AddError(_lang.Url());
            }

            return this;
        }
    }
}