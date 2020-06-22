using Assignment_5.Comments;
using Assignment_5.Posts;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Assignment_5
{
    public class PostService : IPostService
    {
        /// <summary>
        /// This method creates manually inputs manually inputted dummy data to a Post object, and two Comment objects. 
        /// It then adds those comments to the Post's comment list, increases/decreases the post several times, and then adds the info to an List of type IPost.
        /// </summary>
        /// <returns> Returns the resulting post, its information, and associated comments in the form of a List of type IPost.</returns>
        [ExcludeFromCodeCoverage]
        public IList<IPost> GetAll()
        {
             var title = "When you are doing homework while sleep deprived";
             var description = "So in doing this assignment, I originally started at 1:00 am, after only getting two hours of sleep. Which by itself may seem fine, but the problem was that I decided to review the requirements for both assignment 5 and 6. In short, as a result, I made this assignment WAAAY harder than it was supposed to be, including a menu, an archive of posts, and a way to display all of the archived posts, among other things. Morale of the story, don't do programming with only two hours of sleep.";
             var createdby = "Daniel Fischer (aka the dumbass)";

            var post = new Post(title, description, createdby);

            var commentTitle1 = "I hear ya!";
            var commentDescription1 = "Yep, I have been there, and done that as well, AND at the exact same time as you did!";
            var commentCreator1 = "Second Personality";

            var comment1 = new Comment(commentTitle1, commentDescription1, commentCreator1);

            var commentTitle2 = "I agree with your alias";
            var commentDescription2 = "You are right, you are totally a dumbass! Learn to follow instructions you pleeb!";
            var commentCreator2 = "Third Personality";

            var comment2 = new Comment(commentTitle2, commentDescription2, commentCreator2);

            post.AddComment(comment1);
            post.AddComment(comment2);

            post.IncreaseUpVotes();
            post.IncreaseUpVotes();
            post.IncreaseUpVotes();
            post.IncreaseDownVotes();
            post.IncreaseDownVotes();

            return new List<IPost>()
            {
                post
            };
        }
    }
}
