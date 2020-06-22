using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Assignment_5.Posts;
using Assignment_5.Interfaces;
using Assignment_5.Displays;

namespace Assignment_5.Comments
{
    public class Comment : IComment
    {
        #region Properties
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
        #endregion

        public string PostTitle { get; set; }

        #region Constructor
        [ExcludeFromCodeCoverage]
        /// <summary>
        /// The constructor for Comment type object.Which includes the field for title, description, who it was created by, and the datetime of the comment's creation.
        /// </summary>
        /// <param name="title">The comment's title in the form of a string.</param>
        /// <param name="description">The comment's descriptin in the form of a string.</param>
        /// <param name="createdBy">Who the comment was created by.</param>
        public Comment(string title, string description, string createdBy)
        {
            Title = title;
            Description = description;
            CreatedBy = createdBy;
            CreationDateTime = DateTime.UtcNow;
        }
        #endregion

        #region Methods
        [ExcludeFromCodeCoverage]
        /// <summary>
        /// Displays the various information for a comment, including: the title, description, who it was created by, and the creation datetime.
        /// </summary>
        /// <returns>Returns the title, description, creator, and the creation datetime of a Comment type object, in the form of a string statement.</returns>
        public String DisplayComment()
        {
            if (string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Description) || string.IsNullOrEmpty(CreatedBy) || CreationDateTime.Equals(null))
            {
                DisplayUtility.ErrorMessageForNullOrEmpty();
            }

            return ("_____________________________________\n\n" + "Title: " + Title + "\n\nDescription: " + Description + "\n\nCreated By: " + CreatedBy + "\n" + CreationDateTime);
        }
        #endregion
    }
}
