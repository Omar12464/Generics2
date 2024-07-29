using System.Collections;

namespace Generics2
{
    internal class Program
    {
        public static void Reverse(ArrayList arrayList)
        {
            if (arrayList == null || arrayList.Count == 0)
            {
                Console.WriteLine("ArrayList is null or empty");
                return;
            }

            int temp;
            int start = 0;
            int end = arrayList.Count - 1;

            while (start < end)
            {
                temp = (int)arrayList[start];
                arrayList[start] = arrayList[end];
                arrayList[end] = temp;

                start++;
                end--;
            }
        }
        static int FindFirstNonRepeatedCharacterIndex(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            // Step 1: Use a dictionary to store the count of each character
            Dictionary<char, int> characterCount = new Dictionary<char, int>();

            foreach (char c in s)
            {
                if (characterCount.ContainsKey(c))
                {
                    characterCount[c]++;
                }
                else
                {
                    characterCount[c] = 1;
                }
            }

            // Step 2: Find the first character with a count of 1
            for (int i = 0; i < s.Length; i++)
            {
                if (characterCount[s[i]] == 1)
                {
                    return i;
                }
            }

            // Step 3: If no such character exists, return -1
            return -1;
        }
        static void Main(string[] args)
        {
            #region Q1
            //ArrayList array = new ArrayList();
            //array.Add(1);
            //array.Add(2);
            //array.Add(3);
            //array.Add(4);
            //array.Add(5);
            //array.Add(6);

            //Reverse(array);

            //foreach (var number in array)
            //{
            //    Console.Write($"{number} ");
            //}
            #endregion
            #region Q2
            //List<int> List = new List<int>();
            //List<int> list= new List<int>();
            //List.Add(1);
            //List.Add(2);
            //List.Add(3);
            //List.Add(4);
            //List.Add(5);
            //List.Add(6);
            //List.Add(7);
            //List.Add(8);
            //for (int i = 0; i < List.Count; i++)
            //{
            //    if (List[i] % 2 == 0)
            //    {
            //        int even=(int)List[i];
            //        list.Add(even);
            //    }
            //}
            //foreach(var num in list)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
            #region Q3
            //FixedSize<int> fixedSize = new FixedSize<int>(5);
            //fixedSize.Add(3);
            //fixedSize.Add(2);
            //fixedSize.Add(1);
            //fixedSize.Add(5);
            //fixedSize.Add(4);
            //for (int i = 0; i < fixedSize.Count; i++)
            //{
            //    Console.WriteLine(fixedSize.Get(i));
            //}



            #endregion
            #region Q4
            //string s="siss"
            //int index = FindFirstNonRepeatedCharacterIndex(s);
            //Console.WriteLine("The index of the first non-repeated character is: " + index);


            #endregion
        }
    }
}

