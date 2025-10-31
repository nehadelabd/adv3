namespace adv3
{
    internal class Program
    {
        #region 1
        static int FirstNonRepeatedCharIndex(string s)
        {
            Dictionary<char, int> frequency = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (frequency.ContainsKey(c))
                    frequency[c]++;
                else
                    frequency[c] = 1;
            }

            for (int i = 0; i < s.Length; i++)
            {
                if (frequency[s[i]] == 1)
                    return i;
            }

            return -1;
        } 
        #endregion

        static void Main(string[] args)
        {




            #region 1
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            int index = FirstNonRepeatedCharIndex(input);

            if (index != -1)
                Console.WriteLine($"First non-repeated character is '{input[index]}' at index {index}");
            else
                Console.WriteLine("No non-repeated character found.");
            #endregion
        }
    }
}
