using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace MVCExample
{
    internal class MainWindowController
    {
        private Logic logic;

        public MainWindowController(Logic logic)
        {
            this.logic = logic;
        }

        internal void Sum(int a, int b)
        {
            logic.Sum(a, b);
        }
    }
}
