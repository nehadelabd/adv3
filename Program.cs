using System.Collections;

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
        //static void DisplayEmployees(SortedList<int, string> list)
        //{
        //    foreach (var kvp in list)
        //    {
        //        Console.WriteLine($"ID: {kvp.Key}, Name: {kvp.Value}");
        //    }
        //}

        #endregion
        #region 9
        //static Hashtable SwapKeysAndValues(Hashtable original)
        //{
        //    Hashtable swapped = new Hashtable();

        //    foreach (DictionaryEntry entry in original)
        //    {
        //        swapped[entry.Value] = entry.Key;
        //    }

        //    return swapped;
        //}
        #endregion


        #region 11
        //static int CountKeysStartingWith(Dictionary<string, int> dict, char targetChar)
        //{
        //    int count = 0;

        //    foreach (var key in dict.Keys)
        //    {
        //        if (key.StartsWith(targetChar.ToString(), StringComparison.OrdinalIgnoreCase))
        //        {
        //            count++;
        //        }
        //    }

        //    return count;
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
            //    SortedList<int, string> employees = new SortedList<int, string>();

            //    employees.Add(102, "Alice");
            //    employees.Add(101, "Bob");
            //    employees.Add(104, "Charlie");
            //    employees.Add(103, "David");

            //    Console.WriteLine("Employees after adding:");
            //    DisplayEmployees(employees);

            //    Console.Write("\nEnter Employee ID to retrieve: ");
            //    int id = int.Parse(Console.ReadLine());

            //    if (employees.ContainsKey(id))
            //        Console.WriteLine($"Employee with ID {id}: {employees[id]}");
            //    else
            //        Console.WriteLine("Employee not found!");

            //    Console.Write("\nEnter Employee ID to remove: ");
            //    int removeId = int.Parse(Console.ReadLine());

            //    if (employees.Remove(removeId))
            //        Console.WriteLine($"Employee with ID {removeId} removed successfully.");
            //    else
            //        Console.WriteLine("Employee ID not found!");

            //    Console.WriteLine("\nFinal Employee Directory:");
            //    DisplayEmployees(employees);
            //}

            #endregion
            #region 8
            //List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 3, 5, 1 };

            //Console.WriteLine("Original List:");
            //Console.WriteLine(string.Join(", ", numbers));

            //HashSet<int> uniqueNumbers = new HashSet<int>(numbers);

            //Console.WriteLine("\nUnique Values (using HashSet):");
            //Console.WriteLine(string.Join(", ", uniqueNumbers));
            #endregion
            #region 9
            //    Hashtable original = new Hashtable()
            //{
            //    { "A", 1 },
            //    { "B", 2 },
            //    { "C", 3 }
            //};

            //    Console.WriteLine("Original Hashtable:");
            //    foreach (DictionaryEntry entry in original)
            //    {
            //        Console.WriteLine($"{entry.Key} : {entry.Value}");
            //    }

            //    // Swap keys and values
            //    Hashtable swapped = SwapKeysAndValues(original);

            //    Console.WriteLine("\nSwapped Hashtable:");
            //    foreach (DictionaryEntry entry in swapped)
            //    {
            //        Console.WriteLine($"{entry.Key} : {entry.Value}");
            //    }
            //} 
            #endregion

            #region 10
            //HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4 };
            //HashSet<int> set2 = new HashSet<int> { 3, 4, 5, 6 };

            //Console.WriteLine("Set 1: " + string.Join(", ", set1));
            //Console.WriteLine("Set 2: " + string.Join(", ", set2));
            //HashSet<int> unionSet = new HashSet<int>(set1); 
            //unionSet.UnionWith(set2); 

            //Console.WriteLine("\nUnion of Set1 and Set2:");
            //Console.WriteLine(string.Join(", ", unionSet));

            #endregion
            #region 11
            //    Dictionary<string, int> dict = new Dictionary<string, int>()
            //{
            //    { "apple", 1 },
            //    { "animal", 2 },
            //    { "airport", 3 },
            //    { "banana", 4 },
            //    { "car", 5 }
            //};
            #endregion
            #region 13
        //    SortedList<int, int> numbers = new SortedList<int, int>()
        //{
        //    { 1, 5 },
        //    { 2, 8 },
        //    { 3, 10 },
        //    { 4, 7 },
        //    { 5, 12 }
        //};

        //    Console.WriteLine("Original SortedList (Key -> Value):");
        //    foreach (var pair in numbers)
        //        Console.WriteLine($"{pair.Key} -> {pair.Value}");

        //    List<int> evenValueKeys = new List<int>();

        //    foreach (var pair in numbers)
        //    {
        //        if (pair.Value % 2 == 0)
        //            evenValueKeys.Add(pair.Key);
        //    }

        //    Console.WriteLine("\nKeys with even values:");
        //    if (evenValueKeys.Count > 0)
        //        Console.WriteLine(string.Join(", ", evenValueKeys));
        //    else
        //        Console.WriteLine("No even values found.");
        //}
        #endregion
        #region 12
                SortedSet<int> numbers = new SortedSet<int> { 2, 5, 8, 10, 15, 20 };

                Console.WriteLine("SortedSet elements: " + string.Join(", ", numbers));

                Console.Write("Enter a target number: ");
                int target = int.Parse(Console.ReadLine());

                List<int> greaterThanTarget = new List<int>();

                foreach (int num in numbers)
                {
                    if (num > target)
                        greaterThanTarget.Add(num);
                }

                if (greaterThanTarget.Count > 0)
                {
                    Console.WriteLine("\nElements greater than target:");
                    Console.WriteLine(string.Join(", ", greaterThanTarget));
                }
                else
        {
            Console.WriteLine("\nNo elements greater than target were found.");
        }
            }
        #endregion

    }

    }


}

    

