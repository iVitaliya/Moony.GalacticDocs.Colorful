using System;
using Moony.GalacticDocs.Colorful.Checkers;

namespace Moony.GalacticDocs.Colorful.Core
{
    public class BrightBackground
    {
        /// <summary>
        /// Colorizes the provided text with a bright black background color.
        /// </summary>
        /// <param name="text">The text to colorize with a bright black background.</param>
        /// <returns>The colorized background.</returns>
        public string BgBlackBright(string text)
        {
            return Basics.Initiate(100, 49, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a bright red background color.
        /// </summary>
        /// <param name="text">The text to colorize with a bright red background.</param>
        /// <returns>The colorized background.</returns>
        public string BgRedBright(string text)
        {
            return Basics.Initiate(101, 49, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a bright green background color.
        /// </summary>
        /// <param name="text">The text to colorize with a bright green background.</param>
        /// <returns>The colorized background.</returns>
        public string BgGreenBright(string text)
        {
            return Basics.Initiate(102, 49, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a bright yellow background color.
        /// </summary>
        /// <param name="text">The text to colorize with a bright yellow background.</param>
        /// <returns>The colorized background.</returns>
        public string BgBrightYellow(string text)
        {
            return Basics.Initiate(103, 49, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a bright blue background color.
        /// </summary>
        /// <param name="text">The text to colorize with a bright blue background.</param>
        /// <returns>The colorized background.</returns>
        public string BgBrightBlue(string text)
        {
            return Basics.Initiate(104, 49, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a bright magenta background color.
        /// </summary>
        /// <param name="text">The text to colorize with a bright magenta background.</param>
        /// <returns>The colorized background.</returns>
        public string BgBrightMagenta(string text)
        {
            return Basics.Initiate(105, 49, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a bright cyan background color.
        /// </summary>
        /// <param name="text">The text to colorize with a bright cyan background.</param>
        /// <returns>The colorized background.</returns>
        public string BgBrightCyan(string text)
        {
            return Basics.Initiate(106, 49, "")(text);
        }

        /// <summary>
        /// Colorizes the provided text with a bright white background color.
        /// </summary>
        /// <param name="text">The text to colorize with a bright white background.</param>
        /// <returns>The colorized background.</returns>
        public string BgBrightWhite(string text)
        {
            return Basics.Initiate(107, 49, "")(text);
        }
    }
}