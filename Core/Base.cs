using System;
using Moony.GalacticDocs.Colorful.Checkers;

namespace Moony.GalacticDocs.Colorful.Core
{
    public class Base
    {
        /// <summary>
        /// Colorizes the provided text with a black color.
        /// </summary>
        /// <param name="text">The text to color black.</param>
        /// <returns>The colored text.</returns>
        public string Black(string text)
        {
            return Basics.Initiate(30, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a red color.
        /// </summary>
        /// <param name="text">The text to color red.</param>
        /// <returns>The colored text.</returns>
        public string Red(string text)
        {
            return Basics.Initiate(31, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a green color.
        /// </summary>
        /// <param name="text">The text to color green.</param>
        /// <returns>The colored text.</returns>
        public string Green(string text)
        {
            return Basics.Initiate(32, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a yellow color.
        /// </summary>
        /// <param name="text">The text to color yellow.</param>
        /// <returns>The colored text.</returns>
        public string Yellow(string text)
        {
            return Basics.Initiate(33, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a blue color.
        /// </summary>
        /// <param name="text">The text to color blue.</param>
        /// <returns>The colored text.</returns>
        public string Blue(string text)
        {
            return Basics.Initiate(34, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a magenta color.
        /// </summary>
        /// <param name="text">The text to color magenta.</param>
        /// <returns>The colored text.</returns>
        public string Magenta(string text)
        {
            return Basics.Initiate(35, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a cyan color.
        /// </summary>
        /// <param name="text">The text to color cyan.</param>
        /// <returns>The colored text.</returns>
        public string Cyan(string text)
        {
            return Basics.Initiate(36, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a white color.
        /// </summary>
        /// <param name="text">The text to color white.</param>
        /// <returns>The colored text.</returns>
        public string White(string text)
        {
            return Basics.Initiate(37, 39, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a gray color.
        /// </summary>
        /// <param name="text">The text to color gray.</param>
        /// <returns>The colored text.</returns>
        public string Gray(string text)
        {
            return Basics.Initiate(90, 39, "")(text);
        }
    }
}