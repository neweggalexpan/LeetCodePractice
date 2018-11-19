using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Sort_Characters_By_Frequency
{
    public string FrequencySort(string s) 
    {
        var dictionary = new Dictionary<char, int>();
        var charArray = s.ToCharArray();

        foreach(var c in charArray)
        {
            if(!dictionary.Keys.Contains(c))
            {
                dictionary.Add(c, 0);
            }

            var count = (int) dictionary[c];
            
            dictionary[c] = count + 1;
        }

        var newdictionary = from x in dictionary orderby x.Value descending select x;
        var result = string.Empty;

        foreach(var x in newdictionary)
        {
            for(int i = 0; i < x.Value; i++)
            {
                result = result + x.Key;
            }
        }

        return result;
    }
}