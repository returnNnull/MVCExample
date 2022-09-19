using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MVCExample
{
    internal class Logic
    {
        public delegate void  SumResult(int sum);
        public event SumResult listener;

        public async void Sum(int a, int b) {
            await Task.Run(() => HardWork());
            if (listener != null) {
                listener.Invoke(a + b);
            }
        }

        private void HardWork() {
            Task.Delay(2000).Wait();
        }
            
    }
}
