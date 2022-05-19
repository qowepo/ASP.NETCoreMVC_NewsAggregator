using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsAggregator.Interfaces;
using NewsAggregator.Models;

namespace NewsAggregator.Data.Repository
{
    public class NewsPostRepository : IAllNewsPost
    {
        private readonly AppDBContent appDBContent;

        public NewsPostRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public NewsPost getObjectCar(int postId) => appDBContent.General.FirstOrDefault(p => p.id == postId);

        public IEnumerable<NewsPost> Post(string a)
        {
            switch (a)
            {
                case "sport":
                    return appDBContent.Sport.Where(aq=>aq.category == a);
                case "business":
                    return appDBContent.Business.Where(aq => aq.category == a);
                case "russia":
                    return appDBContent.Russia.Where(aq => aq.category == a);
                case "":
                    return appDBContent.General.Where(aq => aq.category == "");
            }
            return appDBContent.General.Where(aq => aq.category == ""); ;
        }
        
    }
}
