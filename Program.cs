//Lesson 10 Final Project: Record Store200 points
//Directions
//For the final project, you are going to create a Blog. This app will be a full .NET Core MVC application using a SQLite database.Please zip your project directory and upload when you are finished. This project will be graded, so be sure you complete all requirements.

//Requirements:
//Project Components:
//MVC
//Identity Framework
//Entity Framework using SQLite
//Models: Post
//Id(numeric id of the post)
//Title(title or subject the post)
//Content(the main body of the post)
//TimeStamp(when the post was created)
//Features
//Any user (not logged in) can view a list of posts.
//Authenticated user (logged in) can create, update, and delete posts.
//Page(s) and posts are styled and display with the newest post at the top.
//Stretch Goals
//Authenticated users can only edit their own posts and not those of other users.
//Think about how you might accomplish this or what extra data might be necessary to add to a post to know who made it.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace _104_FinalProj
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
