using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Assignment_5.Displays;
using Assignment_5.Interfaces;

namespace Assignment_5.Posts
{
    public class Post : IPost
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        [ExcludeFromCodeCoverage]
        public DateTime CreationDateTime { get; set; }
        [ExcludeFromCodeCoverage]
        public List<IComment> Comments { get; set; } = new List<IComment>();
        [ExcludeFromCodeCoverage]
        public int TotalComments 
        {
            get 
            {
                if(Comments is null)
                {
                    return 0;
                }

                return Comments.Count;
            } 
        }

        private int upVotes;
        private int downVotes;

        /// <summary>
        /// The constructor for Post type object.Which includes the field for title, description, who it was created by, and the datetime of the comment's creation.
        /// </summary>
        /// <param name="title">The post's title in the form of a string.</param>
        /// <param name="description">The post's descriptin in the form of a string.</param>
        /// <param name="createdBy">Who the post was created by.</param>
        public Post(string title, string description, string createdBy)
        {
            Title = title;

            Description = description;

            CreatedBy = createdBy;

            CreationDateTime = DateTime.UtcNow;
        }

        /// <summary>
        /// Displays the current count of upvotes and downvotes.
        /// </summary>
        /// <returns>Returns the current count of upvotes and downvotes in the form of a string statement.</returns>
        [ExcludeFromCodeCoverage]
        public string DisplayVotes()
        {
            return "Upvotes: " + upVotes + "     DownVotes: " + downVotes;
        }

        /// <summary>
        /// Increase the count of upvotes in increments of 1.
        /// </summary>
        /// <returns>Returns the current count of upvotes after a single incrementation.</returns>
        public int IncreaseUpVotes()
        {
            return ++upVotes;
        }

        /// <summary>
        /// Increase the count of downvotes in increments of 1.
        /// </summary>
        /// <returns>Returns the current count of downvotes after a single incrementation.</returns>
        public int IncreaseDownVotes()
        {
            return ++downVotes;
        }

        /// <summary>
        /// Displays the various information for a post, including: the title, description, who it was created by, and the creation datetime.
        /// </summary>
        /// <returns>Returns the title, description, creator, and the creation datetime of a Post, in the form of a string statement.</returns>
        [ExcludeFromCodeCoverage]
        public string DisplayPost()
        {
            if (string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Description) || string.IsNullOrEmpty(CreatedBy) || CreationDateTime.Equals(null))
            {
                DisplayUtility.ErrorMessageForNullOrEmpty();
            }
            return ("Title: " + Title + "\n\nDescription: " + Description + "\n\nCreated By: " + CreatedBy + "\n" + CreationDateTime);
        }

        /// <summary>
        /// Adds the specified IComment object to the Comments List of type IComment (i.e. List<IComment> Comments). 
        /// </summary>
        /// <param name="comment">An IComment type object.</param>
        public void AddComment(IComment comment)
        {
            Comments.Add(comment);
        }
    }
}
