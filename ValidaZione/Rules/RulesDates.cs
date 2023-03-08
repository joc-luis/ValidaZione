using System;
using System.Collections.Generic;
using System.Linq;
using ValidaZione.Interfaces;
using ValidaZione.Objects;

namespace ValidaZione.Rules
{
    
    /// <summary>
    /// Rules for DateTime
    /// </summary>
    public class RulesDates : IRule
    {
        private Field Field { get; set; }
        private string FieldName { get; set; }
        private DateTime? Value { get; set; }
        private bool Null { get; set; } = false;
        private ILang _lang;

        
        /// <summary>
        /// Prepare the field and value for the validation.
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
        public RulesDates(ILang lang, string fieldName, DateTime? value)
        {
            _lang = lang;
            _lang.FieldName = fieldName;
            Field = new Field(fieldName);
            FieldName = fieldName;
            Value = value;
        }

        private void AddError(string message)
        {
            Field.Errors.Add(message);
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
        /// The field under validation must be a value after a given date. 
        /// </summary>
        /// <param name="value">
        /// Date to compare the field
        /// </param>
        /// <returns>
        /// The instance of the object.
        /// </returns>
        public RulesDates After(DateTime value)
        {
            if (Value == null)
            {
                if (!this.Null)
                {
                    AddError(_lang.After(value.ToString("yyyy-MM-dd")));
                }

                return this;
            }

            if (Convert.ToDateTime(Value).Date <= value.Date)
            {
                AddError(_lang.After(value.ToString("yyyy-MM-dd")));
            }

            return this;
        }

        
        /// <summary>
        /// The field under validation must be a value after or equal to the given date 
        /// </summary>
        /// <param name="value">
        /// Date to compare the field
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesDates AfterOrEqual(DateTime value)
        {
            if (Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.AfterOrEqual(value.ToString("yyyy-MM-dd")));
                }

                return this;
            }

            if (Convert.ToDateTime(Value).Date < value.Date)
            {
                this.AddError(_lang.AfterOrEqual(value.ToString("yyyy-MM-dd")));
            }

            return this;
        }

        
        /// <summary>
        /// The field under validation must be a value preceding the given date 
        /// </summary>
        /// <param name="value">
        /// Date to compare the field
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesDates Before(DateTime value)
        {
            if (Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.Before(value.ToString("yyyy-MM-dd")));
                }

                return this;
            }

            if (Convert.ToDateTime(Value).Date >= value.Date)
            {
                this.AddError(_lang.Before(value.ToString("yyyy-MM-dd")));
            }

            return this;
        }
        
        
        /// <summary>
        /// The field under validation must be a value preceding or equal to the given date 
        /// </summary>
        /// <param name="value">
        /// Date to compare the field
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesDates BeforeOrEqual(DateTime value)
        {
            if (Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.BeforeOrEqual(value.ToString("yyyy-MM-dd")));
                }

                return this;
            }

            if (Convert.ToDateTime(Value).Date > value.Date)
            {
                this.AddError(_lang.BeforeOrEqual(value.ToString("yyyy-MM-dd")));
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be a value after or equal to the min date
        /// and preceding or equal to the max date 
        /// </summary>
        /// <param name="min">
        /// Min date
        /// </param>
        /// <param name="max">
        /// Max date
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesDates Between(DateTime min, DateTime max)
        {
            if (Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.BetweenNumeric(min.ToString(), max.ToString()));
                }

                return this;
            }

            if (Convert.ToDateTime(this.Value) < min || max < Convert.ToDateTime(this.Value))
            {
                this.AddError(_lang.BetweenNumeric(min.ToString(), max.ToString()));
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
        public RulesDates Confirmed(DateTime? value)
        {
            if (this.Value != value)
            {
                this.AddError(_lang.Confirmed());
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
        public RulesDates Different(String name, DateTime? value)
        {
            if (this.Value == value)
            {
                this.AddError(_lang.Different(name));
            }

            return this;
        }
        
        /// <summary>
        /// The field under validation must be included in the given list of values.
        /// </summary>
        /// <param name="values">
        /// List of the allowed dates.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesDates In(List<DateTime> values)
        {
            if (values.All(v => v != Convert.ToDateTime(Value)))
            {
                this.AddError(_lang.In());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be included in the given array of values
        /// </summary>
        /// <param name="values">
        /// List of the allowed dates.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesDates In(DateTime[] values)
        {
            if (Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.In());
                }

                return this;
            }

            if (values.All(v => v != Convert.ToDateTime(Value)))
            {
                this.AddError(_lang.In());
            }

            return this;
        }
        
        
        /// <summary>
        /// The field under validation must be less than or equal to a maximum value
        /// </summary>
        /// <param name="value">
        /// Max date allowed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesDates Max(DateTime value)
        {
            if (Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.MaxNumeric(value.ToString()));
                }

                return this;
            }

            if (Convert.ToDateTime(this.Value) > value)
            {
                this.AddError(_lang.MaxNumeric(value.ToString()));
            }

            return this;
        }

        /// <summary>
        /// The field under validation must have a minimum value
        /// </summary>
        /// <param name="value">
        /// Minimum date allowed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesDates Min(DateTime value)
        {
            if (Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.MinNumeric(value.ToString()));
                }

                return this;
            }

            if (Convert.ToDateTime(this.Value) < value)
            {
                this.AddError(_lang.MinNumeric(value.ToString()));
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
        public RulesDates NotIn(List<DateTime> values)
        {
            if (Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.NotIn());
                }

                return this;
            }

            if (values.Any(v => v == Convert.ToDateTime(Value)))
            {
                this.AddError(_lang.NotIn());
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
        public RulesDates NotIn(DateTime[] values)
        {
            if (Value == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.NotIn());
                }

                return this;
            }

            if (values.Any(v => v == Convert.ToDateTime(Value)))
            {
                this.AddError(_lang.NotIn());
            }

            return this;
        }
        
        
        /// <summary>
        /// The field under validation may be null.
        /// This feature not works in Confirmed, Different and Same   rules.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesDates Nullable()
        {
            this.Null = true;

            return this;
        }
        
        /// <summary>
        /// The field under validation must be present in the input data and not empty
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesDates Required()
        {
            this.Null = false;

            if (this.Value == null)
            {
                this.AddError(_lang.Required());  
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
        public RulesDates Same(String name, DateTime? value)
        {
            if (Value != value)
            {
                this.AddError(_lang.Same(name));
            }

            return this;
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
        public RulesDates Unique(List<DateTime> values)
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
        public RulesDates Unique(DateTime[] values)
        {
            if (values.Any(v => this.Value == v))
            {
                AddError(_lang.Unique());
            }

            return this;
        }
    }
}