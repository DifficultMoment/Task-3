using System.Linq;
using ConsoleTables;

namespace game
{
    class Table
    {
        public void GenerateTable(string[] values) {
            string[] column = { "PC/USER" };
            var table = new ConsoleTable(column.Concat(values).ToArray());
            for (int i = 0; i < values.Length; i++)
            {
                string[] columns = new Winner().GetResultRow(values, values[i], i);
                table.AddRow(columns);
            }
            table.Write(Format.Alternative);
        }
    }
}
