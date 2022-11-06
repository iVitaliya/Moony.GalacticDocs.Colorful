using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moony.GalacticDocs.Colorful.Checkers
{
    public class Basics
    {
        private static string ReplaceClose(int index, string str, string close, string replace, string head, string tail, int next)
        {
            if (next < 0) 
            {
                return head + tail;
            }

            return head + ReplaceClose(next, tail, close, replace, head+replace, tail, tail.IndexOf(close));
        }

        private static string ClearBleed(int index, string str, string open, string close, string replace)
        {
            if (index < 0)
            {
                return open + str + close;
            }

            return open + ReplaceClose(index, str, close, replace, "", "", str.IndexOf(open)) + close;
        }

        private static Func<string, string> FilterEmpty(string open, string close, string replace, int at)
        {
            return (str) => {
                if (str == "" || str.Length < 1)
                {
                    return "";
                }

                return ClearBleed(at, str, open, close, replace);
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="open"></param>
        /// <param name="close"></param>
        /// <param name="replace"></param>
        /// <returns></returns>
        public static Func<string, string> Initiate(int open, int close, string replace)
        {
            string open_val = Utils.IntegerToString(open);
            string close_val = Utils.IntegerToString(close);

            return (s) => {
                return FilterEmpty($"\x1b[{open_val}m", $"\x1b[{close_val}m", replace, s.IndexOf(open_val))(s);
            };
        }
    }
}