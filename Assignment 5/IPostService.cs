using System.Collections.Generic;

namespace Assignment_5
{
    /// <summary>
    /// This is an interface that implements the GetAll() method which returns an IList of type IPost.
    /// </summary>
    public interface IPostService
    {
        /// <summary>
        /// Gets all the specified information of the posts from the IList.
        /// </summary>
        /// <returns></returns>
        IList<IPost> GetAll();

    }
}
