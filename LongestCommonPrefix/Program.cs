using System.Text;

public class Program
{   

    public static string LongestCommonPrefix(string[] strs)
    {
        StringBuilder sb = new StringBuilder();

        if (strs.Length == 1)
            return strs[0];

        string lastWord = "";
        for (int i = 0; i < strs.Length - 1; i++)
        {
            if (strs[i].Length == 0) // if a word is empty there is not a common string.
            {
                sb.Clear();
                break;
            }

            if (strs[i].Equals(lastWord)) // if current is equals last, take next
                continue;

            bool isCommon = true;
            for (int k = 0; k < strs[i].Length && isCommon; k++) // for each letter
            {
                char letterToCheck = strs[i][k];

                for (int j = i + 1; j < strs.Length; j++) // for each word
                {
                    if (strs[j].Length <= k || strs[j][k] != letterToCheck)
                    {
                        isCommon = false; // if a letter doesn't match
                        break;
                    }
                }

                if (isCommon)
                    sb.Append(letterToCheck);
            }

            lastWord = strs[i];

            break; // we need to iterate only over the first valid letter
        }

        return sb.ToString();
    }



    static int Main(string[] args)
    {
        var input = new[] { "", "cbc", "c", "ca" };

        string common = LongestCommonPrefix(input);
                
        Console.WriteLine("Input: s = {0}", string.Join(", ", input));
        Console.WriteLine("Output: {0}", common);

        return 0;
    }
}