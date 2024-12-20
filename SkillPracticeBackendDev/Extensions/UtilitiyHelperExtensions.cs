﻿namespace SkillPracticeBackendDev.Extensions;
public static class UtilitiyHelperExtensions
{
    public static double AverageHelper(this IEnumerable<int> sources)
    {
            if (sources  is null)
                throw new ArgumentNullException(nameof(sources));
            return (double)sources.Sum()/sources.Count();
    }
    public static T Second<T>(this List<T> sources)
    {
        if(sources.Count>=2)
            return (T)sources[1];
        throw new InvalidOperationException("This list does not have a second element .");
    }

    public static string  RightSubstring(this string s,int count)
    {
        return s.Substring(s.Length-count,count);//Hello=5 , 
    }
}
