using Assignment_5.Posts;
using System;
using System.Diagnostics.CodeAnalysis;

namespace Assignment_5.Displays
{
    public class DisplayUtility
    {
        /// <summary>
        /// Changes the foreground color of the comment to Yellow, then resets the console color back to default after displaying the post information.
        /// </summary>
        /// <param name="comment">The Comment type object's information, which is in the string format.</param>
        [ExcludeFromCodeCoverage]
        public static void OutputCommentDisplay(string comment)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(comment);
            Console.ResetColor();
        }

        /// <summary>
        /// Changes the foreground color of the post to Cyan, then resets the console color back to default after displaying the post information.
        /// </summary>
        /// <param name="post">The Post type object's information, which is in the string format.</param>
        [ExcludeFromCodeCoverage]
        public static void OutputPostDisplay(string post)
        {
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine(post);

            Console.ResetColor();
        }

        /// <summary>
        /// Displays a static error message for null or empty values, and changes the foreground color of that message to dark red. 
        /// It then resets the console foreground color to its default after being displayed. 
        /// </summary>
        [ExcludeFromCodeCoverage]
        public static void ErrorMessageForNullOrEmpty()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You may not have a null or empty value, please stop trying to break my program Professor Harp!");
            Console.ResetColor();
        }

        /// <summary>
        /// Displays a static error message for null vote values, and changes the foreground color of that message to dark red. 
        /// It then resets the console foreground color to its default after being displayed. 
        /// </summary>
        [ExcludeFromCodeCoverage]
        public static void ErrorMessageForNullVotes()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You may not have a null vote count, please stop trying to break my program Professor Harp!");
            Console.ResetColor();
        }
    }
}
