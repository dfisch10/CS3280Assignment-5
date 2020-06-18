using System.Collections.Generic;

namespace Assignment_5
{
    /// <summary>
    /// This is an interface that implements the GetAll() method which returns an IList of type IPost.
    /// </summary>
    public interface IPostService
    {
        IList<IPost> GetAll();

    }
}
