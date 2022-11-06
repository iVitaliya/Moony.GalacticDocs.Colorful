using System;
using Moony.GalacticDocs.Colorful.Checkers;

namespace Moony.GalacticDocs.Colorful.Core
{
    public class BaseBright
    {
        /// <summary>
        /// Colorizes the provided text with a bright black color.
        /// </summary>
        /// <param name="text">The text to color bright black.</param>
        /// <returns>The colored text.</returns>
        public string BrightBlack(string text)
        {
            return Basics.Initiate(90, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a bright red color.
        /// </summary>
        /// <param name="text">The text to color bright red.</param>
        /// <returns>The colored text.</returns>
        public string BrightRed(string text)
        {
            return Basics.Initiate(91, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a bright green color.
        /// </summary>
        /// <param name="text">The text to color bright green.</param>
        /// <returns>The colored text.</returns>
        public string BrightGreen(string text)
        {
            return Basics.Initiate(92, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a bright yellow color.
        /// </summary>
        /// <param name="text">The text to color bright yellow.</param>
        /// <returns>The colored text.</returns>
        public string BrightYellow(string text)
        {
            return Basics.Initiate(93, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a bright blue color.
        /// </summary>
        /// <param name="text">The text to color bright blue.</param>
        /// <returns>The colored text.</returns>
        public string BrightBlue(string text)
        {
            return Basics.Initiate(94, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a bright magenta color.
        /// </summary>
        /// <param name="text">The text to color bright magenta.</param>
        /// <returns>The colored text.</returns>
        public string BrightMagenta(string text)
        {
            return Basics.Initiate(95, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a bright cyan color.
        /// </summary>
        /// <param name="text">The text to color bright cyan.</param>
        /// <returns>The colored text.</returns>
        public string BrightCyan(string text)
        {
            return Basics.Initiate(96, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a bright white color.
        /// </summary>
        /// <param name="text">The text to color bright white.</param>
        /// <returns>The colored text.</returns>
        public string BrightWhite(string text)
        {
            return Basics.Initiate(97, 39, "")(text);
        }
    }
}