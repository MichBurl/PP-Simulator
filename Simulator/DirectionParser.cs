using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator
{
    public static class DirectionParser
    {
        public static Direction[] Parse(string input)
        {
            // Lista, która będzie przechowywać wyniki
            var directions = new System.Collections.Generic.List<Direction>();

            // Iterujemy po każdym znaku w wejściowym ciągu
            foreach (var ch in input.ToUpper())  // Zamieniamy na wielkie litery
            {
                // Sprawdzamy, czy znak odpowiada któremuś z kierunków
                switch (ch)
                {
                    case 'U':
                        directions.Add(Direction.Up);
                        break;
                    case 'R':
                        directions.Add(Direction.Right);
                        break;
                    case 'D':
                        directions.Add(Direction.Down);
                        break;
                    case 'L':
                        directions.Add(Direction.Left);
                        break;
                    // Inne znaki są ignorowane
                    default:
                        continue;
                }
            }

            // Zwracamy tablicę kierunków
            return directions.ToArray();
        }
    }
}

