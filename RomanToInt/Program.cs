public class Roman
{
    public static int ConvertValue(Dictionary<char, int> dic, char[] romans)
    {
        int value = 0;
        int size = romans.Length;

        for (int i = 0; i < size; i++)
        {
            int currentValue;

            int current = dic[romans[i]];

            if (i + 1 >= size)
                currentValue = current;

            else
            {
                int next = dic[romans[i + 1]];

                if (current < next)
                {
                    currentValue = next - current;
                    i = i + 1;
                }
                else
                {
                    currentValue = current;
                }
            }

            value += currentValue;
        }


        return value;
    }

    public static int RomanToInt(string s)
    {
        var romans = new Dictionary<char, int>();
        romans.Add('I', 1);
        romans.Add('V', 5);
        romans.Add('X', 10);
        romans.Add('L', 50);
        romans.Add('C', 100);
        romans.Add('D', 500);
        romans.Add('M', 1000);
        
        return ConvertValue(romans, s.ToCharArray());
    }

    static int Main(string[] args)
    {
        int value = RomanToInt(args[0]);

        Console.WriteLine("Input: s = {0}", args[0]);
        Console.WriteLine("Output: {0}", value);

        return 0;
    }

}