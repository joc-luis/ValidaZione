using ValidaZione.Interfaces;
using ValidaZione.Objects;

namespace ValidaZione.Rules
{
    /// <summary>
    /// Rules for booleans
    /// </summary>
    public class RulesBooleans: IRule
    {
        private ILang _lang;
        private Field Field { get; set; }
        private string FieldName { get; set; }
        private bool Value { get; set; }
        
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