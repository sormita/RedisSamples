using System;
using System.Collections.Generic;
using System.Text;

namespace RedisConnector
{
    [Serializable]
    public class SampleObject
    {
        public string Country { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
