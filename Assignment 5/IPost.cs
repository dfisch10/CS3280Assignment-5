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
        #region Properties
        int TotalComments { get; }

        string Title { get; set; }

        string Description { get; set; }

        string CreatedBy { get; set; }

        DateTime CreationDateTime { get; set; }

        List<IComment> Comments { get; set; }
        #endregion

        #region Methods
        int IncreaseUpVotes();

        int IncreaseDownVotes();

        string DisplayVotes();

        string Display();

        void AddComment(IComment comment);
        #endregion
    }
}
