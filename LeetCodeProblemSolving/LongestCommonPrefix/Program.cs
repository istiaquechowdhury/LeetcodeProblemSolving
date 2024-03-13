public class Program
{
    public static void Main()
    {
        string[] s = Console.ReadLine().Split();

        string prefix = LongestCommonPrefix(s);
        Console.WriteLine(prefix);
       
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        Array.Sort(strs);

        string prefix = "";

        string s = strs[0];

        string s1 = strs[strs.Length-1];

        int index = 0;

        while(index < s.Length && index < s1.Length) 
        {
            if (s[index] == s1[index])
            {
                prefix = prefix + s[index];
                index++;    
            }
            else 
            {
                break;
            }
        }

        return prefix;
    }
}