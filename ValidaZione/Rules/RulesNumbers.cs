using System;
using System.Collections.Generic;
using System.Linq;
using ValidaZione.Interfaces;
using ValidaZione.Langs;
using ValidaZione.Objects;

namespace ValidaZione.Rules
{
    /// <summary>
    /// Rules for numbers
    /// </summary>
    /// <typeparam name="TValue">
    /// Type of the number.
    /// <see cref="UInt16"/>
    /// <see cref="UInt32"/>
    /// <see cref="UInt64"/>
    /// <see cref="Int16"/>
    /// <see cref="Int32"/>
    /// <see cref="Int64"/>
    /// <see cref="Single"/>
    /// <see cref="Double"/>
    /// <see cref="Decimal"/>
    /// </typeparam>
    public class RulesNumbers<TValue> : IRule
    {
        private ILang _lang;
        private Field Field { get; set; }
        private string FieldName { get; set; }
        private TValue Value { get; set; }

        private readonly List<Type> _allowed = new List<Type>()
        {
            typeof(UInt16),
            typeof(UInt32),
            typeof(UInt64),
            typeof(Int16),
            typeof(Int32),
            typeof(Int64),
            typeof(Single),
            typeof(Double),
            typeof(Decimal)
        };

        
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
        /// <exception cref="NotSupportedException">
        /// If the <see cref="TValue"/> is not a number.
        /// </exception>
        public RulesNumbers(ILang lang, string fieldName, TValue value)
        {
            if (!_allowed.Contains(typeof(TValue)))
            {
                throw new NotSupportedException();
            }
            
            _lang = lang;
            _lang.FieldName = fieldName;
            Field = new Field(fieldName);
            FieldName = fieldName;
            Value = value;
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
        /// The field under validation must have a size between the given min and max 
        /// </summary>
        /// <param name="min">
        /// Min value allowed.
        /// </param>
        /// <param name="max">
        /// Max value allowed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesNumbers<TValue> Between(TValue min, TValue max)
        {
            
            if (typeof(TValue) == typeof(UInt16))
            {
                if (Convert.ToUInt16(this.Value) < Convert.ToUInt16(min) ||
                    Convert.ToUInt16(max) < Convert.ToUInt16(Value))
                {
                    AddError(_lang.BetweenNumeric(min.ToString(), max.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(UInt32))
            {
                if (Convert.ToUInt32(this.Value) < Convert.ToUInt32(min) ||
                    Convert.ToUInt32(max) < Convert.ToUInt32(Value))
                {
                    AddError(_lang.BetweenNumeric(min.ToString(), max.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(UInt64))
            {
                if (Convert.ToUInt64(this.Value) < Convert.ToUInt64(min) ||
                    Convert.ToUInt64(max) < Convert.ToUInt64(Value))
                {
                    AddError(_lang.BetweenNumeric(min.ToString(), max.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Int16))
            {
                if (Convert.ToInt16(this.Value) < Convert.ToInt16(min) ||
                    Convert.ToInt16(max) < Convert.ToInt16(Value))
                {
                    AddError(_lang.BetweenNumeric(min.ToString(), max.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Int32))
            {
                if (Convert.ToInt32(this.Value) < Convert.ToInt32(min) ||
                    Convert.ToInt32(max) < Convert.ToInt32(Value))
                {
                    AddError(_lang.BetweenNumeric(min.ToString(), max.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Int64))
            {
                if (Convert.ToInt64(this.Value) < Convert.ToInt64(min) ||
                    Convert.ToInt64(max) < Convert.ToInt64(Value))
                {
                    AddError(_lang.BetweenNumeric(min.ToString(), max.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Single))
            {
                if (Convert.ToSingle(this.Value) < Convert.ToSingle(min) ||
                    Convert.ToSingle(max) < Convert.ToSingle(Value))
                {
                    AddError(_lang.BetweenNumeric(min.ToString(), max.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Double))
            {
                if (Convert.ToDouble(this.Value) < Convert.ToDouble(min) ||
                    Convert.ToDouble(max) < Convert.ToDouble(Value))
                {
                    AddError(_lang.BetweenNumeric(min.ToString(), max.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Decimal))
            {
                if (Convert.ToDecimal(this.Value) < Convert.ToDecimal(min) ||
                    Convert.ToDecimal(max) < Convert.ToDecimal(Value))
                {
                    AddError(_lang.BetweenNumeric(min.ToString(), max.ToString()));
                }
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
        public RulesNumbers<TValue> Confirmed(TValue value)
        {
            if (!Value.Equals(value))
            {
                AddError(_lang.Confirmed());
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
        /// Date of the field.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesNumbers<TValue> Different(String name, TValue value)
        {
            
            if (typeof(TValue) == typeof(UInt16))
            {
                if (Convert.ToUInt16(this.Value) == Convert.ToUInt16(value))
                {
                    AddError(_lang.Different(name));
                }
            }
            else if (typeof(TValue) == typeof(UInt32))
            {
                if (Convert.ToUInt32(this.Value) == Convert.ToUInt32(value))
                {
                    AddError(_lang.Different(name));
                }
            }
            else if (typeof(TValue) == typeof(UInt64))
            {
                if (Convert.ToUInt64(this.Value) == Convert.ToUInt64(value))
                {
                    AddError(_lang.Different(name));
                }
            }
            else if (typeof(TValue) == typeof(Int16))
            {
                if (Convert.ToInt16(this.Value) == Convert.ToInt16(value))
                {
                    AddError(_lang.Different(name));
                }
            }
            else if (typeof(TValue) == typeof(Int32))
            {
                if (Convert.ToInt32(this.Value) == Convert.ToInt32(value))
                {
                    AddError(_lang.Different(name));
                }
            }
            else if (typeof(TValue) == typeof(Int64))
            {
                if (Convert.ToInt64(this.Value) == Convert.ToInt64(value))
                {
                    AddError(_lang.Different(name));
                }
            }
            else if (typeof(TValue) == typeof(Single))
            {
                if (Convert.ToSingle(this.Value) == Convert.ToSingle(value))
                {
                    AddError(_lang.Different(name));
                }
            }
            else if (typeof(TValue) == typeof(Double))
            {
                if (Convert.ToDouble(this.Value) == Convert.ToDouble(value))
                {
                    AddError(_lang.Different(name));
                }
            }
            else if (typeof(TValue) == typeof(Decimal))
            {
                if (Convert.ToDecimal(this.Value) == Convert.ToDecimal(value))
                {
                    AddError(_lang.Different(name));
                }
            }


            return this;
        }
        
        
        
        /// <summary>
        /// The field under validation must be included in the given list of values
        /// </summary>
        /// <param name="values">
        /// List of the allowed dates.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesNumbers<TValue> In(List<TValue> values)
        {
            if (values.All(v => v != null && !v.Equals(Value)))
            {
                AddError(_lang.In());
            }

            return this;
        }
        
        /// <summary>
        /// The field under validation must be included in the given array of values
        /// </summary>
        /// <param name="values">
        /// Array of the allowed dates.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesNumbers<TValue> In(TValue[] values)
        {
            if (!values.All(v => v != null && !v.Equals(Value)))
            {
                AddError(_lang.In());
            }

            return this;
        }

        
        /// <summary>
        /// The field under validation must be less than or equal to a maximum value
        /// </summary>
        /// <param name="value">
        /// Max value allowed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesNumbers<TValue> Max(TValue value)
        {
            
            if (typeof(TValue) == typeof(UInt16))
            {
                if (Convert.ToUInt16(this.Value) > Convert.ToUInt16(value))
                {
                    AddError(_lang.MaxNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(UInt32))
            {
                if (Convert.ToUInt32(this.Value) > Convert.ToUInt32(value))
                {
                    AddError(_lang.MaxNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(UInt64))
            {
                if (Convert.ToUInt64(this.Value) > Convert.ToUInt64(value))
                {
                    AddError(_lang.MaxNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Int16))
            {
                if (Convert.ToInt16(this.Value) > Convert.ToInt16(value))
                {
                    AddError(_lang.MaxNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Int32))
            {
                if (Convert.ToInt32(this.Value) > Convert.ToInt32(value))
                {
                    AddError(_lang.MaxNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Int64))
            {
                if (Convert.ToInt64(this.Value) > Convert.ToInt64(value))
                {
                    AddError(_lang.MaxNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Single))
            {
                if (Convert.ToSingle(this.Value) > Convert.ToSingle(value))
                {
                    AddError(_lang.MaxNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Double))
            {
                if (Convert.ToDouble(this.Value) > Convert.ToDouble(value))
                {
                    AddError(_lang.MaxNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Decimal))
            {
                if (Convert.ToDecimal(this.Value) > Convert.ToDecimal(value))
                {
                    AddError(_lang.MaxNumeric(value.ToString()));
                }
            }
            
            return this;
        }
        
        
        /// <summary>
        /// The field under validation must have a minimum value
        /// </summary>
        /// <param name="value">
        /// Minimum value allowed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesNumbers<TValue> Min(TValue value)
        {
            
            if (typeof(TValue) == typeof(UInt16))
            {
                if (Convert.ToUInt16(this.Value) < Convert.ToUInt16(value))
                {
                     AddError(_lang.MinNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(UInt32))
            {
                if (Convert.ToUInt32(this.Value) < Convert.ToUInt32(value))
                {
                     AddError(_lang.MinNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(UInt64))
            {
                if (Convert.ToUInt64(this.Value) < Convert.ToUInt64(value))
                {
                     AddError(_lang.MinNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Int16))
            {
                if (Convert.ToInt16(this.Value) < Convert.ToInt16(value))
                {
                     AddError(_lang.MinNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Int32))
            {
                if (Convert.ToInt32(this.Value) < Convert.ToInt32(value))
                {
                     AddError(_lang.MinNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Int64))
            {
                if (Convert.ToInt64(this.Value) < Convert.ToInt64(value))
                {
                     AddError(_lang.MinNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Single))
            {
                if (Convert.ToSingle(this.Value) < Convert.ToSingle(value))
                {
                     AddError(_lang.MinNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Double))
            {
                if (Convert.ToDouble(this.Value) < Convert.ToDouble(value))
                {
                     AddError(_lang.MinNumeric(value.ToString()));
                }
            }
            else if (typeof(TValue) == typeof(Decimal))
            {
                if (Convert.ToDecimal(this.Value) < Convert.ToDecimal(value))
                {
                     AddError(_lang.MinNumeric(value.ToString()));
                }
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
        public RulesNumbers<TValue> NotIn(List<TValue> values)
        {
            if (values.Any(v => v != null && v.Equals(Value)))
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
        public RulesNumbers<TValue> NotIn(TValue[] values)
        {
            if (!values.Any(v => v != null && v.Equals(Value)))
            {
                AddError(_lang.NotIn());
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
        public RulesNumbers<TValue> Same(string name, TValue value)
        {
            if (value != null && value.Equals(Value))
            {
                AddError(_lang.Same(name));
            }

            return this;
        }
    }
}