using System;
using System.Collections.Generic;
using System.Text;

namespace HomeMonitoring
{
    abstract class Area
    {
        public int SqFootage { get; set; }

        public int NumberOfWindow { get; set; }

        public int NumberOfVents { get; set; }
    }
}
