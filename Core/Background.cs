using System;
using Moony.GalacticDocs.Colorful.Checkers;

namespace Moony.GalacticDocs.Colorful.Core
{
    public class Background
    {
        /// <summary>
        /// Colorizes the provided text with a black background color.
        /// </summary>
        /// <param name="text">The text to colorize with a black background.</param>
        /// <returns>The colorized background.</returns>
        public string BgBlack(string text)
        {
            return Basics.Initiate(40, 49, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a red background color.
        /// </summary>
        /// <param name="text">The text to colorize with a red background.</param>
        /// <returns>The colorized background.</returns>
        public string BgRed(string text)
        {
            return Basics.Initiate(41, 49, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a green background color.
        /// </summary>
        /// <param name="text">The text to colorize with a green background.</param>
        /// <returns>The colorized background.</returns>
        public string BgGreen(string text)
        {
            return Basics.Initiate(42, 49, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a yellow background color.
        /// </summary>
        /// <param name="text">The text to colorize with a yellow background.</param>
        /// <returns>The colorized background.</returns>
        public string BgYellow(string text)
        {
            return Basics.Initiate(43, 49, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a blue background color.
        /// </summary>
        /// <param name="text">The text to colorize with a blue background.</param>
        /// <returns>The colorized background.</returns>
        public string BgBlue(string text)
        {
            return Basics.Initiate(44, 49, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a magenta background color.
        /// </summary>
        /// <param name="text">The text to colorize with a magenta background.</param>
        /// <returns>The colorized background.</returns>
        public string BgMagenta(string text)
        {
            return Basics.Initiate(45, 49, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a cyan background color.
        /// </summary>
        /// <param name="text">The text to colorize with a cyan background.</param>
        /// <returns>The colorized background.</returns>
        public string BgCyan(string text)
        {
            return Basics.Initiate(46, 49, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a white background color.
        /// </summary>
        /// <param name="text">The text to colorize with a white background.</param>
        /// <returns>The colorized background.</returns>
        public string BgWhite(string text)
        {
            return Basics.Initiate(47, 49, "")(text);
        }
    }
}