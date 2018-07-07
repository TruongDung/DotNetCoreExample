using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DotnetCoreHelloWorldTutorial
{
    public sealed class ClockTower
    {
        private readonly Stopwatch _stopWatch = new Stopwatch();
        private readonly int _delayMilliseconds;

        public ClockTower(int delayMilliseconds)
        {
            _stopWatch.Start();
            _delayMilliseconds = delayMilliseconds;
            DelayedChime();
        }

        public delegate void ChimeEventHandler(object sender, ChimeEventArgs e);
        public event ChimeEventHandler OnChime;
        public async void DelayedChime()
        {
            //await Task.Delay(_delayMilliseconds);
            //ChimeEventArgs e = new ChimeEventArgs(_stopWatch.ElapsedMilliseconds);
            OnChime += new ChimeEventHandler(HeardIt);
            //HeardIt(this, e);

            //await Task.Delay(_delayMilliseconds);
            //HeardIt(this, e);

            await Task.Delay(_delayMilliseconds);
            OnChime(this, new ChimeEventArgs(_stopWatch.ElapsedMilliseconds));

            await Task.Delay(_delayMilliseconds);
            OnChime(this, new ChimeEventArgs(_stopWatch.ElapsedMilliseconds));

        }
        private void HeardIt(object sender, ChimeEventArgs e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public class ChimeEventArgs
    {
        public ChimeEventArgs(long milliseconds)
        {
            Message = String.Format("The clock chimed after {0} seconds", milliseconds / 1000M);
        }

        public string Message { get; set; }
    }
}
