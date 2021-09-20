using System;
using System.Linq;

namespace Algortm21
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var s = "kkkeeticuoooossssslopppps";

            int[] array = {20, 11, 56, 32, 78, 5, 1};


            Console.WriteLine(RemoveFourthReoccuringLetter(s));
            Console.WriteLine(MaxSumOddNumber(array));

        }

        //This method removes the fourth reoccuring letter in a sequence
        public static string RemoveFourthReoccuringLetter(string s){

            for(int i = 0; i < s.Length - 1; i++){
                int count = 1;

                while(s[i] == s[i + 1]){
                    i++;
                    count++;

                    if(count > 2 && s[i] == s[i + 1]){
                        s = s.Remove(s.IndexOf(s[i + 1]), 1);
                    }
                }
            }

            return s;

        }

        //This method sorts and sums the largest two numbers in an array with an odd number as result
        public static int MaxSumOddNumber(int[] array){

            int result = 0;

                    Array.Sort(array);
                    Array.Reverse(array);


                    for(int i = 0; i < array.Length -1; i++){
                        int start = array[i] + array[i + 1];

                        if(start % 2 != 0){
                            result = start;
                            break;
                        }
                    }

            return result;
        }

    }
}
