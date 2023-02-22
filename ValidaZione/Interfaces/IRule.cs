using System.Collections.Generic;
using ValidaZione.Objects;

namespace ValidaZione.Interfaces
{
    
    /// <summary>
    /// Interface for rules.
    /// </summary>
    public interface IRule
    {

        /// <summary>
        /// Get errors of the validation
        /// </summary>
        /// <returns>
        /// Field and errors. <see cref="Field"/>
        /// </returns>
        public Field ErrorsByField();

    }
}