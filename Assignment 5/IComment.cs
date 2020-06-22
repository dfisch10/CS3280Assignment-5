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
        #region Properties
        public string Title { get; set; }

        public string Description { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreationDateTime { get; set; }
        #endregion

        string DisplayComment();
    }
}
