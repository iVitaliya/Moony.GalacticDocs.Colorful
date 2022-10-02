using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moony.GalacticDocs.Colorful.Checkers
{
    public class Utils
    {
        /// <summary>
        /// Prints a message to the console.
        /// </summary>
        /// <param name="text">The text to send to the console.</param>
        /// <param name="line">If the sent text should be a one line print on running this property once.</param>
        /// <returns>The message in console.</returns>
        public static Task Print(string text, bool line)
        {
            if (line == false) {
                Console.Write(text);

                return Task.CompletedTask;
            } else {
                Console.WriteLine(text);

                return Task.CompletedTask;
            }
        }

        /// <summary>
        /// Checks if an string item exists in an string array.
        /// </summary>
        /// <param name="array">The array to check the item for.</param>
        /// <param name="value">The item to check for.</param>
        /// <returns>A boolean if the item exists in the array.</returns>
        public static bool ElementExists(string[] array, string value) 
        {
            for (int i = 0; i < array.Length; i++) {
                if (array[i].Equals(value)) {
                    return true;
                }
            }

            return false;
        }

        public static bool ElementExists(int[] array, int value) 
        {
            for (int i = 0; i < array.Length; i++) {
                if (array[i].Equals(value)) {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Turns an integer to a string.
        /// </summary>
        /// <param name="i">The integer to transform.</param>
        /// <returns>The provided integer as a string.</returns>
        public static string IntegerToString(int i) 
        {
            return i.ToString();
        }

        /// <summary>
        /// Turns a string to an interger.
        /// </summary>
        /// <param name="s">The string to transform.</param>
        /// <returns>The provided string as an integer.</returns>
        public static Nullable<int> StringToInteger(string s)
        {
            int i;

            try
            {
                i = int.Parse(s);
            }
            catch (ArgumentNullException ArgExc)
            {
                Print($"[EXCEPTION | ArgumentNull] {ArgExc.ToString()}", true);
                return null;
            }
            catch (FormatException FormatExc)
            {
                Print(FormatExc.ToString(), true);
                return null;
            }
            catch (OverflowException OverFlowExc)
            {
                Print(OverFlowExc.ToString(), true);
                return null;
            }

            return i;
        }
    }
}