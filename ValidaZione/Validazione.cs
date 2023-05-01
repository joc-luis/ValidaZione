using System;
using System.Collections.Generic;
using System.Linq;
using ValidaZione.Exceptions;
using ValidaZione.Interfaces;
using ValidaZione.Langs;
using ValidaZione.Objects;
using ValidaZione.Rules;

namespace ValidaZione
{
    public class Validazione : IValidazione
    {
        private List<IRule> Rules = new List<IRule>();

        private ILang Lang;

        /// <summary>
        /// Initialize a new instance of <see cref="Validazione"/>.
        /// </summary>
        /// <param name="lang">
        /// Language for error messages.
        /// </param>
        public Validazione(ILang lang)
        {
            Lang = lang;
        }

        /// <summary>
        /// Rules for boolean fields
        /// </summary>
        /// <param name="name">
        /// Name of the field.
        /// </param>
        /// <param name="value">
        /// Value of the field
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesBooleans Field(string name, bool value)
        {
            RulesBooleans rules = new RulesBooleans(Lang, name, value);
            Rules.Add(rules);

            return rules;
        }

        /// <summary>
        /// Rules for DateTime fields
        /// </summary>
        /// <param name="name">
        /// Name of the field.
        /// </param>
        /// <param name="value">
        /// Value of the field
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesDates Field(string name, DateTime value)
        {
            RulesDates rules = new RulesDates(Lang, name, value);
            Rules.Add(rules);

            return rules;
        }

        /// <summary>
        /// Rules for DateTime? fields
        /// </summary>
        /// <param name="name">
        /// Name of the field.
        /// </param>
        /// <param name="value">
        /// Value of the field
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesDates Field(string name, DateTime? value)
        {
            RulesDates rules = new RulesDates(Lang, name, value);
            Rules.Add(rules);

            return rules;
        }


        /// <summary>
        /// Rules for List fields.
        /// </summary>
        /// <param name="name">
        /// Name of the field.
        /// </param>
        /// <param name="values">
        /// Value of the field
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesLists<TValue> Field<TValue>(string name, List<TValue> values)
        {
            RulesLists<TValue> rules = new RulesLists<TValue>(Lang, name, values);
            Rules.Add(rules);

            return rules;
        }

        /// <summary>
        /// Rules for Array fields.
        /// </summary>
        /// <param name="name">
        /// Name of the field.
        /// </param>
        /// <param name="values">
        /// Value of the field
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesLists<TValue> Field<TValue>(string name, TValue[] values)
        {
            RulesLists<TValue> rules = new RulesLists<TValue>(Lang, name, values);
            Rules.Add(rules);

            return rules;
        }

        /// <summary>
        /// Rules for IEnumerable fields.
        /// </summary>
        /// <param name="name">
        /// Name of the field.
        /// </param>
        /// <param name="values">
        /// Value of the field
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesLists<TValue> Field<TValue>(string name, IEnumerable<TValue> values)
        {
            RulesLists<TValue> rules = new RulesLists<TValue>(Lang, name, values);
            Rules.Add(rules);

            return rules;
        }

        /// <summary>
        /// Rules for number fields.
        /// <see cref="UInt16"/> <see cref="UInt32"/>
        /// <see cref="UInt64"/> <see cref="Int16"/>
        /// <see cref="Int32"/> <see cref="Int64"/>
        /// <see cref="Single"/> <see cref="Double"/>
        /// <see cref="Decimal"/>
        /// </summary>
        /// <param name="name">
        /// Name of the field.
        /// </param>
        /// <param name="value">
        /// Value of the field
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesNumbers<TValue> Field<TValue>(string name, TValue value)
        {
            RulesNumbers<TValue> rules = new RulesNumbers<TValue>(Lang, name, value);
            Rules.Add(rules);

            return rules;
        }

        
        /// <summary>
        /// Rules for String fields.
        /// </summary>
        /// <param name="name">
        /// Name of the field.
        /// </param>
        /// <param name="value">
        /// Value of the field
        /// </param>
        /// <returns>
        /// This instance of the object.
        /// </returns>
        public RulesStrings Field(string name, string? value)
        {
            RulesStrings rules = new RulesStrings(Lang, name, value);
            Rules.Add(rules);

            return rules;
        }


        /// <summary>
        /// Change the language for the error messages.
        /// </summary>
        /// <param name="lang">
        /// <see cref="ILang"/>, <see cref="Language"/>
        /// </param>
        public void ChangeLang(ILang lang)
        {
            Lang = lang;
        }


        /// <summary>
        /// Indicates if the fields pass the rules.
        /// </summary>
        /// <returns>
        /// <code>true</code> If all fields pass the rules. <code>false</code> If any field have errors.
        /// </returns>
        public bool Pass()
        {
            return !ErrorsByField().Any();
        }

        /// <summary>
        /// Check if all fields pass the validation rules.
        /// </summary>
        /// <exception cref="ValidazioneException">
        /// If any field have errors.
        /// </exception>
        public void PassOrException()
        {
            if (!Pass())
            {
                throw new ValidazioneException(ErrorsByField());
            }
        }

        /// <summary>
        /// Get all fields with validation errors.
        /// </summary>
        /// <returns>
        /// A list of fields with errors.
        /// </returns>
        public List<Field> ErrorsByField()
        {
            List<Field> fields = new List<Field>();
            foreach (IRule rule in Rules)
            {
                if (rule.ErrorsByField().Errors.Any())
                {
                    fields.Add(rule.ErrorsByField());
                }
            }

            return fields;
        }

        /// <summary>
        /// Get a list of errors
        /// </summary>
        /// <returns>
        /// List of errors found in the validation.
        /// </returns>
        public List<string> Errors()
        {
            List<String> errors = new List<string>();
            List<Field> fields = ErrorsByField();

            foreach (var field in fields)
            {
                field.Errors.ForEach(e => { errors.Add(e); });
            }

            return errors;
        }
    }
}