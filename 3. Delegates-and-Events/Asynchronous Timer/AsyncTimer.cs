using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous_Timer
{
    class AsyncTimer
    {
        private Action<string> method;
        private int interval;
        private int ticks;

        public int Interval
        {
            get { return this.interval; }
            set { this.interval = value; }
        }

        public int Ticks
        {
            get { return this.ticks; }
            set { this.ticks = value; }
        }

        public Action<string> Method
        {
            get { return this.method; }
            set { this.method = value; }
        }

        public AsyncTimer(Action<string> method, int interval, int ticks)
        {
            this.Method = method;
            this.Interval = interval;
            this.Ticks = ticks;
        }
        private void DoWork()
        {
            while (this.Ticks > 0)
            {
                Thread.Sleep(this.Interval);

                if (method != null)
                {
                    method(this.ticks + "");
                }

                this.ticks--;
            }
        }

        public void Start()
        {
            Thread thread = new Thread(this.DoWork);
            thread.Start();
        }
    }
}
