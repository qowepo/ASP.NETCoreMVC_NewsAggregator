using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using NewsAggregator.Models;

namespace NewsAggregator.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            //////
            var rows = from o in content.Sport
                       select o;
            foreach (var row in rows)
            {
                content.Sport.Remove(row);
            }
            content.SaveChanges();

            var rows1 = from o in content.Business
                       select o;
            foreach (var row in rows)
            {
                content.Business.Remove(row);
            }
            content.SaveChanges();

            var rows2 = from o in content.Russia
                       select o;
            foreach (var row in rows)
            {
                content.Russia.Remove(row);
            }
            content.SaveChanges();

            var rows3 = from o in content.General
                       select o;
            foreach (var row in rows)
            {
                content.General.Remove(row);
            }
            content.SaveChanges();

            //////
            content.AddRange(Post("sport"));
            

            
                content.AddRange(Post("russia"));
            

            
                content.AddRange(Post("business"));
            

            
                content.AddRange(Post(""));
            
            content.SaveChanges();
        }

        
      


        private static IEnumerable<NewsPost> Post(string category)
        {
            string m_strFilePath = "https://www.rt.com/rss/" + category;
            XDocument booksFromFile = XDocument.Load(m_strFilePath);
            var list = booksFromFile.Element("rss").Element("channel").Elements("item").ToList();

            List<NewsPost> newsPostsList = new List<NewsPost>();
            
            foreach (var el in list)
            {
                string _title = el.Element("title").Value;
                string _photo = el.Element("enclosure").Attribute("url").Value;
                string _time = Convert.ToDateTime(el.Element("pubDate").Value).ToString();
                string _url = el.Element("guid").Value;

                NewsPost np = new NewsPost();
                np.category = category;
                np.photo = _photo;
                np.title = _title;
                np.url = _url;

                //DateTime d = DateTime.Now;
                np.time = _time;

                newsPostsList.Add(np);
               
            }
            return newsPostsList;
        }
    }
}
