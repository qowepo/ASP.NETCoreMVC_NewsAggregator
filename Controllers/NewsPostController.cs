using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsAggregator.Interfaces;
using NewsAggregator.Models;
using NewsAggregator.ViewModels;


namespace NewsAggregator.Controllers
{
    public class NewsPostController:Controller
    {
        private readonly IAllNewsPost _allNewsPost;
       
        public NewsPostController(IAllNewsPost iAllNewsPost)
        {
            _allNewsPost = iAllNewsPost;
            
        }
                     
        public ViewResult General()
        {
            ViewBag.Title = "Main";
            PostsListViewModel obj = new PostsListViewModel();
            obj.allNewsPost = _allNewsPost.Post("");
            obj.currCategory = "General News RT";
            return View(obj);
        }

        public ViewResult Sport()
        {
            ViewBag.Title = "Sport";
            PostsListViewModel obj = new PostsListViewModel();
            obj.allNewsPost = _allNewsPost.Post("sport");
            obj.currCategory = "Sport News RT";
            return View(obj);
        }

        public ViewResult Business()
        {
            ViewBag.Title = "Business";
            PostsListViewModel obj = new PostsListViewModel();
            obj.allNewsPost = _allNewsPost.Post("business");
            obj.currCategory = "Business News RT";
            return View(obj);
        }

        public ViewResult Russia()
        {
            ViewBag.Title = "Russia";
            PostsListViewModel obj = new PostsListViewModel();
            obj.allNewsPost = _allNewsPost.Post("russia");
            obj.currCategory = "Russia News RT";
            return View(obj);
        }
    }
}
