using System.Diagnostics;

namespace Problems
{
    public abstract class Problem
    {
        private Stopwatch TimeTaken { get; set; }
        
        protected long StopTimer()
        {
            // TODO: Find a way to run this automatically?
            
            TimeTaken.Stop();
            
            return TimeTaken.ElapsedMilliseconds;
        }
        
        protected void StartTimer()
        {
            TimeTaken = new Stopwatch();
            
            TimeTaken.Start();
        }
    }
}