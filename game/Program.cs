using System;

namespace game
{
    class Program
    {
        static int FindArrayRepeats(string[] array) {
            for(int i = 0; i < array.Length; i++) {
                for (int j = i + 1; j < array.Length; j++) {
                    if (array[i] == array[j]) return 1;
                }
            }
            return -1;
        }

        static void ShowMenu(string[] userValues) {
            Console.WriteLine("Available moves:");
            for (int i = 0; i < userValues.Length; i++) {
                Console.WriteLine($"{i + 1} - {userValues[i]}");
            }
            Console.WriteLine("0 - exit\n? - help\nEnter your movie: ");
        }

        static void Main(params string[] userValues) {
            if ((userValues.Length >= 3) && (userValues.Length % 2 != 0) && FindArrayRepeats(userValues) == -1) {
                var key = new Key().GenerateKey();
                int computerTurn = new Random().Next(1, userValues.Length);
                Console.WriteLine($"HMAC:\n{new HMAC().GenerateHMAC(userValues[computerTurn - 1], key)}");
                ShowMenu(userValues);
                string enterValue = Console.ReadLine();
                if (enterValue == "?") new Table().GenerateTable(userValues);
                else {
                    int.TryParse(enterValue, out int userTurn);
                    if (userTurn > 0) {
                        Console.WriteLine($"Your move: {userValues[userTurn - 1]}\nComputer move: {userValues[computerTurn - 1]}");
                        new Winner().GetWinner(computerTurn, userTurn, userValues.Length);
                        Console.WriteLine($"HMAC key: {key}");
                    }
                    else Console.WriteLine("Bye!");
                }
            }
            else Console.WriteLine("Error! The number arguments must be odd, less than three and no repeats\n" +
                "Example: game.exe rock paper scissors");
        }
    }
}
