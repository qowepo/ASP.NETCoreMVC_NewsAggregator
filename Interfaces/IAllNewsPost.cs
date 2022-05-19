using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsAggregator.Models;

namespace NewsAggregator.Interfaces
{
    public interface IAllNewsPost
    {
        IEnumerable<NewsPost> Post(string a);
        NewsPost getObjectCar(int postId);
    }
}
