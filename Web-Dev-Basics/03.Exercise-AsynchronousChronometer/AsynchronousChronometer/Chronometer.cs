namespace AsynchronousChronometer
{
    using AsynchronousChronometer.Contracts;
    using System.Diagnostics;
    using System.Text;

    public class Chronometer : IChronometer
    {
        private Stopwatch _stopwatch;
        private List<string> _laps;

        public Chronometer()
        {
            _stopwatch = new Stopwatch();
            _laps = new List<string>();
        }

        // TODO: Implement IChronometer interface...

        // HINT for GetTime property:
        // Use the Elapsed property of the Stopwatch class to get the total elapsed time.
        // This property returns the time as a TimeSpan, so you should convert it to string in the correct format
        // You can format the string as expected in the exercise using this: @"mm\:ss\.ffff"
        public string GetTime => _stopwatch.Elapsed.ToString(@"mm\:ss\.ffff");

        public List<string> Laps
        {
            get { return _laps; }
            set { _laps = value; }
        }

        public string Lap()
        {
            string result = _stopwatch.Elapsed.ToString(@"mm\:ss\.ffff");
            Laps.Add(result);
            return result;
        }

        public void Reset()
        {
            _stopwatch.Reset();
        }

        public async Task Start()
        {
            await Task.Run(() => _stopwatch.Start());
        }

        public void Stop()
        {
            _stopwatch.Stop();
        }
    }
}
// ®2025 Martin Yanev @ SoftUni BUDITEL