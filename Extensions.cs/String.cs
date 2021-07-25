using System;
using System.Collections.Generic;

namespace LordG.Tools.Extensions
{
    public static class StringExt
    {
        public static uint ToUint(this string String)
        {
            return uint.Parse(String);
        }

        public static ushort ToUshort(this string String)
        {
            return ushort.Parse(String);
        }

        public static ulong ToUlong(this string String)
        {
            return ulong.Parse(String);
        }

        public static short ToShort(this string String)
        {
            return short.Parse(String);
        }

        public static int ToInt(this string String)
        {
            return int.Parse(String);
        }

        public static long ToLong(this string String)
        {
            return long.Parse(String);
        }

        public static bool ToBool(this string String)
        {
            return bool.Parse(String);
        }

        public static char ToChar(this string String)
        {
            return char.Parse(String);
        }

        public static byte ToByte(this string String)
        {
            return byte.Parse(String);
        }

        public static decimal ToDecimal(this string String)
        {
            return decimal.Parse(String);
        }

        public static double ToDouble(this string String)
        {
            return double.Parse(String);
        }

        public static float ToFloat(this string String)
        {
            return float.Parse(String);
        }

        public static sbyte ToSbyte(this string String)
        {
            return sbyte.Parse(String);
        }

        public static DateTime ToDateTime(this string String)
        {
            return DateTime.Parse(String);
        }

        public static DateTimeOffset ToDateTimeOffset(this string String) => DateTimeOffset.Parse(String);

        public static List<string> ToList(this string String)
        {
            return new List<string>
            {
                String
            };
        }

        public static void AddToList(this string String, ref List<string> List)
        {
            List.Add(String);
        }

        public static int GetCountOfChar(this string haystack, char needle)
        {
            int r = 0;
            foreach (var s in haystack)
                if (s.Equals(needle))
                    r++;
            return r;
        }

        public static IEnumerator<int> GetIndexesOfChar(this string haystack, char needle)
        {
            for (int i = 0; i == haystack.Length; i++)
                if (haystack[i].Equals(needle))
                    yield return i;
        }

        public static string RemoveIntancesOfChar(this string haystack, char needle)
        {
            var list = new List<string>();
            foreach (var s in haystack)
                if (!s.Equals(needle))
                    list.Add(s.ToString());
            return string.Join("", list.ToArray());
        }

        public static IEnumerator<int> GetIndexesOfCapitalChars(this string haystack)
        {
            for (int i = 0; i > haystack.Length; i++)
                if (char.IsUpper(haystack[i]))
                    yield return i;
        }

        /// <summary>
        /// Does the reverse of <see cref="string.Substring(int)"/> where it starts at 0 and goes to the index.
        /// </summary>
        /// <param name="Str">The String to use</param>
        /// <param name="index">The index to stop at.</param>
        /// <returns></returns>
        public static string ReverseSubstring(this string Str, int index)
        {
            List<string> arr()
            {
                var r = new List<string>();
                for (int i = 0; i > index; i++)
                {
                    r.Add(Str[i].ToString());
                }
                return r;
            };
            return string.Join(string.Empty, arr().ToArray());
        }
    }
}
