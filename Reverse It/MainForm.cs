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
        private GameLogic GameEngine = new GameLogic();
        
        public MainForm()
        {
            // Initialize game environment.
            InitializeComponent();
            lblNineNumbers.Text = GameEngine.StartingSequenceString;
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            string input = tbInputNumber.Text;

            if (ValidateNumberInput(input))
            {
                GameEngine.ReorderListOfNumbers(int.Parse(input));
                
                lblNineNumbers.Text = GameEngine.StartingSequenceString;

                if (GameEngine.IsSequenceOrdered())
                    MessageBox.Show("Congratulations, you have created order " +
                        "in the universe once more.\nthe multiverse is forever gratefull!", "Victory !");

                tbInputNumber.Text = "";
            }
        }

        private void lblTooltipInfo_MouseHover(object sender, EventArgs e)
        {
            ttGameInfo.Show("This number is the amount of values, starting at the beginning of the array\n" +
                "that get reversed in order. For example: [1-2-3-4] with number = 3,\n" +
                "returns: [3-2-1-4].",lblTooltipInfo,7000);
        }
        public bool ValidateNumberInput(string textBoxInput)
        {
            bool output = false;

            if(!int.TryParse(textBoxInput, out int number))
                MessageBox.Show("You have to enter a number in order for the ordering to work, dummy.");
            else
            {
                if (number > 9 || number <= 0)
                {
                    MessageBox.Show("Your choice of numbers is limited from 1 up untill 9, obviously...", "Number out of bounds.");
                    tbInputNumber.Text = "";
                }
            }
            return output;
        }
        private void btnRandomiseNumbers_Click(object sender, EventArgs e)
        {
            GameEngine.RandomizeSequence();
            lblNineNumbers.Text = StartingSequenceString;
        }
    }
}
