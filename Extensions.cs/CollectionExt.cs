using System.Collections.Generic;

namespace LordG.Tools.Extensions
{
    public static class CollectionExt
    {
        public static List<(T1,T2)> ToList<T1,T2>(this Dictionary<T1,T2> dict)
        {
            var l = new List<(T1, T2)>();
            foreach (var d in dict)
                l.Add((d.Key, d.Value));
            return l;
        }

        public static List<T> ToList<T>(this T[] ts)
        {
            var l = new List<T>();
            foreach (var t in ts)
                l.Add(t);
            return l;
        }
    }
}
