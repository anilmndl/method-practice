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
    }
}
