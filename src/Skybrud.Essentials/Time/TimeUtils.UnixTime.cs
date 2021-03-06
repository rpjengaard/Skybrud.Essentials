﻿using System;

namespace Skybrud.Essentials.Time {

    public static partial class TimeUtils {

        #region Common

        /// <summary>
        /// Returns the current Unix timestamp which is defined as the amount of seconds since the start of the Unix
        /// epoch - that is <code>1st of January, 1970 - 00:00:00 GMT</code>.
        /// </summary>
        /// <returns>Returns an instance of <see cref="System.Int32"/> representing the current Unix timestamp.</returns>
        public static int GetCurrentUnixTimestamp() {
            return (int) Math.Floor(GetCurrentUnixTimestampAsDouble());
        }
        
        /// <summary>
        /// Returns the current Unix timestamp which is defined as the amount of seconds since the start of the Unix
        /// epoch - that is <code>1st of January, 1970 - 00:00:00 GMT</code>.
        /// </summary>
        /// <returns>Returns an instance of <see cref="System.Double"/> representing the current Unix timestamp.</returns>
        public static double GetCurrentUnixTimestampAsDouble() {
            return (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        }

        #endregion

        #region Unix time -> DateTime

        /// <summary>
        /// Returns an instance of <see cref="DateTime"/> based on the amount of seconds since the start of the Unix
        /// epoch - that is <code>1st of January, 1970 - 00:00:00 GMT</code>.
        /// </summary>
        /// <param name="timestamp">The Unix timestamp specified in seconds.</param>
        /// <returns>Returns the timestamp as an instance of <see cref="DateTime"/>.</returns>
        public static DateTime GetDateTimeFromUnixTime(int timestamp) {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp);
        }

        /// <summary>
        /// Returns an instance of <see cref="DateTime"/> based on the amount of seconds since the start of the Unix
        /// epoch - that is <code>1st of January, 1970 - 00:00:00 GMT</code>.
        /// </summary>
        /// <param name="timestamp">The Unix timestamp specified in seconds.</param>
        /// <returns>Returns the timestamp as an instance of <see cref="DateTime"/>.</returns>
        public static DateTime GetDateTimeFromUnixTime(long timestamp) {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp);
        }

        /// <summary>
        /// Returns an instance of <see cref="DateTime"/> based on the amount of seconds since the start of the Unix
        /// epoch - that is <code>1st of January, 1970 - 00:00:00 GMT</code>.
        /// </summary>
        /// <param name="timestamp">The Unix timestamp specified in seconds.</param>
        /// <returns>Returns the timestamp as an instance of <see cref="DateTime"/>.</returns>
        public static DateTime GetDateTimeFromUnixTime(double timestamp) {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(timestamp);
        }

        /// <summary>
        /// Returns an instance of <see cref="DateTime"/> based on the amount of seconds since the start of the Unix
        /// epoch - that is <code>1st of January, 1970 - 00:00:00 GMT</code>.
        /// </summary>
        /// <param name="timestamp">The Unix timestamp specified in seconds.</param>
        /// <returns>Returns the timestamp as an instance of <see cref="DateTime"/>.</returns>
        public static DateTime GetDateTimeFromUnixTime(string timestamp) {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddSeconds(Int64.Parse(timestamp));
        }

        #endregion
        
        #region Unix time -> DateTimeOffset

        /// <summary>
        /// Returns an instance of <see cref="DateTimeOffset"/> based on the amount of seconds since the start of the
        /// Unix epoch - that is <code>1st of January, 1970 - 00:00:00 GMT</code>.
        /// </summary>
        /// <param name="timestamp">The Unix timestamp specified in seconds.</param>
        /// <returns>Returns the timestamp as an instance of <see cref="DateTimeOffset"/>.</returns>
        public static DateTimeOffset GetDateTimeOffsetFromUnixTime(int timestamp) {
            return new DateTimeOffset(1970, 1, 1, 0, 0, 0, 0, TimeSpan.Zero).AddSeconds(timestamp);
        }

        /// <summary>
        /// Returns an instance of <see cref="DateTimeOffset"/> based on the amount of seconds since the start of the
        /// Unix epoch - that is <code>1st of January, 1970 - 00:00:00 GMT</code>.
        /// </summary>
        /// <param name="timestamp">The Unix timestamp specified in seconds.</param>
        /// <returns>Returns the timestamp as an instance of <see cref="DateTimeOffset"/>.</returns>
        public static DateTimeOffset GetDateTimeOffsetFromUnixTime(long timestamp) {
            return new DateTimeOffset(1970, 1, 1, 0, 0, 0, 0, TimeSpan.Zero).AddSeconds(timestamp);
        }

        /// <summary>
        /// Returns an instance of <see cref="DateTimeOffset"/> based on the amount of seconds since the start of the
        /// Unix epoch - that is <code>1st of January, 1970 - 00:00:00 GMT</code>.
        /// </summary>
        /// <param name="timestamp">The Unix timestamp specified in seconds.</param>
        /// <returns>Returns the timestamp as an instance of <see cref="DateTimeOffset"/>.</returns>
        public static DateTimeOffset GetDateTimeOffsetFromUnixTime(double timestamp) {
            return new DateTimeOffset(1970, 1, 1, 0, 0, 0, 0, TimeSpan.Zero).AddSeconds(timestamp);
        }

        /// <summary>
        /// Returns an instance of <see cref="DateTimeOffset"/> based on the amount of seconds since the start of the
        /// Unix epoch - that is <code>1st of January, 1970 - 00:00:00 GMT</code>.
        /// </summary>
        /// <param name="timestamp">The Unix timestamp specified in seconds.</param>
        /// <returns>Returns the timestamp as an instance of <see cref="DateTimeOffset"/>.</returns>
        public static DateTimeOffset GetDateTimeOffsetFromUnixTime(string timestamp) {
            return new DateTimeOffset(1970, 1, 1, 0, 0, 0, 0, TimeSpan.Zero).AddSeconds(Int64.Parse(timestamp));
        }

        #endregion

        #region DateTime -> Unix time

        /// <summary>
        /// Returns the Unix timestamp for the specified <code>date</code>. The Unix timestamp is defined as the amount
        /// of seconds since the start of the Unix epoch - that is <code>1st of January, 1970 - 00:00:00 GMT</code>.
        /// </summary>
        /// <param name="date">The isntance of <see cref="DateTime"/> the timestamp should be based on.</param>
        /// <returns>Returns an instance of <see cref="System.Int32"/> representing the Unix timestamp.</returns>
        public static int GetUnixTimeFromDateTime(DateTime date) {
            return (int) GetUnixTimeFromDateTimeAsDouble(date);
        }

        /// <summary>
        /// Returns the Unix timestamp for the specified <code>date</code>. The Unix timestamp is defined as the amount
        /// of seconds since the start of the Unix epoch - that is <code>1st of January, 1970 - 00:00:00 GMT</code>.
        /// </summary>
        /// <param name="date">The isntance of <see cref="DateTime"/> the timestamp should be based on.</param>
        /// <returns>Returns an instance of <see cref="System.Double"/> representing the Unix timestamp.</returns>
        public static double GetUnixTimeFromDateTimeAsDouble(DateTime date) {
            return (date.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc)).TotalSeconds;
        }

        #endregion

        #region DateTimeOffset -> Unix time

        /// <summary>
        /// Returns the Unix timestamp for the specified <code>date</code>. The Unix timestamp is defined as the amount
        /// of seconds since the start of the Unix epoch - that is <code>1st of January, 1970 - 00:00:00 GMT</code>.
        /// </summary>
        /// <param name="date">The isntance of <see cref="DateTimeOffset"/> the timestamp should be based on.</param>
        /// <returns>Returns an instance of <see cref="System.Int32"/> representing the Unix timestamp.</returns>
        public static int GetUnixTimeFromDateTimeOffset(DateTimeOffset date) {
            return (int) GetUnixTimeFromDateTimeOffsetAsDouble(date);
        }

        /// <summary>
        /// Returns the Unix timestamp for the specified <code>date</code>. The Unix timestamp is defined as the amount
        /// of seconds since the start of the Unix epoch - that is <code>1st of January, 1970 - 00:00:00 GMT</code>.
        /// </summary>
        /// <param name="date">The isntance of <see cref="DateTimeOffset"/> the timestamp should be based on.</param>
        /// <returns>Returns an instance of <see cref="System.Double"/> representing the Unix timestamp.</returns>
        public static double GetUnixTimeFromDateTimeOffsetAsDouble(DateTimeOffset date) {
            return (date.ToUniversalTime() - new DateTimeOffset(1970, 1, 1, 0, 0, 0, 0, TimeSpan.Zero)).TotalSeconds;
        }

        #endregion

    }

}