using System;
using System.Collections.Generic;
using ValidaZione.Objects;

namespace ValidaZione.Exceptions
{
    public class ValidazioneException : Exception
    {
        public List<Field> Fields { get; }
        
        public List<String> Errors { get; }
        public ValidazioneException(List<Field> fields) : base(fields[0].Errors[0])   
        {
            Fields = fields;
            Errors = new List<string>();
            foreach (var field in fields)
            {
                Errors.AddRange(field.Errors);
            }

        }
    }
}