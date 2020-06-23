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
        #region Properties
        /// <summary>
        /// The Getter and Setter property for the Title of the post.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The Getter and Setter property for the description of the post.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The Getter and Setter property for who the post was created by.
        /// </summary>
        public string CreatedBy { get; set; }
       
        /// <summary>
        /// The getter and setter property for the date and time for when the post was created.
        /// </summary>
        public DateTime CreationDateTime { get; set; }
       
        /// <summary>
        /// An initialized Getter and setter for the Comments list, which keeps track of all the comments (acting like an archive/counter). 
        /// </summary>
        public List<IComment> Comments { get; set; } = new List<IComment>();
       
        /// <summary>
        /// Gets the amount of comments that are currently in the Comments List, and returns their count.
        /// </summary>
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

        /// <summary>
        /// Initializes the upVotes variable that is used in the IncreaseUpVotes method.
        /// </summary>
        private int upVotes;

        /// <summary>
        /// Initializes the downVotes variable that is used in the IncreaseDownVotes method.
        /// </summary>
        private int downVotes;
        #endregion

        #region Constructor
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
        #endregion

        #region Methods
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
        public string Display()
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
            if (comment is null)
            {
                DisplayUtility.ErrorMessageForNullOrEmpty();
                return;
            }

            Comments?.Add(comment);
        }
        #endregion
    }
}
