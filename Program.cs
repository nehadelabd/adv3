namespace adv3
{
    internal class Program
    {
        #region 1
        //static int FirstNonRepeatedCharIndex(string s)
        //{
        //    Dictionary<char, int> frequency = new Dictionary<char, int>();

        //    foreach (char c in s)
        //    {
        //        if (frequency.ContainsKey(c))
        //            frequency[c]++;
        //        else
        //            frequency[c] = 1;
        //    }

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (frequency[s[i]] == 1)
        //            return i;
        //    }

        //    return -1;
        //} 
        #endregion

        #region 2

        //static void CountFrequencies(int[] arr)
        //{
        //    Dictionary<int, int> frequency = new Dictionary<int, int>();

        //    foreach (int num in arr)
        //    {
        //        if (frequency.ContainsKey(num))
        //            frequency[num]++;
        //        else
        //            frequency[num] = 1;
        //    }

        //    Console.WriteLine("Element : Frequency");
        //    foreach (var pair in frequency)
        //    {
        //        Console.WriteLine($"{pair.Key} : {pair.Value}");
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {




            #region 1
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //int index = FirstNonRepeatedCharIndex(input);

            //if (index != -1)
            //    Console.WriteLine($"First non-repeated character is '{input[index]}' at index {index}");
            //else
            //    Console.WriteLine("No non-repeated character found.");
            #endregion
            #region 2



            //int[] arr = { 1, 2, 2, 3, 1, 4, 2 };

            //CountFrequencies(arr);
            #endregion
        }
    }
}
