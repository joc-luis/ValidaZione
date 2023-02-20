using System;
using System.Collections.Generic;
using ValidaZione.Objects;
using ValidaZione.Rules;
using ValidaZione.Types;

namespace ValidaZione.Interfaces
{
    public interface IValidazione
    {
        RulesBooleans Field(string name, bool value);
        RulesDates Field(string name, DateTime value);
        RulesLists<TValue> Field<TValue>(string name, List<TValue> values);
        RulesLists<TValue> Field<TValue>(string name, TValue[] values);
        RulesNumbers<TValue> Field<TValue>(string name, TValue value);
        RulesStrings Field(string name, string value);
        void ChangeLang(ILang lang);
        bool Pass();
        void PassOrException();
        List<Field> ErrorsByField();
        List<String> Errors();
    }
}