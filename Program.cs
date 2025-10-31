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
        #region 3
        //static string FindKeyWithHighestValue(Dictionary<string, int> table)
        //{
        //    if (table == null || table.Count == 0)
        //        throw new ArgumentException("Hashtable is empty.");

        //    string maxKey = null;
        //    int maxValue = int.MinValue;

        //    // Iterate through each key-value pair
        //    foreach (var pair in table)
        //    {
        //        if (pair.Value > maxValue)
        //        {
        //            maxValue = pair.Value;
        //            maxKey = pair.Key;
        //        }
        //    }

        //    return maxKey;
        //}
        #endregion
        #region 4
        //static void FindKeysByValue(Dictionary<string, string> table, string targetValue)
        //{
        //    bool found = false;

        //    foreach (var pair in table)
        //    {
        //        if (pair.Value == targetValue)
        //        {
        //            Console.WriteLine(pair.Key);
        //            found = true;
        //        }
        //    }

        //    if (!found)
        //    {
        //        Console.WriteLine("Key not found");
        //    }
        //} 
        #endregion
        #region 5
        //static List<List<string>> GroupAnagrams(string[] words)
        //{
        //    Dictionary<string, List<string>> groups = new Dictionary<string, List<string>>();

        //    foreach (string word in words)
        //    {
        //        string sortedWord = String.Concat(word.OrderBy(c => c));

        //        if (!groups.ContainsKey(sortedWord))
        //            groups[sortedWord] = new List<string>();

        //        groups[sortedWord].Add(word);
        //    }

        //    return groups.Values.ToList();
        //}
        #endregion
        #region 6
        //static void DisplayStudents(SortedDictionary<int, string> dict)
        //{
        //    foreach (var kvp in dict)
        //    {
        //        Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
        //    }
        //}

        #endregion
        #region 7
        static void DisplayEmployees(SortedList<int, string> list)
        {
            foreach (var kvp in list)
            {
                Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
            }
        }

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
            #region 3
            //    Dictionary<string, int> scores = new Dictionary<string, int>()
            //{
            //    { "Alice", 85 },
            //    { "Bob", 92 },
            //    { "Charlie", 78 },
            //    { "David", 92 }
            //};

            //    string keyWithHighestValue = FindKeyWithHighestValue(scores);

            //    Console.WriteLine($"Key with the highest value: {keyWithHighestValue}");
            #endregion
            #region 4
            //    Dictionary<string, string> dict = new Dictionary<string, string>()
            //{
            //    { "key1", "apple" },
            //    { "key2", "banana" },
            //    { "key3", "apple" }
            //};

            //    Console.Write("Enter target value: ");
            //    string target = Console.ReadLine();

            //    FindKeysByValue(dict, target);
            //} 
            #endregion
            #region 5

            //string[] words = { "eat", "tea", "tan", "ate", "nat", "bat" };

            //var grouped = GroupAnagrams(words);

            //Console.WriteLine("Grouped Anagrams:");
            //foreach (var group in grouped)
            //{
            //    Console.WriteLine("[" + string.Join(", ", group) + "]");
            //}
            #endregion
            #region 6
            //    SortedDictionary<int, string> students = new SortedDictionary<int, string>();

            //    students.Add(102, "Alice");
            //    students.Add(101, "Bob");
            //    students.Add(104, "Charlie");
            //    students.Add(103, "David");

            //    Console.WriteLine("Students after adding:");
            //    DisplayStudents(students);

            //    Console.Write("\nEnter Student ID to retrieve: ");
            //    int id = int.Parse(Console.ReadLine());

            //    if (students.ContainsKey(id))
            //        Console.WriteLine($"Student with ID {id}: {students[id]}");
            //    else
            //        Console.WriteLine("Student not found!");

            //    Console.Write("\nEnter Student ID to remove: ");
            //    int removeId = int.Parse(Console.ReadLine());

            //    if (students.Remove(removeId))
            //        Console.WriteLine($"Student with ID {removeId} removed successfully.");
            //    else
            //        Console.WriteLine("Student ID not found!");

            //    Console.WriteLine("\nFinal list of students:");
            //    DisplayStudents(students);
            //}
            #endregion
            #region 7
            SortedList<int, string> employees = new SortedList<int, string>();

            employees.Add(102, "Alice");
            employees.Add(101, "Bob");
            employees.Add(104, "Charlie");
            employees.Add(103, "David");

            Console.WriteLine("Employees after adding:");
            DisplayEmployees(employees);

            Console.Write("\nEnter Employee ID to retrieve: ");
            int id = int.Parse(Console.ReadLine());

            if (employees.ContainsKey(id))
                Console.WriteLine($"Employee with ID {id}: {employees[id]}");
            else
                Console.WriteLine("Employee not found!");

            Console.Write("\nEnter Employee ID to remove: ");
            int removeId = int.Parse(Console.ReadLine());

            if (employees.Remove(removeId))
                Console.WriteLine($"Employee with ID {removeId} removed successfully.");
            else
                Console.WriteLine("Employee ID not found!");

            Console.WriteLine("\nFinal Employee Directory:");
            DisplayEmployees(employees);
        }

        #endregion
    }


}
}
    

