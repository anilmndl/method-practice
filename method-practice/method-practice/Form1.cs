using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace method_practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShowOuput_Click(object sender, EventArgs e)
        {
            // sample data
            int[] intArrayOne = { 6, 0, 6, 58, 89, 48 };
            string[] strArrayTwo = { "hello", "world", "state", "hello" };

            // Q1
            bool q1Output = FirstLast(intArrayOne);
            Console.WriteLine("Q1: " + q1Output.ToString());

            //Q2
            bool q2Output = FirstLastEqual(strArrayTwo);
            Console.WriteLine("Q2: " + q2Output.ToString());

            // Q3
            int[] pi = GetPI();
            Console.WriteLine(String.Format("Q3: {0} {1} {2}", pi[0], pi[1], pi[2]));

            // Q4
            int[] intA = { 3, 5, 7 };
            int[] intB = { 3, 7, 1 };
            bool q4Output = SameFirstLast(intA, intB);
            Console.WriteLine("Q4: " + q4Output.ToString());

            // Q5
            double[] doubleNums = { 10.52, 78.58, 68.45, 75.25 };
            double q5Output = GetSum(doubleNums);
            Console.WriteLine("Q5: " + q5Output.ToString());

            // Q6
            char[] charArr = { 'a', 'e', 'i', 'o', 'u' };
            int q6Output = GetLength(charArr);
            Console.WriteLine("Q6: " + q6Output.ToString());

            // Q7
            int[] intArr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int q7Output = CountFizzBuzz(intArr);
            Console.WriteLine("Q7: " + q7Output.ToString());

            // Q8
            int[] q8Output = GetFizzBuzz(intArr);
            string outputText8 = "";
            for(int i = 0; i < q8Output.Length; i++)
            {
                outputText8 += q8Output[i] + " ";
            }
            Console.WriteLine("Q8: " + outputText8);


            // Q9
            int[] q9Output = ConvertToInt(doubleNums);
            string outputText9 = "";
            for (int i = 0; i < q9Output.Length; i++)
            {
                outputText9 += q9Output[i] + " ";
            }
            Console.WriteLine("Q9: " + outputText9);


            // Q10
            char[] q10Output = ReverseChars(charArr);
            string outputText10 = "";
            for (int i = 0; i < q10Output.Length; i++)
            {
                outputText10 += q10Output[i] + " ";
            }
            Console.WriteLine("Q10: " + outputText10);

            // Q11
            int[] q11Output = ReplaceWithMax(intArr);
            string outputText11 = "";
            for (int i = 0; i < q11Output.Length; i++)
            {
                outputText11 += q11Output[i] + " ";
            }
            Console.WriteLine("Q11: " + outputText11);

            // Q12
            int[] nums = { 4, 3, 7, 2, 8, 9 };
            int[] q12Output = GetMiddleNumbers(nums);
            Console.WriteLine(String.Format("Q12: {0} {1}", q12Output[0], q12Output[1]));

          
        }

        // Q1
        private bool FirstLast(int[] nums)
        {
            if (nums[0] == 6 || nums[nums.Length - 1] == 6)
            {
                return true;
            }
            return false;
        }

        //Q2
        private bool FirstLastEqual(string[] strArray)
        {
            if (strArray[0] == strArray[strArray.Length - 1])
            {
                return true;
            }
            return false;
        }

        //Q3
        private int[] GetPI()
        {
            int[] pi = { 3, 1, 4 };
            return pi;
        }

        //Q4
        private bool SameFirstLast(int[] a, int[] b)
        {
            if (a[0] == b[0] || a[a.Length - 1] == b[b.Length - 1])
            {
                return true;
            }
            return false;
        }

        //Q5
        private double GetSum(double[] numbers)
        {
            double output = 0.0;
            for(int i = 0; i < numbers.Length; i++)
            {
                output += numbers[i];
            }
            return output;
        }
        
        // Q6
        private int GetLength(char[] characters)
        {
            int count = 0;
            for (int i = 0; i < characters.Length; i++)
            {
                count++;
            }
            return count;
        }

        // Q7
        private int CountFizzBuzz(int[] numbers)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 3 == 0 ^ numbers[i] % 5 == 0)
                {
                    count++;
                }
                
            }
            return count;
        }

        // Q8
        private int[] GetFizzBuzz(int[] numbers)
        {
            // we do not know how big the new array size will be
            // since we wrote a method to count the numbers matching the criteria
            // we can leverage that method to get our array size
            int arrSize = CountFizzBuzz(numbers);

            int[] output = new int[arrSize];        // initialize the array of proper size
            int outputIndex = 0;                    // we need an int variable to keep track of this index

            for (int i = 0; i < numbers.Length; i++)
            {
                // if criteria matches, add it out the output array
                if (numbers[i] % 3 == 0 ^ numbers[i] % 5 == 0)
                {
                    output[outputIndex] = numbers[i];
                    outputIndex++;
                }
            }

            return output;
        }

        // Q9
        private int[] ConvertToInt(double[] numbers)
        {
            int[] output = new int[numbers.Length];
            for(int i = 0; i < numbers.Length; i++)
            {
                output[i] = (int)numbers[i];
            }
            return output;
        }

        // Q10
        private char[] ReverseChars(char[] characters)
        {
            char[] output = new char[characters.Length];
            for(int i = 0; i < characters.Length; i++)
            {
                output[i] = characters[characters.Length - i - 1];
            }

            return output;
        }

        // Q11
        private int[] ReplaceWithMax(int[] nums)
        {
            // this is a two step process 

            // first, find the max value in the given array of ints
            int max = nums[0];
            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }

            // we would have the max by now
            // replace each item in the array with the max value
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = max;
            }

            return nums;
        }

        // Q12
        private int[] GetMiddleNumbers(int[] numbers)
        {
            int[] output = new int[2];      // we know for sure we will return an array of size 2
            output[0] = numbers[numbers.Length / 2 - 1];
            output[1] = numbers[numbers.Length / 2];
                 
            return output;
        }
    }
}
