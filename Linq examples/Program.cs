using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq_examples
{
    class Program
    {
        static bool SadeEded(int a)
        {
            for(int i = 2; i < a; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        static void Main(string[] args)
        {

            #region first example
            List<int> array1 = new List<int>();
            int[] nums = { 2, 4, 8, 9, 19, 3, 26, 982, 0, 20, 14, 56 };
            array1.AddRange(nums);
            var result = array1.Where(p => p != 0 & p % 2 == 0);
            #endregion

            #region second example
            List<string> array2 = new List<string>();
            string[] text = { "Madina", "Alizade", "Elon", "Musk", "Bill", "Gates", "Mark", "Zuckerberg", "Ravana", "Revan" };
            array2.AddRange(text);
            var result2 = array2.Where(p => p.Contains('a') & p.StartsWith('R')).Count();
           // Console.WriteLine(result2);
            #endregion

            #region third example
            List<int> num1 = new List<int>();
            num1.Add(2);
            num1.Add(3);
            num1.Add(4);
            num1.Add(5);
            num1.Add(6);
            var result3 = num1.Where(p => 12 % p == 0);
           // Array.ForEach(result3.ToArray(), Console.WriteLine);
            #endregion

            #region forth example
            List<int> num2 = new List<int>();
            num2.Add(13);
            num2.Add(23);
            num2.Add(46);
            num2.Add(45);
            num2.Add(97);
            var result4 = num2.Where(p => p <= 99 && SadeEded(p) );
           // Array.ForEach(result4.ToArray(),Console.WriteLine);
            #endregion 

            #region fifth example
            List<string> array3 = new List<string>();
            string[] text1 = { "Madina", "Alizade", "Elon", "Musk", "Bill", "Gates", "Mark", "Zuckerberg", "Ravana", "Revan" ,"Aynur"};
            array3.AddRange(text1);
            var result5 = array3.Find(p => p.StartsWith('A') && p.Contains('u'));
          //  Console.WriteLine(result5);
            #endregion

            #region sixth example
            List<int> array4 = new List<int>();
            int[] nums2 = { 213, 42, 845, 969, 19, 321, 26, 982, 0, 20, 145, 56 };
            array4.AddRange(nums2);
            var result6 = array4.Where(p => p < 1000 && p>99);
            // Array.ForEach(result6.ToArray(), Console.WriteLine);
            #endregion

            #region seventh example
            ArrayList nums3 = new ArrayList();
            nums3.Add(4.6);
            nums3.Add(35.4);
            nums3.Add(3);
            nums3.Add(56);
            nums3.Add(590.56);
            foreach (var m in nums3)
            {
                if(m.GetType() == typeof(double))
                    Console.WriteLine(m);
            }
            #endregion

            #region eighth example
            List<int> array8 = new List<int>();
            int[] nums5 = { 2, 4, 8, 9, 19, 3, 26, 982, 0, 20, 14, 56 };
            array8.AddRange(nums5);
            var result8 = array8.Where(p => p % 2 == 0 && p % 3 == 0);
            
            #endregion

            #region nineth example
            List<int> array9 = new List<int>();
            int[] nums6= { 2, 4, 8, 9, 19, 3, 26, 982, 0, 20, 14, 56 };
            array9.AddRange(nums6);
            var result9 = array9.Where(p => p % 2 != 0);
            #endregion

            #region
            List<string> text4 = new List<string>();
            text4.Add("Madina");
            text4.Add("Ahmed");
            var result10 = text4.Find(p => p.StartsWith('A')).ToUpper();
            Console.WriteLine(result10);

            #endregion
        }

    }
}
