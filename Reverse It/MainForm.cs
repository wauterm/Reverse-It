using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reverse_It
{
    public partial class MainForm : Form
    {
        private int[] StartingSequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private string StartingSequenceString = string.Empty;
        private int OrderCounter = 0;
        
        public MainForm()
        {
            // Initialize game environment.
            InitializeComponent();

            ShuffleArray(StartingSequence);
            StartingSequenceString = ArrayToString(StartingSequence);
            lblNineNumbers.Text = StartingSequenceString;

            // todo - keep track of amount of clicks needed
            // todo - congratulate on victory.
            // todo - future - keep leaderboard.
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (ValidateNumberInput(tbInputNumber.Text))
            {
                int InputNumber = Int32.Parse(tbInputNumber.Text);
                if (InputNumber > 9 || InputNumber <= 0)
                {
                    MessageBox.Show("Your choice of numbers is limited from 1 up untill 9, obviously...", "Number out of bounds.");
                    tbInputNumber.Text = ""; // clear the inputbox.
                }
                else
                {
                    ReverseNumber(StartingSequence, InputNumber);
                }
                
                //Update the label after reverse.
                StartingSequenceString = ArrayToString(StartingSequence);
                lblNineNumbers.Text = StartingSequenceString;

                // check to see if the sequence is ordered.
                bool IsOrdered = true;
                for (int i = 0; i < StartingSequence.Length - 1; i++)
                {
                    if (StartingSequence[i] + 1 != StartingSequence[i + 1])
                    {
                        IsOrdered = false;
                        break;
                    }
                }

                if (IsOrdered == true)
                {
                    MessageBox.Show("Congratulations, you have created order " +
                        "in the universe once more.\nthe multiverse is forever gratefull!", "Victory !");
                }

                tbInputNumber.Text = ""; // clear the inputbox.
                OrderCounter++;

            }
        }

        /// <summary>
        /// Randomizes the order in which values are located in an array.
        /// </summary>
        /// <param name="arr">The array to be shuffled.</param>
        public static void ShuffleArray(int[] arr)
        {
            int l = arr.Length;
            Random rnd = new Random();

            for (int i = 0; i < l; i++)
            {
                Swap(arr, i, i + rnd.Next(l - i));
            }
        }

        /// <summary>
        /// A method for swapping the first and second value of an integer array.
        /// </summary>
        /// <param name="arr">The input array.</param>
        /// <param name="a">The first index</param>
        /// <param name="b">The second index</param>
        public static void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }

        /// <summary>
        /// Converts the content of the array to one that is fit to be displayed in the label.
        /// </summary>
        /// <param name="arr">Array to be converted.</param>
        /// <returns>Returns a string of the format: [ value-value-... ]</returns>
        public static string ArrayToString(int[] arr)
        {
            StringBuilder sBuilder = new StringBuilder();

            sBuilder.Append("[ ");

            foreach ( int number in arr)
            {
                sBuilder.Append(number + "-");
            }

            sBuilder.Remove(sBuilder.Length - 1, 1);
            sBuilder.Append(" ]");

            return sBuilder.ToString();
        }

        public static void ReverseNumber(int[] arr, int amount)
        {
            if (amount % 2 == 0)
            {
                for (int i = 0; i < amount / 2; i++)
                {
                    Swap(arr, i, amount - i - 1);   
                }
            }
            else
            {
                double HalfAmount = amount / 2;
                int HalfAmountWithoutRest = Convert.ToInt32(Math.Floor(HalfAmount));

                for (int i = 0; i < HalfAmountWithoutRest; i++)
                {
                    Swap(arr, i, amount - i - 1);
                }
            }
        }

        /// <summary>
        /// Displays the way the game works.
        /// </summary>
        /// <param name="sender">The questionmark label.</param>
        /// <param name="e">Hover over event.</param>
        private void lblTooltipInfo_MouseHover(object sender, EventArgs e)
        {
            ttGameInfo.Show("This number is the amount of values, starting at the beginning of the array\n" +
                "that get reversed in order. For example: [1-2-3-4] with number = 3,\n" +
                "returns: [3-2-1-4].",lblTooltipInfo,7000);
        }

        /// <summary>
        /// Checks to see if the input is an integer value.
        /// </summary>
        /// <param name="textBoxNumber">Textbox.Text input</param>
        /// <returns>Boolean value: true if it is an integer, false if it is not.</returns>
        public bool ValidateNumberInput(string textBoxNumber)
        {
            bool Output = false;
            if (!Int32.TryParse(textBoxNumber, out int number))
            {
                MessageBox.Show("You have to enter a number in order for the ordering to work, dummy.");
                tbInputNumber.Text = ""; // clear the inputbox.
                Output = false;
                return Output;
            }
            else
            {
                Output = true;
                return Output;
            }
        }

        private void btnRandomiseNumbers_Click(object sender, EventArgs e)
        {
            ShuffleArray(StartingSequence);
            StartingSequenceString = ArrayToString(StartingSequence);
            lblNineNumbers.Text = StartingSequenceString;
        }
    }
}
