using System;
using System.Text;

namespace Reverse_It
{
    public class GameLogic
    {
        private int[] startingSequence = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private string startingSequenceString = string.Empty;
        private int orderCounter = 0;
        public string StartingSequenceString { get; private set; }

        public GameLogic()
        {
            ShuffleArray(startingSequence);
            StartingSequenceString = ArrayToString(startingSequence);
        }
        public void ReorderListOfNumbers(int input)
        {
            ReverseNumber(startingSequence, input);

            StartingSequenceString = ArrayToString(startingSequence);

            orderCounter++;
        }
        public bool IsSequenceOrdered()
        {
            bool output = true;
            for (int i = 0; i < startingSequenceString.Length - 1; i++)
            {
                if (startingSequence[i] + 1 != startingSequence[i + 1])
                {
                    output = false;
                    break;
                }
            }
            return output;
        }
        public void RandomizeSequence()
        {
            ShuffleArray(startingSequence);
            StartingSequenceString = ArrayToString(startingSequence);
        }

        #region Helper functions

        /// <summary>
        /// Randomizes the order in which values are located in an array.
        /// </summary>
        /// <param name="arr">The array to be shuffled.</param>
        private void ShuffleArray(int[] arr)
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
        private void Swap(int[] arr, int a, int b)
        {
            int temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        private void ReverseNumber(int[] arr, int amount)
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
                double half = amount / 2;
                int halfWithoutRest = Convert.ToInt32(Math.Floor(half));

                for (int i = 0; i < halfWithoutRest; i++)
                {
                    Swap(arr, i, amount - i - 1);
                }
            }
        }
        /// <summary>
        /// Converts the content of the array to one that is fit to be displayed in the label.
        /// </summary>
        /// <param name="arr">Array to be converted.</param>
        /// <returns>Returns a string of the format: [ value-value-... ]</returns>
        private string ArrayToString(int[] arr)
        {
            StringBuilder sBuilder = new StringBuilder();

            sBuilder.Append("[ ");

            foreach (int number in arr)
            {
                sBuilder.Append(number + "-");
            }

            sBuilder.Remove(sBuilder.Length - 1, 1);
            sBuilder.Append(" ]");

            return sBuilder.ToString();
        }

        #endregion
    }
}
