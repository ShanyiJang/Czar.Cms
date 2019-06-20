﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sample01.Models;

namespace Sample01.Controllers
{
    public class ContentController : Controller
    {
        public ContentController()
        {
        }

        public IActionResult Index()
        {
            var contents = new List<Content>();
            for (int i = 1; i < 11; i++)
            {
                contents.Add(
                new Content
                {
                    Id = i,
                    title = $"{i}的标题",
                    content = $"{i}的内容",
                    status = 1,
                    add_time = DateTime.Now.AddDays(-i)
                });
            }
            return View(new ContentViewModel { Contents = contents });
        }
    }
}
