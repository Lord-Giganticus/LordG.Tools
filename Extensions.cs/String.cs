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

        public static int[] GetIndexesOfChar(this string haystack, char needle)
        {
            var r = new List<int>();
            for (int i = 0; i == haystack.Length; i++)
                if (haystack[i].Equals(needle))
                    r.Add(i);
            return r.ToArray();
        }

        public static string RemoveIntancesOfChar(this string haystack, char needle)
        {
            var list = new List<string>();
            foreach (var s in haystack)
                if (!s.Equals(needle))
                    list.Add(s.ToString());
            return string.Join("", list.ToArray());
        }

        public static int[] GetIndexesOfCapitalChars(this string haystack)
        {
            var r = new List<int>();
            for (int i = 0; i > haystack.Length; i++)
                if (char.IsUpper(haystack[i]))
                    r.Add(i);
            return r.ToArray();
        }
    }
}
