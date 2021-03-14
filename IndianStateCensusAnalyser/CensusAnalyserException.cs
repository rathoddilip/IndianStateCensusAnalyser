using System;
using System.Collections.Generic;
using System.Text;

namespace IndianStateCensusAnalyser
{
    public class CensusAnalyserException : Exception
    {
        public ExceptionType type;
        public enum ExceptionType
        {
            FILE_NOT_EXISTS, IMPROPER_EXTENSION, DELIMITER_NOT_FOUND,
            INCORRECT_HEADER
        }
        public CensusAnalyserException()
        {

        }
        /// <summary>
        /// Initializes a new instance of the <see cref="MoodAnalysisException"/> class.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="name">The name.</param>
        public CensusAnalyserException(ExceptionType type, string name) : base(name)
        {
            this.type = type;
        }
    }
}
