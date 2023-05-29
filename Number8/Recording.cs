using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number8
{
    internal class Recording
    {
        public int IdRecording { get; set; }
        public string Service { get; set; }
        public string Client { get; set; }
        public DateTime StartRecording { get; set; }
        public DateTime EndRecording { get; set; }
    }
}
