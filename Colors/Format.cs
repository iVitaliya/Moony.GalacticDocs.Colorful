using System;
using Moony.GalacticDocs.Colorful.Checkers;

namespace Moony.GalacticDocs.Colorful.Colors
{
    public class Format
    {
        /// <summary>
        /// Colorizes the provided text with a reseted color.
        /// </summary>
        /// <param name="text">The text to reset the color for.</param>
        /// <returns>The colored text.</returns>
        public static string Reset(string text)
        {
            return Basics.Initiate(0, 0, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text in a bold color.
        /// </summary>
        /// <param name="text">The text to bold.</param>
        /// <returns>The colored text.</returns>
        public static string Bold(string text)
        {
            return Basics.Initiate(1, 22, "\x1b[22m\x1b[1m")(text);
        }

        /// <summary>
        /// Colorizes the provided text in a darker color.
        /// </summary>
        /// <param name="text">The text to dim.</param>
        /// <returns>The colored text.</returns>
        public static string Dim(string text)
        {
            return Basics.Initiate(2, 22, "\x1b[22m\x1b[2m")(text);
        }

        /// <summary>
        /// Colorizes the provided text in a italic color.
        /// </summary>
        /// <param name="text">The text to return italic.</param>
        /// <returns>The colored text.</returns>
        public static string Italic(string text)
        {
            return Basics.Initiate(3, 23, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a line under the text.
        /// </summary>
        /// <param name="text">The text to underline.</param>
        /// <returns>The colored text.</returns>
        public static string Underline(string text)
        {
            return Basics.Initiate(4, 24, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a inversed color.
        /// </summary>
        /// <param name="text">The text to inverse.</param>
        /// <returns>The colored text.</returns>
        public static string Inverse(string text)
        {
            return Basics.Initiate(7, 27, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a hidden color.
        /// </summary>
        /// <param name="text">The text to hide.</param>
        /// <returns>The colored text.</returns>
        public static string Hidden(string text)
        {
            return Basics.Initiate(8, 28, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a line that strikes through the text.
        /// </summary>
        /// <param name="text">The text to strike through.</param>
        /// <returns>The colored text.</returns>
        public static string StrikeThrough(string text)
        {
            return Basics.Initiate(9, 29, "")(text);
        }
    }
}