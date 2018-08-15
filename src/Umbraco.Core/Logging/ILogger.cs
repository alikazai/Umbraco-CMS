﻿using System;

namespace Umbraco.Core.Logging
{
    /// <summary>
    /// Defines the logging service.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs an error message.
        /// </summary>
        /// <param name="reporting">The reporting type.</param>
        /// <param name="message">A message.</param>
        /// <param name="exception">An exception.</param>
        void Error(Type reporting, string message, Exception exception = null);

        /// <summary>
        /// Logs an error message - using a structured log message
        /// </summary>
        /// <param name="reporting">The reporting type.</param>
        /// <param name="messageTemplate">The message template that includes property values</param>
        /// <param name="exception">An exception.</param>
        /// <param name="propertyValues">Property values to log & update in message template</param>
        void Error(Type reporting, string messageTemplate, Exception exception = null, params object[] propertyValues);
        
        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <param name="reporting">The reporting type.</param>
        /// <param name="message">A message.</param>
        void Warn(Type reporting, string message);

        /// <summary>
        /// Logs a warning message - using a structured log message
        /// </summary>
        /// <param name="reporting">The reporting type.</param>
        /// <param name="messageTemplate">The message template that includes property values</param>
        /// <param name="propertyValues">Property values to log & update in message template</param>
        void Warn(Type reporting, string messageTemplate, params object[] propertyValues);

        /// <summary>
        /// Logs a warning message with an exception.
        /// </summary>
        /// <param name="reporting">The reporting type.</param>
        /// <param name="exception">An exception.</param>
        /// <param name="message">A message.</param>
        void Warn(Type reporting, Exception exception, string message);

        /// <summary>
        /// Logs a warning message with an exception - using a structured log message
        /// </summary>
        /// <param name="reporting">The reporting type.</param>
        /// <param name="exception">An exception.</param>
        /// <param name="messageTemplate">The message template that includes property values</param>
        /// <param name="propertyValues">Property values to log & update in message template</param>
        void Warn(Type reporting, Exception exception, string messageTemplate, params object[] propertyValues);

        /// <summary>
        /// Logs an information message.
        /// </summary>
        /// <param name="reporting">The reporting type.</param>
        /// <param name="message">A message.</param>
        void Info(Type reporting, string message);

        /// <summary>
        /// Logs a info message - using a structured log message
        /// </summary>
        /// <param name="reporting">The reporting type.</param>
        /// <param name="messageTemplate">The message template that includes property values</param>
        /// <param name="propertyValues">Property values to log & update in message template</param>
        void Info(Type reporting, string messageTemplate, params object[] propertyValues);

        /// <summary>
        /// Logs a debugging message.
        /// </summary>
        /// <param name="reporting">The reporting type.</param>
        /// <param name="message">A message.</param>
        void Debug(Type reporting, string message);
        
        /// <summary>
        /// Logs a debug message - using a structured log message
        /// </summary>
        /// <param name="reporting">The reporting type.</param>
        /// <param name="messageTemplate">The message template that includes property values</param>
        /// <param name="propertyValues">Property values to log & update in message template</param>
        void Debug(Type reporting, string messageTemplate, params object[] propertyValues);
    }
}
