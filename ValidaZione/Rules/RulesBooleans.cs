using System;
using System.Collections.Generic;
using ValidaZione.Interfaces;
using ValidaZione.Objects;

namespace ValidaZione.Types
{
    public class RulesBooleans: IRule
    {
        private ILang _lang;
        public Field Field { get; private set; }
        private string FieldName { get; set; }
        private bool Value { get; set; }
        public RulesBooleans(ILang lang, string fieldName, bool value)
        {
            _lang = lang;
            _lang.FieldName = fieldName;
            FieldName = fieldName;
            Value = value;
            Field = new Field(fieldName);
        }
        
        private void AddError(string error)
        {
            Field.Errors.Add(error);
        }

        
        /// <summary>
        /// The field under validation must be true.
        /// This is useful for validating "Terms of Service" acceptance or similar fields.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesBooleans Accepted()
        {
            if (!this.Value)
            {
                this.AddError(_lang.Accepted());
            }

            return this;
        }

   
        /// <summary>
        /// The field under validation must be false.
        /// </summary>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesBooleans Declined()
        {
            if (this.Value)
            {
                this.AddError(_lang.Declined());
            }

            return this;
        }
    }
}