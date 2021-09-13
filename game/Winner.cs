using System;

namespace game
{
    class Winner
    {
        public string[] GetResultRow(string[] array, string firstValue, int index) {
            string[] row = new string[array.Length + 1];
            int winnerValues = array.Length / 2;
            row[0] = firstValue;
            for (int i = index; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (i == j) row[j + 1] = "DRAW";
                    else if(((j - i) > 0 && (j - i) <= winnerValues) || ((j - i) < 0 && (j - i) < -winnerValues)) row[j + 1] = "WIN";
                    else row[j + 1] = "LOSE"; 
                }
                break;
            }
            return row;
        }

        public void GetWinner(int computerTurn, int userTurn, int sizeOfElements) {
            int winnerValues = sizeOfElements / 2;
            if (userTurn == computerTurn) Console.WriteLine("Draw!");
            else if (((userTurn - computerTurn) > 0 && (userTurn - computerTurn) <= winnerValues) || ((userTurn - computerTurn) < 0 && (userTurn - computerTurn) < -winnerValues)) Console.WriteLine("You win!");
            else Console.WriteLine("You lose!");
        }
    }
}
