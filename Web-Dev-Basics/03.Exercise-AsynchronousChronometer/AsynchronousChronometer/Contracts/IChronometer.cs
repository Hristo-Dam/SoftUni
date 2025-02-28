namespace AsynchronousChronometer.Contracts
{
    public interface IChronometer
    {
        /// <summary>
        /// Should return the currently recorded time since the start of the chronometer counter
        /// </summary>
        string GetTime { get; }

        /// <summary>
        /// Returns a collection of recorded times as laps for the current chronometer run
        /// </summary>
        List<string> Laps { get; }

        /// <summary>
        /// Starts the stopwatch counter
        /// </summary>
        Task Start();

        /// <summary>
        /// Stops the stopwatch counter
        /// </summary>
        void Stop();

        /// <summary>
        /// Records the the current elapsed time as a string by adding it to a collection of laps
        /// </summary>
        /// <returns>The current elapsed time</returns>
        string Lap();

        /// <summary>
        /// Resets the stopwatch counter and clears all lap records
        /// </summary>
        void Reset();
    }
}
// ®2025 Martin Yanev @ SoftUni BUDITEL