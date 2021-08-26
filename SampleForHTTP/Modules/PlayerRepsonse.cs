using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForHTTP.Modules
{
    class PlayerRepsonse
    {
        public IEnumerable<Player> Data { get; set; }
        public int Count { get; set; }
        public int Page { get; set; }
        public int Size { get; set; }
    }
}
