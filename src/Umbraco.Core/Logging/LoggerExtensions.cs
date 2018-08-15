﻿using System;

namespace Umbraco.Core.Logging
{
    /// <summary>
    /// Provides extension methods for the <see cref="ILogger"/> interface.
    /// </summary>
    public static class LoggerExtensions
    {
        /// <summary>
        /// Logs an error message.
        /// </summary>
        /// <typeparam name="T">The reporting type.</typeparam>
        /// <param name="logger">The logger.</param>
        /// <param name="message">A message.</param>
        /// <param name="exception">An exception.</param>
        //[Obsolete("Use the Error<T> with message template", true)]
        public static void Error<T>(this ILogger logger, string message, Exception exception = null)
        {
            logger.Error(typeof(T), message, exception);
        }

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <typeparam name="T">The reporting type</typeparam>
        /// <param name="logger">The logger.</param>
        /// <param name="messageTemplate">A structured message template</param>
        /// <param name="exception">An exception</param>
        /// <param name="propertyValues">Message property values</param>
        public static void Error<T>(this ILogger logger, string messageTemplate, Exception exception = null, params object[] propertyValues)
        {
            logger.Error(typeof(T), messageTemplate, exception, propertyValues);
        }

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <typeparam name="T">The reporting type.</typeparam>
        /// <param name="logger">The logger.</param>
        /// <param name="message">A message.</param>
        public static void Warn<T>(this ILogger logger, string message)
        {
            logger.Warn(typeof(T), message);
        }

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <typeparam name="T">The reporting type</typeparam>
        /// <param name="logger">The logger.</param>
        /// <param name="messageTemplate">A structured message template</param>
        /// <param name="propertyValues">Message property values</param>
        public static void Warn<T>(this ILogger logger, string messageTemplate, params object[] propertyValues)
        {
            logger.Warn(typeof(T), messageTemplate, propertyValues);
        }

        /// <summary>
        /// Logs a formatted warning message with an exception.
        /// </summary>
        /// <typeparam name="T">The reporting type.</typeparam>
        /// <param name="logger">The logger.</param>
        /// <param name="exception">An exception.</param>
        /// <param name="message">A message.</param>
        public static void Warn<T>(this ILogger logger, Exception exception, string message)
        {
            logger.Warn(typeof(T), exception, message);
        }

        /// <summary>
        /// Logs a warning message.
        /// </summary>
        /// <typeparam name="T">The reporting type</typeparam>
        /// <param name="logger">The logger.</param>
        /// <param name="exception">An exception</param>
        /// <param name="messageTemplate">A structured message template</param>
        /// <param name="propertyValues">Message property values</param>
        public static void Warn<T>(this ILogger logger, Exception exception, string messageTemplate, params object[] propertyValues)
        {
            logger.Warn(typeof(T), exception, messageTemplate, propertyValues);
        }

        /// <summary>
        /// Logs an information message.
        /// </summary>
        /// <typeparam name="T">The reporting type.</typeparam>
        /// <param name="logger">The logger.</param>
        /// <param name="message">A message.</param>
        public static void Info<T>(this ILogger logger, string message)
        {
            logger.Info(typeof(T), message);
        }

        /// <summary>
        /// Logs a information message.
        /// </summary>
        /// <typeparam name="T">The reporting type</typeparam>
        /// <param name="logger">The logger.</param>
        /// <param name="messageTemplate">A structured message template</param>
        /// <param name="propertyValues">Message property values</param>
        public static void Info<T>(this ILogger logger, string messageTemplate, params object[] propertyValues)
        {
            logger.Info(typeof(T), messageTemplate, propertyValues);
        }

        /// <summary>
        /// Logs a debugging message.
        /// </summary>
        /// <typeparam name="T">The reporting type.</typeparam>
        /// <param name="logger">The logger.</param>
        /// <param name="message">A message.</param>
        public static void Debug<T>(this ILogger logger, string message)
        {
            logger.Debug(typeof(T), message);
        }

        /// <summary>
        /// Logs a debugging message.
        /// </summary>
        /// <typeparam name="T">The reporting type</typeparam>
        /// <param name="logger">The logger.</param>
        /// <param name="messageTemplate">A structured message template</param>
        /// <param name="propertyValues">Message property values</param>
        public static void Debug<T>(this ILogger logger, string messageTemplate, params object[] propertyValues)
        {
            logger.Debug(typeof(T), messageTemplate, propertyValues);
        }
        
    }
}
