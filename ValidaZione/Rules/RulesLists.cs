using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using ValidaZione.Interfaces;
using ValidaZione.Langs;
using ValidaZione.Objects;

namespace ValidaZione.Rules
{
    public class RulesLists<TValue> : IRule
    {
        private ILang _lang;
        public Field Field { get; private set; }
        private List<TValue>? Values { get; set; }
        private String FieldName { get; set; }
        private bool Null { get; set; } = false;

        /// <summary>
        /// Prepare the field and value for the validation.
        /// </summary>
        /// <param name="lang">
        /// Language of errors messages. <see cref="ILang"/>, <see cref="Language"/>
        /// </param>
        /// <param name="name">
        /// Name of the field.
        /// </param>
        /// <param name="values">
        /// Value of the field.
        /// </param>
        public RulesLists(ILang lang, String fieldName, List<TValue>? values)
        {
            _lang = lang;
            _lang.FieldName = fieldName;
            Field = new Field(fieldName);
            FieldName = fieldName;
            Values = values;
        }

        /// <summary>
        /// Prepare the field and value for the validation.
        /// </summary>
        /// <param name="lang">
        /// Language of errors messages. <see cref="ILang"/>, <see cref="Language"/>
        /// </param>
        /// <param name="name">
        /// Name of the field.
        /// </param>
        /// <param name="values">
        /// Value of the field.
        /// </param>
        public RulesLists(ILang lang, String fieldName, TValue[]? values)
        {
            _lang = lang;
            _lang.FieldName = fieldName;
            Field = new Field(fieldName);
            FieldName = fieldName;
            if (values != null) Values = values.ToList();
        }
        
        private void AddError(string error)
        {
            Field.Errors.Add(error);
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
        public RulesLists<TValue>Between(long min, long max)
        {
            if (Values == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.BetweenArray(min, max));
                }

                return this;
            }

            if (this.Values.LongCount() < min || max < this.Values.LongCount())
            {
                this.AddError(_lang.BetweenArray(min, max));
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be a value equal to the given value.
        /// </summary>
        /// <param name="values">
        /// Value to confirmed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesLists<TValue> Confirmed(List<TValue> values)
        {
            if (Values == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.Confirmed());
                }

                return this;
            }

            if (!Enumerable.SequenceEqual(Values, values))
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
        /// <param name="values">
        /// Date of the field.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesLists<TValue>Different(String name, List<TValue> values)
        {
            if (Values == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.Different(name));
                }

                return this;
            }

            if (Enumerable.SequenceEqual(this.Values, values))
            {
                this.AddError(_lang.Different(name));
            }

            return this;
        }
        
        
        /// <summary>
        /// The field under validation must not have any duplicate values
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesLists<TValue>Distinct()
        {
            if (Values == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.Distinct());
                }

                return this;
            }

            bool duplicates = Values
                .GroupBy(v => JsonConvert.SerializeObject(v))
                .Any(g => g.Count() > 1);
            
            if (duplicates)
            {
                AddError(_lang.Distinct());
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be greater than the given field
        /// </summary>
        /// <param name="values">
        /// Value to compare
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesLists<TValue> GreaterThan(List<TValue> values)
        {
            if (Values == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.GreaterThanArray(values.LongCount()));
                }

                return this;
            }

            if (this.Values.Count <= values.Count)
            {
                this.AddError(_lang.GreaterThanArray(values.LongCount()));
            }

            return this;
        }
        
        /// <summary>
        /// The field under validation must be greater than or equal to the given field.
        /// </summary>
        /// <param name="values">
        /// Value to compare
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesLists<TValue> GreaterThanOrEqual(List<TValue> values)
        {
            if (Values == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.GreaterThanOrEqualArray(values.LongCount()));
                }

                return this;
            }

            if (this.Values.Count < values.Count)
            {
                this.AddError(_lang.GreaterThanOrEqualArray(values.LongCount()));
            }

            return this;
        }
        
        
        /// <summary>
        /// The field under validation must be less than the given field
        /// </summary>
        /// <param name="values">
        /// Value to comapre
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesLists<TValue> LessThan(List<TValue> values)
        {
            if (Values == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.LessThanArray(values.LongCount()));
                }

                return this;
            }

            if (this.Values.Count >= values.Count)
            {
                this.AddError(_lang.LessThanArray(values.LongCount()));
            }

            return this;
        }
        
        
        /// <summary>
        /// The field under validation must be less than or equal to the given field
        /// </summary>
        /// <param name="values">
        /// Value to comapre
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesLists<TValue> LessThanOrEqual(List<TValue> values)
        {
            if (Values == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.LessThanOrEqualArray(values.LongCount()));
                }

                return this;
            }

            if (this.Values.Count > values.Count)
            {
                this.AddError(_lang.LessThanOrEqualArray(values.LongCount()));
            }

            return this;
        }

        /// <summary>
        /// The field under validation must be less than or equal to a maximum value
        /// </summary>
        /// <param name="max">
        /// Max lentgh allowed.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesLists<TValue> Max(long max)
        {
            if (Values == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.MaxArray(max));
                }

                return this;
            }

            if (this.Values.LongCount() > max)
            {
                this.AddError(_lang.MaxArray(max));
            }

            return this;
        }
        
        
        /// <summary>
        /// The field under validation must have a minimum value
        /// </summary>
        /// <param name="min">
        ///  Min length allowed.
        /// </param>
        /// <returns></returns>
        public RulesLists<TValue> Min(long min)
        {
            if (Values == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.MinArray(min));
                }

                return this;
            }

            if (this.Values.LongCount() < min)
            {
                this.AddError(_lang.MinArray(min));
            }

            return this;
        }

        /// <summary>
        /// The field under validation may be null.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesLists<TValue>Nullable()
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
        public RulesLists<TValue>Required()
        {
            this.Null = false;

            if (this.Values == null)
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
        /// <param name="values">
        /// Value of the field.
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesLists<TValue> Same(String name, List<TValue> values)
        {
            if (Values == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.Same(name));
                }

                return this;
            }

            if (!Enumerable.SequenceEqual(this.Values, values))
            {
                this.AddError(_lang.Same(name));
            }

            return this;
        }
        
        
        /// <summary>
        /// The field under validation must have a size matching the given value
        /// </summary>
        /// <param name="size">
        /// Length allowed
        /// </param>
        /// <returns></returns>
        public RulesLists<TValue> Size(long size)
        {
            if (Values == null)
            {
                if (!this.Null)
                {
                    this.AddError(_lang.SizeArray(size));
                }

                return this;
            }

            if (this.Values.LongCount() != size)
            {
                this.AddError(_lang.SizeArray(size));
            }

            return this;
        }
    }
}