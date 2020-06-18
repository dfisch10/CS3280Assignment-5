﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Assignment_5.Posts;
using Assignment_5.Interfaces;
using Assignment_5.Displays;

namespace Assignment_5.Comments
{
    public class Comment : IComment
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public string PostTitle { get; }

        [ExcludeFromCodeCoverage]
        public DateTime CreationDateTime { get; set; }

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

        /// <summary>
        /// Displays the various information for a comment, including: the title, description, who it was created by, and the creation datetime.
        /// </summary>
        /// <returns>Returns the title, description, creator, and the creation datetime of a Comment type object, in the form of a string statement.</returns>
        [ExcludeFromCodeCoverage]
        public String DisplayComment()
        {
            if (string.IsNullOrEmpty(Title) || string.IsNullOrEmpty(Description) || string.IsNullOrEmpty(CreatedBy) || CreationDateTime.Equals(null))
            {
                DisplayUtility.ErrorMessageForNullOrEmpty();
            }

            return ("_____________________________________\n\n" + "Title: " + Title + "\n\nDescription: " + Description + "\n\nCreated By: " + CreatedBy + "\n" + CreationDateTime);
        }
    }
}
