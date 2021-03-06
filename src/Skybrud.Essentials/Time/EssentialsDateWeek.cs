﻿namespace Skybrud.Essentials.Time {

    /// <summary>
    /// Class representing a week as defined by the ISO 8601 specification.
    /// </summary>
    public class EssentialsDateWeek {

        #region Properties

        /// <summary>
        /// Gets the year of the week.
        /// </summary>
        public int Year { get; private set; }

        /// <summary>
        /// Gets the number of the week.
        /// </summary>
        public int Week { get; private set; }

        /// <summary>
        /// Gets a reference to the timestamp representing the start of the week.
        /// </summary>
        public EssentialsDateTime Start { get; private set; }

        /// <summary>
        /// Gets a reference to the timestamp representing the end of the week.
        /// </summary>
        public EssentialsDateTime End { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Initialize a new instance based on the specified <code>timestamp</code>.
        /// </summary>
        /// <param name="timestamp">A timestamp.</param>
        public EssentialsDateWeek(EssentialsDateTime timestamp) {

            Week = TimeUtils.GetIso8601WeekNumber(timestamp.DateTime);
            Start = TimeUtils.GetFirstDayOfWeek(timestamp.DateTime);
            End = TimeUtils.GetLastDayOfWeek(timestamp.DateTime);

            if (End.Month == 1 && Week == 1) {
                Year = End.Year;
            } else if (Start.Month == 12 && Week >= 50) {
                Year = Start.Year;
            } else {
                Year = timestamp.Year;
            }

        }

        #endregion

    }

}