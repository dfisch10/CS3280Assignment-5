using System;
using System.Diagnostics.CodeAnalysis;
using Assignment_5.Comments;
using Assignment_5.Displays;
using Microsoft.Extensions.DependencyInjection;
using Assignment_5.Interfaces;
using System.Dynamic;
using System.Collections;
using System.Buffers.Text;

namespace Assignment_5
{
    class Program
    {
        /// <summary>
        /// This is my main method
        /// </summary>
        /// <param name="args"></param>
        [ExcludeFromCodeCoverage]
        static void Main(string[] args)
        {
            var provider = new ServiceCollection()
                            .AddSingleton<IPostService, PostService>()
                            .BuildServiceProvider();

            var service = provider.GetService<IPostService>();

            var posts = service.GetAll();

            foreach (var post in posts)
            {
                DisplayUtility.OutputPostDisplay(post.Display());

                DisplayUtility.OutputPostDisplay(post.DisplayVotes());

                DisplayUtility.OutputPostDisplay("Number of Comments: " +  post.TotalComments.ToString());

                foreach (var comment in post.Comments)
                {                 
                    DisplayUtility.OutputCommentDisplay(comment.DisplayComment());                 
                }     
            }
        }
    }
}
