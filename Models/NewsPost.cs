using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsAggregator.Models
{
    public class NewsPost
    {
        public int id { get; set; }
        public string title { get; set; }
        public string category { get; set; }
        public string photo { get; set; }
        public string url { get; set; }
        public string time { get; set; }
    }
}
