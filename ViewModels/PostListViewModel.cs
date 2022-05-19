using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsAggregator.Models;


namespace NewsAggregator.ViewModels
{
    public class PostsListViewModel
    {
        public IEnumerable<NewsPost> allNewsPost { get; set; }

        public string currCategory { get; set; }
    }
}
