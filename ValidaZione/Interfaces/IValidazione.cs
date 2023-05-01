using System;
using System.Collections.Generic;
using ValidaZione.Exceptions;
using ValidaZione.Langs;
using ValidaZione.Objects;
using ValidaZione.Rules;

namespace ValidaZione.Interfaces
{
    public interface IValidazione
    {
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
        RulesBooleans Field(string name, bool value);
        
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
        RulesDates Field(string name, DateTime value);
        
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
        RulesDates Field(string name, DateTime? value);
        
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
        RulesLists<TValue> Field<TValue>(string name, List<TValue> values);
        
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
        RulesLists<TValue> Field<TValue>(string name, TValue[] values);
        
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
        RulesLists<TValue> Field<TValue>(string name, IEnumerable<TValue> values);
        
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
        RulesNumbers<TValue> Field<TValue>(string name, TValue value);
        
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
        RulesStrings Field(string name, string? value);
        
        /// <summary>
        /// Change the language for the error messages.
        /// </summary>
        /// <param name="lang">
        /// <see cref="ILang"/>, <see cref="Language"/>
        /// </param>
        void ChangeLang(ILang lang);
        
        /// <summary>
        /// Indicates if the fields pass the rules.
        /// </summary>
        /// <returns>
        /// <code>true</code> If all fields pass the rules. <code>false</code> If any field have errors.
        /// </returns>
        bool Pass();
        
        /// <summary>
        /// Check if all fields pass the validation rules.
        /// </summary>
        /// <exception cref="ValidazioneException">
        /// If any field have errors.
        /// </exception>
        void PassOrException();
        
        /// <summary>
        /// Get all fields with validation errors.
        /// </summary>
        /// <returns>
        /// A list of fields with errors.
        /// </returns>
        List<Field> ErrorsByField();
        
        /// <summary>
        /// Get a list of errors
        /// </summary>
        /// <returns>
        /// List of errors found in the validation.
        /// </returns>
        List<String> Errors();
    }
}