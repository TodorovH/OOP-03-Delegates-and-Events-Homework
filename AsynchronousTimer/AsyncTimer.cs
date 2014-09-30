using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsynchronousTimer
{
    class AsyncTimer
    {
        private Action<string> methodToBeCalled;
        private int interval;
        private int ticks;

        public AsyncTimer(Action<string> methodToBeCalled, int ticks, int interval)
        {
            this.Interval = interval;
            this.Ticks = ticks;
            this.methodToBeCalled = methodToBeCalled;
        }

        public int Interval 
        {
            get 
            { 
                return this.interval; 
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The interval cannot be negative.");
                }
                this.interval = value;
            }
        }

        public int Ticks
        {
            get
            {
                return this.ticks;
            } 
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("The argument cannot be negative.");
                }
                this.ticks = value;
            }
        }

        private void Countdown()
        {
            while (this.Ticks > 0)
            {
                Thread.Sleep(this.Interval);

                if (methodToBeCalled != null)
                {
                    methodToBeCalled(this.Ticks + " ");
                }

                this.ticks--;
            }
        }

        public void Start()
        {
            Thread thread = new Thread(this.Countdown);
            thread.Start();
        }
    }
}
