using Assignment_5.Interfaces;
using Assignment_5.Posts;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Assignment_5
{
    /// <summary>
    /// This is an interface that implements the: IncreaseUpVotes(), IncreaseDownVotes(), DisplayVotes(), DisplayPost(), and AddComments() methods. 
    /// Along with getters and/or setters for various fields, which are meant to be used in the creation of a Post type object.
    /// </summary>
    public interface IPost
    {
        /// <summary>
        /// Gets the amount of comments that are currently in the Comments List, and returns their count.
        /// </summary>
        int TotalComments { get; }

        /// <summary>
        /// The Getter and Setter property for the Title of the post.
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// The Getter and Setter property for the description of the post.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// The Getter and Setter property for who the post was created by.
        /// </summary>
        string CreatedBy { get; set; }

        /// <summary>
        /// The getter and setter property for the date and time for when the post was created.
        /// </summary>
        DateTime CreationDateTime { get; set; }

        /// <summary>
        /// An initialized Getter and setter for the Comments list, which keeps track of all the comments (acting like an archive/counter). 
        /// </summary>
        List<IComment> Comments { get; set; }

        /// <summary>
        /// Increase the count of upvotes.
        /// </summary>
        /// <returns>Returns the current count of upvotes.</returns>
        int IncreaseUpVotes();

        /// <summary>
        /// Increase the count of downvotes.
        /// </summary>
        /// <returns>Returns the current count of downvotes.</returns>
        int IncreaseDownVotes();

        /// <summary>
        /// Displays the current count of upvotes and downvotes.
        /// </summary>
        /// <returns>Returns the current count of upvotes and downvotes in the form of a string statement.</returns>
        string DisplayVotes();

        /// <summary>
        /// Displays the various specified information for a post.
        /// </summary>
        /// <returns>Returns the various specified information of a post in string format.</returns>
        string Display();

        /// <summary>
        /// Adds the specified IComment object to the Comments List of type IComment (i.e. List<IComment> Comments). 
        /// </summary>
        /// <param name="comment">An IComment type object.</param>
        void AddComment(IComment comment);
    }
}
