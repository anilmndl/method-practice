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
            string outputText = "";
            for(int i = 0; i < q8Output.Length; i++)
            {
                outputText += q8Output[i] + " ";
            }
            Console.WriteLine("Q8: " + outputText);
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
    }
}
