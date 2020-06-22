using System;
using System.Diagnostics.CodeAnalysis;
using Assignment_5.Comments;
using Assignment_5.Posts;

namespace Assignment_5.Interfaces
{
    /// <summary>
    /// This is an interface that implements the: DisplayComment() method. 
    /// Along with getters and/or setters for various fields, which are meant to be used in the creation of a Comment type object.
    /// </summary>
    public interface IComment
    {
        /// <summary>
        /// The Getter and Setter property for the Title of the comment.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The Getter and Setter property for the description of the comment.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The Getter and Setter property for who the comment was created by.
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// The getter and setter property for the date and time for when the post was created.
        /// </summary>
        public DateTime CreationDateTime { get; set; }

        /// <summary>
        /// Displays the various information for a comment.
        /// </summary>
        /// <returns>Returns the specified comment information.</returns>
        string DisplayComment();
    }
}
